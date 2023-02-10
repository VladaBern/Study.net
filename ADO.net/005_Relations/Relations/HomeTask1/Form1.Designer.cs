namespace HomeTask1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.examNumbForSt = new System.Windows.Forms.Button();
            this.examNumbOfDisc = new System.Windows.Forms.Button();
            this.examInfo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // examNumbForSt
            // 
            this.examNumbForSt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examNumbForSt.Location = new System.Drawing.Point(42, 40);
            this.examNumbForSt.Name = "examNumbForSt";
            this.examNumbForSt.Size = new System.Drawing.Size(130, 81);
            this.examNumbForSt.TabIndex = 0;
            this.examNumbForSt.Text = "Get number of exams for each student";
            this.examNumbForSt.UseVisualStyleBackColor = true;
            this.examNumbForSt.Click += new System.EventHandler(this.examNumbForSt_Click);
            // 
            // examNumbOfDisc
            // 
            this.examNumbOfDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examNumbOfDisc.Location = new System.Drawing.Point(293, 39);
            this.examNumbOfDisc.Name = "examNumbOfDisc";
            this.examNumbOfDisc.Size = new System.Drawing.Size(133, 82);
            this.examNumbOfDisc.TabIndex = 1;
            this.examNumbOfDisc.Text = "Get number of exams in each discipline";
            this.examNumbOfDisc.UseVisualStyleBackColor = true;
            this.examNumbOfDisc.Click += new System.EventHandler(this.examNumbOfDisc_Click);
            // 
            // examInfo
            // 
            this.examInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examInfo.Location = new System.Drawing.Point(575, 42);
            this.examInfo.Name = "examInfo";
            this.examInfo.Size = new System.Drawing.Size(132, 80);
            this.examInfo.TabIndex = 2;
            this.examInfo.Text = "Show exam info";
            this.examInfo.UseVisualStyleBackColor = true;
            this.examInfo.Click += new System.EventHandler(this.examInfo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 160);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(665, 254);
            this.dataGridView1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.examInfo);
            this.Controls.Add(this.examNumbOfDisc);
            this.Controls.Add(this.examNumbForSt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button examNumbForSt;
        private System.Windows.Forms.Button examNumbOfDisc;
        private System.Windows.Forms.Button examInfo;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

