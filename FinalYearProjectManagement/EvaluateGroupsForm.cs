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
    public partial class EvaluateGroupsForm : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        int evalId;
        int Gid;
        string Ename;
        string value;
        int marks;
        public EvaluateGroupsForm(int groupId, string evalName, string obtmarks, string val)
        {
            InitializeComponent();
            value = val;
            if (val == "edit")
            {
                Gid = groupId;
                Ename = evalName;
                marks = Convert.ToInt32(obtmarks);
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            GroupEvaluation form = new GroupEvaluation();
            form.Show();
            this.Close();
        }

        private void EvaluateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int groupId = Convert.ToInt32(GroupsComboBox.Text);
                string EvaluationName = EvaluationComboBox.Text;
                int ObtMarks = Convert.ToInt32(ObtainedMarksNUmericUpDown.Value.ToString());

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                if (value != "edit")
                {
                    string eval = string.Format("INSERT INTO GroupEvaluation(GroupId, EvaluationId, ObtainedMarks, EvaluationDate) Values('{0}', '{1}', '{2}', '{3}')", groupId, evalId, ObtMarks, DateTime.Now);
                    SqlCommand cmd = new SqlCommand(eval, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Group Evaluated!");
                }
                else if (value == "edit")
                {
                    string getid = string.Format("SELECT Id FROM EValuation WHERE Name = '{0}'", Ename);
                    string eval = string.Format("UPDATE GroupEvaluation SET ObtainedMarks = '{0}', EvaluationDate = '{3}' WHERE GroupId = '{1}' AND EvaluationId = '{2}'", Convert.ToInt32(ObtainedMarksNUmericUpDown.Value.ToString()), Gid, evalId, DateTime.Now);

                    SqlCommand cmd = new SqlCommand(getid, conn);
                    int id = (Int32)cmd.ExecuteScalar();
                    cmd.CommandText = string.Format("UPDATE GroupEvaluation SET ObtainedMarks = '{0}', EvaluationDate = '{3}' WHERE GroupId = '{1}' AND EvaluationId = '{2}'", Convert.ToInt32(ObtainedMarksNUmericUpDown.Value.ToString()), Gid, id, DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Obtained marks updated!");
                }
                GroupEvaluation form = new GroupEvaluation();
                form.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Please select group, evaluation from the drop-down list and enter the obtained marks");
            }
        }

        private void EvaluationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string evalName = EvaluationComboBox.Text;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string getid = string.Format("SELECT Id FROM Evaluation WHERE Name = '{0}'", evalName);
            SqlCommand cmd = new SqlCommand(getid, conn);
            evalId = (Int32)cmd.ExecuteScalar();

            cmd.CommandText = string.Format("SELECT TotalMarks FROM Evaluation WHERE Name = '{0}'", evalName);
            TotalMarksLabel.Text = cmd.ExecuteScalar().ToString();

            ObtainedMarksNUmericUpDown.Maximum = Convert.ToInt32(TotalMarksLabel.Text);
            ObtainedMarksNUmericUpDown.Minimum = 0;
            
        }

        private void EvaluateGroupsForm_Load(object sender, EventArgs e)
        {
            if (value != "edit")
            {
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                string getGroups = "SELECT DISTINCT GroupId FROM GroupStudent WHERE Status = 3 AND GroupId IN" +
                    "(SELECT Groupid FROM GroupProject)";
                SqlCommand cmd = new SqlCommand(getGroups, connection);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //GroupsComboBox.Items.Add(reader[0]);
                    string getCountGroup = string.Format("select count(GroupId) FROM GroupEvaluation WHERE GroupId = '{0}'", reader[0]);
                    SqlConnection con = new SqlConnection(connString);
                    con.Open();
                    SqlCommand command = new SqlCommand(getCountGroup, con);
                    int countGroup = (Int32)command.ExecuteScalar();
                    string getcountEval = string.Format("select count(id) FROM Evaluation");
                    command.CommandText = getcountEval;
                    int countEval = (Int32)command.ExecuteScalar();
                    if (countGroup < countEval)
                    {
                        GroupsComboBox.Items.Add(reader[0]);
                    }
                    con.Close();
                }
                
                connection.Close();

               
            }
            else if (value == "edit")
            {
                GroupsComboBox.Items.Clear();
                EvaluationComboBox.Items.Clear();

                GroupsComboBox.Items.Add(Gid);
                EvaluationComboBox.Items.Add(Ename);

                GroupsComboBox.Text = Gid.ToString();
                EvaluationComboBox.Text = Ename;

                EvaluationComboBox.SelectedItem = Ename;
                ObtainedMarksNUmericUpDown.Value = marks;

                SqlConnection conn = new SqlConnection(connString);
                conn.Open();

                string getid = string.Format("SELECT Id FROM Evaluation WHERE Name = '{0}'", Ename);
                SqlCommand cmd = new SqlCommand(getid, conn);
                evalId = (Int32)cmd.ExecuteScalar();

                cmd.CommandText = string.Format("SELECT TotalMarks FROM Evaluation WHERE Name = '{0}'", Ename);
                TotalMarksLabel.Text = cmd.ExecuteScalar().ToString();

                ObtainedMarksNUmericUpDown.Maximum = Convert.ToInt32(TotalMarksLabel.Text);
                ObtainedMarksNUmericUpDown.Minimum = 0;
            }
        }

        private void GroupsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            EvaluationComboBox.Items.Clear();
            SqlConnection connection1 = new SqlConnection(connString);
            connection1.Open();
            string getEval = string.Format("SELECT Name FROM Evaluation WHERE Id NOT IN (SELECT EvaluationId FROM GroupEvaluation " +
                "WHERE GroupId = '{0}')", GroupsComboBox.Text);
            SqlCommand cmd1 = new SqlCommand(getEval, connection1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                EvaluationComboBox.Items.Add(reader1[0]);
            }
            connection1.Close();
        }

        private void GroupsComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
          
        }

        private void EvaluationComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AssignProjectLabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
