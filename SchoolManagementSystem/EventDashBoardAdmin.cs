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
    public partial class EventDashboard : Form
    {
        public EventDashboard()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

       

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

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

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.Show();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {

        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            CreateStudentAccount creAcc = new CreateStudentAccount();
            this.Hide();
            creAcc.ShowDialog();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void ButtonEvent_Click(object sender, EventArgs e)
        {
            AddEventform Form_ae = new AddEventform();
            this.Hide();
            Form_ae.Show();
        }

        private void ButtonExpenses_Click(object sender, EventArgs e)
        {
            AddExpense_form Form_ax = new AddExpense_form();
            this.Hide();
            Form_ax.Show();
        }

        

        private void AddParticipants_Click(object sender, EventArgs e)
        {
            addParticipant_form Form_ap = new addParticipant_form();
            this.Hide();
            Form_ap.Show();
            
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void GenerateEventRepo_click(object sender, EventArgs e)
        {
            YearlyEventReport.YearlyEventReport evRepo = new YearlyEventReport.YearlyEventReport();
            this.Hide();
            evRepo.Show();
        }
    }
}
