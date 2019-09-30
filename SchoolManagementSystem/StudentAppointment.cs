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
    public partial class StudentAppointment : Form
    {
        public StudentAppointment()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            try
            {
                var appointment = new AppointmentModel
                {
                    TeacherName = txtTName.Text.Trim(),
                    Reason = txtReason.Text.Trim(),
                    ADate = YearPicker.Value
                    
                };

                ValidationContext context = new ValidationContext(appointment);

                List<ValidationResult> errorList = new List<ValidationResult>();

                var error = string.Empty;

                if (!Validator.TryValidateObject(appointment, context, errorList, true))
                {
                    foreach (ValidationResult result1 in errorList)
                    {
                        error = error + result1.ErrorMessage + "\r\n";
                    }
                    MessageBox.Show(error);
                    return;
                }

                var data = new AppointmentData();
                bool result = data.SaveAppointment(appointment);
                if (result)
                {
                    MessageBox.Show("Appointment place Sucessfully");
                    this.Hide();
                    HomePage3 h3 = new HomePage3();
                    h3.ShowDialog();


                }
                else
                {
                    MessageBox.Show("Appointment place unsucessfully");
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage3 h3 = new HomePage3();
            h3.ShowDialog();
        }

        private void NAddStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewStudentMarks vsm = new ViewStudentMarks();
            vsm.ShowDialog();
        }

        private void NViewStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAppointment sappointment = new StudentAppointment();
            sappointment.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentAppointmentEdit sappointmentedit = new StudentAppointmentEdit();
            sappointmentedit.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void StudentAppointment_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
        }
    }
}
