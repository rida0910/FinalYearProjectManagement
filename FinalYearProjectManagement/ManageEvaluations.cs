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
    public partial class ManageEvaluationForm : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public ManageEvaluationForm()
        {
            InitializeComponent();
        }
        
        private void ManageEvaluation123_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string display = "SELECT Name, TotalMarks, TotalWeightage FROM Evaluation";
            SqlCommand cmd = new SqlCommand(display, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            Evaluations.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "EvaluationEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.Evaluations.Columns.Add(EditButton);

            var deleteButton = new DataGridViewButtonColumn();
            deleteButton.Name = "EvaluationDeleteButton";
            deleteButton.HeaderText = "Delete";
            deleteButton.Text = "Delete";
            deleteButton.UseColumnTextForButtonValue = true;
            this.Evaluations.Columns.Add(deleteButton);
            connection.Close();
        }

        private void InsertEvaluation_Click_1(object sender, EventArgs e)
        {
            AddEvaluation form = new AddEvaluation("", 0, 0, "add");
            this.Hide();
            form.Show();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void Evaluations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == Evaluations.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == Evaluations.Columns["EvaluationDeleteButton"].Index)
            {
                int i = e.RowIndex;
                string Name = Evaluations.Rows[i].Cells[0].Value.ToString();
                string marks1 = Evaluations.Rows[i].Cells[1].Value.ToString();
                int marks = int.Parse(marks1);
                string weightage1 = Evaluations.Rows[i].Cells[2].Value.ToString();
                int weightage = int.Parse(weightage1);

                string dialog = string.Format("Delete Evaluation '{0}' and all its information?", Name);
                DialogResult dialogResult = MessageBox.Show(dialog, "Delete Evaluation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(connString);
                    connection.Open();
                    string getid = string.Format("SELECT Id FROM Evaluation WHERE Name = '{0}'AND TotalMarks = '{1}' AND TotalWeightage = '{2}'", Name, marks, weightage);
                    SqlCommand cmd = new SqlCommand(getid, connection);
                    int id = (Int32)cmd.ExecuteScalar();

                    cmd.CommandText = string.Format("DELETE FROM GroupEvaluation WHERE EvaluationId = '{0}'", id);
                    cmd.ExecuteNonQuery();

                    string display = String.Format("DELETE FROM Evaluation WHERE Name = '{0}'AND TotalMarks = '{1}' AND TotalWeightage = '{2}'", Name, marks, weightage);
                    cmd.CommandText = display;
                    cmd.ExecuteNonQuery();
                    Evaluations.Rows.RemoveAt(i);
                    MessageBox.Show("Evaluation deleted successfully!");
                    connection.Close();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("Evaluation not deleted!");
                }
            }
            if (e.ColumnIndex == Evaluations.Columns["EvaluationEditButton"].Index)
            {
                int i = e.RowIndex;
                string Name = Evaluations.Rows[i].Cells[0].Value.ToString();
                string marks1 = Evaluations.Rows[i].Cells[1].Value.ToString();
                int marks = int.Parse(marks1);
                string weightage1 = Evaluations.Rows[i].Cells[2].Value.ToString();
                int weightage = int.Parse(weightage1);
                AddEvaluation form = new AddEvaluation(Name, marks, weightage, "edit");
                form.Show();
                this.Hide();
            }
        }
    }
}
