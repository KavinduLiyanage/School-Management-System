using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace SchoolManagementSystem
{
    public partial class LibraryAddBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public LibraryAddBook()
        {
            InitializeComponent();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.username;
        }

        private void LibAddBook() {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into books_info values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox8.Text + "','" + textBox4.Text + "','" + textBox5.Text + "'," + Int32.Parse(textBox6.Text) + "," + Convert.ToDouble(textBox7.Text) + "," + Int32.Parse(textBox6.Text) + ")";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added Successfully");
            con.Close();
            textBox1.Text = ""; textBox2.Text = ""; textBox3.Text = ""; textBox8.Text = ""; textBox4.Text = ""; textBox5.Text = ""; textBox6.Text = ""; textBox7.Text = "";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ArrayList errorArr1 = new ArrayList();

            Boolean bookidcon = true;
            Boolean booknamecon = true;
            Boolean bookisbncon = true;
            Boolean bookauthorcon = true;
            Boolean bookeditioncon = true;
            Boolean bookpublishercon = true;
            Boolean bookquantitycon = true;
            Boolean bookpricecon = true;

            if(textBox1.Text.Equals(""))
            {
                bookidcon = false;
                errorArr1.Add("Please Enter Book ID");
            }

            if(textBox2.Text.Equals(""))
            {
                booknamecon = false;
                errorArr1.Add("Please Enter Book Name");
            }

            if (textBox3.Text.Equals(""))
            {
                bookisbncon = false;
                errorArr1.Add("Please Enter Book Name");
            }

            if(textBox8.Text.Equals(""))
            {
                bookauthorcon = false;
                errorArr1.Add("Please Enter Valid ISBN ");
            }

            if (textBox4.Text.Equals(""))
            {
                bookeditioncon = false;
                errorArr1.Add("Please Enter Book Edition ");
            }

            if (textBox5.Text.Equals(""))
            {
                bookpublishercon = false;
                errorArr1.Add("Please Enter Book Publisher ");
            }

            if (textBox6.Text.Equals(""))
            {
                bookquantitycon = false;
                errorArr1.Add("Please Enter Valid Quantity ");
            }
             
            if (textBox7.Text.Equals(""))
            {
                bookpricecon = false;
                errorArr1.Add("Please Enter Valid Price ");
            }

            string arrayStr = "";
            foreach(Object obj in errorArr1)
            {
                arrayStr = arrayStr + "\n" + obj;
            }

            if(bookidcon && booknamecon && bookisbncon && bookauthorcon && bookeditioncon && bookpublishercon && bookquantitycon && bookpricecon)
            {
                this.LibAddBook();
            }
            else
            {
                MessageBox.Show(arrayStr);
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            AdminMngStaffHome mngStaff = new AdminMngStaffHome();
            this.Hide();
            mngStaff.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard newdash = new Notice_Dashboard();
            this.Hide();
            newdash.ShowDialog();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard eveDash = new EventDashboard();
            this.Hide();
            eveDash.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
           TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
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

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            LibrarySearchBook lsbook = new LibrarySearchBook();
            this.Hide();
            lsbook.ShowDialog();
        }

        private void NViewStaffBtn_Click(object sender, EventArgs e)
        {
            IssueBook issue = new IssueBook();
            this.Hide();
            issue.ShowDialog();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            ReturnBook rtn = new ReturnBook();
            this.Hide();
            rtn.ShowDialog();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void TextBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

           }
        }

        private void TextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox3_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void TextBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))

            {
                e.Handled = true;

            }
        }

        private void TextBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

            }
        }

        private void TextBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))

            {
                e.Handled = true;

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "732";
            textBox2.Text = "Famous Five";
            textBox3.Text = "WV-732";
            textBox8.Text = "Enid Blyton";
            textBox4.Text = "5th";
            textBox5.Text = "Hodder";
            textBox6.Text = "10";
            textBox7.Text = "3500";

        }
    }
}
