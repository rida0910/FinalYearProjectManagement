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
    public partial class ManageProjects : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public ManageProjects()
        {
            InitializeComponent();
        }

        private void ManageProject123_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string display = "SELECT Title, Description FROM Project";
            SqlCommand cmd = new SqlCommand(display, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Projects.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "ProjectEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            Projects.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "ProjectDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            Projects.Columns.Add(deleteButton);
            connection.Close();
        }

        private void InsertProject_Click_1(object sender, EventArgs e)
        {
            AddProject form = new AddProject("", "", "add");
            form.Show();
            this.Hide();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void Projects_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == Projects.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == Projects.Columns["ProjectDeleteButton"].Index)
            {
                int i = e.RowIndex;
                String Title = Projects.Rows[i].Cells[0].Value.ToString();
                string Description = Projects.Rows[i].Cells[1].Value.ToString();

                string dialog = string.Format("Delete Project '{0}' and all its information?", Title);
                DialogResult dialogResult = MessageBox.Show(dialog, "Delete Project", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string getid = string.Format("SELECT Id FROM Project WHERE Title = '{0}' AND Description = '{1}'", Title, Description);
                    SqlCommand cmd = new SqlCommand(getid, connection);
                    int id = (Int32)cmd.ExecuteScalar();

                    string del = string.Format("DELETE FROM ProjectAdvisor WHERE ProjectId = '{0}'", id);
                    cmd.CommandText = del;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = string.Format("DELETE FROM GroupProject WHERE ProjectId = '{0}'", id);
                    cmd.ExecuteNonQuery();

                    string del0 = String.Format("DELETE FROM Project WHERE Title = '{0}' AND Description = '{1}'", Title, Description);
                    cmd.CommandText = del0;
                    cmd.ExecuteNonQuery();
                    Projects.Rows.RemoveAt(i);
                    MessageBox.Show("Project deleted successfully!");
                    connection.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Project not deleted!");
                }
            }
            if (e.ColumnIndex == Projects.Columns["ProjectEditButton"].Index)
            {
                int i = e.RowIndex;
                string Title = Projects.Rows[i].Cells[0].Value.ToString();
                string Description = Projects.Rows[i].Cells[1].Value.ToString();
                AddProject form = new AddProject(Title, Description, "edit");
                form.Show();
                this.Hide();
            }
        }
    }
}
