namespace SchoolManagementSystem
{
    partial class AddEventform
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.UsrlinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxStat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.textBoxvenue = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateNoticebtn = new System.Windows.Forms.Button();
            this.SearchEventbtn = new System.Windows.Forms.Button();
            this.DeleteEventbtn = new System.Windows.Forms.Button();
            this.ViewEventbtn = new System.Windows.Forms.Button();
            this.AddEventbtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.subLabel2 = new System.Windows.Forms.PictureBox();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.NStaffHomeBtn = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subLabel2)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.panel5.Location = new System.Drawing.Point(15, 8);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1228, 92);
            this.panel5.TabIndex = 45;
            // 
            // btnLogOutHeader
            // 
            this.btnLogOutHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOutHeader.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOutHeader.Location = new System.Drawing.Point(1078, 19);
            this.btnLogOutHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOutHeader.Name = "btnLogOutHeader";
            this.btnLogOutHeader.Size = new System.Drawing.Size(145, 50);
            this.btnLogOutHeader.TabIndex = 25;
            this.btnLogOutHeader.Text = "Log Out";
            this.btnLogOutHeader.UseVisualStyleBackColor = true;
            this.btnLogOutHeader.Click += new System.EventHandler(this.BtnLogOutHeader_Click);
            // 
            // btnNoticeMHeader
            // 
            this.btnNoticeMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNoticeMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoticeMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnNoticeMHeader.Location = new System.Drawing.Point(927, 19);
            this.btnNoticeMHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnExamMheader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnLibraryMHeader.Location = new System.Drawing.Point(738, 19);
            this.btnLibraryMHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnStudentMHeader.Location = new System.Drawing.Point(196, 21);
            this.btnStudentMHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnResourseMHeader.Location = new System.Drawing.Point(566, 21);
            this.btnResourseMHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.btnInventoryMHeader.Location = new System.Drawing.Point(379, 21);
            this.btnInventoryMHeader.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnInventoryMHeader.Name = "btnInventoryMHeader";
            this.btnInventoryMHeader.Size = new System.Drawing.Size(145, 50);
            this.btnInventoryMHeader.TabIndex = 19;
            this.btnInventoryMHeader.Text = "Inventory Management";
            this.btnInventoryMHeader.UseVisualStyleBackColor = false;
            this.btnInventoryMHeader.Click += new System.EventHandler(this.BtnInventoryMHeader_Click);
            // 
            // UsrlinkLabel
            // 
            this.UsrlinkLabel.AutoSize = true;
            this.UsrlinkLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsrlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrlinkLabel.Location = new System.Drawing.Point(57, 269);
            this.UsrlinkLabel.Name = "UsrlinkLabel";
            this.UsrlinkLabel.Size = new System.Drawing.Size(167, 25);
            this.UsrlinkLabel.TabIndex = 52;
            this.UsrlinkLabel.TabStop = true;
            this.UsrlinkLabel.Text = "Dulashni Amanda";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.comboBoxStat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.backButton);
            this.panel1.Controls.Add(this.textBoxvenue);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.UpdateNoticebtn);
            this.panel1.Controls.Add(this.SearchEventbtn);
            this.panel1.Controls.Add(this.DeleteEventbtn);
            this.panel1.Controls.Add(this.ViewEventbtn);
            this.panel1.Controls.Add(this.AddEventbtn);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.textBoxTime);
            this.panel1.Controls.Add(this.textBoxName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(286, 106);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 546);
            this.panel1.TabIndex = 53;
            // 
            // comboBoxStat
            // 
            this.comboBoxStat.Font = new System.Drawing.Font("Calibri", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxStat.FormattingEnabled = true;
            this.comboBoxStat.Items.AddRange(new object[] {
            "To be held",
            "Concluded"});
            this.comboBoxStat.Location = new System.Drawing.Point(780, 135);
            this.comboBoxStat.Name = "comboBoxStat";
            this.comboBoxStat.Size = new System.Drawing.Size(140, 27);
            this.comboBoxStat.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(701, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 46;
            this.label6.Text = "Status";
            // 
            // backButton
            // 
            this.backButton.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.back_black_square_interface_button_symbol2;
            this.backButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.backButton.Location = new System.Drawing.Point(4, 4);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(51, 41);
            this.backButton.TabIndex = 45;
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.Back_e_click);
            // 
            // textBoxvenue
            // 
            this.textBoxvenue.Location = new System.Drawing.Point(203, 135);
            this.textBoxvenue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxvenue.Name = "textBoxvenue";
            this.textBoxvenue.Size = new System.Drawing.Size(180, 26);
            this.textBoxvenue.TabIndex = 44;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(616, 211);
            this.textBoxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(200, 26);
            this.textBoxSearch.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 249);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(940, 285);
            this.dataGridView1.TabIndex = 42;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ViewEvent_cellclick);
            // 
            // UpdateNoticebtn
            // 
            this.UpdateNoticebtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.UpdateNoticebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateNoticebtn.Location = new System.Drawing.Point(414, 202);
            this.UpdateNoticebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateNoticebtn.Name = "UpdateNoticebtn";
            this.UpdateNoticebtn.Size = new System.Drawing.Size(104, 40);
            this.UpdateNoticebtn.TabIndex = 41;
            this.UpdateNoticebtn.Text = "Update";
            this.UpdateNoticebtn.UseVisualStyleBackColor = false;
            this.UpdateNoticebtn.Click += new System.EventHandler(this.UpdateNoticebtn_Click);
            // 
            // SearchEventbtn
            // 
            this.SearchEventbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SearchEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEventbtn.Location = new System.Drawing.Point(824, 202);
            this.SearchEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchEventbtn.Name = "SearchEventbtn";
            this.SearchEventbtn.Size = new System.Drawing.Size(112, 41);
            this.SearchEventbtn.TabIndex = 40;
            this.SearchEventbtn.Text = "Search";
            this.SearchEventbtn.UseVisualStyleBackColor = false;
            this.SearchEventbtn.Click += new System.EventHandler(this.SearchEvent_click);
            // 
            // DeleteEventbtn
            // 
            this.DeleteEventbtn.BackColor = System.Drawing.Color.LightCoral;
            this.DeleteEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventbtn.Location = new System.Drawing.Point(295, 202);
            this.DeleteEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteEventbtn.Name = "DeleteEventbtn";
            this.DeleteEventbtn.Size = new System.Drawing.Size(104, 40);
            this.DeleteEventbtn.TabIndex = 39;
            this.DeleteEventbtn.Text = "Delete";
            this.DeleteEventbtn.UseVisualStyleBackColor = false;
            this.DeleteEventbtn.Click += new System.EventHandler(this.DeleteEvent_click);
            // 
            // ViewEventbtn
            // 
            this.ViewEventbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ViewEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewEventbtn.Location = new System.Drawing.Point(176, 202);
            this.ViewEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ViewEventbtn.Name = "ViewEventbtn";
            this.ViewEventbtn.Size = new System.Drawing.Size(104, 40);
            this.ViewEventbtn.TabIndex = 38;
            this.ViewEventbtn.Text = "View";
            this.ViewEventbtn.UseVisualStyleBackColor = false;
            this.ViewEventbtn.Click += new System.EventHandler(this.ViewEvent_click);
            // 
            // AddEventbtn
            // 
            this.AddEventbtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddEventbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEventbtn.Location = new System.Drawing.Point(52, 202);
            this.AddEventbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEventbtn.Name = "AddEventbtn";
            this.AddEventbtn.Size = new System.Drawing.Size(104, 40);
            this.AddEventbtn.TabIndex = 37;
            this.AddEventbtn.Text = "Add";
            this.AddEventbtn.UseVisualStyleBackColor = false;
            this.AddEventbtn.Click += new System.EventHandler(this.AddEvent_click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(601, 64);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 28);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Location = new System.Drawing.Point(467, 135);
            this.textBoxTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(200, 26);
            this.textBoxTime.TabIndex = 14;
            this.textBoxTime.TextChanged += new System.EventHandler(this.TextBoxTime_TextChanged);
            this.textBoxTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TimeKeypress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(203, 64);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(180, 26);
            this.textBoxName.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(405, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(455, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Event Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(73, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Event Venue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(73, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Event Name";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(404, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Add Event";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox4.Image = global::SchoolManagementSystem.Properties.Resources.girl2;
            this.pictureBox4.Location = new System.Drawing.Point(72, 122);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(141, 134);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 51;
            this.pictureBox4.TabStop = false;
            // 
            // subLabel2
            // 
            this.subLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subLabel2.Location = new System.Drawing.Point(15, 106);
            this.subLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.subLabel2.Name = "subLabel2";
            this.subLabel2.Size = new System.Drawing.Size(260, 220);
            this.subLabel2.TabIndex = 50;
            this.subLabel2.TabStop = false;
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.NStaffHomeBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(15, 334);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(260, 335);
            this.ButtonPanel.TabIndex = 54;
            // 
            // NHomeBtn
            // 
            this.NHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHomeBtn.ForeColor = System.Drawing.Color.Red;
            this.NHomeBtn.Location = new System.Drawing.Point(11, 6);
            this.NHomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NHomeBtn.Name = "NHomeBtn";
            this.NHomeBtn.Size = new System.Drawing.Size(235, 35);
            this.NHomeBtn.TabIndex = 24;
            this.NHomeBtn.Text = "Home";
            this.NHomeBtn.UseVisualStyleBackColor = false;
            this.NHomeBtn.Click += new System.EventHandler(this.NHomeBtn_Click);
            // 
            // NStaffHomeBtn
            // 
            this.NStaffHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NStaffHomeBtn.Location = new System.Drawing.Point(12, 52);
            this.NStaffHomeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NStaffHomeBtn.Name = "NStaffHomeBtn";
            this.NStaffHomeBtn.Size = new System.Drawing.Size(235, 35);
            this.NStaffHomeBtn.TabIndex = 17;
            this.NStaffHomeBtn.Text = "Yearly Event Report";
            this.NStaffHomeBtn.UseVisualStyleBackColor = false;
            this.NStaffHomeBtn.Click += new System.EventHandler(this.GenerateEventReport_click);
            // 
            // AddEventform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1258, 664);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UsrlinkLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.subLabel2);
            this.Controls.Add(this.panel5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEventform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Event";
            this.Load += new System.EventHandler(this.AddEventform_Load);
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subLabel2)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.LinkLabel UsrlinkLabel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox subLabel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateNoticebtn;
        private System.Windows.Forms.Button SearchEventbtn;
        private System.Windows.Forms.Button DeleteEventbtn;
        private System.Windows.Forms.Button ViewEventbtn;
        private System.Windows.Forms.Button AddEventbtn;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBoxvenue;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Button NStaffHomeBtn;
        private System.Windows.Forms.ComboBox comboBoxStat;
        private System.Windows.Forms.Label label6;
    }
}