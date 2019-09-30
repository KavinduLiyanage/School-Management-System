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
    public partial class MngTimeTable : Form
    {
      

            SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");


        public MngTimeTable()
        {
            InitializeComponent();
           
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSetInfo.getSubject(subject);
            getStaff(NameOfTeacher);
            display_details();


        }

        public void reset()
        {
            NameOfTeacher.SelectedIndex = -1;
            subject.SelectedIndex = -1;
            grade.SelectedIndex = -1;
            className.SelectedIndex = -1;
            day.SelectedIndex = -1;
            time.Clear();
           }

        private void Resmngbtn_Click(object sender, EventArgs e)
        {
            ResourceManageHome openForm = new ResourceManageHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addsubbtn_Click(object sender, EventArgs e)
        {
            ManageSubject openForm = new ManageSubject();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Addclassbtn_Click(object sender, EventArgs e)
        {
            MngClassRoom openForm = new MngClassRoom();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Viewtimetablebtn_Click(object sender, EventArgs e)
        {
            timetableview openForm = new timetableview();
            this.Hide();
            openForm.ShowDialog();
        }

    private void BtnSave_Click(object sender, EventArgs e)
        {
            ArrayList array2 = new ArrayList();

            Boolean NameOfTeacherCon = true;
            Boolean subjectCon = true;
            Boolean gradeCon = true;
            Boolean classNameCon = true;
            Boolean dayCon = true;
            Boolean timeCon = true;

          

            if (NameOfTeacher.Text.Equals(""))
            {
                NameOfTeacherCon = false;
                array2.Add("Please Enter Teacher's Name");
            }

            if (subject.Text.Equals(""))
            {
                subjectCon = false;
                array2.Add("Please Enter Subject");
            }

            if (grade.Text.Equals(""))
            {
                gradeCon = false;
                array2.Add("Please Enter Grade");
            }

            if(className.Text.Equals(""))
            {
                classNameCon = false;
                array2.Add("Please Enter Class");
            }

            if(day.Text.Equals(""))
            {
                dayCon = false;
                array2.Add("Please Enter Day");
            }

            if(time.Text.Equals(""))
            {
                timeCon = false;
                array2.Add("Please Enter Time");
            }



            string arrayStr = "";
            foreach (Object obj in array2)
            {
                arrayStr = arrayStr + "\n" + obj;
            } 

            if (NameOfTeacherCon && subjectCon && gradeCon && classNameCon && dayCon && timeCon)
            {
                this.insertOperation();
            }
            else
            {
                MessageBox.Show(arrayStr);
            }
        }

        public void display_details()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Timetable";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewtimetable.DataSource = dt;
            con.Close();
        }

        private void insertOperation()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Timetable values ('" + NameOfTeacher.Text + "','" + subject.Text + "','" + grade.Text + "','" + className.Text + "','" + day.Text + "','" + time.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
           
            NameOfTeacher.Text = "";
            subject.Text = "";
            grade.Text = "";
            className.Text = "";
            day.Text = "";
            time.Text = "";
            display_details();
            MessageBox.Show("Inserted Successfully");
            reset();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
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

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard openForm = new InventoryDashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard openForm = new Notice_Dashboard();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getStaff(System.Windows.Forms.ComboBox comboBox)
        {
            DataSet ds = new DataSet();
            string query = "select * from staff where memberType = 'Acedemic'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            con.Open();

            da.Fill(ds);

            comboBox.DataSource = ds.Tables[0];
            comboBox.DisplayMember = "fullName";
            comboBox.ValueMember = "fullName";
            con.Close();
        }

       

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridViewtimetable.Rows[index];
            NameOfTeacher.Text = selectRow.Cells[0].Value.ToString();
            subject.Text = selectRow.Cells[1].Value.ToString();
            grade.Text = selectRow.Cells[2].Value.ToString();
            className.Text = selectRow.Cells[3].Value.ToString();
            day.Text = selectRow.Cells[4].Value.ToString();
            time.Text = selectRow.Cells[5].Value.ToString();
            timetableId.Text = selectRow.Cells[6].Value.ToString();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Timetable where timeTableId = '"+timetableId.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Deleted Successfully");
            reset();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Timetable set NameOfTeacher = '" + NameOfTeacher.Text + "',subject = '"+subject.Text+"',grade = '" + grade.Text + "',className ='"+className.Text+"',day = '"+day.Text+"',time = '"+time.Text+"' where timeTableId='" + timetableId.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Updated Successfully");
            reset();
        }

        private void Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TimetableResourceReport.TimetableResForm trf = new TimetableResourceReport.TimetableResForm();
            this.Hide();
            trf.ShowDialog();
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

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
