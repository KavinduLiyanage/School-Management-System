using System;
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
    public partial class DeletedList : Form
    {
        public DeletedList()
        {
            InitializeComponent();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem add = new ManageItem("View All Items");
            add.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryDashboard add = new InventoryDashboard();
            add.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem item = new ManageItem("View All Items");
            item.Show();
        }

        private void DeletedList_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [dbo].[DeletedStatus]";
            cmd.ExecuteNonQuery();
            DataTable dt1 = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();

            if (dataGridView1.Rows.Count > 0)
            {
                label9.Text = dataGridView1.Rows.Count.ToString();
                
            }
            else
            {
                label9.Text = "0";
            }
            UsrlinkLabel.Text = GetSetInfo.userName;
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void UsrlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
