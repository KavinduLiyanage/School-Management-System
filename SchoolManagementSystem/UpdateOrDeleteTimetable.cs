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
    public partial class UpdateOrDeleteTimetable : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public UpdateOrDeleteTimetable()
        {
            InitializeComponent();
        }

        private void BtnTeachersHomeUDTT_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksUDTT_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksUDTT_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnUpdateDeleteUDTT_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks ud = new UpdateORDeleteMarks();
            this.Hide();
            ud.ShowDialog();
        }

        private void BtnStudentResultSheetUDTT_Click(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetUDTT_Click(object sender, EventArgs e)
        {
            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetUDTT_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableUDTT_Click(object sender, EventArgs e)
        {
            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void BtnGetTimetableUDTT_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnViewUDTT_Click(object sender, EventArgs e)
        {
            ViewTimetable viewtble = new ViewTimetable();
            this.Hide();
            viewtble.ShowDialog();
        }

        private void UpdateOrDeleteTimetable_Load(object sender, EventArgs e)
        {
            FillSubjectCombo();
        }

        private void BtnUpdateUDTT_Click(object sender, EventArgs e)
        {
            if (cbTerm.Text == "" || tbStartTime.Text == "" || tbTimeTablID.Text == "" || cbGrade.Text == "" || cbSubject.Text == "")
            {
                errorProvider1.SetError(tbStartTime, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(tbTimeTablID, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(cbTerm, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(cbGrade, "Please fill the empty Areas!!!!");
                MessageBox.Show("Please fill the empty Areas!!!!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }
            con.Open();

            SqlCommand check = new SqlCommand("SELECT * FROM ExamTimeTable WHERE Grade = '" + cbGrade.Text + "' AND Subject = '" + cbSubject.Text + "' AND Term = '" + cbTerm.Text + "' AND Date =  '" + dateTimePicker1.Value + "' AND StartTime = '" + tbStartTime.Text + "' ", con);
            SqlDataAdapter checkDa = new SqlDataAdapter(check);
            DataSet ds = new DataSet();
            checkDa.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                errorProvider1.SetError(cbTerm, "This already Exist!!!!");
                errorProvider1.SetError(dateTimePicker1, "This already Exist!!!!");
                errorProvider1.SetError(tbStartTime, "This already Exist!!!!");
                errorProvider1.SetError(cbGrade, "This already Exist!!!!");
                errorProvider1.SetError(cbSubject, "This already Exist!!!!");


                MessageBox.Show("This already Exist!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                con.Close();
            }
            else
            {

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE ExamTimeTable SET Term ='" + cbTerm.Text + "',Date ='" + dateTimePicker1.Value + "' ,StartTime ='" + tbStartTime.Text + "',Grade ='" + cbGrade.Text + "',Subject = '" + cbSubject.Text + "'  WHERE TimetableID ='" + tbTimeTablID.Text + "' ";
                cmd.ExecuteNonQuery();

                if (MessageBox.Show("Are You Sure??", "UPDATE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    clearFields();
                    con.Close();
                    MessageBox.Show("Record Updated Successfully!!!");
                    displayData("");

                }
            }
        }

        public void displayData(string searchValue)
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM ExamTimeTable WHERE TimetableID LIKE '%" + searchValue + "%' OR Grade LIKE '%" + searchValue + " %' OR Subject LIKE '%" + searchValue + "%'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewTimeTable.DataSource = dt;

            con.Close();

        }

        private void DataGridViewTimeTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridViewTimeTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            tbTimeTablID.Text = dataGridViewTimeTable.Rows[rowIndex].Cells[0].Value.ToString();

            cbTerm.SelectedIndex = cbTerm.FindStringExact(dataGridViewTimeTable.Rows[rowIndex].Cells[1].Value.ToString());
            dateTimePicker1.Value = DateTime.Parse(dataGridViewTimeTable.Rows[rowIndex].Cells[2].Value.ToString());
            tbStartTime.Text = dataGridViewTimeTable.Rows[rowIndex].Cells[3].Value.ToString();
            cbGrade.SelectedIndex = cbGrade.FindStringExact(dataGridViewTimeTable.Rows[rowIndex].Cells[5].Value.ToString());

            cbSubject.SelectedIndex = cbSubject.FindStringExact(dataGridViewTimeTable.Rows[rowIndex].Cells[6].Value.ToString());
            errorProvider1.Clear();

        }

        void FillGradeCombo()
        {

        }

        void clearFields()
        {
            tbTimeTablID.Text = "";
            cbTerm.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            tbStartTime.Text = "";
            cbGrade.SelectedIndex = -1;
            cbSubject.SelectedIndex = -1;
        }

        void FillSubjectCombo()
        {
            //TYP 01 fill combo box...get data from db
            cbSubject.Items.Clear();

            DataSet ds = new DataSet();
            try
            {

                string query = "select * from Subject";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();

                da.Fill(ds);

                cbSubject.DataSource = ds.Tables[0];
                cbSubject.DisplayMember = "SubjectName";
                cbSubject.ValueMember = "SubjectID";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }


        }

        private void BtnDisplayUDTT_Click(object sender, EventArgs e)
        {
            displayData("");
        }

        private void BtnDeleteUDTT_Click(object sender, EventArgs e)
        {
            if (cbTerm.Text == "" || tbStartTime.Text == "" || tbTimeTablID.Text == "" || cbGrade.Text == "" || cbSubject.Text == "")
            {

                errorProvider1.SetError(tbStartTime, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(tbTimeTablID, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(cbTerm, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(cbGrade, "This already Exist!!!!");
                errorProvider1.SetError(cbSubject, "This already Exist!!!!");
                MessageBox.Show("Please choose correct complete record to DELETE !!!!");
                return;
            }

            errorProvider1.Clear();
            con.Open();
            string qry = "DELETE FROM ExamTimeTable WHERE TimetableId = '" + tbTimeTablID.Text + "'";
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();

            if (MessageBox.Show("Are You Sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                clearFields();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!!!");
                displayData("");

            }
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnStudentMHeader_Click(object sender, EventArgs e)
        {
            StudentManageHome smh = new StudentManageHome();
            this.Hide();
            smh.ShowDialog();
        }

        private void BtnInventoryMHeader_Click(object sender, EventArgs e)
        {
            InventoryDashboard ind = new InventoryDashboard();
            this.Hide();
            ind.ShowDialog();
        }

        private void BtnResourseMHeader_Click(object sender, EventArgs e)
        {
            ResourceManageHome rmh = new ResourceManageHome();
            this.Hide();
            rmh.ShowDialog();
        }

        private void BtnLibraryMHeader_Click(object sender, EventArgs e)
        {
            LibraryHome lh = new LibraryHome();
            this.Hide();
            lh.ShowDialog();
        }

        private void BtnExamMheader_Click(object sender, EventArgs e)
        {
            TeachersHome th = new TeachersHome();
            this.Hide();
            th.ShowDialog();
        }

        private void BtnNoticeMHeader_Click(object sender, EventArgs e)
        {
            Notice_Dashboard nd = new Notice_Dashboard();
            this.Hide();
            nd.ShowDialog();
        }

        private void LbUserUDT_Click(object sender, EventArgs e)
        {
            lbUserUDT.Text = GetSetInfo.userName;
        }
    }
}
