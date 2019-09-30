using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SchoolManagementSystem
{
    public partial class userna_noticeView : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public userna_noticeView()
        {
            InitializeComponent();
        }
        public bool OpenConnection()
        {
            try
            {
                conn.Open();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }
        public void Display_Data()
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Published Date] ,[Details]  from Notices where [Category] ='Non Academic'  ORDER BY [Notice Id] DESC";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

        private void Userna_noticeView_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }
    }
}
