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
    public partial class AddAdvisor : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string value1;
        int IDadvisor;
        public AddAdvisor(string firstName, string lastName, string Designation, string contact, string email, Decimal salary, DateTime dob, string gender, string value)
        {
            InitializeComponent();
            value1 = value;
            if (value == "edit")
            {
                FirstNametext.Text = firstName;
                LastNameText.Text = lastName;
                designationComboBox.Text = Designation;
                ContactText.Text = contact;
                EmailText.Text = email;
                SalaryTextBox.Text = salary.ToString();
                DOBdateTimePicker.Value = dob;
                GenderComboBox.Text = gender;

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string cmdtext = string.Format("SELECT Id FROM Person WHERE Email = '{0}'", EmailText.Text);
                SqlCommand cmd = new SqlCommand(cmdtext, conn);
                IDadvisor = (Int32)cmd.ExecuteScalar();

                this.Text = "Update Advisor";
                AddAdvisorHeadingLabel.Text = "Update Advsior";
            }
        }
        private void AddAdvisor1_Click(object sender, EventArgs e)
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

                Advisor advisor = new Advisor();
                try
                {
                    advisor.designation = designationComboBox.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please select designation from the dropdown list");
                    designationComboBox.ResetText();
                    throw new ArgumentException();
                }

                try
                {
                    advisor.salary = SalaryTextBox.Text;
                }
                catch
                {
                    MessageBox.Show("Please enter the salary in digits");
                    throw new ArgumentException();
                }
                if (value1 == "add")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string genderid = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND Category = 'GENDER'", GenderComboBox.Text);
                    SqlCommand cmd = new SqlCommand(genderid, connection);
                    int id = (Int32)cmd.ExecuteScalar();

                    String cmdtext = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('{0}','{1}', '{2}', '{3}', '{4}', '{5}' )", FirstNametext.Text, LastNameText.Text, ContactText.Text, EmailText.Text, DOBdateTimePicker.Value, id);
                    cmd.CommandText = cmdtext;
                    cmd.ExecuteNonQuery();

                    string getid = string.Format("SELECT id FROM Person WHERE Email = '{0}'", EmailText.Text);
                    cmd.CommandText = getid;
                    id = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = string.Format("SELECT Id FROM Lookup WHERE Value = '{0}' AND Category = 'DESIGNATION'", designationComboBox.Text);
                    int desig = (Int32)cmd.ExecuteScalar();

                    string addStudent = string.Format("INSERT INTO Advisor(Id, Designation, Salary) values('{0}' , '{1}', '{2}')", id, desig, SalaryTextBox.Text);
                    cmd.CommandText = addStudent;
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Advisor Added");
                    connection.Close();
                }
                else if (value1 == "edit")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();

                    string getGenderId = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND Category = 'GENDER'", GenderComboBox.Text);
                    SqlCommand cmd = new SqlCommand(getGenderId, connection);
                    int gender = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}' AND Category = 'DESIGNATION'", designationComboBox.Text);
                    int desig = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = string.Format("UPDATE Person SET FirstName = '{0}', LastName = '{1}', Contact = '{2}', Email = '{3}', " +
                        "DateOfBirth = '{4}', Gender = '{5}' WHERE Id = '{6}'", FirstNametext.Text, LastNameText.Text, ContactText.Text, EmailText.Text, DOBdateTimePicker.Value, gender, IDadvisor);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format("UPDATE Advisor SET Designation = '{0}', Salary = '{1}' " +
                        "WHERE Id = '{2}'", desig, int.Parse(SalaryTextBox.Text), IDadvisor);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Updated!");
                    connection.Close();
                }
                ManageAdvisors form = new ManageAdvisors();
                this.Close();
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Advisor not saved. Please try again!");
            }
        }

        private void BackToMainScreenStudent_Click(object sender, EventArgs e)
        {
            ManageAdvisors form = new ManageAdvisors();
            this.Close();
            form.Show();
        }
    }
}
