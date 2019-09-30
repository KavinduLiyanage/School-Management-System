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
    public partial class ManageStock : Form
    {
        protected string category;
        public ManageStock(String category)
        {
            InitializeComponent();
            catbox.Text = category;
            this.category = category ;
        }

        private void ManageStock_Load(object sender, EventArgs e)
        {
            loadDat();
            this.ActiveControl = dateTimePicker1;
            //Categorybox.SelectedItem = 1;
            Search();

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ',') {
                e.Handled = true;
            }
        }


        private void CodeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back & e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        public void loadDat()
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            if (category.Equals("View All Items"))
            {
                cmd.CommandText = "select * from [dbo].[stockTable]";
            }
            else {
                cmd.CommandText = "select * from [dbo].[stockTable] where [Category]='"+ category + "'";
            }
            cmd.ExecuteNonQuery();


            UsrlinkLabel.Text = GetSetInfo.userName;
            DataTable dt1 = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            ad.Fill(dt1);
            dataGridView1.DataSource = dt1;
            con.Close();

            //Total product and Total quantity
            if (dataGridView1.Rows.Count > 0)
            {
                label9.Text = dataGridView1.Rows.Count.ToString();
                float totqty = 0;
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    totqty += float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                    label10.Text = totqty.ToString();
                }
            }
            else {
                label9.Text = "0";
                label10.Text = "0";
            }
            RowColour();
        }



        private void resetRecords() {
            dateTimePicker1.Value = DateTime.Now;
            codeText.Clear();
            nametext.Clear();
            Categorybox.SelectedIndex = -1;
            quantityBox1.Clear();
            btnsave.Text = "Add";
            dateTimePicker1.Focus();
            
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            resetRecords();
        }

        //Validation function
        private bool validation()
        {
            bool result = false;
            if (string.IsNullOrEmpty(codeText.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(codeText, "Item Code Required.");
            }
            else {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(nametext.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(nametext, "Item Name Required.");
            }
            else {
                errorProvider1.Clear();
            }
            if (Categorybox.SelectedIndex == -1)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(Categorybox, "Select Category.");
            }
            else {
                errorProvider1.Clear();
            }
            if (string.IsNullOrEmpty(quantityBox1.Text))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(quantityBox1, "Quantity is Required.");
            }
            else {
                errorProvider1.Clear();
            }
           
            if (!string.IsNullOrEmpty(nametext.Text) && !string.IsNullOrEmpty(quantityBox1.Text) && Categorybox.SelectedIndex > -1)
            {
                result = true;
            }

            return result;

        }

        private bool IfProductExists(SqlConnection con, String itemCode) {
            SqlDataAdapter sda = new SqlDataAdapter("Select 2 from [dbo].[stockTable] where [ItemCode]='" + itemCode + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else {
                return false;
            }

        }

        private void Btnsave_Click_1(object sender, EventArgs e)
        {
            if (validation())
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure to add this item?", "Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
                    con.Open();
                    var sqlQuery = "";
                    if (IfProductExists(con, codeText.Text))
                    {
                        sqlQuery = @"UPDATE [dbo].[stockTable] SET [ItemName]='" + nametext.Text + "', [Category] = '" + Categorybox.Text + "' ,[Quantity] = '" + quantityBox1.Text + "' WHERE [ItemCode] = '" + codeText.Text + "'";
                    }
                    else
                    {
                        sqlQuery = @"INSERT INTO[dbo].[stockTable](ItemCode,ItemName,Category,Quantity,Date) VALUES('" + codeText.Text + "','" + nametext.Text + "','" + Categorybox.Text + "','" + quantityBox1.Text + "','" + dateTimePicker1.Value + "')";
                    }
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sqlQuery;
                    cmd.ExecuteNonQuery();
                    con.Close();
                    loadDat();

                    MessageBox.Show("Record saved successfully.");
                    errorProvider1.Clear();
                    resetRecords();
                    RowColour();
                }
            }
        }

        private void RowColour() {
            for (int i=0; i < dataGridView1.Rows.Count; i++) {
                int val = Int32.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());
                if (val <= 3) {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red; 
                }
            }
        }

        private void DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            btnsave.Text = "UPDATE";
            codeText.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            nametext.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            Categorybox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            quantityBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker1.Text = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()).ToString();
        }

        private void DateTimePicker1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                codeText.Focus();
            }
        }

        private void CodeText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                if (dgview.Rows.Count > 0)
                {
                    codeText.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                    nametext.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                    Categorybox.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                    quantityBox1.Focus();
                }
                else {
                    this.dgview.Visible = false;
                }
            }
        }


        bool change = true;
        private void ItemCode_MouseDoubleClick(object sender, MouseEventArgs e) {
            if (change) {
                change = false;
                codeText.Text = dgview.SelectedRows[0].Cells[0].Value.ToString();
                nametext.Text = dgview.SelectedRows[0].Cells[1].Value.ToString();
                Categorybox.Text = dgview.SelectedRows[0].Cells[2].Value.ToString();
                this.dgview.Visible = false;
                quantityBox1.Focus();
                change = true;
            }
        }

        private void Nametext_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (nametext.Text.Length > 0)
                {
                    Categorybox.Focus();
                }
                else
                {
                    nametext.Focus();
                }
            }
        }

        private void Categorybox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Categorybox.SelectedIndex != -1)
                {
                    quantityBox1.Focus();
                }
                else
                {
                    Categorybox.Focus();
                }
            }
        }

        private void QuantityBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (quantityBox1.Text.Length > 0)
                {
                    btnsave.Focus();
                }
                else
                {
                    quantityBox1.Focus();
                }
            }
        }

        private void CodeText_TextChanged(object sender, EventArgs e)
        {

            if (codeText.Text.Length > 0)
            {
                this.dgview.Visible = true;
                dgview.BringToFront();
                Search(550, 300, 250, 100, "Item Code,Item Name,Category", "50,100,100");
                this.dgview.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ItemCode_MouseDoubleClick);
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select top(10) ItemCode,ItemName,Category from [Items] where [ItemCode] like'" + codeText.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgview.Rows.Clear();
                foreach (DataRow row in dt.Rows)
                {
                    int n = dgview.Rows.Add();
                    dgview.Rows[n].Cells[0].Value = row["ItemCode"].ToString();
                    dgview.Rows[n].Cells[1].Value = row["ItemName"].ToString();
                    dgview.Rows[n].Cells[2].Value = row["Category"].ToString();
                }
            }
            else
            {
                dgview.Visible = false;
            }

            
            
        }

        private DataGridView dgview;
        private DataGridViewTextBoxColumn dgviewcol1;
        private DataGridViewTextBoxColumn dgviewcol2;
        private DataGridViewTextBoxColumn dgviewcol3;


        //dynamic data gridView
        void Search() {
            dgview = new DataGridView();
            dgviewcol1 = new DataGridViewTextBoxColumn();
            dgviewcol2 = new DataGridViewTextBoxColumn();
            dgviewcol3 = new DataGridViewTextBoxColumn();
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.dgviewcol1 ,
                this.dgviewcol2,this.dgviewcol3});
            this.dgview.Name = "dgview";
            dgview.Visible = false;
            this.dgviewcol1.Visible = false;
            this.dgviewcol2.Visible = false;
            this.dgviewcol3.Visible = false;
            this.dgview.AllowUserToAddRows = false;
            this.dgview.RowHeadersVisible = false;
            this.dgview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.Controls.Add(dgview);
            this.dgview.ReadOnly = true;
            dgview.BringToFront();
        }

        void Search(int LX, int LY, int DW, int DH, string colName, string colSize)
        {   //location(LX,LY) and size(DW,DH)
            this.dgview.Location = new System.Drawing.Point(LX, LY);
            this.dgview.Size = new System.Drawing.Size(DW, DH);

            string[] ClSize = colSize.Split(',');
            //size
            for (int i = 0; i < ClSize.Length; i++) {
                if (int.Parse(ClSize[i]) != 0) {
                    dgview.Columns[i].Width = int.Parse(ClSize[i]);
                }
                else {
                    dgview.Columns[i].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
                }
            }

            //name
            string[] ClName = colName.Split(',');

            for (int i = 0; i < ClName.Length; i++) {
                this.dgview.Columns[i].HeaderText = ClName[i];
                this.dgview.Columns[i].Visible = true;
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //int x = Int32.Parse(codeText.Text);
            if (validation())
            {
                DeleteStatus delete = new DeleteStatus(codeText.Text, nametext.Text, Categorybox.Text);
                delete.Show();
            }
            else {
                MessageBox.Show("Record not Exists...!");
                resetRecords() ;
            }
        }

        private void NHomeBtn_Click(object sender, EventArgs e)
        {
            HomePage1 newHome = new HomePage1();
            this.Hide();
            newHome.ShowDialog();
        }

        private void NViewLeaveBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageItem add = new ManageItem("View All Items");
            add.Show();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ManageStock mngstck = new ManageStock(category);
            this.Hide();
            mngstck.ShowDialog();
        }

        private void NViewSalaryBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeletedList list = new DeletedList();
            list.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            InventoryDashboard add = new InventoryDashboard();
            add.Show();
        }

        private void BtnLogOutHeader_Click(object sender, EventArgs e)
        {
            LoginForm log = new LoginForm();
            this.Hide();
            log.ShowDialog();
        }

        private void NStaffHomeBtn_Click(object sender, EventArgs e)
        {
            InventoryItemReportGenerate report = new InventoryItemReportGenerate();
            this.Hide();
            report.Show();

        }

        private void NAddStaffBtn_Click(object sender, EventArgs e)
        {
            InventoryProductReportGenerate report = new InventoryProductReportGenerate();
            this.Hide();
            report.Show();
        }

        private void Catbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard note = new Notice_Dashboard();
            this.Hide();
            note.Show();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome lb = new LibraryHome();
            this.Hide();
            lb.Show();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome mg = new ResourceManageHome();
            this.Hide();
            mg.Show();
        }

        private void BtnEventMHeader_Click(object sender, EventArgs e)
        {
            EventDashboard ev = new EventDashboard();
            this.Hide();
            ev.Show();
        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome st = new StudentManageHome();
            this.Hide();
            st.Show();
        }

        private void QuantityBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
