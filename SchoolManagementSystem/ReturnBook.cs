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
    public partial class ReturnBook : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public ReturnBook()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ContentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Load(object sender, EventArgs e)
        {
            UsrlinkLabel.Text = GetSetInfo.username;
            if (con.State==ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
        }

        public void fill_grid(string studentName)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from book_issue where SNAME ='" + studentName.ToString() + "'and book_return_date is NULL ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            fill_grid(textBox1.Text);
            panel2.Visible = true;
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            panel3.Visible = true;
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from book_issue where Id="+i+"";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                lbl_booksName.Text = dr["books_name"].ToString();
                lbl_issueDate.Text = Convert.ToString(dr["book_issue_date"].ToString());
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update book_issue set book_return_date='"+dateTimePicker1.Value.ToString()+"'where Id=" + i + "";
            cmd.ExecuteNonQuery();

            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update books_info set available_qty=available_qty+1 where books_name='" + lbl_booksName.Text + "'";
            cmd1.ExecuteNonQuery();

            MessageBox.Show("Books Return Successfully");

            panel3.Visible = true;

            fill_grid(textBox1.Text);
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            LibraryAddBook add = new LibraryAddBook();
            this.Hide();
            add.ShowDialog();
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

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            ReportBooks report = new ReportBooks();
            this.Hide();
            report.ShowDialog();
        }
    }
}
