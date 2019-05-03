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
    public partial class AddProject : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string value1;
        int id;
        public AddProject(string Title, string Description, string value)
        {
            InitializeComponent();
            value1 = value;
            if (value == "edit")
            {
                TitleTextBox.Text = Title;
                DescriptionTextBox.Text = Description;
                this.Text = "Update Project";
                AddProjectHeadingLabel.Text = "Update Project";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string getid = string.Format("SELECT Id FROM Project WHERE Title = '{0}' AND Description = '{1}'", TitleTextBox.Text, DescriptionTextBox.Text);
                SqlCommand cmd = new SqlCommand(getid, connection);
                id = (Int32)cmd.ExecuteScalar();
            }
        }

        private void SaveProject_Click(object sender, EventArgs e)
        {
            try
            {
                if (TitleTextBox.Text == "" || DescriptionTextBox.Text == "")
                {
                    throw new ArgumentException();
                }
                if (value1 == "add")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string addProject = string.Format("INSERT INTO Project(Title, Description) values('{0}', '{1}')", TitleTextBox.Text, DescriptionTextBox.Text);
                    SqlCommand cmd = new SqlCommand(addProject, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                else if (value1 == "edit")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string update = string.Format("UPDATE Project SET Title = '{0}', Description = '{1}' " +
                        "WHERE Id = '{2}'", TitleTextBox.Text, DescriptionTextBox.Text, id);
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                ManageProjects form = new ManageProjects();
                this.Close();
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter title and description");
            }
        }

        private void BackToMainScreen_Click(object sender, EventArgs e)
        {
            ManageProjects form = new ManageProjects();
            this.Close();
            form.Show();
        }
    }
}
