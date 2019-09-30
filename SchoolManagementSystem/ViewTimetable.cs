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
    public partial class ViewTimetable : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        ReportDocument rd = new ReportDocument();

        public ViewTimetable()
        {
            InitializeComponent();
        }

        private void BtnTeachersHomeGTT_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksGTT_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksGTT_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteGTT_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetGTT_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetGTT_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetGTT_Click(object sender, EventArgs e)
        {

            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableGTT_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnAddTimetableGTT_Click(object sender, EventArgs e)
        {
            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void CrystalReportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void BtnGetReportGTT_Click(object sender, EventArgs e)
        {
            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void ViewTimetable_Load(object sender, EventArgs e)
        {
            rd.Load(@"D:\SchoolManagementSystem\StudentResultSheet.rpt");
            con.Open();
            DataSet dst = new DataSet();
            String query = "Select * From ExamTimetable";
            SqlDataAdapter sd = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            rd.SetDataSource(dt);
            crystalReportViewer3.ReportSource = rd;
            con.Close();

        }

        public void displayData()
        {
            
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            //displayData(tbSearch.Text);

        }

        private void BtnDisplayGTT_Click(object sender, EventArgs e)
        {
          
            DataTable dt = new DataTable();
            string query = "SELECT Term,Date,Grade,Subject  FROM ExamTimeTable WHERE Grade = '" + cbGrade.Text + "' AND Term = '" + cbTerm.Text + "'  ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.Fill(dt);
            dataGridViewTimeTable.DataSource = dt;
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

        private void LbUserGT_Click(object sender, EventArgs e)
        {
            lbUserGT.Text = GetSetInfo.userName;
        }
    }
}
