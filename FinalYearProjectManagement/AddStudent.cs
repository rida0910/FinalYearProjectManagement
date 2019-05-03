using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FinalYearProjectManagement
{
    public partial class AddStudent : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string value1;
        int IDStudent;
        public AddStudent(string firstName, string lastName, string regno, string contact, string email, DateTime dob, string gender, string value)
        {
            InitializeComponent();
            value1 = value;
            if (value == "edit")
            {
                FirstNametext.Text = firstName;
                LastNameText.Text = lastName;
                RegistrationNoText.Text = regno;
                ContactText.Text = contact;
                EmailText.Text = email;
                DOBdateTimePicker.Value = dob;
                GenderComboBox.Text = gender;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string cmdtext = string.Format("SELECT Id FROM Student WHERE RegistrationNo = '{0}'", regno);
                SqlCommand cmd = new SqlCommand(cmdtext, conn);
                IDStudent = (Int32)cmd.ExecuteScalar();

                this.Text = "Update Student";
                AddStudentHeadingLabel.Text = "Update Student";
            }
        }

        private void SaveStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = new Person();
                try
                {
                    person.fname = FirstNametext.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please Enter correct first name!");
                    FirstNametext.Clear();
                    throw new ArgumentException();
                }
                try
                {
                    person.lname = LastNameText.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please Enter correct last name!");
                    LastNameText.Clear();
                    throw new ArgumentException();
                }
                try
                {
                    person.Contact = ContactText.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please enter the correct 11 digit contact number");
                    ContactText.Clear();
                    throw new ArgumentException();
                }
                try
                {
                    person.Email = EmailText.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please Enter the email address");
                    EmailText.Clear();
                    throw new ArgumentException();
                }
                catch (FormatException)
                {
                    MessageBox.Show("Please Enter the correct email address");
                    EmailText.Clear();
                    throw new ArgumentException();
                }
                try
                {
                    person.DOB = DOBdateTimePicker.Value;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Person Age Must Be Greater Than 18");
                    DOBdateTimePicker.Value = DateTime.Now;
                    throw new ArgumentException();
                }
                try
                {
                    person.Gender = GenderComboBox.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please Select the gender From the dropdown list");
                    throw new ArgumentException();
                }

                Student student = new Student();
                try
                {
                    student.regNo = RegistrationNoText.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please Enter the Registration Number in the Format 1234-XY-567");
                    RegistrationNoText.Clear();
                    throw new ArgumentException();
                }

                if (value1 == "add")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string genderid = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND Category = 'GENDER'", person.Gender);
                    SqlCommand cmd = new SqlCommand(genderid, connection);
                    int id = (Int32)cmd.ExecuteScalar();

                    String cmdtext = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('{0}','{1}', '{2}', '{3}', '{4}', '{5}' )", person.fname, person.lname, person.Contact, person.Email, person.DOB, id);
                    cmd.CommandText = cmdtext;
                    cmd.ExecuteNonQuery();

                    string getid = string.Format("SELECT id FROM Person WHERE Email = '{0}'", person.Email);
                    cmd.CommandText = getid;
                    id = (Int32)cmd.ExecuteScalar();

                    string addStudent = string.Format("INSERT INTO Student(Id, RegistrationNo) values('{0}' , '{1}')", id, student.regNo);
                    cmd.CommandText = addStudent;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student Added");
                    connection.Close();
                }
                else if (value1 == "edit")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();

                    string getGenderId = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND Category = 'GENDER'", GenderComboBox.Text);
                    SqlCommand cmd = new SqlCommand(getGenderId, connection);
                    int gender = (Int32)cmd.ExecuteScalar();
                    string update = string.Format("UPDATE Student SET RegistrationNo = '{0}' WHERE Id = '{1}'", RegistrationNoText.Text, IDStudent);
                    cmd.CommandText = update;
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = string.Format("UPDATE Person SET FirstName = '{0}', LastName = '{1}', Contact = '{2}', Email = '{3}', " +
                        "DateOfBirth = '{4}', Gender = '{5}' WHERE Id = '{6}'", FirstNametext.Text, LastNameText.Text, ContactText.Text, EmailText.Text, DOBdateTimePicker.Value, gender, IDStudent);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated!");
                    connection.Close();
                }
                ManageStudentsForm form = new ManageStudentsForm();
                this.Close();
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Student not saved. Please try again!");
            }
        }

        private void BackToMainScreenStudent_Click(object sender, EventArgs e)
        {
            ManageStudentsForm form = new ManageStudentsForm();
            this.Close();
            form.Show();
        }
    }
}
