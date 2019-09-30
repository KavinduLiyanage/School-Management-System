using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class InventoryItemReportGenerate : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        public InventoryItemReportGenerate()
        {
            InitializeComponent();
        }

        private void InventoryItemReportGenerate_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\cristalReportItem.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Items]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Buttonall_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\cristalReportItem.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Items]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\cristalReportItem.rpt");
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * from [Items] where [Category]='"+ comboBox1.Text+"'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 h1 = new HomePage1();
            this.Hide();
            h1.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            InventoryDashboard h1 = new InventoryDashboard();
            this.Hide();
            h1.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InventoryProductReportGenerate x = new InventoryProductReportGenerate();
            this.Hide();
            x.Show();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            DeletedList list = new DeletedList();
            this.Hide();
            list.Show();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.Show();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard note = new Notice_Dashboard();
            this.Hide();
            note.Show();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome lb = new LibraryHome();
            this.Hide();
            lb.Show();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome mg = new ResourceManageHome();
            this.Hide();
            mg.Show();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard ev = new EventDashboard();
            this.Hide();
            ev.Show();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome st = new StudentManageHome();
            this.Hide();
            st.Show();
        }
    }
}
