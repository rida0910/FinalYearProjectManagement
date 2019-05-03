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
    public partial class GroupProjects : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public GroupProjects()
        {
            InitializeComponent();
        }

        private void GroupProjects_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string display = "SELECT GroupId AS [Group Number], Title AS [Project Title], convert(varchar, AssignmentDate, 106) AS [Assigned On] " +
                "FROM GroupProject JOIN Project ON GroupProject.ProjectId = Project.id";
            SqlCommand cmd = new SqlCommand(display, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            ProjectGroups.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "GroupEditButton";
            EditButton.HeaderText = "Re-Assign";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.ProjectGroups.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "GroupDeleteButton";
            deleteButton.HeaderText = "Remove";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.ProjectGroups.Columns.Add(deleteButton);
            connection.Close();
        }

        
        private void InsertGroupProject_Click_1(object sender, EventArgs e)
        {
            AssignProjectToGroup form = new AssignProjectToGroup(null, null, "add");
            form.Show();
            this.Close();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void ProjectGroups_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == ProjectGroups.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == ProjectGroups.Columns["GroupDeleteButton"].Index)
            {
                string dialog = string.Format("Remove Project '{0}'?", ProjectGroups.Rows[e.RowIndex].Cells[1].Value);
                DialogResult dialogResult = MessageBox.Show(dialog, "Remove Project", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string query1 = string.Format("SELECT Id FROM Project WHERE Title = '{0}'", ProjectGroups.Rows[e.RowIndex].Cells[1].Value);
                    SqlCommand cmd = new SqlCommand(query1, connection);
                    int id = (Int32)cmd.ExecuteScalar();
                    string query = string.Format("DELETE FROM GroupProject WHERE GroupId = '{0}' AND ProjectId = '{1}'", ProjectGroups.Rows[e.RowIndex].Cells[0].Value, id);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Project Removed!");
                    ProjectGroups.Rows.RemoveAt(e.RowIndex);
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Project not Removed!");
                }
            }
            else if (e.ColumnIndex == ProjectGroups.Columns["GroupEditButton"].Index)
            {
                string Groupid = ProjectGroups.Rows[e.RowIndex].Cells[0].Value.ToString();
                string projectid = ProjectGroups.Rows[e.RowIndex].Cells[1].Value.ToString();
                AssignProjectToGroup form = new AssignProjectToGroup(Groupid, projectid, "edit");
                form.Show();
                this.Close();
            }
        }
    }
}
