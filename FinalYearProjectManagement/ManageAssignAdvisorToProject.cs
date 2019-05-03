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
    public partial class ManageAssignAdvisorToProject : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public ManageAssignAdvisorToProject()
        {
            InitializeComponent();
        }

        private void ManageAssignAdvisorToProject_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string dsiplay = "SELECT Title AS [Project Title], CONCAT(FirstName,' ', LastName) AS [Advisor Name] , Value AS [Advisor Role]" +
            "FROM Person JOIN Advisor ON Person.Id = Advisor.Id JOIN ProjectAdvisor ON ProjectAdvisor.AdvisorId = Advisor.Id JOIN Project ON Project.Id = ProjectAdvisor.ProjectId" +
            " JOIN LookUp ON ProjectAdvisor.AdvisorRole = LookUp.Id";
            SqlCommand cmd = new SqlCommand(dsiplay, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            ProjectAdvisorsGrid.DataSource = ds.Tables[0].DefaultView;
            
            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "AdvisorEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.ProjectAdvisorsGrid.Columns.Add(EditButton);

            var UnAssignButton = new DataGridViewButtonColumn();
            UnAssignButton.Name = "AdvisorUnAssignButton";
            UnAssignButton.HeaderText = "Remove";
            UnAssignButton.Text = "Remove";
            UnAssignButton.UseColumnTextForButtonValue = true;
            this.ProjectAdvisorsGrid.Columns.Add(UnAssignButton);
            
            string display = string.Format("SELECT Title FROM Project");
            cmd.CommandText = display;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ProjectsComboBox.Items.Add(reader[0]);
            }
            conn.Close();
        }

        private void ProjectsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ProjectAdvisorsGrid.Columns.Remove("AdvisorUnAssignButton");
            ProjectAdvisorsGrid.Columns.Remove("AdvisorEditButton");
            string query = string.Format("SELECT Title AS [Project Title], CONCAT(FirstName,' ', LastName) AS Name , Value AS [Advisor Role] " +
            "FROM Person JOIN Advisor ON Person.Id = Advisor.Id JOIN ProjectAdvisor ON ProjectAdvisor.AdvisorId = Advisor.Id JOIN Project ON Project.Id = ProjectAdvisor.ProjectId" +
            " JOIN LookUp ON ProjectAdvisor.AdvisorRole = LookUp.Id WHERE Project.Title = '{0}'", ProjectsComboBox.Text);
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            ProjectAdvisorsGrid.DataSource = ds.Tables[0].DefaultView;
            connection.Close();

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "AdvisorEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.ProjectAdvisorsGrid.Columns.Add(EditButton);

            var UnAssignButton = new DataGridViewButtonColumn();
            UnAssignButton.Name = "AdvisorUnAssignButton";
            UnAssignButton.HeaderText = "Remove";
            UnAssignButton.Text = "Remove";
            UnAssignButton.UseColumnTextForButtonValue = true;
            this.ProjectAdvisorsGrid.Columns.Add(UnAssignButton);
        }

        private void InsertProjectAdvsior_Click_1(object sender, EventArgs e)
        {
            AssignAdvisorToProject form = new AssignAdvisorToProject(null, null, null, "add");
            form.Show();
            this.Close();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void ProjectAdvisorsGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ProjectAdvisorsGrid.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == ProjectAdvisorsGrid.Columns["AdvisorUnAssignButton"].Index)
            {
                int i = e.RowIndex;
                string Ptitle = ProjectAdvisorsGrid.Rows[i].Cells[0].Value.ToString();
                string dialog = string.Format("Remove Advisor '{0}' from project {1}?", ProjectAdvisorsGrid.Rows[i].Cells[1].Value.ToString(), Ptitle);
                DialogResult dialogResult = MessageBox.Show(dialog, "Remove Advisor", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string query = string.Format("SELECT Advisor.Id FROM Advisor JOIN Person ON Advisor.Id = Person.Id " +
                        "WHERE CONCAT(FirstName,' ', LastName) = '{0}'", ProjectAdvisorsGrid.Rows[i].Cells[1].Value.ToString());
                    SqlConnection con = new SqlConnection(connString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    int Aid = (Int32)cmd.ExecuteScalar();


                    cmd.CommandText = string.Format("SELECT Id FROM Project WHERE Title = '{0}'", Ptitle);
                    int pid = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = string.Format("DELETE FROM ProjectAdvisor WHERE AdvisorId = '{0}'AND ProjectId = '{1}'", Aid, pid);
                    cmd.ExecuteNonQuery();
                    ProjectAdvisorsGrid.Rows.RemoveAt(i);
                    MessageBox.Show(String.Format("Advisor removed from the project {0}!", Ptitle));

                    con.Close();
                }
                else
                {
                    MessageBox.Show(String.Format("Advisor not removed from the project {0}!", Ptitle));
                }

            }
            else if (e.ColumnIndex == ProjectAdvisorsGrid.Columns["AdvisorEditButton"].Index)
            {
                int i = e.RowIndex;
                string Ptitle = ProjectAdvisorsGrid.Rows[i].Cells[0].Value.ToString();
                string aName = ProjectAdvisorsGrid.Rows[i].Cells[1].Value.ToString();
                string aRole = ProjectAdvisorsGrid.Rows[i].Cells[2].Value.ToString();
                AssignAdvisorToProject form = new AssignAdvisorToProject(Ptitle, aName, aRole, "edit");
                form.Show();
                this.Close();
            }
        }
    }
}
