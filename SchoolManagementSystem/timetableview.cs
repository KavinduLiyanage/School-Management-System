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
    public partial class timetableview : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");


        public timetableview()
        {
            InitializeComponent();
            

        }

        public void display_details()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Timetable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewTimeTable.DataSource = dt;

            con.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MngClassRoom openForm = new MngClassRoom();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Timetablebtn_Click(object sender, EventArgs e)
        {
            MngTimeTable openForm = new MngTimeTable();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addsubjectbtn_Click(object sender, EventArgs e)
        {
            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();
        }

        private void ResmngHome_Click(object sender, EventArgs e)
        {
            ResourceManageHome openForm = new ResourceManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 openForm = new HomePage1();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome openForm = new StudentManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome openForm = new TeachersHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome openForm = new LibraryHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard openForm = new InventoryDashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard openForm = new Notice_Dashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Timetableview_Load(object sender, EventArgs e)
        {
            display_details();
        }

        

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Timetable where timeTableId = '"+textBox1.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewTimeTable.DataSource = dt;
            con.Close();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard openform = new EventDashboard();
            this.Hide();
            openform.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome openForm = new ResourceManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm openForm = new LoginForm();
            this.Hide();
            openForm.ShowDialog();
        }

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
