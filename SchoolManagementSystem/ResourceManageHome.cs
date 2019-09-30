using SchoolManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ResourceManageHome : Form
    {
        public ResourceManageHome()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MngClassRoom openForm = new MngClassRoom();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MngTimeTable openForm = new MngTimeTable();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addsubbtn_Click(object sender, EventArgs e)
        {
            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addclassbtn_Click(object sender, EventArgs e)
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

        private void Viewtimetablebtn_Click(object sender, EventArgs e)
        {
            timetableview openForm = new timetableview();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            timetableview openForm = new timetableview();
            this.Hide();
            openForm.ShowDialog();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            MngClassRoom openForm = new MngClassRoom();
            this.Hide();
            openForm.ShowDialog();
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            MngTimeTable openForm = new MngTimeTable();
            this.Hide();
            openForm.ShowDialog();
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            timetableview openForm = new timetableview();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome openForm = new TeachersHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome openForm = new StudentManageHome();
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

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

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
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
