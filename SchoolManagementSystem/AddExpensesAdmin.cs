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
    public partial class AddExpense_form : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
        public AddExpense_form()
        {
            InitializeComponent();
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }
        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error has occured" + e);
                return false;
            }
        }

        public void Display_Data()
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Expenses";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

        public void Display_Combo()
        {
            comboBoxEv1.Items.Clear();
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select [Event ID] from Events where [Status]='To be held'");
            cmd.ExecuteNonQuery();
            CloseConnection();
            DataTable ddt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ddt);
            foreach (DataRow dr in ddt.Rows)
            {
                comboBoxEv1.Items.Add(dr["Event ID"]);
            }
            CloseConnection();
        }

        public void Display_ComboSearch()
        {
            comboBoxEv2.Items.Clear();
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("select [Event ID] from Events where [Status]='To be held'");
            cmd.ExecuteNonQuery();
            CloseConnection();
            DataTable ddt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(ddt);
            foreach (DataRow dr in ddt.Rows)
            {
                comboBoxEv2.Items.Add(dr["Event ID"]);
            }
            CloseConnection();
        }

        private void ResetRecords()
        {

            textBoxdet.Clear();
            textBoxAmt.Clear();
        }

        int ExpenseID;
        private void ViewEx_click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectRow = dataGridView1.Rows[index];
            ExpenseID = Int32.Parse(selectRow.Cells[0].Value.ToString());
            comboBoxEv1.SelectedItem = selectRow.Cells[1].Value;
            textBoxdet.Text = selectRow.Cells[2].Value.ToString();
            textBoxAmt.Text = selectRow.Cells[3].Value.ToString();

        }

        private void AddExpense_form_Load(object sender, EventArgs e)
        {
            Display_Data();
            Display_Combo();
            Display_ComboSearch();
        }

        private void back_e_click(object sender, EventArgs e)
        {
            EventDashboard form_back = new EventDashboard();
            this.Hide();
            form_back.Show();
        }

        private void AddEx_click(object sender, EventArgs e)
        {
            ArrayList errors = new ArrayList();
            Boolean eventID = true;
            Boolean details = true;
            Boolean amount = true;

            if (comboBoxEv1.SelectedIndex == -1)
            {
                eventID = false;
                errors.Add("please Add EventID");

            }
            if (textBoxdet.Text.Equals(""))
            {
                details = false;
                errors.Add("please add details");
            }
            if (textBoxAmt.Text.Equals(""))
            {
                amount = false;
                errors.Add("please add amount");
            }

            string errorArr = "";
            foreach (Object ob in errors)
            {
                errorArr = errorArr + "\n" + ob;
            }
            if (eventID && details && amount)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = ("set IDENTITY_INSERT ON");
                cmd.CommandText = ("insert into Expenses([Event Id],[Details],[Amount]) values ('" + comboBoxEv1.SelectedItem + "','" + textBoxdet.Text + "','" + textBoxAmt.Text + "')");
                cmd.ExecuteNonQuery();
                CloseConnection();
                ResetRecords();



                DialogResult dResult = MessageBox.Show("Add more Expenses", "Record Inserted Successfully", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dResult == DialogResult.Yes)
                {
                    AddExpense_form AddExpense = new AddExpense_form();
                    this.Hide();
                    AddExpense.Show();
                }
            }
            else
            {
                MessageBox.Show(errorArr);
            }
        }

        private void ViewEx_click(object sender, EventArgs e)
        {
            Display_Data();
        }

        private void deleteEx_click(object sender, EventArgs e)
        {
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Delete?", "Delete!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dResult == DialogResult.Yes)
            {
                OpenConnection();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "delete from Expenses where [Expense Id]= '" + ExpenseID + "'";
                cmd.ExecuteNonQuery();
                CloseConnection();
                ResetRecords();
                MessageBox.Show("Deleted Succesfully");
            }
        }

        private void UpdateEx_click(object sender, EventArgs e)
        {
            ArrayList errors = new ArrayList();
            Boolean eventID = true;
            Boolean details = true;
            Boolean amount = true;

            if (comboBoxEv1.SelectedIndex == -1)
            {
                eventID = false;
                errors.Add("please Add EventID");

            }
            if (textBoxdet.Text.Equals(""))
            {
                details = false;
                errors.Add("please add details");
            }
            if (textBoxAmt.Text.Equals(""))
            {
                amount = false;
                errors.Add("please add amaount");
            }

            string errorArr = "";
            foreach (Object ob in errors)
            {
                errorArr = errorArr + "\n" + ob;
            }
            DialogResult dResult = MessageBox.Show("Are You Sure You Want To Update?", "Update!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dResult == DialogResult.Yes)
            {
                if (eventID && details && amount)
                {
                    OpenConnection();
                    SqlCommand cmd = conn.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = ("update Expenses set [Event Id]='" + comboBoxEv1.SelectedItem + "', [Details] ='" + textBoxdet.Text + "',[Amount]='" + textBoxAmt.Text + "' where [Expense Id]='" + ExpenseID + "'");
                    cmd.ExecuteNonQuery();
                    CloseConnection();
                    ResetRecords();
                    MessageBox.Show("Updated Succesfully");
                }
                else
                {
                    MessageBox.Show(errorArr);
                }
            }

        }

        private void SearchEx_click(object sender, EventArgs e)
        {
            OpenConnection();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Expenses where  [Event Id]='" + comboBoxEv2.SelectedItem + "' ";

            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            CloseConnection();
        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void ExpenseAmt_keypress(object sender, KeyPressEventArgs e)
        {

        }

        private void GenerateEventReport_click(object sender, EventArgs e)
        {
            YearlyEventReport.YearlyEventReport evRepo = new YearlyEventReport.YearlyEventReport();
            this.Hide();
            evRepo.Show();
        }

        private void Expense_keypress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            TeachersHome home = new TeachersHome();
            this.Hide();
            home.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CreateStudentAccount creAcc = new CreateStudentAccount();
            this.Hide();
            creAcc.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            InventoryDashboard inveDash = new InventoryDashboard();
            this.Hide();
            inveDash.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ResourceManageHome newres = new ResourceManageHome();
            this.Hide();
            newres.ShowDialog();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            LibraryHome libHome = new LibraryHome();
            this.Hide();
            libHome.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.Show();
        }
    }
}
