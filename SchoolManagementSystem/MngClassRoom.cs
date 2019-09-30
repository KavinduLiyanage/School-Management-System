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
    public partial class MngClassRoom : Form
    {
       

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public MngClassRoom()
        {
            InitializeComponent();
            display_details();
        }

       

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void reset()
        {
            classid.Clear();
            classname.Clear();
            grade.SelectedIndex = -1;
            capacity.Clear();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Classroom where ClassId='" + classid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Deleted Successfully");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Classroom set ClassId = '" + classid.Text + "' ,ClassName = '"+classname.Text+"',ClassCapacity='"+capacity.Text+ "',grade = '" + grade.Text + "'where ClassId='" + classid.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            display_details();
            MessageBox.Show("Updated Successfully");
            reset();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList array1 = new ArrayList();

            Boolean classidCon = true;
            Boolean classnameCon = true;
            Boolean gradeCon = true;
            Boolean capacityCon = true;

            if(classid.Text.Equals(""))
            {
                classidCon = false;
                array1.Add("Please Enter Class Id");
            }

            if (classname.Text.Equals(""))
            {
                classnameCon = false;
                array1.Add("Please Enter Class Name");
            }

            if (grade.Text.Equals(""))
            {
                gradeCon = false;
                array1.Add("Please Enter Grade");
            }

            if (capacity.Text.Equals(""))
            {
                capacityCon = false;
                array1.Add("Please Enter Class Capacity");
            }

            string arrayStr = "";
            foreach (Object obj in array1)
            {
                arrayStr = arrayStr + "\n" + obj;
            }

            if (classidCon && classnameCon && gradeCon && capacityCon )
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
            cmd.CommandText = "insert into Classroom values('" + classid.Text + "','" + classname.Text + "','" + grade.Text + "','" + capacity.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            classid.Text = "";
            classname.Text = "";
            grade.Text = "";
            capacity.Text = "";
            display_details();
            MessageBox.Show("Inserted Successfully");
            reset();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Classroom where ClassId = '" + classid.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
     
        }

        public void display_details()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Classroom";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void ResmngHome_Click(object sender, EventArgs e)
        {
            ResourceManageHome resmng = new ResourceManageHome();
            this.Hide();
            resmng.ShowDialog();
        }

        private void Addsubjectbtn_Click(object sender, EventArgs e)
        {
            ManageSubject addsub = new ManageSubject();
            this.Hide();
            addsub.ShowDialog();
        }

        private void Timetablebtn_Click(object sender, EventArgs e)
        {
            MngTimeTable mngtimetable = new MngTimeTable();
            this.Hide();
            mngtimetable.ShowDialog();
        }

        private void Viewtimetable_Click(object sender, EventArgs e)
        {
            timetableview openForm = new timetableview();
            this.Hide();
            openForm.ShowDialog();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            classid.Text = selectRow.Cells[0].Value.ToString();
            classname.Text = selectRow.Cells[1].Value.ToString();
            grade.Text = selectRow.Cells[2].Value.ToString();
            capacity.Text = selectRow.Cells[3].Value.ToString();
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

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome openForm = new TeachersHome();
            this.Hide();
            openForm.ShowDialog();
        }

        private void Capacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }

        private void Classid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Classname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            ClassroomManagementReport.ClassroomReport crr = new ClassroomManagementReport.ClassroomReport();
            this.Hide();
            crr.ShowDialog();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
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

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
