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

namespace SchoolManagementSystem.StudentReports
{
    public partial class StudentMarksReport : Form
    {
        ReportDocument cryrpt = new ReportDocument();

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public StudentMarksReport()
        {
            InitializeComponent();
        }

        private void StudentMarksReport_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\StudentMarksCrystalReport1.rpt");
            con.Open();
            StudentDataSet1 dst = new StudentDataSet1();
            SqlDataAdapter sda = new SqlDataAdapter("Select EM.Term, EM.Year, EM.Mark From ExamMarks EM", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();

        }
    }
}
