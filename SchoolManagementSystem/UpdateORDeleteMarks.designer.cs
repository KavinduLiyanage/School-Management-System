namespace SchoolManagementSystem
{
    partial class UpdateORDeleteMarks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateORDeleteMarks));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.cbSubName = new System.Windows.Forms.ComboBox();
            this.tbRegNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.cbExam = new System.Windows.Forms.ComboBox();
            this.YearPicker = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridViewMarks = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddMarksUD = new System.Windows.Forms.Button();
            this.btnSectionResultSheetUD = new System.Windows.Forms.Button();
            this.btnUpdateTimetableUD = new System.Windows.Forms.Button();
            this.btnAddTimetableUD = new System.Windows.Forms.Button();
            this.btnManageTimetableUD = new System.Windows.Forms.Button();
            this.btnClassResultSheetUD = new System.Windows.Forms.Button();
            this.btnStudentResultSheetUD = new System.Windows.Forms.Button();
            this.btnManageMarksUD = new System.Windows.Forms.Button();
            this.btnTeachersHomeUD = new System.Windows.Forms.Button();
            this.lbUserUDM = new System.Windows.Forms.Label();
            this.btnimgUDM = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.btnEventMHeader = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 220);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.cbSubName);
            this.panel2.Controls.Add(this.tbRegNo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbMark);
            this.panel2.Controls.Add(this.cbExam);
            this.panel2.Controls.Add(this.YearPicker);
            this.panel2.Location = new System.Drawing.Point(292, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(389, 487);
            this.panel2.TabIndex = 19;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(42, 382);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 50);
            this.btnUpdate.TabIndex = 29;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(228, 382);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(130, 50);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // cbSubName
            // 
            this.cbSubName.FormattingEnabled = true;
            this.cbSubName.Items.AddRange(new object[] {
            "Sinhala",
            "Mathematics",
            "English"});
            this.cbSubName.Location = new System.Drawing.Point(188, 87);
            this.cbSubName.Name = "cbSubName";
            this.cbSubName.Size = new System.Drawing.Size(184, 24);
            this.cbSubName.TabIndex = 16;
            // 
            // tbRegNo
            // 
            this.tbRegNo.Location = new System.Drawing.Point(188, 37);
            this.tbRegNo.Name = "tbRegNo";
            this.tbRegNo.ReadOnly = true;
            this.tbRegNo.Size = new System.Drawing.Size(184, 22);
            this.tbRegNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select exam";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Marks";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Enter Year";
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(188, 205);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(184, 22);
            this.tbMark.TabIndex = 6;
            // 
            // cbExam
            // 
            this.cbExam.FormattingEnabled = true;
            this.cbExam.Items.AddRange(new object[] {
            "1st Term",
            "2nd Term",
            "3rd Term"});
            this.cbExam.Location = new System.Drawing.Point(188, 148);
            this.cbExam.Name = "cbExam";
            this.cbExam.Size = new System.Drawing.Size(184, 24);
            this.cbExam.TabIndex = 9;
            // 
            // YearPicker
            // 
            this.YearPicker.CustomFormat = "yyyy";
            this.YearPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.YearPicker.Location = new System.Drawing.Point(188, 257);
            this.YearPicker.Name = "YearPicker";
            this.YearPicker.Size = new System.Drawing.Size(184, 22);
            this.YearPicker.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.dataGridViewMarks);
            this.panel3.Controls.Add(this.tbSearch);
            this.panel3.Controls.Add(this.lbSearch);
            this.panel3.Location = new System.Drawing.Point(703, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 438);
            this.panel3.TabIndex = 20;
            // 
            // dataGridViewMarks
            // 
            this.dataGridViewMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMarks.Location = new System.Drawing.Point(19, 64);
            this.dataGridViewMarks.Name = "dataGridViewMarks";
            this.dataGridViewMarks.RowHeadersWidth = 51;
            this.dataGridViewMarks.RowTemplate.Height = 24;
            this.dataGridViewMarks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMarks.Size = new System.Drawing.Size(496, 351);
            this.dataGridViewMarks.TabIndex = 14;
            this.dataGridViewMarks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMarks_CellClick);
            this.dataGridViewMarks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewMarks_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(91, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(403, 22);
            this.tbSearch.TabIndex = 12;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.Location = new System.Drawing.Point(23, 18);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(62, 20);
            this.lbSearch.TabIndex = 13;
            this.lbSearch.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnAddMarksUD);
            this.panel1.Controls.Add(this.btnSectionResultSheetUD);
            this.panel1.Controls.Add(this.btnUpdateTimetableUD);
            this.panel1.Controls.Add(this.btnAddTimetableUD);
            this.panel1.Controls.Add(this.btnManageTimetableUD);
            this.panel1.Controls.Add(this.btnClassResultSheetUD);
            this.panel1.Controls.Add(this.btnStudentResultSheetUD);
            this.panel1.Controls.Add(this.btnManageMarksUD);
            this.panel1.Controls.Add(this.btnTeachersHomeUD);
            this.panel1.Location = new System.Drawing.Point(12, 336);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 335);
            this.panel1.TabIndex = 19;
            // 
            // btnAddMarksUD
            // 
            this.btnAddMarksUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddMarksUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMarksUD.Location = new System.Drawing.Point(11, 76);
            this.btnAddMarksUD.Name = "btnAddMarksUD";
            this.btnAddMarksUD.Size = new System.Drawing.Size(235, 35);
            this.btnAddMarksUD.TabIndex = 23;
            this.btnAddMarksUD.Text = "Add Marks";
            this.btnAddMarksUD.UseVisualStyleBackColor = false;
            this.btnAddMarksUD.Click += new System.EventHandler(this.BtnAddMarksUD_Click_1);
            // 
            // btnSectionResultSheetUD
            // 
            this.btnSectionResultSheetUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSectionResultSheetUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSectionResultSheetUD.Location = new System.Drawing.Point(11, 185);
            this.btnSectionResultSheetUD.Name = "btnSectionResultSheetUD";
            this.btnSectionResultSheetUD.Size = new System.Drawing.Size(235, 35);
            this.btnSectionResultSheetUD.TabIndex = 20;
            this.btnSectionResultSheetUD.Text = "Section Resultsheet";
            this.btnSectionResultSheetUD.UseVisualStyleBackColor = false;
            this.btnSectionResultSheetUD.Click += new System.EventHandler(this.BtnSectionResultSheetUD_Click);
            // 
            // btnUpdateTimetableUD
            // 
            this.btnUpdateTimetableUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdateTimetableUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTimetableUD.Location = new System.Drawing.Point(11, 292);
            this.btnUpdateTimetableUD.Name = "btnUpdateTimetableUD";
            this.btnUpdateTimetableUD.Size = new System.Drawing.Size(235, 35);
            this.btnUpdateTimetableUD.TabIndex = 19;
            this.btnUpdateTimetableUD.Text = "Update / Delete Timetable";
            this.btnUpdateTimetableUD.UseVisualStyleBackColor = false;
            this.btnUpdateTimetableUD.Click += new System.EventHandler(this.BtnUpdateTimetableUD_Click);
            // 
            // btnAddTimetableUD
            // 
            this.btnAddTimetableUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAddTimetableUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimetableUD.Location = new System.Drawing.Point(11, 256);
            this.btnAddTimetableUD.Name = "btnAddTimetableUD";
            this.btnAddTimetableUD.Size = new System.Drawing.Size(235, 35);
            this.btnAddTimetableUD.TabIndex = 21;
            this.btnAddTimetableUD.Text = "Add Timetable";
            this.btnAddTimetableUD.UseVisualStyleBackColor = false;
            this.btnAddTimetableUD.Click += new System.EventHandler(this.BtnAddTimetableUD_Click);
            // 
            // btnManageTimetableUD
            // 
            this.btnManageTimetableUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageTimetableUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageTimetableUD.Location = new System.Drawing.Point(11, 220);
            this.btnManageTimetableUD.Name = "btnManageTimetableUD";
            this.btnManageTimetableUD.Size = new System.Drawing.Size(235, 35);
            this.btnManageTimetableUD.TabIndex = 22;
            this.btnManageTimetableUD.Text = "Get Timetable";
            this.btnManageTimetableUD.UseVisualStyleBackColor = false;
            this.btnManageTimetableUD.Click += new System.EventHandler(this.BtnManageTimetableUD_Click);
            // 
            // btnClassResultSheetUD
            // 
            this.btnClassResultSheetUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClassResultSheetUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassResultSheetUD.Location = new System.Drawing.Point(11, 148);
            this.btnClassResultSheetUD.Name = "btnClassResultSheetUD";
            this.btnClassResultSheetUD.Size = new System.Drawing.Size(235, 35);
            this.btnClassResultSheetUD.TabIndex = 18;
            this.btnClassResultSheetUD.Text = "Class Resultsheet";
            this.btnClassResultSheetUD.UseVisualStyleBackColor = false;
            this.btnClassResultSheetUD.Click += new System.EventHandler(this.BtnClassResultSheetUD_Click);
            // 
            // btnStudentResultSheetUD
            // 
            this.btnStudentResultSheetUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnStudentResultSheetUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentResultSheetUD.Location = new System.Drawing.Point(11, 112);
            this.btnStudentResultSheetUD.Name = "btnStudentResultSheetUD";
            this.btnStudentResultSheetUD.Size = new System.Drawing.Size(235, 35);
            this.btnStudentResultSheetUD.TabIndex = 18;
            this.btnStudentResultSheetUD.Text = "Student ResultSheet";
            this.btnStudentResultSheetUD.UseVisualStyleBackColor = false;
            this.btnStudentResultSheetUD.Click += new System.EventHandler(this.BtnStudentResultSheetUD_Click_1);
            // 
            // btnManageMarksUD
            // 
            this.btnManageMarksUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnManageMarksUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageMarksUD.Location = new System.Drawing.Point(11, 40);
            this.btnManageMarksUD.Name = "btnManageMarksUD";
            this.btnManageMarksUD.Size = new System.Drawing.Size(235, 35);
            this.btnManageMarksUD.TabIndex = 17;
            this.btnManageMarksUD.Text = "Manage Marks";
            this.btnManageMarksUD.UseVisualStyleBackColor = false;
            this.btnManageMarksUD.Click += new System.EventHandler(this.BtnManageMarksUD_Click_1);
            // 
            // btnTeachersHomeUD
            // 
            this.btnTeachersHomeUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTeachersHomeUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeachersHomeUD.Location = new System.Drawing.Point(11, 3);
            this.btnTeachersHomeUD.Name = "btnTeachersHomeUD";
            this.btnTeachersHomeUD.Size = new System.Drawing.Size(235, 35);
            this.btnTeachersHomeUD.TabIndex = 17;
            this.btnTeachersHomeUD.Text = "Teachers Home";
            this.btnTeachersHomeUD.UseVisualStyleBackColor = false;
            this.btnTeachersHomeUD.Click += new System.EventHandler(this.BtnTeachersHomeUD_Click_1);
            // 
            // lbUserUDM
            // 
            this.lbUserUDM.AutoSize = true;
            this.lbUserUDM.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbUserUDM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserUDM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbUserUDM.Location = new System.Drawing.Point(66, 282);
            this.lbUserUDM.Name = "lbUserUDM";
            this.lbUserUDM.Size = new System.Drawing.Size(155, 25);
            this.lbUserUDM.TabIndex = 24;
            this.lbUserUDM.Text = "Ashani Malsha";
            this.lbUserUDM.Click += new System.EventHandler(this.LbUserUDM_Click);
            // 
            // btnimgUDM
            // 
            this.btnimgUDM.Location = new System.Drawing.Point(57, 134);
            this.btnimgUDM.Name = "btnimgUDM";
            this.btnimgUDM.Size = new System.Drawing.Size(174, 135);
            this.btnimgUDM.TabIndex = 26;
            this.btnimgUDM.Text = "button3";
            this.btnimgUDM.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(57, 134);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 135);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(1043, 606);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(130, 50);
            this.btnDisplay.TabIndex = 17;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.SkyBlue;
            this.panel5.Controls.Add(this.btnLogOutHeader);
            this.panel5.Controls.Add(this.btnNoticeMHeader);
            this.panel5.Controls.Add(this.btnExamMheader);
            this.panel5.Controls.Add(this.btnLibraryMHeader);
            this.panel5.Controls.Add(this.btnStudentMHeader);
            this.panel5.Controls.Add(this.btnResourseMHeader);
            this.panel5.Controls.Add(this.btnInventoryMHeader);
            this.panel5.Controls.Add(this.btnEventMHeader);
            this.panel5.Location = new System.Drawing.Point(12, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 92);
            this.panel5.TabIndex = 44;
            // 
            // btnLogOutHeader
            // 
            this.btnLogOutHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOutHeader.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOutHeader.Location = new System.Drawing.Point(1078, 20);
            this.btnLogOutHeader.Name = "btnLogOutHeader";
            this.btnLogOutHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLogOutHeader.TabIndex = 25;
            this.btnLogOutHeader.Text = "Log Out";
            this.btnLogOutHeader.UseVisualStyleBackColor = true;
            // 
            // btnNoticeMHeader
            // 
            this.btnNoticeMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNoticeMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoticeMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnNoticeMHeader.Location = new System.Drawing.Point(927, 21);
            this.btnNoticeMHeader.Name = "btnNoticeMHeader";
            this.btnNoticeMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnNoticeMHeader.TabIndex = 23;
            this.btnNoticeMHeader.Text = "Notice Management";
            this.btnNoticeMHeader.UseVisualStyleBackColor = false;
            this.btnNoticeMHeader.Click += new System.EventHandler(this.BtnNoticeMHeader_Click);
            // 
            // btnExamMheader
            // 
            this.btnExamMheader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExamMheader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamMheader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnExamMheader.Location = new System.Drawing.Point(21, 19);
            this.btnExamMheader.Name = "btnExamMheader";
            this.btnExamMheader.Size = new System.Drawing.Size(145, 50);
            this.btnExamMheader.TabIndex = 1;
            this.btnExamMheader.Text = "Exam Management";
            this.btnExamMheader.UseVisualStyleBackColor = false;
            this.btnExamMheader.Click += new System.EventHandler(this.BtnExamMheader_Click);
            // 
            // btnLibraryMHeader
            // 
            this.btnLibraryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLibraryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnLibraryMHeader.Location = new System.Drawing.Point(776, 21);
            this.btnLibraryMHeader.Name = "btnLibraryMHeader";
            this.btnLibraryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLibraryMHeader.TabIndex = 22;
            this.btnLibraryMHeader.Text = " Library Management";
            this.btnLibraryMHeader.UseVisualStyleBackColor = false;
            this.btnLibraryMHeader.Click += new System.EventHandler(this.BtnLibraryMHeader_Click);
            // 
            // btnStudentMHeader
            // 
            this.btnStudentMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnStudentMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudentMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnStudentMHeader.Location = new System.Drawing.Point(172, 20);
            this.btnStudentMHeader.Name = "btnStudentMHeader";
            this.btnStudentMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnStudentMHeader.TabIndex = 18;
            this.btnStudentMHeader.Text = "Student Management";
            this.btnStudentMHeader.UseVisualStyleBackColor = false;
            this.btnStudentMHeader.Click += new System.EventHandler(this.BtnStudentMHeader_Click);
            // 
            // btnResourseMHeader
            // 
            this.btnResourseMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResourseMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourseMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnResourseMHeader.Location = new System.Drawing.Point(625, 20);
            this.btnResourseMHeader.Name = "btnResourseMHeader";
            this.btnResourseMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnResourseMHeader.TabIndex = 21;
            this.btnResourseMHeader.Text = "Resourse Management";
            this.btnResourseMHeader.UseVisualStyleBackColor = false;
            this.btnResourseMHeader.Click += new System.EventHandler(this.BtnResourseMHeader_Click);
            // 
            // btnInventoryMHeader
            // 
            this.btnInventoryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnInventoryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventoryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnInventoryMHeader.Location = new System.Drawing.Point(323, 20);
            this.btnInventoryMHeader.Name = "btnInventoryMHeader";
            this.btnInventoryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnInventoryMHeader.TabIndex = 19;
            this.btnInventoryMHeader.Text = "Inventory Management";
            this.btnInventoryMHeader.UseVisualStyleBackColor = false;
            this.btnInventoryMHeader.Click += new System.EventHandler(this.BtnInventoryMHeader_Click);
            // 
            // btnEventMHeader
            // 
            this.btnEventMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnEventMHeader.Location = new System.Drawing.Point(474, 20);
            this.btnEventMHeader.Name = "btnEventMHeader";
            this.btnEventMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnEventMHeader.TabIndex = 20;
            this.btnEventMHeader.Text = "Event Management";
            this.btnEventMHeader.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(788, 606);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(130, 50);
            this.btnRefresh.TabIndex = 45;
            this.btnRefresh.Text = "Reset";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // UpdateORDeleteMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnimgUDM);
            this.Controls.Add(this.lbUserUDM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UpdateORDeleteMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update OR Delete Marks";
            this.Load += new System.EventHandler(this.UpdateORDeleteMarks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMarks)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbRegNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMark;
        private System.Windows.Forms.ComboBox cbExam;
        private System.Windows.Forms.DateTimePicker YearPicker;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridViewMarks;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddMarksUD;
        private System.Windows.Forms.Button btnSectionResultSheetUD;
        private System.Windows.Forms.Button btnUpdateTimetableUD;
        private System.Windows.Forms.Button btnAddTimetableUD;
        private System.Windows.Forms.Button btnManageTimetableUD;
        private System.Windows.Forms.Button btnClassResultSheetUD;
        private System.Windows.Forms.Button btnStudentResultSheetUD;
        private System.Windows.Forms.Button btnManageMarksUD;
        private System.Windows.Forms.Button btnTeachersHomeUD;
        private System.Windows.Forms.Label lbUserUDM;
        private System.Windows.Forms.Button btnimgUDM;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox cbSubName;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.Button btnEventMHeader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnRefresh;
    }
}