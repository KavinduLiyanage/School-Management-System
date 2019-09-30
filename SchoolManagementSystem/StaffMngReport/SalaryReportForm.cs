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

namespace SchoolManagementSystem.StaffMngReport
{
    public partial class SalaryReportForm : Form
    {

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        ReportDocument reportDocument = new ReportDocument();
        public SalaryReportForm()
        {
            InitializeComponent();
        }

        private void SalaryReportForm_Load(object sender, EventArgs e)
        {
            reportDocument.Load(@"D:\SchoolManagementSystem\SalaryReport.rpt");
            con.Open();
            DataSet dst = new DataSet();
            String query = "select SR.staffID,SR.salary,SR.date from SalaryRecord SR,staff S where SR.staffID = S.staffID and SR.staffID=" + GetSetInfo.usrId + "";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            reportDocument.SetDataSource(dt);
            crystalReportViewer1.ReportSource = reportDocument;

            con.Close();


        }
    }
}
