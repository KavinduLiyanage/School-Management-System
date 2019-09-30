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
    public partial class ClassResultSheet : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        ReportDocument rd = new ReportDocument();
        public ClassResultSheet()
        {
            InitializeComponent();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnTeachersHomeCRS_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void ClassResultSheet_Load(object sender, EventArgs e)
        {
            rd.Load(@"D:\SchoolManagementSystem\ClassResultSheet.rpt");
            con.Open();
            DataSet dst = new DataSet();
            String query = "Select * From ExamMarks";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            rd.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rd;
            con.Close();

        }

        private void BtnManageMarksCRS_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksCRS_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteCRS_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetCRS_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();

        }

        private void BtnSectionResultSheetCRS_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableCRS_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableCRS_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnAddTimetableCRS_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnGetReportCRS_Click(object sender, EventArgs e)
        {
            ClassResultSheet crs = new ClassResultSheet();
            this.Hide();
            crs.ShowDialog();
        }

        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

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

        private void LbUserCRS_Click(object sender, EventArgs e)
        {
            lbUserCRS.Text = GetSetInfo.userName;
        }
    }
}
