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
    public partial class InventoryDashboard : Form
    {
        public InventoryDashboard()
        {
            InitializeComponent();
        }

        private void BtnLab_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Laboratory Equipments");
            item.Show();
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Moveable Infrastructures");
            item.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Sports Items");
            item.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Music Instruments");
            item.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Teaching Aid");
            item.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Cleaning Items");
            item.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Stationary");
            item.Show();
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("Electronic Items");
            item.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("View All Items");
            item.Show();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletedList list = new DeletedList();
            list.Show();
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
            AdminMngStaffHome newADM = new AdminMngStaffHome();
            this.Hide();
            newADM.ShowDialog();
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
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            InventoryProductReportGenerate rp = new InventoryProductReportGenerate();
            this.Hide();
            rp.Show();
        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
