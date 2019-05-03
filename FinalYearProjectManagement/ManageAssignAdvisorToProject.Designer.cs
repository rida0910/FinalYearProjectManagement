namespace FinalYearProjectManagement
{
    partial class ManageAssignAdvisorToProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageAssignAdvisorToProject));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ProjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.InsertProjectAdvsior = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.ProjectAdvisorsGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAdvisorsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 93);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century725 BdCn BT", 27F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(106, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(846, 93);
            this.label1.TabIndex = 5;
            this.label1.Text = "FYP Management System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(106, 93);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 93);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 43);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.HomeButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 43);
            this.panel4.TabIndex = 29;
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(106, 43);
            this.HomeButton.TabIndex = 27;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ProjectsComboBox);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(481, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(471, 43);
            this.panel5.TabIndex = 28;
            // 
            // ProjectsComboBox
            // 
            this.ProjectsComboBox.FormattingEnabled = true;
            this.ProjectsComboBox.Location = new System.Drawing.Point(290, 9);
            this.ProjectsComboBox.Name = "ProjectsComboBox";
            this.ProjectsComboBox.Size = new System.Drawing.Size(169, 21);
            this.ProjectsComboBox.TabIndex = 5;
            this.ProjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectsComboBox_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(200, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Select Project";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.InsertProjectAdvsior);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 136);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(952, 45);
            this.panel6.TabIndex = 3;
            // 
            // InsertProjectAdvsior
            // 
            this.InsertProjectAdvsior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertProjectAdvsior.Dock = System.Windows.Forms.DockStyle.Right;
            this.InsertProjectAdvsior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertProjectAdvsior.Font = new System.Drawing.Font("Century725 BdCn BT", 14F, System.Drawing.FontStyle.Italic);
            this.InsertProjectAdvsior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.InsertProjectAdvsior.Image = ((System.Drawing.Image)(resources.GetObject("InsertProjectAdvsior.Image")));
            this.InsertProjectAdvsior.Location = new System.Drawing.Point(809, 0);
            this.InsertProjectAdvsior.Name = "InsertProjectAdvsior";
            this.InsertProjectAdvsior.Size = new System.Drawing.Size(143, 45);
            this.InsertProjectAdvsior.TabIndex = 29;
            this.InsertProjectAdvsior.UseVisualStyleBackColor = true;
            this.InsertProjectAdvsior.Click += new System.EventHandler(this.InsertProjectAdvsior_Click_1);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Century725 BdCn BT", 14F, System.Drawing.FontStyle.Italic);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(512, 45);
            this.label2.TabIndex = 28;
            this.label2.Text = "Project Advisors";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.ProjectAdvisorsGrid);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 181);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(952, 257);
            this.panel7.TabIndex = 4;
            // 
            // ProjectAdvisorsGrid
            // 
            this.ProjectAdvisorsGrid.AllowUserToAddRows = false;
            this.ProjectAdvisorsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProjectAdvisorsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProjectAdvisorsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProjectAdvisorsGrid.Location = new System.Drawing.Point(0, 0);
            this.ProjectAdvisorsGrid.Name = "ProjectAdvisorsGrid";
            this.ProjectAdvisorsGrid.RowHeadersVisible = false;
            this.ProjectAdvisorsGrid.Size = new System.Drawing.Size(952, 257);
            this.ProjectAdvisorsGrid.TabIndex = 28;
            this.ProjectAdvisorsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProjectAdvisorsGrid_CellClick_1);
            // 
            // ManageAssignAdvisorToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ManageAssignAdvisorToProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Advisor";
            this.Load += new System.EventHandler(this.ManageAssignAdvisorToProject_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectAdvisorsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox ProjectsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button InsertProjectAdvsior;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView ProjectAdvisorsGrid;
    }
}