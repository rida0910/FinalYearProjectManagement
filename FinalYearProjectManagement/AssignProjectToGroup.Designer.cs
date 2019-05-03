namespace FinalYearProjectManagement
{
    partial class AssignProjectToGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.GroupsComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectsComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AssignProjectButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AssignProjectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(251, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Group";
            // 
            // GroupsComboBox
            // 
            this.GroupsComboBox.FormattingEnabled = true;
            this.GroupsComboBox.Location = new System.Drawing.Point(420, 153);
            this.GroupsComboBox.Name = "GroupsComboBox";
            this.GroupsComboBox.Size = new System.Drawing.Size(195, 21);
            this.GroupsComboBox.TabIndex = 1;
            // 
            // ProjectsComboBox
            // 
            this.ProjectsComboBox.FormattingEnabled = true;
            this.ProjectsComboBox.Location = new System.Drawing.Point(420, 236);
            this.ProjectsComboBox.Name = "ProjectsComboBox";
            this.ProjectsComboBox.Size = new System.Drawing.Size(195, 21);
            this.ProjectsComboBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(251, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Project";
            // 
            // AssignProjectButton
            // 
            this.AssignProjectButton.Location = new System.Drawing.Point(779, 345);
            this.AssignProjectButton.Name = "AssignProjectButton";
            this.AssignProjectButton.Size = new System.Drawing.Size(113, 36);
            this.AssignProjectButton.TabIndex = 4;
            this.AssignProjectButton.Text = "Assign Project";
            this.AssignProjectButton.UseVisualStyleBackColor = true;
            this.AssignProjectButton.Click += new System.EventHandler(this.AssignProjectButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(97, 345);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(97, 36);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // AssignProjectLabel
            // 
            this.AssignProjectLabel.AutoSize = true;
            this.AssignProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AssignProjectLabel.ForeColor = System.Drawing.Color.White;
            this.AssignProjectLabel.Location = new System.Drawing.Point(416, 48);
            this.AssignProjectLabel.Name = "AssignProjectLabel";
            this.AssignProjectLabel.Size = new System.Drawing.Size(130, 24);
            this.AssignProjectLabel.TabIndex = 6;
            this.AssignProjectLabel.Text = "Assign Project";
            // 
            // AssignProjectToGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.AssignProjectLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AssignProjectButton);
            this.Controls.Add(this.ProjectsComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupsComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AssignProjectToGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assign Project";
            this.Load += new System.EventHandler(this.AssignProjectToGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GroupsComboBox;
        private System.Windows.Forms.ComboBox ProjectsComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AssignProjectButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label AssignProjectLabel;
    }
}