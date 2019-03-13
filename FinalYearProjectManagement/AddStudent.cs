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

                FirstNametext.ReadOnly = true;
                LastNameText.ReadOnly = true;
                RegistrationNoText.ReadOnly = true;
                DOBdateTimePicker.Enabled = false;
                GenderComboBox.Enabled = false;

                this.Text = "Update Student";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (value1 == "add")
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

                    SqlConnection connection1 = new SqlConnection(connString);
                    SqlConnection connection2 = new SqlConnection(connString);
                    connection1.Open();
                    connection2.Open();
                    string genderid = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND Category = 'GENDER'", person.Gender);
                    SqlCommand cmd1 = new SqlCommand(genderid, connection1);
                    int id = (Int32)cmd1.ExecuteScalar();

                    String cmdtext = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('{0}','{1}', '{2}', '{3}', '{4}', '{5}' )", person.fname, person.lname, person.Contact, person.Email, person.DOB, id);
                    SqlCommand cmd = new SqlCommand(cmdtext, connection2);
                    cmd.ExecuteNonQuery();

                    SqlConnection connection3 = new SqlConnection(connString);
                    connection3.Open();
                    string getid = string.Format("SELECT id FROM Person WHERE Email = '{0}'", person.Email);
                    SqlCommand cmd2 = new SqlCommand(getid, connection3);
                    id = (Int32)cmd2.ExecuteScalar();

                    SqlConnection connection4 = new SqlConnection(connString);
                    connection4.Open();
                    string addStudent = string.Format("INSERT INTO Student(Id, RegistrationNo) values('{0}' , '{1}')", id, student.regNo);
                    SqlCommand cmd3 = new SqlCommand(addStudent, connection3);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Student Added");
                    connection1.Close();
                    connection2.Close();
                    connection3.Close();
                    connection4.Close();
                }
                else if (value1 == "edit")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string update = string.Format("UPDATE Person SET Email = '{0}', Contact = '{1}'" +
                        "FROM Person JOIN Student on person.Id = Student.Id " +
                        "WHERE FirstName = '{2}' AND LastName = '{3}' AND RegistrationNo = '{4}'", EmailText.Text, ContactText.Text, FirstNametext.Text,
                        LastNameText.Text, RegistrationNoText.Text);
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.ExecuteNonQuery();
                }
                Form1 form = new Form1();
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
            Form1 form = new Form1();
            this.Close();
            form.Show();
        }
    }
}
