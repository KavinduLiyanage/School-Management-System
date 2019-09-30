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
    public partial class StudentManageHome : Form
    {
        public StudentManageHome()
        {
            InitializeComponent();
        }

        private void AddStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateStudentAccount sacc = new CreateStudentAccount();
            sacc.ShowDialog();
        }

        private void NAddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateStudentAccount sacc = new CreateStudentAccount();
            sacc.ShowDialog();
        }

        private void NViewStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void ViewStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void ViewLeaveImgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void AddStaffImgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateStudentAccount sacc = new CreateStudentAccount();
            sacc.ShowDialog();
        }

        private void ViewSalaryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void ViewStaffImgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void NEditStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void NStudentHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManageHome smanagehome = new StudentManageHome();
            smanagehome.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1 hm = new HomePage1();
            hm.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void ViewSalaryImgBtn_Click(object sender, EventArgs e)
        {
            StudentReports.StudentDetailReport2 log = new StudentReports.StudentDetailReport2();
            this.Hide();
            log.ShowDialog();
        }

        private void viewLeaveBtn_Click(object sender, EventArgs e)
        {
            StudentReports.StudentDetailReport2 log = new StudentReports.StudentDetailReport2();
            this.Hide();
            log.ShowDialog();
        }

        private void StudentManageHome_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
