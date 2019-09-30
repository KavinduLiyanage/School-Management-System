using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class StudentExam : Form
    {
        public StudentExam()
        {
            InitializeComponent();
        }

        private void BtnStudentViewTT_Click(object sender, EventArgs e)
        {
            StudentViewExamTimetable stvtt = new StudentViewExamTimetable();
            this.Hide();
            stvtt.ShowDialog();
        }

        private void BtnStudentViewTimetableSH_Click(object sender, EventArgs e)
        {
            StudentViewExamTimetable stvtt = new StudentViewExamTimetable();
            this.Hide();
            stvtt.ShowDialog();
        }

        private void BtnStudentHome_Click(object sender, EventArgs e)
        {

            HomePage3 hp3 = new HomePage3();
            this.Hide();
            hp3.ShowDialog();
        }
    }
}
