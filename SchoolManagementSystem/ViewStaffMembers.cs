using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SchoolManagementSystem
{
    public partial class ViewStaffMembers : Form
    {
        int staffID;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public ViewStaffMembers()
        {
            InitializeComponent();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 home = new HomePage1();
            this.Hide();
            home.ShowDialog();
        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            AddStaffMember newStaffPage = new AddStaffMember();
            this.Hide();
            newStaffPage.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome adminHome = new AdminMngStaffHome();
            this.Hide();
            adminHome.ShowDialog();
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            ViewStaffMembers newViewStaff = new ViewStaffMembers();
            this.Hide();
            newViewStaff.ShowDialog();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ViewSalaryInfo newViewSalary = new ViewSalaryInfo();
            this.Hide();
            newViewSalary.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ViewStaffLeaves newStffLeave = new ViewStaffLeaves();
            this.Hide();
            newStffLeave.ShowDialog();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where name like '%"+ searchTextBox1.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void ViewStaffMembers_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
            this.displayData();
            GetSetInfo.getSubject(subTextBox1);
            GetSetInfo.getSubject(subTextBox2);
        }

        private void displayData() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM staff";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void NonAcedemicRadio_CheckedChanged(object sender, EventArgs e)
        {
            //nonAcedemicRadio
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            staffID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            string memType = selectRow.Cells[1].Value.ToString();

            if (memType.Equals("Acedemic"))
            {
                adedemicRadio.Checked = true;
            }
            else if (memType.Equals("Non-Acedemic"))
            {
                nonAcedemicRadio.Checked = true;
            }
            string accLvl = selectRow.Cells[2].Value.ToString();

            if (accLvl.Equals("Admin"))
            {
                adminRadio.Checked = true;
            }
            else if (accLvl.Equals("User"))
            {
                userRadio.Checked = true;
            }

            NametextBox1.Text = selectRow.Cells[3].Value.ToString();
            nameTextBox2.Text = selectRow.Cells[4].Value.ToString();

            string gender = selectRow.Cells[5].Value.ToString();

            if (gender.Equals("Male"))
            {
                maleRadioButton2.Checked = true;
            }
            else if (gender.Equals("Female"))
            {
                femaleRadioButton1.Checked = true;
            }

            NICTextBox.Text = selectRow.Cells[6].Value.ToString();

            string date = selectRow.Cells[7].Value.ToString();
            try
            {
                DateTime oDate = Convert.ToDateTime(date);
                dateTimePicker1.Value = new System.DateTime(oDate.Year, oDate.Month, oDate.Day, 0, 0, 0, 0);
            }
            catch (Exception) {
                DateTime newdate = DateTime.Now;
                dateTimePicker1.Value = new System.DateTime(newdate.Year, newdate.Month, newdate.Day, 0, 0, 0, 0);
            }

            addressTextBox.Text = selectRow.Cells[8].Value.ToString();
            phNoTextBox.Text = selectRow.Cells[9].Value.ToString();
            emailTextBox1.Text = selectRow.Cells[10].Value.ToString();
            subTextBox1.Text = selectRow.Cells[11].Value.ToString();
            pastSchTextBox.Text = selectRow.Cells[12].Value.ToString();
            serviceYrsTextBox.Text = selectRow.Cells[13].Value.ToString();
            salaryTextBox.Text = selectRow.Cells[15].Value.ToString();


            pwdtextBox2.Text = selectRow.Cells[16].Value.ToString();
            ConfirmPwdtextBox2.Text = selectRow.Cells[16].Value.ToString();
            subTextBox2.Text = selectRow.Cells[17].Value.ToString();
        }

        private void SearchTextBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff where name like '%" + searchTextBox1.Text + "%' ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void updateBtnOperation()
        {
            string memberTypeValue = "";
            bool memberTypeisChecked = adedemicRadio.Checked;
            if (memberTypeisChecked)
            {
                memberTypeValue = adedemicRadio.Text;
            }
            else
            {
                memberTypeValue = nonAcedemicRadio.Text;
            }

            string accessLevelValue = "";
            bool accessLevelisChecked = adminRadio.Checked;
            if (accessLevelisChecked)
                accessLevelValue = adminRadio.Text;
            else
                accessLevelValue = userRadio.Text;

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
                cmd.CommandText = "UPDATE staff SET memberType = '" + memberTypeValue + "',accessLevel = '" + accessLevelValue + "',fullName = '" + NametextBox1.Text + "',name = '" + nameTextBox2.Text + "',gender = '" + genderValue + "',NIC = '" + NICTextBox.Text + "',DOB = '" + dateTimePicker1.Value + "',address = '" + addressTextBox.Text + "',phoneNo = '" + phNoTextBox.Text + "',email = '" + emailTextBox1.Text + "',subject = '" + subTextBox1.Text + "',pastSchool = '" + pastSchTextBox.Text + "',serviceYears = '" + Int32.Parse(serviceYrsTextBox.Text) + "',salary = '" + Convert.ToDouble(salaryTextBox.Text) + "',password = '" + pwdtextBox2.Text + "',subject2 = '" + subTextBox2.Text + "' WHERE staffID = '" + staffID + "'";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Updated Succesfully");

                ViewStaffMembers viewStaff = new ViewStaffMembers();
                this.Hide();
                viewStaff.ShowDialog();
            }
        }

        private void SearchTextBox1_Click(object sender, EventArgs e)
        {
            searchTextBox1.Text = "";
            searchTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string memberTypeValue = "";
            bool memberTypeisChecked = adedemicRadio.Checked;
            if (memberTypeisChecked)
            {
                memberTypeValue = adedemicRadio.Text;
            }
            else if (nonAcedemicRadio.Checked)
            {
                memberTypeValue = nonAcedemicRadio.Text;
            }

            string accessLevelValue = "";
            bool accessLevelisChecked = adminRadio.Checked;
            if (accessLevelisChecked)
                accessLevelValue = adminRadio.Text;
            else if (userRadio.Checked)
                accessLevelValue = userRadio.Text;

            string genderValue = "";
            bool genderisChecked = maleRadioButton2.Checked;
            if (genderisChecked)
                genderValue = maleRadioButton2.Text;
            else if (femaleRadioButton1.Checked)
                genderValue = femaleRadioButton1.Text;

            ArrayList errorArr1 = new ArrayList();

            Boolean memTypeCon = true;
            Boolean accessLevelCon = true;
            Boolean genderCon = true;
            Boolean fullNameCon = true;
            Boolean nameCon = true;
            Boolean nicCon = true;
            Boolean addCon = true;
            Boolean addressCon = true;
            Boolean salaryCon = true;
            Boolean phNoCon = true;
            Boolean mailCon = true;
            Boolean pwdEqlPwd = true;


            if (memberTypeValue.Equals(""))
            {
                memTypeCon = false;
                errorArr1.Add("Please Choose Member Type!");
            }

            if (accessLevelValue.Equals(""))
            {
                accessLevelCon = false;
                errorArr1.Add("Please Choose Member Type!");
            }

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

            if ((pwdtextBox2.Text != ConfirmPwdtextBox2.Text) || pwdtextBox2.Text.Equals("") || ConfirmPwdtextBox2.Text.Equals(""))
            {
                pwdEqlPwd = false;
                errorArr1.Add("Please Check Password!");
                pwdtextBox2.Text = "";
                ConfirmPwdtextBox2.Text = "";
            }

            string arrayStr = "";
            foreach (Object obj in errorArr1)
            {
                arrayStr = arrayStr + "\n" + obj;
            }

            if (pwdEqlPwd && memTypeCon && accessLevelCon && genderCon && fullNameCon && nameCon && nicCon && addCon && addressCon && salaryCon && phNoCon && mailCon)
            {
                this.updateBtnOperation();
            }
            else
            {
                MessageBox.Show(arrayStr);
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlgResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlgResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                string memberTypeValue = "";
                bool memberTypeisChecked = adedemicRadio.Checked;
                if (memberTypeisChecked)
                {
                    memberTypeValue = adedemicRadio.Text;
                }
                else
                {
                    memberTypeValue = nonAcedemicRadio.Text;
                }

                string accessLevelValue = "";
                bool accessLevelisChecked = adminRadio.Checked;
                if (accessLevelisChecked)
                    accessLevelValue = adminRadio.Text;
                else
                    accessLevelValue = userRadio.Text;

                string genderValue = "";
                bool genderisChecked = maleRadioButton2.Checked;
                if (genderisChecked)
                    genderValue = maleRadioButton2.Text;
                else
                    genderValue = femaleRadioButton1.Text;

                cmd.CommandText = "INSERT INTO pastStaff(staffID,memberType,accessLevel,fullName,name,gender,NIC,DOB,address,phoneNo,email,subject,pastSchool,serviceYears,salary,password,subject2) VALUES('"+ staffID + "','" + memberTypeValue + "','" + accessLevelValue + "','" + NametextBox1.Text + "','" + nameTextBox2.Text + "','" + genderValue + "','" + NICTextBox.Text + "','" + dateTimePicker1.Value + "','" + addressTextBox.Text + "','" + phNoTextBox.Text + "','" + emailTextBox1.Text + "','" + subTextBox1.Text + "','" + pastSchTextBox.Text + "','" + Int32.Parse(serviceYrsTextBox.Text) + "','" + Convert.ToDouble(salaryTextBox.Text) + "','" + NICTextBox.Text + "','" + subTextBox2.Text + "')";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "delete from staff where staffID = '" + staffID + "'";
                cmd.ExecuteNonQuery();
                con.Close();
            }

            ViewStaffMembers viewStaff = new ViewStaffMembers();
            this.Hide();
            viewStaff.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
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

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {

        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {

        }
    }
}
