using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class ManageSubject : Form
    {
         SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public ManageSubject()
        {
            InitializeComponent();
        }

        private void Subject_Load(object sender, EventArgs e)
        {
            display_details();
        }

        public void reset()
        {
            subjectid.Clear();
            subjectname.Clear();
            grade.SelectedIndex = -1;
        }

       
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList array1 = new ArrayList();

            Boolean subjectidCon = true;
            Boolean subjectnameCon = true;
            Boolean gradeCon = true;
          

            if (subjectid.Text.Equals(""))
            {
                subjectidCon = false;
                array1.Add("Please Enter Subject Id");
            }

            if (subjectname.Text.Equals(""))
            {
                subjectnameCon = false;
                array1.Add("Please Enter Subject Name");
            }

            if (grade.Text.Equals(""))
            {
                gradeCon = false;
                array1.Add("Please Enter Grade");
            }

           

            string arrayStr = "";
            foreach (Object obj in array1)
            {
                arrayStr = arrayStr + "\n" + obj;
            }

            if (subjectidCon && subjectnameCon && gradeCon)
            {
                this.insertOperation();
            }
            else
            {
                MessageBox.Show(arrayStr);
            }

        }

        private void insertOperation()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Subject values('" + subjectid.Text + "','" + subjectname.Text + "','" + grade.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            subjectid.Text = "";
            subjectname.Text = "";
            grade.Text = "";
            display_details();
            MessageBox.Show("Inserted Successfully");
            reset();
        }

        public void display_details()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subject";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            
            con.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Subject where subjectId='"+subjectid.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Deleted Successfully");
            reset();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Subject where subjectId = '"+subjectid.Text+"'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Subject set subjectName = '"+subjectname.Text+"',grade = '"+grade.Text+"' where subjectId='"+subjectid.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Updated Successfully");
            reset();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void ResmngHome_Click(object sender, EventArgs e)
        {
            ResourceManageHome ResmngHome= new ResourceManageHome();
            this.Hide();
            ResmngHome.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            MngClassRoom addclass = new MngClassRoom();
            this.Hide();
            addclass.ShowDialog();
        }

        private void Timetable_Click(object sender, EventArgs e)
        {
            MngTimeTable mtimetable = new MngTimeTable();
            this.Hide();
            mtimetable.ShowDialog();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            subjectid.Text = selectRow.Cells[0].Value.ToString();
            subjectname.Text = selectRow.Cells[1].Value.ToString();
            grade.Text = selectRow.Cells[2].Value.ToString();
         }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

         private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome openForm = new StudentManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome openForm = new TeachersHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome openForm = new LibraryHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard openForm = new Notice_Dashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Subjectid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Subjectname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SubjectManageReport.SubjectMngForm smf = new SubjectManageReport.SubjectMngForm();
            this.Hide();
            smf.ShowDialog();
        }

        private void BtnExamMheader_Click_1(object sender, EventArgs e)
        {
            TeachersHome openForm = new TeachersHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnStudentMHeader_Click_1(object sender, EventArgs e)
        {
            StudentManageHome openForm = new StudentManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard openForm = new InventoryDashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard openform = new EventDashboard();
            this.Hide();
            openform.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome openForm = new ResourceManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnLibraryMHeader_Click_1(object sender, EventArgs e)
        {
            LibraryHome openForm = new LibraryHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnNoticeMHeader_Click_1(object sender, EventArgs e)
        {
            Notice_Dashboard openForm = new Notice_Dashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            timetableview openForm = new timetableview();
            this.Hide();
            openForm.ShowDialog();
        }

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
