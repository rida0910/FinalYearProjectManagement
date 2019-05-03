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
    public partial class AddEvaluation : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string value1;
        int id;
        public AddEvaluation(string Name, int Marks, int Weightage, string value)
        {
            InitializeComponent();
            value1 = value;
            if (value == "edit")
            {
                NameTextBox.Text = Name;
                MarksTextBox.Text = Marks.ToString();
                WeightageTextBox.Text = Weightage.ToString();
                Text = "Update Evaluation";
                AddEvaluationHeadingLabel.Text = "Update Evaluation";
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string getid = string.Format("SELECT Id FROM Evaluation WHERE Name = '{0}' AND TotalMarks = '{1}' AND TotalWeightage = '{2}'", NameTextBox.Text, MarksTextBox.Text, WeightageTextBox.Text);
                SqlCommand cmd = new SqlCommand(getid, connection);
                id = (Int32)cmd.ExecuteScalar();
            }
        }

        private void InsertEvaluation_Click(object sender, EventArgs e)
        {
            try
            {
                Evaluation evaluation = new Evaluation();
                evaluation.Name = NameTextBox.Text;
                try
                {
                    evaluation.Marks = MarksTextBox.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please enter the marks of evaluation in digits");
                    throw new ArgumentException();
                }
                try
                {
                    evaluation.TotalWeightage = WeightageTextBox.Text;
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Please enter the correct weightage");
                    throw new ArgumentException();
                }
                if (value1 == "add")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string addEvaluation = string.Format("INSERT INTO Evaluation(Name, TotalMarks, TotalWeightage) values('{0}', '{1}', '{2}')", evaluation.Name, int.Parse(evaluation.Marks), int.Parse(evaluation.TotalWeightage));
                    SqlCommand cmd = new SqlCommand(addEvaluation, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Evaluation Added!");
                    connection.Close();
                }
                else if (value1 == "edit")
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string update = string.Format("UPDATE Evaluation SET Name = '{0}', TotalMarks = '{1}', TotalWeightage = '{2}'" +
                        "WHERE Id = '{3}'", evaluation.Name, int.Parse(evaluation.Marks), int.Parse(evaluation.TotalWeightage), id);
                    SqlCommand cmd = new SqlCommand(update, connection);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Evaluation Updated!");
                    connection.Close();
                }
                ManageEvaluationForm form = new ManageEvaluationForm();
                this.Close();
                form.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Evaluation not saved!");
            }
        }

        private void BackScreen_Click(object sender, EventArgs e)
        {
            ManageEvaluationForm form = new ManageEvaluationForm();
            this.Close();
            form.Show();
        }
    }
    
}
