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
    public partial class Form1 : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public Form1()
        {
            InitializeComponent();
        }

        private void AddStudent_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string display = "SELECT CONCAT(FirstName,' ', LastName) AS Name ,RegistrationNo AS [Registration Number], Contact, Email, convert(varchar, DateOfBirth, 106) AS [Date OF Birth], Value AS Gender " +
                "FROM Person JOIN Student ON Person.Id = Student.Id" +
                " JOIN LookUp ON Person.Gender = LookUp.Id";
            SqlCommand cmd = new SqlCommand(display, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Students.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "StudentEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.Students.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "StudentDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.Students.Columns.Add(deleteButton);
            connection.Close();
        }

        private void Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == Students.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == Students.Columns["StudentDeleteButton"].Index)
            {
                int i = e.RowIndex;
                String email = Students.Rows[i].Cells[3].Value.ToString();
                string regno = Students.Rows[i].Cells[1].Value.ToString();
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string display = String.Format("DELETE FROM Student WHERE RegistrationNo = '{0}'", regno);
                SqlCommand cmd = new SqlCommand(display, connection);
                cmd.ExecuteNonQuery();

                cmd.CommandText = string.Format("DELETE FROM Person WHERE Email = '{0}'", email);
                cmd.ExecuteNonQuery();
                Students.Rows.RemoveAt(i);
                connection.Close();
            }
            if (e.ColumnIndex == Students.Columns["StudentEditButton"].Index)
            {
                int i = e.RowIndex;
                string fullName = Students.Rows[i].Cells[0].Value.ToString();
                var names = fullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];
                string regno = Students.Rows[i].Cells[1].Value.ToString();
                string contact = Students.Rows[i].Cells[2].Value.ToString();
                string email = Students.Rows[i].Cells[3].Value.ToString();
                string DOB1 = Students.Rows[i].Cells[4].Value.ToString();
                DateTime dob = Convert.ToDateTime(DOB1);
                string gender = Students.Rows[i].Cells[5].Value.ToString();
                AddStudent form = new AddStudent(firstName, lastName, regno, contact, email, dob, gender, "edit");
                form.Show();
                this.Hide();
            }
        }

        private void InsertStudent_Click(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = "";
            string regno = "";
            string contact = "";
            string email = "";
            DateTime dob = DateTime.Now;
            string gender = "";
            AddStudent addStudent = new AddStudent(firstName, lastName, regno, contact, email, dob, gender, "add");
            this.Hide();
            addStudent.Show();
        }
    }
}
