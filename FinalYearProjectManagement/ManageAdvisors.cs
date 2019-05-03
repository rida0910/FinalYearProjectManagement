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
    public partial class ManageAdvisors : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public ManageAdvisors()
        {
            InitializeComponent();
        }

        private void ManagerAdvisor_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string display = "SELECT CONCAT(FirstName,' ', LastName) AS Name, D.Value AS Designation, Contact, Email, Salary, " +
                "convert(varchar, DateOfBirth, 106) AS[Date OF Birth], G.Value AS Gender " +
                "FROM Person JOIN Advisor ON Person.Id = Advisor.Id " +
                "JOIN Lookup AS G ON Person.Gender = G.Id " +
                "JOIN Lookup AS D ON Advisor.Designation = D.Id";

            SqlCommand cmd = new SqlCommand(display, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Advisors.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "AdvisorEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.Advisors.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "AdvisorDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.Advisors.Columns.Add(deleteButton);
            connection.Close();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void InsertAdvisor_Click_1(object sender, EventArgs e)
        {
            string firstName = "";
            string lastName = "";
            string contact = "";
            string email = "";
            DateTime dob = DateTime.Now;
            string gender = "";
            AddAdvisor addStudent = new AddAdvisor(firstName, lastName, "", contact, email, 0, dob, gender, "add");
            this.Hide();
            addStudent.Show();
        }

        private void Advisors_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == Advisors.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == Advisors.Columns["AdvisorDeleteButton"].Index)
            {
                int i = e.RowIndex;
                String email = Advisors.Rows[i].Cells[3].Value.ToString();
                string fullName = Advisors.Rows[i].Cells[0].Value.ToString();
                var names = fullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];


                string dialog = string.Format("Delete Advsior '{0}' and all its information?", fullName);
                DialogResult dialogResult = MessageBox.Show(dialog, "Delete Advsior", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();

                    string getid = string.Format("SELECT Id FROM Person WHERE FirstName = '{0}' AND LastName = '{1}'" +
                        "AND Email = '{2}'", firstName, lastName, email);
                    SqlCommand cmd = new SqlCommand(getid, connection);
                    int id = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = string.Format("DELETE FROM ProjectAdvisor WHERE AdvisorId = '{0}'", id);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = String.Format("DELETE FROM Advisor WHERE Id = '{0}'", id);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format("DELETE FROM Person WHERE Id = '{0}'", id);
                    cmd.ExecuteNonQuery();
                    Advisors.Rows.RemoveAt(i);
                    MessageBox.Show("Advsior Deleted successfully!");
                    connection.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Advisor not deleted!");
                }

            }
            if (e.ColumnIndex == Advisors.Columns["AdvisorEditButton"].Index)
            {
                int i = e.RowIndex;
                string fullName = Advisors.Rows[i].Cells[0].Value.ToString();
                var names = fullName.Split(' ');
                string firstName = names[0];
                string lastName = names[1];
                string Designation = Advisors.Rows[i].Cells[1].Value.ToString();
                string contact = Advisors.Rows[i].Cells[2].Value.ToString();
                string email = Advisors.Rows[i].Cells[3].Value.ToString();
                Decimal salary = Convert.ToDecimal(Advisors.Rows[i].Cells[4].Value);
                string DOB1 = Advisors.Rows[i].Cells[5].Value.ToString();
                DateTime dob = Convert.ToDateTime(DOB1);
                string gender = Advisors.Rows[i].Cells[6].Value.ToString();
                AddAdvisor form = new AddAdvisor(firstName, lastName, Designation, contact, email, salary, dob, gender, "edit");
                form.Show();
                this.Hide();
            }
        }
    }
}
