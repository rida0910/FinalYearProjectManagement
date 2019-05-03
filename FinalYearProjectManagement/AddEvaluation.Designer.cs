namespace FinalYearProjectManagement
{
    partial class AddEvaluation
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
            this.WeightageTextBox = new System.Windows.Forms.TextBox();
            this.TotalWeightageLabel = new System.Windows.Forms.Label();
            this.MarksTextBox = new System.Windows.Forms.TextBox();
            this.TotalMarksLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.InsertEvaluation = new System.Windows.Forms.Button();
            this.BackScreen = new System.Windows.Forms.Button();
            this.AddEvaluationHeadingLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WeightageTextBox
            // 
            this.WeightageTextBox.Location = new System.Drawing.Point(620, 201);
            this.WeightageTextBox.Name = "WeightageTextBox";
            this.WeightageTextBox.Size = new System.Drawing.Size(100, 20);
            this.WeightageTextBox.TabIndex = 15;
            // 
            // TotalWeightageLabel
            // 
            this.TotalWeightageLabel.AutoSize = true;
            this.TotalWeightageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TotalWeightageLabel.ForeColor = System.Drawing.Color.White;
            this.TotalWeightageLabel.Location = new System.Drawing.Point(179, 199);
            this.TotalWeightageLabel.Name = "TotalWeightageLabel";
            this.TotalWeightageLabel.Size = new System.Drawing.Size(130, 20);
            this.TotalWeightageLabel.TabIndex = 14;
            this.TotalWeightageLabel.Text = "Total Weightage";
            // 
            // MarksTextBox
            // 
            this.MarksTextBox.Location = new System.Drawing.Point(620, 154);
            this.MarksTextBox.Name = "MarksTextBox";
            this.MarksTextBox.Size = new System.Drawing.Size(100, 20);
            this.MarksTextBox.TabIndex = 13;
            // 
            // TotalMarksLabel
            // 
            this.TotalMarksLabel.AutoSize = true;
            this.TotalMarksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.TotalMarksLabel.ForeColor = System.Drawing.Color.White;
            this.TotalMarksLabel.Location = new System.Drawing.Point(179, 152);
            this.TotalMarksLabel.Name = "TotalMarksLabel";
            this.TotalMarksLabel.Size = new System.Drawing.Size(97, 20);
            this.TotalMarksLabel.TabIndex = 12;
            this.TotalMarksLabel.Text = "Total Marks";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(620, 113);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 20);
            this.NameTextBox.TabIndex = 11;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(179, 111);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(53, 20);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Name";
            // 
            // InsertEvaluation
            // 
            this.InsertEvaluation.Location = new System.Drawing.Point(785, 363);
            this.InsertEvaluation.Name = "InsertEvaluation";
            this.InsertEvaluation.Size = new System.Drawing.Size(75, 23);
            this.InsertEvaluation.TabIndex = 9;
            this.InsertEvaluation.Text = "Save";
            this.InsertEvaluation.UseVisualStyleBackColor = true;
            this.InsertEvaluation.Click += new System.EventHandler(this.InsertEvaluation_Click);
            // 
            // BackScreen
            // 
            this.BackScreen.Location = new System.Drawing.Point(128, 363);
            this.BackScreen.Name = "BackScreen";
            this.BackScreen.Size = new System.Drawing.Size(75, 23);
            this.BackScreen.TabIndex = 8;
            this.BackScreen.Text = "Back";
            this.BackScreen.UseVisualStyleBackColor = true;
            this.BackScreen.Click += new System.EventHandler(this.BackScreen_Click);
            // 
            // AddEvaluationHeadingLabel
            // 
            this.AddEvaluationHeadingLabel.AutoSize = true;
            this.AddEvaluationHeadingLabel.Font = new System.Drawing.Font("Century Schoolbook", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEvaluationHeadingLabel.ForeColor = System.Drawing.Color.White;
            this.AddEvaluationHeadingLabel.Location = new System.Drawing.Point(393, 40);
            this.AddEvaluationHeadingLabel.Name = "AddEvaluationHeadingLabel";
            this.AddEvaluationHeadingLabel.Size = new System.Drawing.Size(166, 25);
            this.AddEvaluationHeadingLabel.TabIndex = 20;
            this.AddEvaluationHeadingLabel.Text = "Add Evaluation";
            // 
            // AddEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.AddEvaluationHeadingLabel);
            this.Controls.Add(this.WeightageTextBox);
            this.Controls.Add(this.TotalWeightageLabel);
            this.Controls.Add(this.MarksTextBox);
            this.Controls.Add(this.TotalMarksLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.InsertEvaluation);
            this.Controls.Add(this.BackScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Evaluation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeightageTextBox;
        private System.Windows.Forms.Label TotalWeightageLabel;
        private System.Windows.Forms.TextBox MarksTextBox;
        private System.Windows.Forms.Label TotalMarksLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button InsertEvaluation;
        private System.Windows.Forms.Button BackScreen;
        private System.Windows.Forms.Label AddEvaluationHeadingLabel;
    }
}