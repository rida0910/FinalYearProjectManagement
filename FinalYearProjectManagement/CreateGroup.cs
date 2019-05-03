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
    public partial class CreateGroup : Form
    {
        String connString = "Data Source=RIDA\\SQLSERVER;Initial Catalog=ProjectA;User ID=sa;Password=0910";
        string id;
        List<int> studentID = new List<int>();
        string val;
        //int GroupID;
        int Count;
        public CreateGroup(int gID, int count, List<int> sID, string value)
        {
            InitializeComponent();
            if (value == "edit")
            {
                this.Text = "Update Group";
                studentID = sID;
                val = value;
                id = gID.ToString();
                Count = count;
            }
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            // Adding items to combobox
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            string getStatus = "SELECT Id FROM LookUp WHERE Value = 'InActive' AND Category = 'STATUS'";
            SqlCommand cmd = new SqlCommand(getStatus, connection);
            int status = (Int32)cmd.ExecuteScalar();

            string display = string.Format("SELECT RegistrationNo FROM Student " +
                "WHERE Student.Id NOT IN(SELECT StudentId FROM GroupStudent) " +
                "OR Student.Id IN(SELECT StudentId FROM GroupStudent WHERE Status = '{0}'" +
                "AND Student.Id NOT IN(SELECT StudentId FROM GroupStudent WHERE Status = 3))", status);
            cmd.CommandText = display;
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                StudentsCombobox.Items.Add(reader[0]);
            }
            connection.Close();

            // Placing Id of Group in Label
            if (val != "edit")
            {
                SqlConnection con1 = new SqlConnection(connString);
                con1.Open();
                string query = "SELECT IDENT_CURRENT('Group')";
                SqlCommand cmd1 = new SqlCommand(query, con1);
                id = cmd1.ExecuteScalar().ToString();
                GroupNum.Text = "Group " + id;
                connection.Close();
                con1.Close();
            }
            else if (val == "edit")
            {
                GroupNum.Text = "Group " + id;
            }

            DataGridViewColumn col = new DataGridViewTextBoxColumn();
            col.HeaderText = "Name";
            col.Name = "Name";
            StudentsGrid.Columns.Add(col);
            DataGridViewColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "Registration Number";
            col1.Name = "Registration Number";
            StudentsGrid.Columns.Add(col1);
            DataGridViewColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Contact";
            col2.Name = "Contact";
            StudentsGrid.Columns.Add(col2);
            DataGridViewColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Email";
            col3.Name = "Email";
            StudentsGrid.Columns.Add(col3);
            DataGridViewColumn col4 = new DataGridViewTextBoxColumn();
            col4.HeaderText = "Date OF Birth";
            col4.Name = "Date OF Birth";
            StudentsGrid.Columns.Add(col4);
            DataGridViewColumn col5 = new DataGridViewTextBoxColumn();
            col5.HeaderText = "Gender";
            col5.Name = "Gender";
            StudentsGrid.Columns.Add(col5);

            if (val == "edit")
            {
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string display1 = string.Format("SELECT CONCAT(FirstName,' ', LastName) AS Name ,RegistrationNo AS [Registration Number], " +
                    "Contact, Email, convert(varchar, DateOfBirth, 106) AS [Date OF Birth], Value AS Gender " +
                    "FROM Person JOIN Student ON Person.Id = Student.Id" +
                    " JOIN LookUp ON Person.Gender = LookUp.Id WHERE Student.Id IN ("
               + string.Join(",", studentID)
               + ")");
                SqlCommand cmd2 = new SqlCommand(display1, conn);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                while (reader2.Read())
                {
                    int rowIndex = this.StudentsGrid.Rows.Add();
                    var row = this.StudentsGrid.Rows[rowIndex];
                    row.Cells["Name"].Value = reader2.GetString(0);
                    row.Cells["Registration Number"].Value = reader2.GetString(1);
                    row.Cells["Contact"].Value = reader2.GetString(2);
                    row.Cells["Email"].Value = reader2.GetString(3);
                    row.Cells["Date OF Birth"].Value = reader2.GetString(4);
                    row.Cells["Gender"].Value = reader2.GetString(5);
                }

            }
            var RemoveButton = new DataGridViewButtonColumn();
            RemoveButton.Name = "StudentRemoveButton";
            RemoveButton.HeaderText = "Remove";
            RemoveButton.Text = "Remove";
            RemoveButton.UseColumnTextForButtonValue = true;
            this.StudentsGrid.Columns.Add(RemoveButton);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            // deleting groups having no students
            string getid = "SELECT Id FROM [Group] WHERE Id NOT IN (SELECT GroupId FROM GroupStudent) ";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand command = new SqlCommand(getid, connection);
            SqlDataReader GroupIDs = command.ExecuteReader();
            while (GroupIDs.Read())
            {
                string delGroup = string.Format("DELETE FROM [Group] WHERE Id = '{0}'", GroupIDs[0]);
                SqlConnection sql = new SqlConnection(connString);
                sql.Open();
                SqlCommand cmd = new SqlCommand(delGroup, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            connection.Close();
            ManageGroups form = new ManageGroups();
            form.Show();
            this.Close();
        }

        private void StudentsCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StudentsGrid.Rows.Count < 5)
            {
                string query = string.Format("SELECT CONCAT(FirstName,' ', LastName) AS Name ,RegistrationNo AS [Registration Number], " +
                    "Contact, Email, convert(varchar, DateOfBirth, 106) AS [Date OF Birth], Value AS Gender " +
                "FROM Person JOIN Student ON Person.Id = Student.Id" +
                " JOIN LookUp ON Person.Gender = LookUp.Id WHERE RegistrationNo = '{0}'", StudentsCombobox.Text);
                SqlConnection connection = new SqlConnection(connString);
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();

                int rowIndex = this.StudentsGrid.Rows.Add();
                var row = this.StudentsGrid.Rows[rowIndex];
                while (reader.Read())
                {
                    row.Cells[0].Value = reader.GetString(0);
                    row.Cells[1].Value = reader.GetString(1);
                    row.Cells[2].Value = reader.GetString(2);
                    row.Cells[3].Value = reader.GetString(3);
                    row.Cells[4].Value = reader.GetString(4);
                    row.Cells[5].Value = reader.GetString(5);
                }

                // Removing items from combobox already in grid
                List<string> list = new List<string>();

                foreach (string s in StudentsCombobox.Items)
                {
                    list.Add(s);
                }

                foreach (DataGridViewRow r in StudentsGrid.Rows)
                {
                    foreach (string s in list)
                    {
                        if (r.Cells[1].Value.ToString() == s)
                        {
                            StudentsCombobox.Items.Remove(s);
                        }
                    }
                }
            }
            else if (StudentsGrid.Rows.Count >= 5)
            {
                MessageBox.Show("More than 5 students cannot be added to the group!");
            }
        }

        private void CreateGroupButton_Click(object sender, EventArgs e)
        {
            List<String> list = new List<string>();
            string regno;
            
            SqlConnection con = new SqlConnection(connString);
            con.Open();
            if (val != "edit")
            {
                foreach (DataGridViewRow r in StudentsGrid.Rows)
                {
                    if (r.Index != StudentsGrid.NewRowIndex)
                    {
                        regno = r.Cells["Registration Number"].Value.ToString();
                        list.Add(regno);
                    }
                }
                foreach (String s in list)
                {
                    string query = string.Format("SELECT Id FROM Student WHERE RegistrationNo = '{0}'", s);
                    SqlCommand cmd = new SqlCommand(query, con);
                    int id1 = (Int32)cmd.ExecuteScalar();
                    cmd.CommandText = string.Format("INSERT INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) Values('{0}', '{1}', '{2}', '{3}')", int.Parse(id), id1, 3, DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show(string.Format("Students Added to the group '{0}'", id));
            }
            else if (val == "edit")
            {
                foreach (DataGridViewRow r in StudentsGrid.Rows)
                {
                    if (r.Index >= Count)
                    {
                        regno = r.Cells["Registration Number"].Value.ToString();
                        list.Add(regno);
                    }
                }
                foreach (String s in list)
                {
                    string query = string.Format("SELECT Id FROM Student WHERE RegistrationNo = '{0}'", s);
                    SqlConnection sql = new SqlConnection(connString);
                    sql.Open();
                    SqlCommand cmd = new SqlCommand(query, sql);
                    int id1 = (Int32)cmd.ExecuteScalar();

                    string q2 = string.Format("SELECT StudentId FROM GroupStudent WHERE GroupId = '{0}'", id);
                    cmd.CommandText = q2;
                    SqlDataReader read = cmd.ExecuteReader();
                    List<int> ids = new List<int>();
                    while (read.Read())
                    {
                        ids.Add(Convert.ToInt32(read[0].ToString()));
                    }
                    SqlConnection conn = new SqlConnection(connString);
                    conn.Open();
                    SqlCommand comm = new SqlCommand("",conn);
                    if (ids.Contains(id1))
                    {
                        comm.CommandText = string.Format("UPDATE GroupStudent SET Status = 3 WHERE GroupId = '{0}' AND StudentId = '{1}'", id, id1);
                        comm.ExecuteNonQuery();

                    }
                    else
                    {
                        comm.CommandText = string.Format("INSERT INTO GroupStudent(GroupId, StudentId, Status, AssignmentDate) Values('{0}', '{1}', '{2}', '{3}')", int.Parse(id), id1, 3, DateTime.Now);
                        comm.ExecuteNonQuery();
                    }
                    conn.Close();
                    sql.Close();
                }
                MessageBox.Show(string.Format("Group Updated '{0}'", id));
            }

            // deleting groups having no students
            string getid = "SELECT Id FROM [Group] WHERE Id NOT IN (SELECT GroupId FROM GroupStudent) ";
            SqlConnection connection = new SqlConnection(connString);
            connection.Open();
            SqlCommand command = new SqlCommand(getid, connection);
            SqlDataReader GroupIDs = command.ExecuteReader();
            while (GroupIDs.Read())
            {
                string delGroup = string.Format("DELETE FROM [Group] WHERE Id = '{0}'", GroupIDs[0]);
                SqlConnection sql = new SqlConnection(connString);
                sql.Open();
                SqlCommand cmd = new SqlCommand(delGroup, sql);
                cmd.ExecuteNonQuery();
                sql.Close();
            }
            connection.Close();
            
            con.Close();
            ManageGroups form = new ManageGroups();
            form.Show();
            this.Close();
        }

        private void StudentsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == StudentsGrid.NewRowIndex || e.RowIndex < 0)
                return;

            if (e.ColumnIndex == StudentsGrid.Columns["StudentRemoveButton"].Index)
            { 
                int i = e.RowIndex;
                string regno = StudentsGrid.Rows[i].Cells[1].Value.ToString();
                string query = string.Format("SELECT Id FROM Student WHERE RegistrationNo = '{0}'", regno);
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                int id1 = (Int32)cmd.ExecuteScalar();

                string q2 = string.Format("SELECT StudentId FROM GroupStudent WHERE GroupId = '{0}'", id);
                cmd.CommandText = q2;
                SqlDataReader read = cmd.ExecuteReader();
                List<int> ids = new List<int>();
                while (read.Read())
                {
                    ids.Add(Convert.ToInt32(read[0].ToString()));
                }
                con.Close();
                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                SqlCommand command = new SqlCommand("", conn);
                if (ids.Contains(id1))
                {
                    command.CommandText = string.Format("UPDATE GroupStudent SET Status = 4 WHERE GroupId = '{0}' AND StudentId = '{1}'", id, id1);
                    command.ExecuteNonQuery();
                    StudentsGrid.Rows.RemoveAt(e.RowIndex);
                    MessageBox.Show(string.Format("Student '{1}' status changed from active to inactive in the group '{0}'", id, id1));
                }
                else
                {
                    StudentsGrid.Rows.RemoveAt(e.RowIndex);
                }
                conn.Close();
            }
        }
    }
}
