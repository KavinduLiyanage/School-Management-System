using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem
{
    public static class GetSetInfo
    {
        public static string username;
        public static string proPic;
        public static int usrId;
        public static string sysLvl;

        public static SqlConnection getCon() {
            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            return con;
        }

        public static void getSubject(System.Windows.Forms.ComboBox comboBox)
        {
            DataSet ds = new DataSet();
            string query = "select * from Subject";
            SqlDataAdapter da = new SqlDataAdapter(query, getCon());
            getCon().Open();

            da.Fill(ds);

            comboBox.DataSource = ds.Tables[0];
            comboBox.DisplayMember = "SubjectName";
            comboBox.ValueMember = "SubjectName";
            getCon().Close();
        }

        public static string userName
        {
            get { return username; }
            set { username = value; }
        }
        public static string getsetproPic
        {
            get { return proPic; }
            set { proPic = value; }
        }
        public static int getsetusrId
        {
            get { return usrId; }
            set { usrId = value; }
        }
        public static string getsetsysLvl
        {
            get { return sysLvl; }
            set { sysLvl = value; }
        }

    }
}
