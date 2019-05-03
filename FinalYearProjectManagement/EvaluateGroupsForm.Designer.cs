namespace FinalYearProjectManagement
{
    partial class EvaluateGroupsForm
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
            this.EvaluateButton = new System.Windows.Forms.Button();
            this.EvaluationComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GroupsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ObtainedMarksNUmericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObtainedMarksNUmericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AssignProjectLabel
            // 
            this.AssignProjectLabel.AutoSize = true;
            this.AssignProjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.AssignProjectLabel.ForeColor = System.Drawing.Color.White;
            this.AssignProjectLabel.Location = new System.Drawing.Point(456, 41);
            this.AssignProjectLabel.Name = "AssignProjectLabel";
            this.AssignProjectLabel.Size = new System.Drawing.Size(140, 24);
            this.AssignProjectLabel.TabIndex = 13;
            this.AssignProjectLabel.Text = "Evaluate Group";
            this.AssignProjectLabel.Click += new System.EventHandler(this.AssignProjectLabel_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(118, 338);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(97, 36);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EvaluateButton
            // 
            this.EvaluateButton.Location = new System.Drawing.Point(789, 338);
            this.EvaluateButton.Name = "EvaluateButton";
            this.EvaluateButton.Size = new System.Drawing.Size(113, 36);
            this.EvaluateButton.TabIndex = 11;
            this.EvaluateButton.Text = "Done";
            this.EvaluateButton.UseVisualStyleBackColor = true;
            this.EvaluateButton.Click += new System.EventHandler(this.EvaluateButton_Click);
            // 
            // EvaluationComboBox
            // 
            this.EvaluationComboBox.FormattingEnabled = true;
            this.EvaluationComboBox.Location = new System.Drawing.Point(476, 177);
            this.EvaluationComboBox.Name = "EvaluationComboBox";
            this.EvaluationComboBox.Size = new System.Drawing.Size(217, 21);
            this.EvaluationComboBox.TabIndex = 10;
            this.EvaluationComboBox.SelectedIndexChanged += new System.EventHandler(this.EvaluationComboBox_SelectedIndexChanged);
            this.EvaluationComboBox.SelectedValueChanged += new System.EventHandler(this.EvaluationComboBox_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(259, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Select Evaluation";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // GroupsComboBox
            // 
            this.GroupsComboBox.FormattingEnabled = true;
            this.GroupsComboBox.Location = new System.Drawing.Point(476, 140);
            this.GroupsComboBox.Name = "GroupsComboBox";
            this.GroupsComboBox.Size = new System.Drawing.Size(217, 21);
            this.GroupsComboBox.TabIndex = 8;
            this.GroupsComboBox.SelectedIndexChanged += new System.EventHandler(this.GroupsComboBox_SelectedIndexChanged);
            this.GroupsComboBox.SelectedValueChanged += new System.EventHandler(this.GroupsComboBox_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Group";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ObtainedMarksNUmericUpDown
            // 
            this.ObtainedMarksNUmericUpDown.Location = new System.Drawing.Point(476, 246);
            this.ObtainedMarksNUmericUpDown.Name = "ObtainedMarksNUmericUpDown";
            this.ObtainedMarksNUmericUpDown.Size = new System.Drawing.Size(217, 20);
            this.ObtainedMarksNUmericUpDown.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(259, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Obtained Marks";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(259, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "TotalMarks";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.ForeColor = System.Drawing.Color.White;
            this.TotalMarksLabel.Location = new System.Drawing.Point(473, 216);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(0, 13);
            this.TotalMarksLabel.TabIndex = 17;
            // 
            // EvaluateGroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.TotalMarksLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ObtainedMarksNUmericUpDown);
            this.Controls.Add(this.AssignProjectLabel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EvaluateButton);
            this.Controls.Add(this.EvaluationComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupsComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EvaluateGroupsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EvaluateGroupsForm";
            this.Load += new System.EventHandler(this.EvaluateGroupsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ObtainedMarksNUmericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AssignProjectLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EvaluateButton;
        private System.Windows.Forms.ComboBox EvaluationComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GroupsComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ObtainedMarksNUmericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TotalMarksLabel;
    }
}