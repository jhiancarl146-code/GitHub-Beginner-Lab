namespace StudentProfile
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
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentContactNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStudentName.Location = new System.Drawing.Point(45, 66);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(312, 22);
            this.lblStudentName.TabIndex = 0;
            this.lblStudentName.Text = "Student Profile - GitHub Beginner Lab";
            // 
            // lblStudentContactNumber
            // 
            this.lblStudentContactNumber.AutoSize = true;
            this.lblStudentContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lblStudentContactNumber.Location = new System.Drawing.Point(45, 112);
            this.lblStudentContactNumber.Name = "lblStudentContactNumber";
            this.lblStudentContactNumber.Size = new System.Drawing.Size(265, 22);
            this.lblStudentContactNumber.TabIndex = 1;
            this.lblStudentContactNumber.Text = "Student Contact - 09171234567";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 353);
            this.Controls.Add(this.lblStudentContactNumber);
            this.Controls.Add(this.lblStudentName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentContactNumber;
    }
}

