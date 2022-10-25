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
            this.OpenFile = new System.Windows.Forms.Button();
            this.Implement = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxInternet = new System.Windows.Forms.CheckBox();
            this.checkBoxIntranet = new System.Windows.Forms.CheckBox();
            this.checkBoxTrusted = new System.Windows.Forms.CheckBox();
            this.checkBoxUntrusted = new System.Windows.Forms.CheckBox();
            this.checkBoxMyComputer = new System.Windows.Forms.CheckBox();
            this.checkBoxNoZone = new System.Windows.Forms.CheckBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Location = new System.Drawing.Point(60, 66);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(75, 23);
            this.OpenFile.TabIndex = 0;
            this.OpenFile.Text = "Open file";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // Implement
            // 
            this.Implement.Location = new System.Drawing.Point(141, 66);
            this.Implement.Name = "Implement";
            this.Implement.Size = new System.Drawing.Size(75, 23);
            this.Implement.TabIndex = 1;
            this.Implement.Text = "Implement";
            this.Implement.UseVisualStyleBackColor = true;
            this.Implement.Click += new System.EventHandler(this.Implement_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 2;
            // 
            // checkBoxInternet
            // 
            this.checkBoxInternet.AutoSize = true;
            this.checkBoxInternet.Location = new System.Drawing.Point(231, 40);
            this.checkBoxInternet.Name = "checkBoxInternet";
            this.checkBoxInternet.Size = new System.Drawing.Size(62, 17);
            this.checkBoxInternet.TabIndex = 3;
            this.checkBoxInternet.Text = "Internet";
            this.checkBoxInternet.UseVisualStyleBackColor = true;
            // 
            // checkBoxIntranet
            // 
            this.checkBoxIntranet.AutoSize = true;
            this.checkBoxIntranet.Location = new System.Drawing.Point(231, 63);
            this.checkBoxIntranet.Name = "checkBoxIntranet";
            this.checkBoxIntranet.Size = new System.Drawing.Size(62, 17);
            this.checkBoxIntranet.TabIndex = 4;
            this.checkBoxIntranet.Text = "Intranet";
            this.checkBoxIntranet.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrusted
            // 
            this.checkBoxTrusted.AutoSize = true;
            this.checkBoxTrusted.Location = new System.Drawing.Point(231, 86);
            this.checkBoxTrusted.Name = "checkBoxTrusted";
            this.checkBoxTrusted.Size = new System.Drawing.Size(62, 17);
            this.checkBoxTrusted.TabIndex = 5;
            this.checkBoxTrusted.Text = "Trusted";
            this.checkBoxTrusted.UseVisualStyleBackColor = true;
            // 
            // checkBoxUntrusted
            // 
            this.checkBoxUntrusted.AutoSize = true;
            this.checkBoxUntrusted.Location = new System.Drawing.Point(231, 109);
            this.checkBoxUntrusted.Name = "checkBoxUntrusted";
            this.checkBoxUntrusted.Size = new System.Drawing.Size(72, 17);
            this.checkBoxUntrusted.TabIndex = 6;
            this.checkBoxUntrusted.Text = "Untrusted";
            this.checkBoxUntrusted.UseVisualStyleBackColor = true;
            // 
            // checkBoxMyComputer
            // 
            this.checkBoxMyComputer.AutoSize = true;
            this.checkBoxMyComputer.Location = new System.Drawing.Point(231, 132);
            this.checkBoxMyComputer.Name = "checkBoxMyComputer";
            this.checkBoxMyComputer.Size = new System.Drawing.Size(85, 17);
            this.checkBoxMyComputer.TabIndex = 7;
            this.checkBoxMyComputer.Text = "MyComputer";
            this.checkBoxMyComputer.UseVisualStyleBackColor = true;
            // 
            // checkBoxNoZone
            // 
            this.checkBoxNoZone.AutoSize = true;
            this.checkBoxNoZone.Location = new System.Drawing.Point(231, 155);
            this.checkBoxNoZone.Name = "checkBoxNoZone";
            this.checkBoxNoZone.Size = new System.Drawing.Size(65, 17);
            this.checkBoxNoZone.TabIndex = 8;
            this.checkBoxNoZone.Text = "NoZone";
            this.checkBoxNoZone.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxNoZone);
            this.Controls.Add(this.checkBoxMyComputer);
            this.Controls.Add(this.checkBoxUntrusted);
            this.Controls.Add(this.checkBoxTrusted);
            this.Controls.Add(this.checkBoxIntranet);
            this.Controls.Add(this.checkBoxInternet);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Implement);
            this.Controls.Add(this.OpenFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.Button Implement;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxInternet;
        private System.Windows.Forms.CheckBox checkBoxIntranet;
        private System.Windows.Forms.CheckBox checkBoxTrusted;
        private System.Windows.Forms.CheckBox checkBoxUntrusted;
        private System.Windows.Forms.CheckBox checkBoxMyComputer;
        private System.Windows.Forms.CheckBox checkBoxNoZone;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

