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

namespace SchoolManagementSystem.YearlyEventReport
{
    public partial class YearlyEventReport : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        ReportDocument crypt = new ReportDocument();
        public YearlyEventReport()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void GenerateReport_click(object sender, EventArgs e)
        {
            //crypt.Load(@"C:\Users\dulas\source\repos\MilindaRanawaka\SchoolManagementSystem\SchoolManagementSystem\YearlyEventReport\YearlyEvReport.rpt");
            crypt.Load(@"D:\SchoolManagementSystem\YearlyEvReport.rpt");
            con.Open();
            DataSet dst = new DataSet();
            String query = "Select [Event Name],[Event Date],[Event Venue] from Events where [Event Date] like '%" + textBoxYear.Text + "%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dst, "Events");
            crypt.SetDataSource(dst);
            crystalReportViewer1.ReportSource = crypt;
            con.Close();
        }

        private void back_click(object sender, EventArgs e)
        {
            EventDashboard form_back = new EventDashboard();
            this.Hide();
            form_back.Show();
        }
    }
}
