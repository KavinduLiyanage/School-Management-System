using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class HomePage3 : Form
    {
        public HomePage3()
        {
            InitializeComponent();
        }

        private void HomePage3_Load(object sender, System.EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.username;
        }

        private void DomainUpDown1_SelectedItemChanged(object sender, System.EventArgs e)
        {

        }

        private void MngExmBtn_Click(object sender, System.EventArgs e)
        {
            StudentExam seh = new StudentExam();
            this.Hide();
            seh.ShowDialog();
        }

        private void MngLibImgBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            StudentAppointment sappointment = new StudentAppointment();
            sappointment.ShowDialog();
        }

        private void MngLibBtn_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            StudentAppointment sappointment = new StudentAppointment();
            sappointment.ShowDialog();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            ViewStudentMarks vsm = new ViewStudentMarks();
            vsm.ShowDialog();
        }

        private void Button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            ViewStudentMarks vsm = new ViewStudentMarks();
            vsm.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, System.EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, System.EventArgs e)
        {
            HomePage3 newHome = new HomePage3();
            this.Hide();
            newHome.ShowDialog();
        }
    }
}
