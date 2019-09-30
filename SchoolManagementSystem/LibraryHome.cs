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
    public partial class LibraryHome : Form
    {
        public LibraryHome()
        {
            InitializeComponent();
        }

        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LibraryAddBook libraryAddBook = new LibraryAddBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LibraryAddBook libraryAddBook = new LibraryAddBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            LibrarySearchBook libraryAddBook = new LibrarySearchBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            IssueBook libraryAddBook = new IssueBook();
            this.Hide();
            libraryAddBook.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ReturnBook retBook = new ReturnBook();
            this.Hide();
            retBook.ShowDialog();
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
            AdminMngStaffHome mngStaff = new AdminMngStaffHome();
            this.Hide();
            mngStaff.ShowDialog();
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

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ReportBooks log = new ReportBooks();
            this.Hide();
            log.ShowDialog();
        }

        private void LibraryHome_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.username;
        }
    }
}
