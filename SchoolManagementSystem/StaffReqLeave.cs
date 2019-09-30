using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StaffReqLeave : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public StaffReqLeave()
        {
            InitializeComponent();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage2 hme = new HomePage2();
            this.Hide();
            hme.ShowDialog();
        }

        private void AcceotDeclineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            viewLeaves();
        }

        private void StaffReqLeave_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
            AcceptDeclineCombo.Text = "All";
            NametextBox1.Text = GetSetInfo.userName;
            UsrlinkLabel.Text = GetSetInfo.userName;
            viewLeaves();
        }

        private void viewLeaves() {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (AcceptDeclineCombo.Text.Equals("All"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves where staffID=" + GetSetInfo.getsetusrId + "";
                cmd.ExecuteNonQuery();
            }
            else if (AcceptDeclineCombo.Text.Equals("Accepted"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves where staffID=" + GetSetInfo.getsetusrId + " and status='Accepted'";
                cmd.ExecuteNonQuery();
            }
            else if (AcceptDeclineCombo.Text.Equals("Decline"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves where staffID=" + GetSetInfo.getsetusrId + " and status='Decline'";
                cmd.ExecuteNonQuery();
            }
            else if (AcceptDeclineCombo.Text.Equals("Pending")) {
                cmd.CommandText = "SELECT * FROM staffLeaves where staffID=" + GetSetInfo.getsetusrId + " and status='Pending'";
                cmd.ExecuteNonQuery();
            }


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SalarydataView1.DataSource = dt;
            con.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO staffLeaves ([staffID],[status],[date],[returnDate],[type],[reason]) VALUES ("+GetSetInfo.getsetusrId+",'Pending','"+dateTimePicker1.Value+"','"+dateTimePicker2.Value+"','"+typeComboBox1.Text+"','"+reasonTextBox.Text+"')";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Inserted Succesfully");
            viewLeaves();

        }

        private void SalarydataView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
