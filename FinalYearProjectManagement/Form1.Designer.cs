namespace FinalYearProjectManagement
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
            this.Students = new System.Windows.Forms.DataGridView();
            this.FYPManagementSystem = new System.Windows.Forms.Label();
            this.Student = new System.Windows.Forms.Label();
            this.InsertStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Students)).BeginInit();
            this.SuspendLayout();
            // 
            // Students
            // 
            this.Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Students.Location = new System.Drawing.Point(32, 119);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(613, 238);
            this.Students.TabIndex = 18;
            this.Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Students_CellClick);
            // 
            // FYPManagementSystem
            // 
            this.FYPManagementSystem.AutoSize = true;
            this.FYPManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FYPManagementSystem.Location = new System.Drawing.Point(232, 22);
            this.FYPManagementSystem.Name = "FYPManagementSystem";
            this.FYPManagementSystem.Size = new System.Drawing.Size(195, 20);
            this.FYPManagementSystem.TabIndex = 19;
            this.FYPManagementSystem.Text = "FYP Management System";
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.Location = new System.Drawing.Point(29, 79);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(60, 16);
            this.Student.TabIndex = 20;
            this.Student.Text = "Students";
            // 
            // InsertStudent
            // 
            this.InsertStudent.Location = new System.Drawing.Point(570, 72);
            this.InsertStudent.Name = "InsertStudent";
            this.InsertStudent.Size = new System.Drawing.Size(75, 23);
            this.InsertStudent.TabIndex = 21;
            this.InsertStudent.Text = "Add";
            this.InsertStudent.UseVisualStyleBackColor = true;
            this.InsertStudent.Click += new System.EventHandler(this.InsertStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 369);
            this.Controls.Add(this.InsertStudent);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.FYPManagementSystem);
            this.Controls.Add(this.Students);
            this.Name = "Form1";
            this.Text = "Manage Students";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Students;
        private System.Windows.Forms.Label FYPManagementSystem;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Button InsertStudent;
    }
}

