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

                FirstNametext.ReadOnly = true;
                LastNameText.ReadOnly = true;
                DOBdateTimePicker.Enabled = false;
                GenderComboBox.Enabled = false;

                this.Text = "Update Advisor";
            }
        }
        private void AddAdvisor1_Click(object sender, EventArgs e)
        {
            try
            {
                if (value1 == "add")
                {
                    SqlConnection connection1 = new SqlConnection(connString);
                    SqlConnection connection2 = new SqlConnection(connString);
                    connection1.Open();
                    connection2.Open();
                    string genderid = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND Category = 'GENDER'", GenderComboBox.Text);
                    SqlCommand cmd1 = new SqlCommand(genderid, connection1);
                    int id = (Int32)cmd1.ExecuteScalar();

                    String cmdtext = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender) values('{0}','{1}', '{2}', '{3}', '{4}', '{5}' )", FirstNametext.Text, LastNameText.Text, ContactText.Text, EmailText.Text, DOBdateTimePicker.Value, id);
                    SqlCommand cmd = new SqlCommand(cmdtext, connection2);
                    cmd.ExecuteNonQuery();

                    SqlConnection connection3 = new SqlConnection(connString);
                    connection3.Open();
                    string getid = string.Format("SELECT id FROM Person WHERE Email = '{0}'", EmailText.Text);
                    SqlCommand cmd2 = new SqlCommand(getid, connection3);
                    id = (Int32)cmd2.ExecuteScalar();


                    cmd.CommandText = string.Format("SELECT Id FROM Lookup WHERE Value = '{0}' AND Category = 'DESIGNATION'", designationComboBox.Text);
                    int desig = (Int32)cmd.ExecuteScalar();

                    SqlConnection connection4 = new SqlConnection(connString);
                    connection4.Open();
                    string addStudent = string.Format("INSERT INTO Advisor(Id, Designation, Salary) values('{0}' , '{1}', '{2}')", id, desig, SalaryTextBox.Text);
                    SqlCommand cmd3 = new SqlCommand(addStudent, connection3);
                    cmd3.ExecuteNonQuery();

                    MessageBox.Show("Advisor Added");
                    connection1.Close();
                    connection2.Close();
                    connection3.Close();
                    connection4.Close();
                }
                else if (value1 == "edit")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();

                    string getid = String.Format("SELECT Id FROM Person WHERE Email = '{0}'", EmailText.Text);
                    SqlCommand cmd = new SqlCommand(getid, connection);
                    int id = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = String.Format("SELECT Id FROM Lookup WHERE Value = '{0}' AND Category = 'DESIGNATION'", designationComboBox.Text);
                    int desig = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = string.Format("UPDATE Person SET Email = '{0}', Contact = '{1}' " +
                        "WHERE Person.Id = '{2}'", EmailText.Text, ContactText.Text, id); 
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format("UPDATE Advisor SET Designation = '{0}', Salary = '{1}' " +
                        "WHERE Id = '{2}'", desig, int.Parse(SalaryTextBox.Text), id);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                ManagerAdvisor form = new ManagerAdvisor();
                this.Close();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackToMainScreenStudent_Click(object sender, EventArgs e)
        {
            ManagerAdvisor form = new ManagerAdvisor();
            this.Close();
            form.Show();
        }
    }
}
