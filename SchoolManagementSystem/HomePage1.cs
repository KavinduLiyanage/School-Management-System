using System;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage1 : Form
    {
        public HomePage1()
        {
            InitializeComponent();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MngEvtImgBtn_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void MngStaffBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngStaffImgBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void MngExmBtn_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void MngExmImgBtn_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void MngResrceImgBtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome resMngHome = new ResourceManageHome();
            this.Hide();
            resMngHome.ShowDialog();
        }

        private void MngResrceBtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome resMngHome = new ResourceManageHome();
            this.Hide();
            resMngHome.ShowDialog();
        }

        private void MngEvtBtn_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void MngNticeImgBtn_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void MngNticeBtn_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void MngStuBtn_Click(object sender, EventArgs e)
        {
            StudentManageHome sthome = new StudentManageHome();
            this.Hide();
            sthome.ShowDialog();
        }

        private void MngStuImgBtn_Click(object sender, EventArgs e)
        {
            StudentManageHome sthome = new StudentManageHome();
            this.Hide();
            sthome.ShowDialog();
        }

        private void MngInvenImgBtn_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void MngInvenBtn_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void MngLibImgBtn_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }

        private void MngLibBtn_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome sthome = new StudentManageHome();
            this.Hide();
            sthome.ShowDialog();
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

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newhome = new HomePage1();
            this.Hide();
            newhome.ShowDialog();
        }

        private void HomePage1_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
