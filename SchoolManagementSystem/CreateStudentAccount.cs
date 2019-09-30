using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using Models;

namespace SchoolManagementSystem
{
    public partial class CreateStudentAccount : Form
    {
        public CreateStudentAccount()
        {
            InitializeComponent();
        }

        private void Save()
        {
            try
            {
                var student = new StudentModel()
                {
                    SName = txtName.Text.Trim(),
                    SEmail = txtEmail.Text.Trim(),
                    SAddress = txtAddress.Text.Trim(),
                    SGDName = txtGDName.Text.Trim(),
                    SGDContact = txtGDContact.Text.Trim(),
                    SDob = dateTimePickerDOB.Value,
                    SGender = gender,
                    SGrade = comboBoxGrade.Text.Trim(),
                    SClass = comboBoxClass.Text.Trim()

                };

                ValidationContext context = new ValidationContext(student);

                List<ValidationResult> errorList = new List<ValidationResult>();

                var error = string.Empty;

                if(!Validator.TryValidateObject(student, context, errorList, true))
                {
                    foreach(ValidationResult result1 in errorList)
                    {
                        error = error + result1.ErrorMessage + "\r\n";
                    }
                    MessageBox.Show(error);
                    return;
                }

                var data = new StudentData();
                bool result = data.SaveStudent(student);
                if(result)
                {
                    MessageBox.Show("Student Account Added Sucessfully");
                    this.Hide();
                    StudentList slist = new StudentList();
                    slist.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Student Account Added unsucessfully");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void Clear()
        {
            txtName.Text = txtAddress.Text = txtEmail.Text = txtGDName.Text = txtGDContact.Text = "";
        }


        private void BtnSubmit_Click_1(object sender, EventArgs e)
        {
            Save();
        }

        private void TableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Clear();
        }

        string gender;
        private void RbtnMale_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void RbtnFemale_CheckedChanged_1(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
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
            //Redirect to Login Form
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateStudentAccount_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
