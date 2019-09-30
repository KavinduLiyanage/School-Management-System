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
    public partial class StudentDetailReport2 : Form
    {
        ReportDocument cryrpt = new ReportDocument();

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public StudentDetailReport2()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
           
        }

        private void StudentDetailReport2_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\StudentDetailsCrystalReport2.rpt");
            con.Open();
            StudentDataSet1 dst = new StudentDataSet1();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From Student", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();
        }
    }
}
