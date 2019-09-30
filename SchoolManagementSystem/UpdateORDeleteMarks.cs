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
    public partial class UpdateORDeleteMarks : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=SchoolManagementSystemDB;Integrated Security=True");

        public UpdateORDeleteMarks()
        {
            InitializeComponent();

            YearPicker.Format = DateTimePickerFormat.Custom;
            YearPicker.CustomFormat = "yyyy";
            YearPicker.ShowUpDown = true;
        }
        Connection o = new Connection();

        private void UpdateORDeleteMarks_Load(object sender, EventArgs e)
        {
            FillSubjectCombo();
            displayData();
        }

        private void BtnAddMarksUD_Click(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            am.StartPosition = FormStartPosition.CenterScreen;
            am.ShowDialog();
        }

        private void BtnTeachersHomeUD_Click(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnManageMarksUD_Click(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            Mm.StartPosition = FormStartPosition.CenterScreen;
            Mm.ShowDialog();
        }

        private void BtnUpdateDeleteTimetableA_Click(object sender, EventArgs e)
        {

        }

        private void BtnStudentResultSheetUD_Click(object sender, EventArgs e)
        {

        }

        private void BtnTeachersHomeUD_Click_1(object sender, EventArgs e)
        {
            TeachersHome Mm = new TeachersHome();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnManageMarksUD_Click_1(object sender, EventArgs e)
        {
            ManageMarks Mm = new ManageMarks();
            this.Hide();
            Mm.ShowDialog();
        }

        private void BtnAddMarksUD_Click_1(object sender, EventArgs e)
        {
            AddMarks am = new AddMarks();
            this.Hide();
            am.ShowDialog();
        }

        private void BtnStudentResultSheetUD_Click_1(object sender, EventArgs e)
        {
            StudentResultSheet stdRS = new StudentResultSheet();
            this.Hide();
            stdRS.ShowDialog();
        }

        private void BtnClassResultSheetUD_Click(object sender, EventArgs e)
        {

            ClassResultSheet clzRS = new ClassResultSheet();
            this.Hide();
            clzRS.ShowDialog();
        }

        private void BtnSectionResultSheetUD_Click(object sender, EventArgs e)
        {
            SectionResultSheet secRS = new SectionResultSheet();
            this.Hide();
            secRS.ShowDialog();
        }

        private void BtnUpdateTimetableUD_Click(object sender, EventArgs e)
        {
            UpdateOrDeleteTimetable udtt = new UpdateOrDeleteTimetable();
            this.Hide();
            udtt.ShowDialog();
        }

        private void BtnManageTimetableUD_Click(object sender, EventArgs e)
        {

            ViewTimetable vtt = new ViewTimetable();
            this.Hide();
            vtt.ShowDialog();
        }

        private void BtnAddTimetableUD_Click(object sender, EventArgs e)
        {

            AddTimetable att = new AddTimetable();
            this.Hide();
            att.ShowDialog();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (tbRegNo.Text == "" || tbMark.Text == "")
            {
                MessageBox.Show("Please choose correct complete record to DELETE !!!!");
            }
            else
            {
                try
                {
                    //con.Open();
                    string qry = "DELETE FROM ExamMarks WHERE SID = '" + tbRegNo.Text + "' AND SubjectID = '" + ((DataRowView)cbSubName.SelectedItem)[0] + "' And Term = '" + cbExam.Text + "' AND Year = '" + YearPicker.Value + "'";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.AddWithValue("@SubjectID", cbSubName.SelectedText.ToString());
                    cmd.ExecuteNonQuery();


                    if (MessageBox.Show("Are You Sure??", "DELETE", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        clearFields();

                        MessageBox.Show("Successfully Deleted!!");
                        displayData();
                        //  con.Close();

                        UpdateORDeleteMarks newud = new UpdateORDeleteMarks();
                        this.Hide();
                        newud.ShowDialog();

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    MessageBox.Show(ex.StackTrace);
                    con.Close();
                }
            }
        
        }

            void clearFields()
            {
                tbRegNo.Text = "";
                cbSubName.SelectedIndex = -1;
                cbExam.Text = "";
                tbMark.Text = "";
                YearPicker.Value = DateTime.Now;
            }

        public void displayData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM ExamMarks  ";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                dataGridViewMarks.DataSource = dt;
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

        void FillSubjectCombo()
        {

            DataSet ds = new DataSet();
            try
            {

                string query = "select * from Subject";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                con.Open();

                da.Fill(ds);

                cbSubName.DataSource = ds.Tables[0];
                cbSubName.DisplayMember = "SubjectName";
                cbSubName.ValueMember = "SubjectID";


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

        private void dataGridViewMarks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int id = int.Parse(dataGridViewMarks.Rows[rowIndex].Cells[1].Value.ToString());

            string var = "SELECT SubjectName FROM Subject WHERE SubjectID = '" + id + "' ";
            SqlCommand cmd = new SqlCommand(var, con);
            con.Open();
            string name = "";


            SqlDataReader dr = cmd.ExecuteReader();
            try
            {
                while (dr.Read())
                {
                    name = dr["SubjectName"].ToString();
                    break;
                }
            }
            catch
            {

            }
            finally
            {

                dr.Close();
                con.Close();
            }



            try
            {
                tbRegNo.Text = dataGridViewMarks.Rows[rowIndex].Cells[0].Value.ToString();

                for (int i = 0; i < cbSubName.Items.Count; i++)
                {
                    DataRowView drw = (DataRowView)cbSubName.Items[i];
                    if (drw[1].ToString() == name)
                    {
                        cbSubName.SelectedIndex = i;
                    }
                }

                cbExam.SelectedIndex = cbExam.FindStringExact(dataGridViewMarks.Rows[rowIndex].Cells[2].Value.ToString());
                tbMark.Text = dataGridViewMarks.Rows[rowIndex].Cells[3].Value.ToString();
                YearPicker.Value = DateTime.Parse(dataGridViewMarks.CurrentRow.Cells[4].Value.ToString());

              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDisplay_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (tbRegNo.Text == "" || tbMark.Text == "" || cbExam.Text == "")
            {
                errorProvider1.SetError(tbRegNo, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(tbMark, "Please fill the empty Areas!!!!");
                errorProvider1.SetError(cbExam, "Please fill the empty Areas!!!!");
                MessageBox.Show("Please fill the empty Areas!!!!");
                return;
            }
            else
            {
                errorProvider1.Clear();
            }

            con.Open();
            SqlCommand check = new SqlCommand("SELECT * FROM ExamMarks WHERE SID = '" + tbRegNo.Text + "' AND SubjectID =  '" + ((DataRowView)cbSubName.SelectedItem)[0] + "'  AND Term = '" + cbExam.Text + "'  AND  Mark = '" + tbMark.Text + "' AND Year =  '" + YearPicker.Value + "'  ", con);
            SqlDataAdapter checkDa = new SqlDataAdapter(check);
            DataSet ds = new DataSet();
            checkDa.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                errorProvider1.SetError(tbRegNo, "This already Exist!!!!");
                errorProvider1.SetError(cbSubName, "This already Exist!!!!");
                errorProvider1.SetError(cbExam, "This already Exist!!!!");
                errorProvider1.SetError(tbMark, "This already Exist!!!!");
                errorProvider1.SetError(YearPicker, "This already Exist!!!!");


                MessageBox.Show("This already Exist!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                con.Close();
            }
            else
            {
                try
                {
                    //con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;

                    cmd.CommandText = "UPDATE ExamMarks SET Mark ='" + tbMark.Text + "' WHERE SID ='" + tbRegNo.Text + "' AND SubjectID = '" + ((DataRowView)cbSubName.SelectedItem)[0] + "' AND Term = '" + cbExam.Text + "' AND  Year = '" + YearPicker.Value + "' ";
                    cmd.ExecuteNonQuery();
                    con.Close();
                    displayData();
                    clearFields();
                    MessageBox.Show("Record Updated Successfully!!!");

                    UpdateORDeleteMarks newud = new UpdateORDeleteMarks();
                    this.Hide();
                    newud.ShowDialog();

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }

        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            UpdateORDeleteMarks newud = new UpdateORDeleteMarks();
            this.Hide();
            newud.ShowDialog();
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

        private void LbUserUDM_Click(object sender, EventArgs e)
        {
            lbUserUDM.Text = GetSetInfo.userName;
        }
    }
}
