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
    public partial class AssignAdvisorToProject : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string value;
        string Ptitle, Aname, Arole;
        public AssignAdvisorToProject(string Title, string Name, string Role, string val)
        {
            InitializeComponent();
            if (val == "edit")
            {
                value = val;
                Ptitle = Title;
                Aname = Name;
                Arole = Role;
            }
        }

        private void AssignAdvisorToProject_Load(object sender, EventArgs e)
        {
            if (value != "edit")
            {
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string getGroups = "SELECT Title FROM Project WHERE Id IN (SELECT ProjectId FROM ProjectAdvisor GROUP BY ProjectId " +
                "HAVING COUNT(*) < 3) OR Id NOT IN(SELECT ProjectId FROM ProjectAdvisor) ";
                SqlCommand cmd = new SqlCommand(getGroups, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ProjectsComboBox.Items.Add(reader[0]);
                }
                connection.Close();
            }
            else if (value == "edit")
            {
                ProjectsComboBox.Items.Add(Ptitle);
                ProjectsComboBox.SelectedItem = Ptitle;
                ProjectsComboBox_SelectedIndexChanged(sender, e);
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ManageAssignAdvisorToProject form = new ManageAssignAdvisorToProject();
            form.Show();
            this.Close();
        }

        private void AssignAdvisorButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ProjectsComboBox.Text == "" || AdvisorComboBox.Text == "" || RoleComboBox.Text == "")
                {
                    throw new ArgumentException();
                }
                string projectTitle = ProjectsComboBox.Text;
                string AdvisorName = AdvisorComboBox.Text;
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string query1 = string.Format("SELECT Id FROM Project WHERE Title = '{0}'", projectTitle);
                SqlCommand cmd = new SqlCommand(query1, conn);
                int pid = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = string.Format("SELECT Advisor.Id FROM Person JOIN Advisor ON Person.Id = Advisor.Id WHERE CONCAT(FirstName,' ', LastName) = '{0}'", AdvisorName);
                int Aid = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = string.Format("SELECT Id FROM LookUp WHERE Value = '{0}' AND CATEGORY = 'ADVISOR_ROLE'", RoleComboBox.Text);
                int Rid = (Int32)cmd.ExecuteScalar();
                if (value != "edit")
                {
                    string query = string.Format("INSERT INTO ProjectAdvisor(AdvisorId, ProjectId, AdvisorRole, AssignmentDate) Values('{0}', '{1}', '{2}', '{3}')", Aid, pid, Rid, DateTime.Now);
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(string.Format("Advisor assigned to project '{0}'", projectTitle));
                }
                else if (value == "edit")
                {
                    cmd.CommandText = string.Format("UPDATE ProjectAdvisor SET AdvisorRole = '{0}' WHERE ProjectId = '{1}' AND AdvisorId = '{2}'", Rid, pid, Aid);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Advisor Role Updated!");
                }
                ManageAssignAdvisorToProject form = new ManageAssignAdvisorToProject();
                form.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select project, advisor and advisor role from drop-down list");
            }
        }

        private void ProjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AdvisorComboBox.Items.Clear();
            if (value == "edit")
            {
                AdvisorComboBox.Items.Add(Aname);
                AdvisorComboBox.SelectedItem = Aname;
            }
            else
            {
                string getProjects = string.Format("SELECT CONCAT(FirstName,' ', LastName) AS Name FROM Advisor JOIN Person ON Advisor.Id = Person.Id " +
                    "WHERE Advisor.Id NOT IN(SELECT AdvisorId FROM ProjectAdvisor JOIN Project ON ProjectAdvisor.ProjectId = Project.id WHERE Title = '{0}')", ProjectsComboBox.Text);
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd1 = new SqlCommand(getProjects, con);
                SqlDataReader dataReader = cmd1.ExecuteReader();
                while (dataReader.Read())
                {
                    AdvisorComboBox.Items.Add(dataReader[0]);
                }
                con.Close();
            }
        }

        private void AdvisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RoleComboBox.Items.Clear();
            string getRole = "SELECT Value FROM LookUp WHERE CATEGORY = 'ADVISOR_ROLE'";
            SqlConnection con1 = new SqlConnection(connString);
            con1.Open();
            SqlCommand cmd2 = new SqlCommand(getRole, con1);
            SqlDataReader roles = cmd2.ExecuteReader();
            while (roles.Read())
            {
                RoleComboBox.Items.Add(roles[0]);
            }
            string query = string.Format("SELECT DISTINCT Value AS [Advisor Role] FROM ProjectAdvisor JOIN Project " +
                "ON ProjectAdvisor.ProjectId = Project.Id JOIN Lookup ON ProjectAdvisor.AdvisorRole = LookUP.Id WHERE Title = '{0}'", ProjectsComboBox.Text);
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                if (RoleComboBox.Items.Contains(reader[0]))
                {
                    RoleComboBox.Items.Remove(reader[0]);
                }
            }
            con.Close();
            con1.Close();
        }
    }
}
