using HomeTask2.UniversityTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            University university = new University();
            new StudentsTableAdapter().Fill(university.Students);
            new ExamsTableAdapter().Fill(university.Exams);
            new TeachersTableAdapter().Fill(university.Teachers);
            new FacultiesTableAdapter().Fill(university.Faculties);
            new DisciplinesTableAdapter().Fill(university.Disciplines);
            new TeacherDiscTableAdapter().Fill(university.TeacherDisc);

            dataGridView1.DataSource = university.Exams
                .GroupBy(x => x.StudentId)
                .Select(x => new { StudentNumber = x.Key, ExamCount = x.Count() })
                .Join(university.Students, ex => ex.StudentNumber, s => s.StNumber, (ex, s) => new { s.FName, s.LName, ex.ExamCount })
                .ToList();

            dataGridView2.DataSource = university.Exams
                .GroupBy(x => x.Discipline)
                .Select(x => new { DiscId = x.Key, DiscCount = x.Count() })
                .Join(university.Disciplines, ex => ex.DiscId, dc => dc.Id, (ex, dc) => new { dc.Name, ex.DiscCount })
                .ToList();

            dataGridView3.DataSource = university.Exams
                .Join(university.Teachers, ex => ex.TeacherId, t => t.Id, (ex, t) => new { TeacherFName = t.FName, TeacherLName = t.LName, ex.StudentId, ex.Discipline, ex.Mark, ex.Date })
                .Join(university.Students, ex => ex.StudentId, st => st.StNumber, (ex, st) => 
                new {StudentFName = st.FName, StudentLName = st.LName, ex.TeacherFName, ex.TeacherLName, ex.Discipline, ex.Mark, ex.Date})
                .Join(university.Disciplines, ex => ex.Discipline, d => d.Id, (ex, d) =>
                new {ex.TeacherFName, ex.TeacherLName, ex.StudentFName, ex.StudentLName, d.Name, ex.Mark, ex.Date})
                .ToList();
        }
    }
}
