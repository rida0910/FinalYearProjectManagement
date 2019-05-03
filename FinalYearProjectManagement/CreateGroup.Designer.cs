namespace FinalYearProjectManagement
{
    partial class CreateGroup
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
            this.StudentsGrid = new System.Windows.Forms.DataGridView();
            this.StudentsCombobox = new System.Windows.Forms.ComboBox();
            this.GroupNum = new System.Windows.Forms.Label();
            this.CreateGroupButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsGrid
            // 
            this.StudentsGrid.AllowUserToAddRows = false;
            this.StudentsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsGrid.Location = new System.Drawing.Point(93, 148);
            this.StudentsGrid.Name = "StudentsGrid";
            this.StudentsGrid.Size = new System.Drawing.Size(764, 204);
            this.StudentsGrid.TabIndex = 0;
            this.StudentsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGrid_CellClick);
            // 
            // StudentsCombobox
            // 
            this.StudentsCombobox.FormattingEnabled = true;
            this.StudentsCombobox.Location = new System.Drawing.Point(653, 69);
            this.StudentsCombobox.Name = "StudentsCombobox";
            this.StudentsCombobox.Size = new System.Drawing.Size(204, 21);
            this.StudentsCombobox.TabIndex = 1;
            this.StudentsCombobox.SelectedIndexChanged += new System.EventHandler(this.StudentsCombobox_SelectedIndexChanged);
            // 
            // GroupNum
            // 
            this.GroupNum.AutoSize = true;
            this.GroupNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.GroupNum.ForeColor = System.Drawing.Color.White;
            this.GroupNum.Location = new System.Drawing.Point(89, 58);
            this.GroupNum.Name = "GroupNum";
            this.GroupNum.Size = new System.Drawing.Size(60, 24);
            this.GroupNum.TabIndex = 2;
            this.GroupNum.Text = "label1";
            // 
            // CreateGroupButton
            // 
            this.CreateGroupButton.Location = new System.Drawing.Point(798, 384);
            this.CreateGroupButton.Name = "CreateGroupButton";
            this.CreateGroupButton.Size = new System.Drawing.Size(75, 23);
            this.CreateGroupButton.TabIndex = 3;
            this.CreateGroupButton.Text = "Create";
            this.CreateGroupButton.UseVisualStyleBackColor = true;
            this.CreateGroupButton.Click += new System.EventHandler(this.CreateGroupButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(71, 384);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(531, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Student";
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CreateGroupButton);
            this.Controls.Add(this.GroupNum);
            this.Controls.Add(this.StudentsCombobox);
            this.Controls.Add(this.StudentsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CreateGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Group";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsGrid;
        private System.Windows.Forms.ComboBox StudentsCombobox;
        private System.Windows.Forms.Label GroupNum;
        private System.Windows.Forms.Button CreateGroupButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
    }
}