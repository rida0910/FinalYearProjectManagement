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
    public partial class AssignProjectToGroup : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string value;
        string GroupId;
        string projectid;
        public AssignProjectToGroup(string gid, string pid, string val)
        {
            InitializeComponent();
            if (val == "edit")
            {
                value = val;
                GroupId = gid;
                projectid = pid;
                GroupsComboBox.Text = GroupId;
                GroupsComboBox.SelectedItem = GroupId;
                ProjectsComboBox.Text = projectid;
                ProjectsComboBox.SelectedItem = projectid;
                
            }

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GroupProjects form = new GroupProjects();
            form.Show();
            this.Close();
        }

        private void AssignProjectButton_Click(object sender, EventArgs e)
        {
            try
            {
                string projectTitle = ProjectsComboBox.Text.ToString();
                string groupId = GroupsComboBox.Text.ToString();

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string query1 = string.Format("SELECT Id FROM Project WHERE Title = '{0}'", projectTitle);
                SqlCommand cmd = new SqlCommand(query1, conn);
                int id = (Int32)cmd.ExecuteScalar();
                if (value != "edit")
                {
                    string query = string.Format("INSERT INTO GroupProject(ProjectId, GroupId, AssignmentDate) Values('{0}', '{1}', '{2}')", id, groupId, DateTime.Now);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
                else if (value == "edit")
                {
                    string query = string.Format("UPDATE GroupProject SET ProjectId = '{0}', AssignmentDate = '{2}' WHERE GroupId = '{1}'", id, GroupId, DateTime.Now);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please select a group and project from the list");
            }
            GroupProjects form = new GroupProjects();
            form.Show();
            this.Close();
        }

        private void AssignProjectToGroup_Load(object sender, EventArgs e)
        {
            if (value != "edit")
            {
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string getGroups = "SELECT Id FROM [Group] WHERE Id NOT IN (SELECT GroupId FROM GroupProject)" +
                    "AND Id IN (SELECT GroupId FROM GroupStudent WHERE Status = 3)";
                SqlCommand cmd = new SqlCommand(getGroups, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    GroupsComboBox.Items.Add(reader[0]);
                }
                connection.Close();
            }
            else if (value == "edit")
            {
                GroupsComboBox.Items.Add(GroupId);
            }
            string getProjects = "SELECT Title FROM Project";
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd1 = new SqlCommand(getProjects, con);
            SqlDataReader dataReader = cmd1.ExecuteReader();
            while (dataReader.Read())
            {
                ProjectsComboBox.Items.Add(dataReader[0]);
            }
            con.Close();
        }
    }
}
