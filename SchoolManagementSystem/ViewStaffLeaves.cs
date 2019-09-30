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
    public partial class ViewStaffLeaves : Form
    {

        private int leaveID;
        private int staffID;
        private String name;
        private String fullName;

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public ViewStaffLeaves()
        {
            InitializeComponent();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 home = new HomePage1();
            this.Hide();
            home.ShowDialog();
        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaffMember newStaffPage = new AddStaffMember();
            this.Hide();
            newStaffPage.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            ViewStaffMembers newViewStaff = new ViewStaffMembers();
            this.Hide();
            newViewStaff.ShowDialog();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo newViewSalary = new ViewSalaryInfo();
            this.Hide();
            newViewSalary.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves newStffLeave = new ViewStaffLeaves();
            this.Hide();
            newStffLeave.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            CreateStudentAccount creAcc = new CreateStudentAccount();
            this.Hide();
            creAcc.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void ViewStaffLeaves_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
            AcceotDeclineCombo.Text = "All";
            fillStaffLeave();
        }
        
        private void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AcceotDeclineCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillStaffLeave();
        }

        private void fillStaffLeave() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (AcceotDeclineCombo.Text.Equals("All"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves";
                cmd.ExecuteNonQuery();
            }
            else if (AcceotDeclineCombo.Text.Equals("Accepted"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves where status='Accepted'";
                cmd.ExecuteNonQuery();
            }
            else if (AcceotDeclineCombo.Text.Equals("Decline"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves where status='Decline'";
                cmd.ExecuteNonQuery();
            }
            else if (AcceotDeclineCombo.Text.Equals("Pending"))
            {
                cmd.CommandText = "SELECT * FROM staffLeaves where status='Pending'";
                cmd.ExecuteNonQuery();
            }


            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            SalarydataView1.DataSource = dt;
            con.Close();
        }

        private void SalarydataView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = SalarydataView1.Rows[index];
            leaveID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            staffID = Int32.Parse(selectRow.Cells[1].Value.ToString());

            getMemName();

            string date = selectRow.Cells[3].Value.ToString();
            try
            {
                DateTime oDate = Convert.ToDateTime(date);
                dateTimePicker1.Value = new System.DateTime(oDate.Year, oDate.Month, oDate.Day, 0, 0, 0, 0);
            }
            catch (Exception)
            {
                DateTime newdate = DateTime.Now;
                dateTimePicker1.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
            }

            string date2 = selectRow.Cells[4].Value.ToString();
            try
            {
                DateTime oDate = Convert.ToDateTime(date2);
                dateTimePicker1.Value = new System.DateTime(oDate.Year, oDate.Month, oDate.Day, 0, 0, 0, 0);
            }
            catch (Exception)
            {
                DateTime newdate = DateTime.Now;
                dateTimePicker2.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
            }

            addressTextBox.Text = selectRow.Cells[5].Value.ToString();

        }

        private void getMemName() {
            con.Open();
            SqlCommand command;
            SqlDataReader dataReader;

            string query = "SELECT name,fullName FROM staff where staffID = '" + staffID + "'";

            command = new SqlCommand(query,con);
            dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                name = dataReader.GetValue(0).ToString();
                fullName = dataReader.GetValue(1).ToString();
            }
            dataReader.Close();
            command.Dispose();
            con.Close();

            NametextBox1.Text = name;
            nameTextBox2.Text = fullName;

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            if (acTDeclinecomboBox.Text.Equals("Accept"))
            {
                cmd.CommandText = "UPDATE staffLeaves SET status='Accepted' where leaveID = '" + leaveID + "'";
                cmd.ExecuteNonQuery();
            }
            else if (acTDeclinecomboBox.Text.Equals("Decline"))
            {
                cmd.CommandText = "UPDATE staffLeaves SET status='Decline' where leaveID = '" + leaveID + "'";
                cmd.ExecuteNonQuery();
            }

            con.Close();

            MessageBox.Show("Leave Status Update Succesfully");

            ViewStaffLeaves viewStaffLeaves = new ViewStaffLeaves();
            this.Hide();
            viewStaffLeaves.ShowDialog();
        }
    }
}
