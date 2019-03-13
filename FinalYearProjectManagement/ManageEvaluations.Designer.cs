namespace FinalYearProjectManagement
{
    partial class ManageEvaluations
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
            this.InsertEvaluation = new System.Windows.Forms.Button();
            this.EvaluationLabel = new System.Windows.Forms.Label();
            this.Evaluations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Evaluations)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertEvaluation
            // 
            this.InsertEvaluation.Location = new System.Drawing.Point(563, 35);
            this.InsertEvaluation.Name = "InsertEvaluation";
            this.InsertEvaluation.Size = new System.Drawing.Size(75, 23);
            this.InsertEvaluation.TabIndex = 24;
            this.InsertEvaluation.Text = "Add";
            this.InsertEvaluation.UseVisualStyleBackColor = true;
            this.InsertEvaluation.Click += new System.EventHandler(this.InsertEvaluation_Click);
            // 
            // EvaluationLabel
            // 
            this.EvaluationLabel.AutoSize = true;
            this.EvaluationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EvaluationLabel.Location = new System.Drawing.Point(22, 42);
            this.EvaluationLabel.Name = "EvaluationLabel";
            this.EvaluationLabel.Size = new System.Drawing.Size(78, 16);
            this.EvaluationLabel.TabIndex = 23;
            this.EvaluationLabel.Text = "Evaluations";
            // 
            // Evaluations
            // 
            this.Evaluations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Evaluations.Location = new System.Drawing.Point(25, 82);
            this.Evaluations.Name = "Evaluations";
            this.Evaluations.Size = new System.Drawing.Size(613, 238);
            this.Evaluations.TabIndex = 22;
            this.Evaluations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Evaluations_CellClick);
            // 
            // ManageEvaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 332);
            this.Controls.Add(this.InsertEvaluation);
            this.Controls.Add(this.EvaluationLabel);
            this.Controls.Add(this.Evaluations);
            this.Name = "ManageEvaluations";
            this.Text = "ManageEvaluations";
            this.Load += new System.EventHandler(this.ManageEvaluations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Evaluations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertEvaluation;
        private System.Windows.Forms.Label EvaluationLabel;
        private System.Windows.Forms.DataGridView Evaluations;
    }
}