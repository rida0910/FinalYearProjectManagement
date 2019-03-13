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
    public partial class ManageEvaluations : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public ManageEvaluations()
        {
            InitializeComponent();
        }

        private void InsertEvaluation_Click(object sender, EventArgs e)
        {
            AddEvaluation form = new AddEvaluation("", 0, 0, "add");
            this.Hide();
            form.Show();

        }

        private void ManageEvaluations_Load(object sender, EventArgs e)
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
                MessageBox.Show(marks.ToString());
                string weightage1 = Evaluations.Rows[i].Cells[2].Value.ToString();
                int weightage = int.Parse(weightage1);
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string display = String.Format("DELETE FROM Evaluation WHERE Name = '{0}'AND TotalMarks = '{1}' AND TotalWeightage = '{2}'", Name, marks, weightage);
                SqlCommand cmd = new SqlCommand(display, connection);
                cmd.ExecuteNonQuery();
                Evaluations.Rows.RemoveAt(i);
                connection.Close();
            }
            if (e.ColumnIndex == Evaluations.Columns["EvaluationEditButton"].Index)
            {
                int i = e.RowIndex;
                string Name = Evaluations.Rows[i].Cells[0].Value.ToString();
                string marks1 = Evaluations.Rows[i].Cells[1].Value.ToString();
                int marks = int.Parse(marks1);
                string weightage1 = Evaluations.Rows[i].Cells[2].Value.ToString();
                int weightage = int.Parse(weightage1);
                AddEvaluation form = new AddEvaluation(Name, marks, weightage,"edit");
                form.Show();
                this.Hide();
            }
        }
    }
}
