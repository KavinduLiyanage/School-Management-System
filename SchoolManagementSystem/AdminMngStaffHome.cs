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
    public partial class AdminMngStaffHome : Form
    {
        public AdminMngStaffHome()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HomePage1 home = new HomePage1();
            this.Hide();
            home.ShowDialog();
        }

        private void AddStaffImgBtn_Click(object sender, EventArgs e)
        {
            AddStaffMember newStaffPage = new AddStaffMember();
            this.Hide();
            newStaffPage.ShowDialog();
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
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

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaffMember newStaffPage = new AddStaffMember();
            this.Hide();
            newStaffPage.ShowDialog();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo viewSlary = new ViewSalaryInfo();
            this.Hide();
            viewSlary.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves newStffLeave = new ViewStaffLeaves();
            this.Hide();
            newStffLeave.ShowDialog();
        }

        private void ViewStaffBtn_Click(object sender, EventArgs e)
        {
            ViewStaffMembers viewStaff = new ViewStaffMembers();
            this.Hide();
            viewStaff.ShowDialog();
        }

        private void ViewStaffImgBtn_Click(object sender, EventArgs e)
        {
            ViewStaffMembers viewStaff = new ViewStaffMembers();
            this.Hide();
            viewStaff.ShowDialog();
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

        private void ViewSalaryImgBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo viewSlary = new ViewSalaryInfo();
            this.Hide();
            viewSlary.ShowDialog();
        }

        private void ViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo viewSlary = new ViewSalaryInfo();
            this.Hide();
            viewSlary.ShowDialog();
        }

        private void ViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves staffLeave = new ViewStaffLeaves();
            this.Hide();
            staffLeave.ShowDialog();
        }

        private void ViewLeaveImgBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves staffLeave = new ViewStaffLeaves();
            this.Hide();
            staffLeave.ShowDialog();
        }

        private void AdminMngStaffHome_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
