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
    
    public partial class userNoticeView : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public userNoticeView()
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
            cmd.CommandText = "select [Published Date] ,[Details]  from Notices where [Category] ='Academic'  ORDER BY [Notice Id] DESC";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }


        private void AcademicNoticeView_Load(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            CreateStudentAccount creAcc = new CreateStudentAccount();
            this.Hide();
            creAcc.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }



        private void Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }


    }
}
