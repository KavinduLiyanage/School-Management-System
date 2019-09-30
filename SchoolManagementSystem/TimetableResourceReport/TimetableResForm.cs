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

namespace SchoolManagementSystem.TimetableResourceReport
{
    public partial class TimetableResForm : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public TimetableResForm()
        {
            InitializeComponent();
        }

        private void TimetableResForm_Load(object sender, EventArgs e)
        {
            cryrpt.Load(@"D:\SchoolManagementSystem\TimetableReaCrystalReport.rpt");
            con.Open();
            DataSet dst = new DataSet();
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [Timetable]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cryrpt.SetDataSource(dt);
            crystalReportViewer1.ReportSource = cryrpt;
            con.Close();
        }
    }
}
