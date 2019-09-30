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

namespace SchoolManagementSystem.SubjectManageReport
{
    public partial class SubjectMngForm : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public SubjectMngForm()
        {
            InitializeComponent();
        }

        private void SubjectMngForm_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\SubjectMngCrystalReport.rpt");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Subject]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();
        }
    }
}
