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
    public partial class GroupEvaluation : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        public GroupEvaluation()
        {
            InitializeComponent();
        }

        private void GroupEvaluation_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            string dsiplay = "SELECT GroupId, Name AS [Evaluation], TotalMarks AS [Total Marks], ObtainedMarks AS [Obtained Marks], convert(varchar, EvaluationDate, 106) AS [Evaluation Date] " +
                "FROM GroupEvaluation JOIN Evaluation ON GroupEvaluation.EvaluationId = Evaluation.Id";
            SqlCommand cmd = new SqlCommand(dsiplay, conn);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            GroupEvaluationsGrid.DataSource = ds.Tables[0].DefaultView;

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "EvaluationEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.GroupEvaluationsGrid.Columns.Add(EditButton);

            var UnAssignButton = new DataGridViewButtonColumn();
            UnAssignButton.Name = "EvaluationRemoveButton";
            UnAssignButton.HeaderText = "Remove";
            UnAssignButton.Text = "Remove";
            UnAssignButton.UseColumnTextForButtonValue = true;
            this.GroupEvaluationsGrid.Columns.Add(UnAssignButton);

            string display = string.Format("SELECT DISTINCT GroupId FROM GroupStudent WHERE Status = 3 AND GroupId IN" +
                    "(SELECT Groupid FROM GroupProject)");
            cmd.CommandText = display;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                GroupsComboBox.Items.Add(reader[0]);
            }
            conn.Close();

            SqlConnection con = new SqlConnection(connString);
            con.Open();
            string display1 = "SELECT Name FROM Evaluation";
            SqlCommand cmd1 = new SqlCommand(display1, con);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                EvaluationComboBox.Items.Add(reader1[0]);
            }
            con.Close();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            FYPMainScreen form = new FYPMainScreen();
            form.Show();
            this.Close();
        }

        private void AddGroupEvaluation_Click_1(object sender, EventArgs e)
        {
            EvaluateGroupsForm form = new EvaluateGroupsForm(0, null, null, "add");
            form.Show();
            this.Close();
        }

        private void GroupEvaluationsGrid_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == GroupEvaluationsGrid.NewRowIndex || e.RowIndex < 0)
                return;
            if (e.ColumnIndex == GroupEvaluationsGrid.Columns["EvaluationRemoveButton"].Index)
            {
                int i = e.RowIndex;
                int groupId = Convert.ToInt32(GroupEvaluationsGrid.Rows[i].Cells[0].Value);
                string EvalName = GroupEvaluationsGrid.Rows[i].Cells[1].Value.ToString();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string getid = string.Format("SELECT Id FROM Evaluation WHERE Name = '{0}'", EvalName);
                SqlCommand cmd = new SqlCommand(getid, conn);
                int id = (Int32)cmd.ExecuteScalar();
                string remove = string.Format("DELETE FROM GroupEvaluation WHERE GroupId = '{0}' AND EvaluationId = '{1}'", groupId, id);
                cmd.CommandText = remove;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evaluation Removed!");
                GroupEvaluationsGrid.Rows.RemoveAt(i);
                conn.Close();
            }
            else if (e.ColumnIndex == GroupEvaluationsGrid.Columns["EvaluationEditButton"].Index)
            {
                int i = e.RowIndex;
                int groupId = Convert.ToInt32(GroupEvaluationsGrid.Rows[i].Cells[0].Value);
                string EvalName = GroupEvaluationsGrid.Rows[i].Cells[1].Value.ToString();
                string obtMarks = GroupEvaluationsGrid.Rows[i].Cells[3].Value.ToString();
                EvaluateGroupsForm form = new EvaluateGroupsForm(groupId, EvalName, obtMarks, "edit");
                form.Show();
                this.Close();

            }
        }

        private void EvaluationComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GroupEvaluationsGrid.Columns.Remove("EvaluationEditButton");
            GroupEvaluationsGrid.Columns.Remove("EvaluationRemoveButton");
            string query = string.Format("SELECT GroupId, Name AS [Evaluation], TotalMarks AS [Total Marks], ObtainedMarks AS [Obtained Marks], EvaluationDate AS [Evaluation Date] " +
                "FROM GroupEvaluation JOIN Evaluation ON GroupEvaluation.EvaluationId = Evaluation.Id WHERE Name = '{0}'", EvaluationComboBox.Text);
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            GroupEvaluationsGrid.DataSource = ds.Tables[0].DefaultView;
            connection.Close();

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "EvaluationEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.GroupEvaluationsGrid.Columns.Add(EditButton);

            var UnAssignButton = new DataGridViewButtonColumn();
            UnAssignButton.Name = "EvaluationRemoveButton";
            UnAssignButton.HeaderText = "Remove";
            UnAssignButton.Text = "Remove";
            UnAssignButton.UseColumnTextForButtonValue = true;
            this.GroupEvaluationsGrid.Columns.Add(UnAssignButton);
        }

        private void GroupsComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            GroupEvaluationsGrid.Columns.Remove("EvaluationEditButton");
            GroupEvaluationsGrid.Columns.Remove("EvaluationRemoveButton");
            string query = string.Format("SELECT GroupId, Name AS [Evaluation], TotalMarks AS [Total Marks], ObtainedMarks AS [Obtained Marks], EvaluationDate AS [Evaluation Date] " +
                "FROM GroupEvaluation JOIN Evaluation ON GroupEvaluation.EvaluationId = Evaluation.Id WHERE GroupId = '{0}'", GroupsComboBox.Text);
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds);
            GroupEvaluationsGrid.DataSource = ds.Tables[0].DefaultView;
            connection.Close();

            var EditButton = new DataGridViewButtonColumn();
            EditButton.Name = "EvaluationEditButton";
            EditButton.HeaderText = "Edit";
            EditButton.Text = "Edit";
            EditButton.UseColumnTextForButtonValue = true;
            this.GroupEvaluationsGrid.Columns.Add(EditButton);

            var UnAssignButton = new DataGridViewButtonColumn();
            UnAssignButton.Name = "EvaluationRemoveButton";
            UnAssignButton.HeaderText = "Remove";
            UnAssignButton.Text = "Remove";
            UnAssignButton.UseColumnTextForButtonValue = true;
            this.GroupEvaluationsGrid.Columns.Add(UnAssignButton);
        }
    }
}
