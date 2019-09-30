using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public LoginForm()
        {
            InitializeComponent();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void getUserData() {
            string name;
            string accessLevel;
            int staffid;
            int stuid;

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT name,accessLevel,staffID FROM STAFF WHERE NIC = '" + unTxtBox.Text + "' AND password = '" + pwdTxtBox.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            con.Open();
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "SELECT SID,SNAME FROM Student WHERE [SEMAIL] = '" + unTxtBox.Text + "' AND [SPASSWORD] = '" + pwdTxtBox.Text + "'";
            cmd2.ExecuteNonQuery();
            con.Close();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            if (dt.Rows.Count == 1)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    name = dr["name"].ToString();
                    accessLevel = dr["accessLevel"].ToString();
                    staffid = Int32.Parse(dr["staffID"].ToString());
                    GetSetInfo.userName = name;
                    GetSetInfo.getsetsysLvl = accessLevel;
                    GetSetInfo.getsetusrId = staffid;

                    if (accessLevel.Equals("Admin")) {
                        HomePage1 loadHome1 = new HomePage1();
                        this.Hide();
                        loadHome1.ShowDialog();
                    }
                    else if (accessLevel.Equals("User")) {
                        HomePage2 loadHome2 = new HomePage2();
                        this.Hide();
                        loadHome2.ShowDialog();
                    }
                }
            }
            else if (dt2.Rows.Count == 1)
            {
                foreach (DataRow dr2 in dt2.Rows)
                {
                    name = dr2["SNAME"].ToString();
                    stuid = Int32.Parse(dr2["SID"].ToString());
                    GetSetInfo.userName = name;
                    GetSetInfo.getsetusrId = stuid;
                    GetSetInfo.getsetsysLvl = "Student";

                    HomePage3 loadHome3 = new HomePage3();
                    this.Hide();
                    loadHome3.ShowDialog();
                }
            }
            else {
                MessageBox.Show("Incorrect Username or Password!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pwdTxtBox.Clear();
            }
        }   

        private void Button1_Click(object sender, EventArgs e)
        {

            string text = unTxtBox.Text;
            this.getUserData();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}