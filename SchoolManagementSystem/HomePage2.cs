using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage2 : Form
    {
        public HomePage2()
        {
            InitializeComponent();
        }

        private void HomePage2_Load(object sender, System.EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }

        private void ReqLeaveImgBtn_Click(object sender, System.EventArgs e)
        {
            StaffReqLeave reqLeave = new StaffReqLeave();
            this.Hide();
            reqLeave.ShowDialog();
        }

        private void ReqLeaveBtn_Click(object sender, System.EventArgs e)
        {
            StaffReqLeave reqLeave = new StaffReqLeave();
            this.Hide();
            reqLeave.ShowDialog();
        }

        private void MngNticeBtn_Click(object sender, System.EventArgs e)
        {
            userNoticeView Unv = new userNoticeView();
            this.Hide();
            Unv.ShowDialog();
        }

        private void MngStuImgBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void MngNticeImgBtn_Click(object sender, System.EventArgs e)
        {
            userNoticeView Unv = new userNoticeView();
            this.Hide();
            Unv.ShowDialog();
        }

        private void MngStuBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void MngExmImgBtn_Click(object sender, System.EventArgs e)
        {

        }

        private void BtnExamMheader_Click(object sender, System.EventArgs e)
        {

        }

        private void MngStaffBtn_Click(object sender, System.EventArgs e)
        {
            TeacherMyProfile myPro = new TeacherMyProfile();
            this.Hide();
            myPro.ShowDialog();
        }

        private void MngStaffImgBtn_Click(object sender, System.EventArgs e)
        {
            TeacherMyProfile myPro = new TeacherMyProfile();
            this.Hide();
            myPro.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, System.EventArgs e)
        {
            HomePage2 newHome = new HomePage2();
            this.Hide();
            newHome.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, System.EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            
        }
    }
}
