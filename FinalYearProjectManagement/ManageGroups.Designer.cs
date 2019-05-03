﻿namespace FinalYearProjectManagement
{
    partial class ManageGroups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageGroups));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.GroupsLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.InsertGroup = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.Groups = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Groups)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(952, 90);
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
            this.label1.Size = new System.Drawing.Size(846, 90);
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
            this.panel2.Size = new System.Drawing.Size(106, 90);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 90);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(952, 61);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.GroupsLabel);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(106, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(646, 61);
            this.panel5.TabIndex = 1;
            // 
            // GroupsLabel
            // 
            this.GroupsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupsLabel.Font = new System.Drawing.Font("Century725 BdCn BT", 14F, System.Drawing.FontStyle.Italic);
            this.GroupsLabel.ForeColor = System.Drawing.Color.White;
            this.GroupsLabel.Location = new System.Drawing.Point(0, 0);
            this.GroupsLabel.Name = "GroupsLabel";
            this.GroupsLabel.Size = new System.Drawing.Size(646, 61);
            this.GroupsLabel.TabIndex = 25;
            this.GroupsLabel.Text = "Groups";
            this.GroupsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.InsertGroup);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(752, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 61);
            this.panel6.TabIndex = 2;
            // 
            // InsertGroup
            // 
            this.InsertGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InsertGroup.Dock = System.Windows.Forms.DockStyle.Right;
            this.InsertGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InsertGroup.Font = new System.Drawing.Font("Century725 BdCn BT", 14F, System.Drawing.FontStyle.Italic);
            this.InsertGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.InsertGroup.Image = ((System.Drawing.Image)(resources.GetObject("InsertGroup.Image")));
            this.InsertGroup.Location = new System.Drawing.Point(61, 0);
            this.InsertGroup.Name = "InsertGroup";
            this.InsertGroup.Size = new System.Drawing.Size(139, 61);
            this.InsertGroup.TabIndex = 25;
            this.InsertGroup.UseVisualStyleBackColor = true;
            this.InsertGroup.Click += new System.EventHandler(this.InsertGroup_Click_1);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.HomeButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(106, 61);
            this.panel4.TabIndex = 0;
            // 
            // HomeButton
            // 
            this.HomeButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(106, 61);
            this.HomeButton.TabIndex = 2;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click_1);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.Groups);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 151);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(952, 287);
            this.panel7.TabIndex = 7;
            // 
            // Groups
            // 
            this.Groups.AllowUserToAddRows = false;
            this.Groups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Groups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Groups.Location = new System.Drawing.Point(0, 0);
            this.Groups.Name = "Groups";
            this.Groups.RowHeadersVisible = false;
            this.Groups.Size = new System.Drawing.Size(952, 287);
            this.Groups.TabIndex = 23;
            this.Groups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Groups_CellClick_1);
            // 
            // ManageGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(51)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(952, 438);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "ManageGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageGroups";
            this.Load += new System.EventHandler(this.ManageGroups_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Groups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label GroupsLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button InsertGroup;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView Groups;
    }
}