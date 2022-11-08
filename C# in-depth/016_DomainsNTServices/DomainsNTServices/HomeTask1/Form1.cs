using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Policy;
using System.Windows.Forms;

namespace HomeTask1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void Implement_Click(object sender, EventArgs e)
        {
            if (!IsFileAdded())
            {
                MessageBox.Show("Choose file", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var zones = GetZones();

            if (zones.Count == 0)
            {
                MessageBox.Show("Choose zones", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AppDomain domain = AppDomain.CreateDomain("SandBox domain");
            Evidence evidence = new Evidence(zones.Select(x => new Zone(x)).ToArray(), null);

            try
            {
                domain.ExecuteAssembly(textBox1.Text, evidence);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsFileAdded()
        {
            return !String.IsNullOrEmpty(textBox1.Text);
        }

        private List<SecurityZone> GetZones()
        {
            List<SecurityZone> zones = new List<SecurityZone>();

            if (checkBoxInternet.Checked)
            {
                zones.Add(SecurityZone.Internet);
            }
            if (checkBoxIntranet.Checked)
            {
                zones.Add(SecurityZone.Intranet);
            }
            if (checkBoxMyComputer.Checked)
            {
                zones.Add(SecurityZone.MyComputer);
            }
            if (checkBoxTrusted.Checked)
            {
                zones.Add(SecurityZone.Trusted);
            }
            if (checkBoxUntrusted.Checked)
            {
                zones.Add(SecurityZone.Untrusted);
            }
            if (checkBoxNoZone.Checked)
            {
                zones.Add(SecurityZone.NoZone);
            }

            return zones;
        }
    }
}
