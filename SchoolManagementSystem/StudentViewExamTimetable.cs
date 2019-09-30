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
    public partial class StudentViewExamTimetable : Form
    {
        public StudentViewExamTimetable()
        {
            InitializeComponent();
        }

        private void BtnStudentHomeETT_Click(object sender, EventArgs e)
        {
            StudentExam seh = new StudentExam();
            this.Hide();
            seh.ShowDialog();
        }

        private void BtnStudentHome_Click(object sender, EventArgs e)
        {
            HomePage3 hp3 = new HomePage3();
            this.Hide();
            hp3.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome smh = new StudentManageHome();
            this.Hide();
            smh.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard ind = new InventoryDashboard();
            this.Hide();
            ind.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome rmh = new ResourceManageHome();
            this.Hide();
            rmh.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome lh = new LibraryHome();
            this.Hide();
            lh.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome th = new TeachersHome();
            this.Hide();
            th.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.ShowDialog();
        }

        private void LbUserTH_Click(object sender, EventArgs e)
        {
            lbUserTH.Text= GetSetInfo.userName;
        }
    }
}
