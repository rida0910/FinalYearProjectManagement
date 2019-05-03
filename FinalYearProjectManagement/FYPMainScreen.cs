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
    public partial class FYPMainScreen : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public FYPMainScreen()
        {
            InitializeComponent();
        }

        private void FYPMainScreen_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string cmdtext = "SELECT COUNT(*) FROM Student";
            SqlCommand cmd = new SqlCommand(cmdtext, conn);
            string Scount = cmd.ExecuteScalar().ToString();
            studentsLabel.Text = Scount;

            cmd.CommandText = "SELECT COUNT(*) FROM Advisor";
            string ACount = cmd.ExecuteScalar().ToString();
            advisorsLabel.Text = ACount;

            cmd.CommandText = "SELECT COUNT(*) FROM Project";
            string PCount = cmd.ExecuteScalar().ToString();
            ProjectsLabel.Text = PCount;

            cmd.CommandText = "SELECT COUNT(*) FROM Evaluation";
            string ECount = cmd.ExecuteScalar().ToString();
            EvaluationsLabel.Text = ECount;
        }

        private void GoToStudentsForm_Click(object sender, EventArgs e)
        {
            ManageStudentsForm form = new ManageStudentsForm();
            form.Show();
            this.Hide();
        }
        private void GoToAdvisorForm_Click_1(object sender, EventArgs e)
        {
            ManageAdvisors form = new ManageAdvisors();
            form.Show();
            this.Hide();
        }

        private void GoToProjectForm_Click_1(object sender, EventArgs e)
        {
            ManageProjects form = new ManageProjects();
            form.Show();
            this.Hide();
        }

        private void GoToEvaluationForm_Click_1(object sender, EventArgs e)
        {
            ManageEvaluationForm form = new ManageEvaluationForm();
            form.Show();
            this.Hide();
        }

        /*private void GoToGroupsForm_Click(object sender, EventArgs e)
        {
            ManageGroups form = new ManageGroups();
            form.Show();
            this.Hide();
        }*/

        /*private void AssignProjectButton_Click(object sender, EventArgs e)
        {
            GroupProjects form = new GroupProjects();
            form.Show();
            this.Hide();
        }*/

        private void ProjectAdvsiors_Click(object sender, EventArgs e)
        {
            ManageAssignAdvisorToProject form = new ManageAssignAdvisorToProject();
            form.Show();
            this.Hide();
        }

        private void GoToGroupsForm_Click_1(object sender, EventArgs e)
        {
            ManageGroups form = new ManageGroups();
            form.Show();
            this.Hide();
        }

        private void AssignProject_Click(object sender, EventArgs e)
        {
            GroupProjects form = new GroupProjects();
            form.Show();
            this.Hide();
        }

        private void GroupEvaluations_Click(object sender, EventArgs e)
        {
            GroupEvaluation form = new GroupEvaluation();
            form.Show();
            this.Hide();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            Reports form = new Reports();
            form.Show();
            this.Hide();
        }
    }
}
