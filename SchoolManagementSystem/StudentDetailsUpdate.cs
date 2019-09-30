using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using DAO;
using Models;
using System.Data.Entity;

namespace SchoolManagementSystem
{
    public partial class StudentDetailsUpdate : Form
    {
        protected int sss;

        Student student1 = new Student();

        public StudentDetailsUpdate(int sid)
        {
            InitializeComponent();
            sss = sid;
            
        }
        
        private void StudentDetailsUpdate_Load_1(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.userName;
            using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
            {
                student1 = db.Students.Where(x => x.SID == sss).FirstOrDefault();
        
                txtName.Text = student1.SNAME;
                txtAddress.Text = student1.SADDRESS;
                txtEmail.Text = student1.SEMAIL;
                txtGDName.Text = student1.SGDNAME;
                txtGDContact.Text = student1.SGDCONTACT;
                dateTimePickerDOB.Value = (DateTime)student1.SDOB;
                comboBoxGrade.Text = student1.Grade;
                comboBoxClass.Text = student1.ClassName;              
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void Update()
        {
            student1.SNAME = txtName.Text.Trim();
           
            student1.SADDRESS = txtAddress.Text.Trim();
            student1.SEMAIL = txtEmail.Text.Trim();
            student1.SGDNAME = txtGDName.Text.Trim();
            student1.SGDCONTACT = txtGDContact.Text.Trim();
            student1.SDOB = dateTimePickerDOB.Value;
            student1.Grade = comboBoxGrade.Text.Trim();
            student1.ClassName = comboBoxClass.Text.Trim();
            
            using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
            {                               
                if (student1.SID == 0)     
                    db.Students.Add(student1);
                   
                else
                    db.Entry(student1).State = EntityState.Modified;

                db.SaveChanges();
            }
            MessageBox.Show("Student Details Updated Sucessfully");
            this.Hide();
            StudentList slist = new StudentList();
            slist.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void delete()
        {
            if (MessageBox.Show("Are You Sure to Delete this Account?", "EF CRUD Operetion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SchoolManagementSystemDBEntities db = new SchoolManagementSystemDBEntities())
                {
                    var entry = db.Entry(student1);
                    if (entry.State == EntityState.Detached)
                        db.Students.Attach(student1);
                    db.Students.Remove(student1);
                    db.SaveChanges();
                    MessageBox.Show("Student Account Deleted Sucessfully");
                    this.Hide();
                    StudentList slist = new StudentList();
                    slist.ShowDialog();

                }
            }
        }

        private void NViewStudentBtn_Click(object sender, EventArgs e)
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
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }
    }
}
