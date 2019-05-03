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
    public partial class ManageGroups : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public ManageGroups()
        {
            InitializeComponent();
        }

        private void ManageGroups_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string display = "SELECT GroupId AS [Group Number], COUNT(*) AS [Active Members] " +
                "FROM GroupStudent  WHERE Status = 3 GROUP BY GroupId";
            SqlCommand cmd = new SqlCommand(display, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Groups.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "GroupEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.Groups.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "GroupDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.Groups.Columns.Add(deleteButton);
            connection.Close();
        }

        private void InsertGroup_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string query = string.Format("INSERT INTO [Group](Created_On) Values('{0}')", DateTime.Now.Date);
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            CreateGroup form = new CreateGroup(0, 0, null, null);
            form.Show();
            this.Close();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void Groups_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == Groups.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == Groups.Columns["GroupEditButton"].Index)
            {
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string query = string.Format("SELECT StudentId FROM GroupStudent WHERE GroupId = '{0}' AND Status = 3", Groups.Rows[e.RowIndex].Cells[0].Value);
                SqlCommand cmd = new SqlCommand(query, con);
                List<int> list = new List<int>();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(Convert.ToInt32(reader["StudentId"].ToString()));
                }
                con.Close();
                int count = Convert.ToInt32(Groups.Rows[e.RowIndex].Cells[1].Value);
                CreateGroup form = new CreateGroup(Convert.ToInt32(Groups.Rows[e.RowIndex].Cells[0].Value), count, list, "edit");
                form.Show();
                this.Close();
            }
            else if (e.ColumnIndex == Groups.Columns["GroupDeleteButton"].Index)
            {
                int Gid = Convert.ToInt32(Groups.Rows[e.RowIndex].Cells[0].Value.ToString());
                string dialog = string.Format("Delete Group and all its information? '{0}'?", Gid);
                DialogResult dialogResult = MessageBox.Show(dialog, "Delete Group", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    string query0 = string.Format("DELETE FROM GroupProject WHERE GroupId = '{0}'", Gid);
                    string query01 = string.Format("DELETE FROM GroupEvaluation WHERE GroupId = '{0}'", Gid);
                    string query1 = String.Format("DELETE FROM GroupStudent WHERE GroupId = '{0}'", Gid);
                    string query2 = string.Format("DELETE FROM [Group] WHERE Id = '{0}'", Gid);
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(query0, connection);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query01;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query1;
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = query2;
                    cmd.ExecuteNonQuery();

                    Groups.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show("Group deleted successfully!");
                    connection.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Group not deleted!");
                }
            }
        }
    }
}
