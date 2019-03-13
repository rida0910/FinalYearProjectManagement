namespace FinalYearProjectManagement
{
    partial class ManagerAdvisor
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
            this.InsertAdvisor = new System.Windows.Forms.Button();
            this.Advisor = new System.Windows.Forms.Label();
            this.Advisors = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Advisors)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertAdvisor
            // 
            this.InsertAdvisor.Location = new System.Drawing.Point(135, 57);
            this.InsertAdvisor.Name = "InsertAdvisor";
            this.InsertAdvisor.Size = new System.Drawing.Size(75, 23);
            this.InsertAdvisor.TabIndex = 24;
            this.InsertAdvisor.Text = "Add";
            this.InsertAdvisor.UseVisualStyleBackColor = true;
            this.InsertAdvisor.Click += new System.EventHandler(this.InsertAdvisor_Click);
            // 
            // Advisor
            // 
            this.Advisor.AutoSize = true;
            this.Advisor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Advisor.Location = new System.Drawing.Point(33, 60);
            this.Advisor.Name = "Advisor";
            this.Advisor.Size = new System.Drawing.Size(54, 16);
            this.Advisor.TabIndex = 23;
            this.Advisor.Text = "Advisor";
            // 
            // Advisors
            // 
            this.Advisors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Advisors.Location = new System.Drawing.Point(12, 100);
            this.Advisors.Name = "Advisors";
            this.Advisors.Size = new System.Drawing.Size(764, 238);
            this.Advisors.TabIndex = 22;
            this.Advisors.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Advisors_CellClick);
            // 
            // ManagerAdvisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 350);
            this.Controls.Add(this.InsertAdvisor);
            this.Controls.Add(this.Advisor);
            this.Controls.Add(this.Advisors);
            this.Name = "ManagerAdvisor";
            this.Text = "ManagerAdvisor";
            this.Load += new System.EventHandler(this.ManagerAdvisor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Advisors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button InsertAdvisor;
        private System.Windows.Forms.Label Advisor;
        private System.Windows.Forms.DataGridView Advisors;
    }
}