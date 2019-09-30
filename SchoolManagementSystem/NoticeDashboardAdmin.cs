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
    public partial class Notice_Dashboard : Form
    {
        public Notice_Dashboard()
        {
            InitializeComponent();
        }

       

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notice_Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubLabel2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNonA_Click(object sender, EventArgs e)
        {
            NonAcademic_noticeBoard form_NAnotice = new NonAcademic_noticeBoard();
            this.Hide();
            form_NAnotice.Show();
        }

        private void ButtonAca_Click(object sender, EventArgs e)
        {
            AcadNotice_board form_ACAnotice = new AcadNotice_board();
            this.Hide();
            form_ACAnotice.Show();
        }

        private void addNotice_Click(object sender, EventArgs e)
        {
            addNotice Addnotice = new addNotice();
            this.Hide();
            Addnotice.Show();
        }

        private void BtnStaffMHeader_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome newadminstaff = new AdminMngStaffHome();
            this.Hide();
            newadminstaff.ShowDialog();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard edd = new EventDashboard();
            this.Hide();
            edd.ShowDialog();
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

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
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

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }
    }
}
