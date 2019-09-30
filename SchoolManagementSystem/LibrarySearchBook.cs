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

namespace SchoolManagementSystem
{
    public partial class LibrarySearchBook : Form
    {
        private int i;
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public LibrarySearchBook()
        {
            InitializeComponent();
        }

        private void LibrarySearchBook_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.username;
            display_books();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%"+ textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            int i = 0;
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where books_name like('%" + textBox1.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());

                dataGridView1.DataSource = dt;

                con.Close();

                if(i==0)
                {
                    MessageBox.Show("No books found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel4.Visible = true;

            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info where id=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
               
                foreach(DataRow dr in dt.Rows)
                {
                    textBox2.Text = dr["books_name"].ToString();
                    textBox3.Text = dr["books_isbn"].ToString();
                    textBox4.Text = dr["books_author"].ToString();
                    textBox5.Text = dr["books_edition"].ToString();
                    textBox6.Text = dr["books_publisher"].ToString();
                    textBox7.Text = dr["books_quantity"].ToString();

                }


                con.Close();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());

            try

            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update books_info set books_name='"+textBox2.Text+"',books_isbn='"+textBox3.Text+"',books_author='"+textBox4.Text+"',books_edition='"+textBox5.Text+"',books_publisher='"+textBox6.Text+"',books_quantity='"+textBox7.Text+"'where id ="+i+"";
                cmd.ExecuteNonQuery();
                con.Close();
                display_books();
                MessageBox.Show("Record updated Successfully");
                panel4.Visible = false;

                LibrarySearchBook lib = new LibrarySearchBook();
                this.Hide();
                lib.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void display_books()
        {
            try
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from books_info";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from books_info where Id="+i+"";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Deleted Successfully");
            LibrarySearchBook lib = new LibrarySearchBook();
            this.Hide();
            lib.ShowDialog();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            LibraryAddBook add = new LibraryAddBook();
            this.Hide();
            add.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
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

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
