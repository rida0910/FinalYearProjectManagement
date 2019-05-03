namespace FinalYearProjectManagement
{
    partial class AssignAdvisorToProject
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
            this.AssignProjectLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.AssignAdvisorButton = new System.Windows.Forms.Button();
            this.ProjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RoleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AssignProjectLabel
            // 
            this.AssignProjectLabel.AutoSize = true;
            this.AssignProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AssignProjectLabel.ForeColor = System.Drawing.Color.White;
            this.AssignProjectLabel.Location = new System.Drawing.Point(430, 28);
            this.AssignProjectLabel.Name = "AssignProjectLabel";
            this.AssignProjectLabel.Size = new System.Drawing.Size(135, 24);
            this.AssignProjectLabel.TabIndex = 13;
            this.AssignProjectLabel.Text = "Assign Advisor";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(91, 357);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(97, 36);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AssignAdvisorButton
            // 
            this.AssignAdvisorButton.Location = new System.Drawing.Point(782, 357);
            this.AssignAdvisorButton.Name = "AssignAdvisorButton";
            this.AssignAdvisorButton.Size = new System.Drawing.Size(113, 36);
            this.AssignAdvisorButton.TabIndex = 11;
            this.AssignAdvisorButton.Text = "Assign Advisor";
            this.AssignAdvisorButton.UseVisualStyleBackColor = true;
            this.AssignAdvisorButton.Click += new System.EventHandler(this.AssignAdvisorButton_Click);
            // 
            // ProjectsComboBox
            // 
            this.ProjectsComboBox.FormattingEnabled = true;
            this.ProjectsComboBox.Location = new System.Drawing.Point(434, 116);
            this.ProjectsComboBox.Name = "ProjectsComboBox";
            this.ProjectsComboBox.Size = new System.Drawing.Size(184, 21);
            this.ProjectsComboBox.TabIndex = 10;
            this.ProjectsComboBox.SelectedIndexChanged += new System.EventHandler(this.ProjectsComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(276, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Project";
            // 
            // AdvisorComboBox
            // 
            this.AdvisorComboBox.FormattingEnabled = true;
            this.AdvisorComboBox.Location = new System.Drawing.Point(434, 183);
            this.AdvisorComboBox.Name = "AdvisorComboBox";
            this.AdvisorComboBox.Size = new System.Drawing.Size(184, 21);
            this.AdvisorComboBox.TabIndex = 8;
            this.AdvisorComboBox.SelectedIndexChanged += new System.EventHandler(this.AdvisorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(276, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Advisor";
            // 
            // RoleComboBox
            // 
            this.RoleComboBox.FormattingEnabled = true;
            this.RoleComboBox.Location = new System.Drawing.Point(434, 249);
            this.RoleComboBox.Name = "RoleComboBox";
            this.RoleComboBox.Size = new System.Drawing.Size(184, 21);
            this.RoleComboBox.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(276, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Select Advisor Role";
            // 
            // AssignAdvisorToProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.RoleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AssignProjectLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AssignAdvisorButton);
            this.Controls.Add(this.ProjectsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AdvisorComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AssignAdvisorToProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignAdvisorToProject";
            this.Load += new System.EventHandler(this.AssignAdvisorToProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssignProjectLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AssignAdvisorButton;
        private System.Windows.Forms.ComboBox ProjectsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox AdvisorComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox RoleComboBox;
        private System.Windows.Forms.Label label3;
    }
}