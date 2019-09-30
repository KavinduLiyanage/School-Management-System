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
    public partial class TeacherMyProfile : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public TeacherMyProfile()
        {
            InitializeComponent();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {

        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            TeacherMyProfile tchrProfile = new TeacherMyProfile();
            this.Hide();
            tchrProfile.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage2 newHome = new HomePage2();
            this.Hide();
            newHome.ShowDialog();
        }

        private void TeacherMyProfile_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where staffID = '"+GetSetInfo.getsetusrId+"' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            foreach (DataRow dr in dt.Rows)
            {
                UsrlinkLabel.Text = dr["name"].ToString();
                linkLabel1.Text = dr["name"].ToString();
                NametextBox1.Text = dr["fullName"].ToString();
                nameTextBox2.Text = dr["name"].ToString();

                string gender = dr["gender"].ToString();

                if (gender.Equals("Male"))
                {
                    maleRadioButton2.Checked = true;
                }
                else if (gender.Equals("Female"))
                {
                    femaleRadioButton1.Checked = true;
                }

                NICTextBox.Text = dr["NIC"].ToString();

                string date = dr["DOB"].ToString();
                try
                {
                    DateTime oDate = Convert.ToDateTime(date);
                    dateTimePicker1.Value = new System.DateTime(oDate.Year, oDate.Month, oDate.Day, 0, 0, 0, 0);
                }
                catch (Exception)
                {
                    DateTime newdate = DateTime.Now;
                    dateTimePicker1.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
                }

                addressTextBox.Text = dr["address"].ToString();
                phNoTextBox.Text = dr["phoneNo"].ToString();
                emailTextBox1.Text = dr["email"].ToString();
                subTextBox1.Text = dr["subject"].ToString();
                pastSchTextBox.Text = dr["pastSchool"].ToString();
                serviceYrsTextBox.Text = dr["serviceYears"].ToString();
                salaryTextBox.Text = dr["salary"].ToString();
                subTextBox2.Text = dr["subject2"].ToString();
            }

        }

        private void UpdateStaffBtn_Click(object sender, EventArgs e)
        {

            string genderValue = "";
            bool genderisChecked = maleRadioButton2.Checked;
            if (genderisChecked)
                genderValue = maleRadioButton2.Text;
            else if (femaleRadioButton1.Checked)
                genderValue = femaleRadioButton1.Text;

            ArrayList errorArr1 = new ArrayList();
            Boolean genderCon = true;
            Boolean fullNameCon = true;
            Boolean nameCon = true;
            Boolean nicCon = true;
            Boolean addCon = true;
            Boolean addressCon = true;
            Boolean salaryCon = true;
            Boolean phNoCon = true;
            Boolean mailCon = true;

            if (NametextBox1.Text.Equals(""))
            {
                fullNameCon = false;
                errorArr1.Add("Please Enter Full Name!");
            }

            if (nameTextBox2.Text.Equals(""))
            {
                nameCon = false;
                errorArr1.Add("Please Enter Name with Initials!");
            }

            if (genderValue.Equals(""))
            {
                genderCon = false;
                errorArr1.Add("Please Choose a Gender!");
            }

            if (NICTextBox.Text.Equals(""))
            {
                nicCon = false;
                errorArr1.Add("Please Enter NIC Number!");
            }

            if (addressTextBox.Text.Equals(""))
            {
                addCon = false;
                errorArr1.Add("Please Enter Address!");
            }

            if (salaryTextBox.Text.Equals(""))
            {
                salaryCon = false;
                errorArr1.Add("Please Enter Salary!");
            }

            if (phNoTextBox.Text.Equals(""))
            {
                phNoCon = false;
                errorArr1.Add("Please Enter a Phone Number!");
            }

            if (emailTextBox1.Text.Equals(""))
            {
                mailCon = false;
                errorArr1.Add("Please Enter a Email Address!");
            }

            string arrayStr = "";
            foreach (Object obj in errorArr1)
            {
                arrayStr = arrayStr + "\n" + obj;
            }

            if (genderCon && fullNameCon && nameCon && nicCon && addCon && addressCon && salaryCon && phNoCon && mailCon)
            {
                this.updateBtnOperation();
            }
            else
            {
                MessageBox.Show(arrayStr);
            }
        }

        private void updateBtnOperation()
        {

            string genderValue = "";
            bool genderisChecked = maleRadioButton2.Checked;
            if (genderisChecked)
                genderValue = maleRadioButton2.Text;
            else
                genderValue = femaleRadioButton1.Text;

            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Update?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE staff SET fullName = '" + NametextBox1.Text + "',name = '" + nameTextBox2.Text + "',gender = '" + genderValue + "',NIC = '" + NICTextBox.Text + "',DOB = '" + dateTimePicker1.Value + "',address = '" + addressTextBox.Text + "',phoneNo = '" + phNoTextBox.Text + "',email = '" + emailTextBox1.Text + "',subject = '" + subTextBox1.Text + "',pastSchool = '" + pastSchTextBox.Text + "',serviceYears = '" + Int32.Parse(serviceYrsTextBox.Text) + "',salary = '" + Convert.ToDouble(salaryTextBox.Text) + "',subject2 = '" + subTextBox2.Text + "' WHERE staffID = '" + GetSetInfo.getsetusrId + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                GetSetInfo.userName = nameTextBox2.Text;

                MessageBox.Show("Updated Succesfully");

                TeacherMyProfile teacherMyProfile = new TeacherMyProfile();
                this.Hide();
                teacherMyProfile.ShowDialog();
            }
        }

        private void NametextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void NReqLeaveBtn_Click(object sender, EventArgs e)
        {
            StaffReqLeave reqLeave = new StaffReqLeave();
            this.Hide();
            reqLeave.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            StaffMngReport.SalaryReportForm salary = new StaffMngReport.SalaryReportForm();
            this.Hide();
            salary.ShowDialog();
        }
    }
}
