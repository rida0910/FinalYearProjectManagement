namespace FinalYearProjectManagement
{
    partial class AddStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BackToMainScreenStudent = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RegistrationNoText = new System.Windows.Forms.TextBox();
            this.ContactText = new System.Windows.Forms.TextBox();
            this.RegistrationNumber = new System.Windows.Forms.Label();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.FirstName = new System.Windows.Forms.Label();
            this.DOBdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FirstNametext = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.DOB = new System.Windows.Forms.Label();
            this.LastNameText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.FirstNametext);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.RegistrationNoText);
            this.panel1.Controls.Add(this.ContactText);
            this.panel1.Controls.Add(this.RegistrationNumber);
            this.panel1.Controls.Add(this.GenderComboBox);
            this.panel1.Controls.Add(this.FirstName);
            this.panel1.Controls.Add(this.DOBdateTimePicker);
            this.panel1.Controls.Add(this.Gender);
            this.panel1.Controls.Add(this.LastName);
            this.panel1.Controls.Add(this.DOB);
            this.panel1.Controls.Add(this.LastNameText);
            this.panel1.Controls.Add(this.EmailText);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.Email);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 343);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.BackToMainScreenStudent);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(17, 266);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 65);
            this.panel2.TabIndex = 18;
            // 
            // BackToMainScreenStudent
            // 
            this.BackToMainScreenStudent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackToMainScreenStudent.Location = new System.Drawing.Point(26, 24);
            this.BackToMainScreenStudent.Name = "BackToMainScreenStudent";
            this.BackToMainScreenStudent.Size = new System.Drawing.Size(79, 27);
            this.BackToMainScreenStudent.TabIndex = 17;
            this.BackToMainScreenStudent.Text = "Back";
            this.BackToMainScreenStudent.UseVisualStyleBackColor = true;
            this.BackToMainScreenStudent.Click += new System.EventHandler(this.BackToMainScreenStudent_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(344, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegistrationNoText
            // 
            this.RegistrationNoText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationNoText.Location = new System.Drawing.Point(151, 224);
            this.RegistrationNoText.Name = "RegistrationNoText";
            this.RegistrationNoText.Size = new System.Drawing.Size(237, 20);
            this.RegistrationNoText.TabIndex = 16;
            // 
            // ContactText
            // 
            this.ContactText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ContactText.Location = new System.Drawing.Point(151, 89);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(237, 20);
            this.ContactText.TabIndex = 6;
            // 
            // RegistrationNumber
            // 
            this.RegistrationNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RegistrationNumber.AutoSize = true;
            this.RegistrationNumber.Location = new System.Drawing.Point(14, 231);
            this.RegistrationNumber.Name = "RegistrationNumber";
            this.RegistrationNumber.Size = new System.Drawing.Size(103, 13);
            this.RegistrationNumber.TabIndex = 15;
            this.RegistrationNumber.Text = "Registration Number";
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenderComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.GenderComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(151, 188);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(237, 21);
            this.GenderComboBox.TabIndex = 14;
            // 
            // FirstName
            // 
            this.FirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstName.AutoSize = true;
            this.FirstName.Location = new System.Drawing.Point(14, 33);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(57, 13);
            this.FirstName.TabIndex = 0;
            this.FirstName.Text = "First Name";
            // 
            // DOBdateTimePicker
            // 
            this.DOBdateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DOBdateTimePicker.Location = new System.Drawing.Point(151, 153);
            this.DOBdateTimePicker.Name = "DOBdateTimePicker";
            this.DOBdateTimePicker.Size = new System.Drawing.Size(237, 20);
            this.DOBdateTimePicker.TabIndex = 13;
            // 
            // FirstNametext
            // 
            this.FirstNametext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstNametext.Location = new System.Drawing.Point(151, 26);
            this.FirstNametext.Name = "FirstNametext";
            this.FirstNametext.Size = new System.Drawing.Size(236, 20);
            this.FirstNametext.TabIndex = 2;
            // 
            // Gender
            // 
            this.Gender.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Gender.AutoSize = true;
            this.Gender.Location = new System.Drawing.Point(14, 191);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(42, 13);
            this.Gender.TabIndex = 11;
            this.Gender.Text = "Gender";
            // 
            // LastName
            // 
            this.LastName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastName.AutoSize = true;
            this.LastName.Location = new System.Drawing.Point(14, 64);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(58, 13);
            this.LastName.TabIndex = 3;
            this.LastName.Text = "Last Name";
            // 
            // DOB
            // 
            this.DOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DOB.AutoSize = true;
            this.DOB.Location = new System.Drawing.Point(14, 153);
            this.DOB.Name = "DOB";
            this.DOB.Size = new System.Drawing.Size(66, 13);
            this.DOB.TabIndex = 9;
            this.DOB.Text = "Date of Birth";
            // 
            // LastNameText
            // 
            this.LastNameText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastNameText.Location = new System.Drawing.Point(151, 57);
            this.LastNameText.Name = "LastNameText";
            this.LastNameText.Size = new System.Drawing.Size(237, 20);
            this.LastNameText.TabIndex = 4;
            // 
            // EmailText
            // 
            this.EmailText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailText.Location = new System.Drawing.Point(151, 121);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(237, 20);
            this.EmailText.TabIndex = 8;
            // 
            // Contact
            // 
            this.Contact.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(14, 96);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(44, 13);
            this.Contact.TabIndex = 5;
            this.Contact.Text = "Contact";
            // 
            // Email
            // 
            this.Email.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(14, 128);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(32, 13);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 343);
            this.Controls.Add(this.panel1);
            this.Name = "AddStudent";
            this.Text = "Add Student";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox RegistrationNoText;
        private System.Windows.Forms.TextBox ContactText;
        private System.Windows.Forms.Label RegistrationNumber;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.DateTimePicker DOBdateTimePicker;
        private System.Windows.Forms.TextBox FirstNametext;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label DOB;
        private System.Windows.Forms.TextBox LastNameText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Button BackToMainScreenStudent;
        private System.Windows.Forms.Panel panel2;
    }
}