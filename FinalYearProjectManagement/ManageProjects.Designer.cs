namespace FinalYearProjectManagement
{
    partial class ManageProjects
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
            this.InsertProject = new System.Windows.Forms.Button();
            this.ProjectsLabel = new System.Windows.Forms.Label();
            this.Projects = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Projects)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertProject
            // 
            this.InsertProject.Location = new System.Drawing.Point(161, 47);
            this.InsertProject.Name = "InsertProject";
            this.InsertProject.Size = new System.Drawing.Size(75, 23);
            this.InsertProject.TabIndex = 27;
            this.InsertProject.Text = "Add";
            this.InsertProject.UseVisualStyleBackColor = true;
            this.InsertProject.Click += new System.EventHandler(this.InsertProject_Click);
            // 
            // ProjectsLabel
            // 
            this.ProjectsLabel.AutoSize = true;
            this.ProjectsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectsLabel.Location = new System.Drawing.Point(24, 50);
            this.ProjectsLabel.Name = "ProjectsLabel";
            this.ProjectsLabel.Size = new System.Drawing.Size(57, 16);
            this.ProjectsLabel.TabIndex = 26;
            this.ProjectsLabel.Text = "Projects";
            // 
            // Projects
            // 
            this.Projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Projects.Location = new System.Drawing.Point(27, 92);
            this.Projects.Name = "Projects";
            this.Projects.Size = new System.Drawing.Size(530, 238);
            this.Projects.TabIndex = 25;
            this.Projects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Projects_CellContentClick);
            // 
            // ManageProjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 342);
            this.Controls.Add(this.InsertProject);
            this.Controls.Add(this.ProjectsLabel);
            this.Controls.Add(this.Projects);
            this.Name = "ManageProjects";
            this.Text = "ManageProjects";
            this.Load += new System.EventHandler(this.ManageProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Projects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertProject;
        private System.Windows.Forms.Label ProjectsLabel;
        private System.Windows.Forms.DataGridView Projects;
    }
}