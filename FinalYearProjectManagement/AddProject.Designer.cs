namespace FinalYearProjectManagement
{
    partial class AddProject
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.SaveProject = new System.Windows.Forms.Button();
            this.BackToMainScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(52, 75);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(192, 72);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(237, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(192, 132);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(237, 133);
            this.DescriptionTextBox.TabIndex = 3;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(52, 176);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.DescriptionLabel.TabIndex = 2;
            this.DescriptionLabel.Text = "Description";
            // 
            // SaveProject
            // 
            this.SaveProject.Location = new System.Drawing.Point(401, 307);
            this.SaveProject.Name = "SaveProject";
            this.SaveProject.Size = new System.Drawing.Size(75, 23);
            this.SaveProject.TabIndex = 4;
            this.SaveProject.Text = "Save";
            this.SaveProject.UseVisualStyleBackColor = true;
            this.SaveProject.Click += new System.EventHandler(this.SaveProject_Click);
            // 
            // BackToMainScreen
            // 
            this.BackToMainScreen.Location = new System.Drawing.Point(100, 307);
            this.BackToMainScreen.Name = "BackToMainScreen";
            this.BackToMainScreen.Size = new System.Drawing.Size(75, 23);
            this.BackToMainScreen.TabIndex = 5;
            this.BackToMainScreen.Text = "Back";
            this.BackToMainScreen.UseVisualStyleBackColor = true;
            this.BackToMainScreen.Click += new System.EventHandler(this.BackToMainScreen_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 353);
            this.Controls.Add(this.BackToMainScreen);
            this.Controls.Add(this.SaveProject);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddProject";
            this.Text = "AddProject";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Button SaveProject;
        private System.Windows.Forms.Button BackToMainScreen;
    }
}