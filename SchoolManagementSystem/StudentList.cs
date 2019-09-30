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
using DAO;
using Models;

namespace SchoolManagementSystem
{
    public partial class StudentList : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public StudentList()
        {
            InitializeComponent();
        }

        private void StudentList_Load(object sender, EventArgs e)
        {
            StudentDetailsDataGridView();
            UsrlinkLabel.Text = GetSetInfo.userName;
        }

        private void StudentDetailsDataGridView()
        {
            dgvStudents.AutoGenerateColumns = false;
            using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
            {
                dgvStudents.DataSource = db.Students.ToList<Student>();
            }
        }

        private void DgvStudents_DoubleClick(object sender, EventArgs e)
        {
            Student student1 = new Student();

            if (dgvStudents.CurrentRow.Index != -1)
            {
                student1.SID = Convert.ToInt32(dgvStudents.CurrentRow.Cells["SID"].Value);
                
            }

            this.Hide();
            StudentDetailsUpdate supdate = new StudentDetailsUpdate(student1.SID);
            supdate.ShowDialog();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where SNAME like '%" + textBox1.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvStudents.DataSource = dt;
            con.Close();
        }

        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Student where Grade like '%" + comboBoxGrade.Text + "' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dgvStudents.DataSource = dt;
            con.Close();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage1 hm = new HomePage1();
            hm.ShowDialog();
        }

        private void NAddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateStudentAccount sacc = new CreateStudentAccount();
            sacc.ShowDialog();
        }

        private void NViewStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void NEditStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void NStudentHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentManageHome smanagehome = new StudentManageHome();
            smanagehome.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

       
    }
}
