namespace SchoolManagementSystem
{
    partial class InventoryProductReportGenerate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryProductReportGenerate));
            this.button1 = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnLogOutHeader = new System.Windows.Forms.Button();
            this.btnNoticeMHeader = new System.Windows.Forms.Button();
            this.btnExamMheader = new System.Windows.Forms.Button();
            this.btnLibraryMHeader = new System.Windows.Forms.Button();
            this.btnStudentMHeader = new System.Windows.Forms.Button();
            this.btnResourseMHeader = new System.Windows.Forms.Button();
            this.btnInventoryMHeader = new System.Windows.Forms.Button();
            this.btnEventMHeader = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UsrlinkLabel = new System.Windows.Forms.LinkLabel();
            this.ButtonPanel = new System.Windows.Forms.Panel();
            this.NHomeBtn = new System.Windows.Forms.Button();
            this.NViewLeaveBtn = new System.Windows.Forms.Button();
            this.NViewSalaryBtn = new System.Windows.Forms.Button();
            this.NStaffHomeBtn = new System.Windows.Forms.Button();
            this.subLabel2 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ButtonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(483, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "View";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(212, 130);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(717, 419);
            this.crystalReportViewer1.TabIndex = 5;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Laboratory Equipments",
            "Moveable Infrastructures",
            "Sports Items",
            "Music Instruments",
            "Cleaning Items",
            "Stationary",
            "Electronic Items",
            "Teaching Aid"});
            this.comboBox1.Location = new System.Drawing.Point(292, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(212, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(74, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Category:";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
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
            this.panel5.Location = new System.Drawing.Point(10, 8);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(921, 75);
            this.panel5.TabIndex = 71;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // btnLogOutHeader
            // 
            this.btnLogOutHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogOutHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOutHeader.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogOutHeader.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogOutHeader.Location = new System.Drawing.Point(801, 13);
            this.btnLogOutHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOutHeader.Name = "btnLogOutHeader";
            this.btnLogOutHeader.Size = new System.Drawing.Size(109, 41);
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
            this.btnNoticeMHeader.Location = new System.Drawing.Point(688, 13);
            this.btnNoticeMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnNoticeMHeader.Name = "btnNoticeMHeader";
            this.btnNoticeMHeader.Size = new System.Drawing.Size(109, 41);
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
            this.btnExamMheader.Location = new System.Drawing.Point(5, 13);
            this.btnExamMheader.Name = "btnExamMheader";
            this.btnExamMheader.Size = new System.Drawing.Size(109, 41);
            this.btnExamMheader.TabIndex = 1;
            this.btnExamMheader.Text = "Exam Management";
            this.btnExamMheader.UseVisualStyleBackColor = false;
            // 
            // btnLibraryMHeader
            // 
            this.btnLibraryMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLibraryMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibraryMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnLibraryMHeader.Location = new System.Drawing.Point(575, 13);
            this.btnLibraryMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnLibraryMHeader.Name = "btnLibraryMHeader";
            this.btnLibraryMHeader.Size = new System.Drawing.Size(109, 41);
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
            this.btnStudentMHeader.Location = new System.Drawing.Point(119, 13);
            this.btnStudentMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudentMHeader.Name = "btnStudentMHeader";
            this.btnStudentMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnStudentMHeader.TabIndex = 1;
            this.btnStudentMHeader.Text = "Student Management";
            this.btnStudentMHeader.UseVisualStyleBackColor = false;
            this.btnStudentMHeader.Click += new System.EventHandler(this.BtnStudentMHeader_Click);
            // 
            // btnResourseMHeader
            // 
            this.btnResourseMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResourseMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResourseMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnResourseMHeader.Location = new System.Drawing.Point(462, 13);
            this.btnResourseMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnResourseMHeader.Name = "btnResourseMHeader";
            this.btnResourseMHeader.Size = new System.Drawing.Size(109, 41);
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
            this.btnInventoryMHeader.Location = new System.Drawing.Point(235, 13);
            this.btnInventoryMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnInventoryMHeader.Name = "btnInventoryMHeader";
            this.btnInventoryMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnInventoryMHeader.TabIndex = 19;
            this.btnInventoryMHeader.Text = "Inventory Management";
            this.btnInventoryMHeader.UseVisualStyleBackColor = false;
            // 
            // btnEventMHeader
            // 
            this.btnEventMHeader.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEventMHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEventMHeader.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold);
            this.btnEventMHeader.Location = new System.Drawing.Point(349, 13);
            this.btnEventMHeader.Margin = new System.Windows.Forms.Padding(2);
            this.btnEventMHeader.Name = "btnEventMHeader";
            this.btnEventMHeader.Size = new System.Drawing.Size(109, 41);
            this.btnEventMHeader.TabIndex = 20;
            this.btnEventMHeader.Text = "Event Management";
            this.btnEventMHeader.UseVisualStyleBackColor = false;
            this.btnEventMHeader.Click += new System.EventHandler(this.BtnEventMHeader_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 99);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 77;
            this.pictureBox1.TabStop = false;
            // 
            // UsrlinkLabel
            // 
            this.UsrlinkLabel.AutoSize = true;
            this.UsrlinkLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.UsrlinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsrlinkLabel.Location = new System.Drawing.Point(34, 222);
            this.UsrlinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsrlinkLabel.Name = "UsrlinkLabel";
            this.UsrlinkLabel.Size = new System.Drawing.Size(138, 20);
            this.UsrlinkLabel.TabIndex = 76;
            this.UsrlinkLabel.TabStop = true;
            this.UsrlinkLabel.Text = "Milinda Ranawaka";
            // 
            // ButtonPanel
            // 
            this.ButtonPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ButtonPanel.Controls.Add(this.NHomeBtn);
            this.ButtonPanel.Controls.Add(this.NViewLeaveBtn);
            this.ButtonPanel.Controls.Add(this.NViewSalaryBtn);
            this.ButtonPanel.Controls.Add(this.NStaffHomeBtn);
            this.ButtonPanel.Location = new System.Drawing.Point(8, 277);
            this.ButtonPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonPanel.Name = "ButtonPanel";
            this.ButtonPanel.Size = new System.Drawing.Size(195, 272);
            this.ButtonPanel.TabIndex = 75;
            // 
            // NHomeBtn
            // 
            this.NHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NHomeBtn.ForeColor = System.Drawing.Color.Red;
            this.NHomeBtn.Location = new System.Drawing.Point(6, 6);
            this.NHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NHomeBtn.Name = "NHomeBtn";
            this.NHomeBtn.Size = new System.Drawing.Size(176, 28);
            this.NHomeBtn.TabIndex = 24;
            this.NHomeBtn.Text = "Home";
            this.NHomeBtn.UseVisualStyleBackColor = false;
            this.NHomeBtn.Click += new System.EventHandler(this.NHomeBtn_Click);
            // 
            // NViewLeaveBtn
            // 
            this.NViewLeaveBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewLeaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NViewLeaveBtn.Location = new System.Drawing.Point(6, 35);
            this.NViewLeaveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NViewLeaveBtn.Name = "NViewLeaveBtn";
            this.NViewLeaveBtn.Size = new System.Drawing.Size(176, 28);
            this.NViewLeaveBtn.TabIndex = 18;
            this.NViewLeaveBtn.Text = "Inventory Home";
            this.NViewLeaveBtn.UseVisualStyleBackColor = false;
            this.NViewLeaveBtn.Click += new System.EventHandler(this.NViewLeaveBtn_Click);
            // 
            // NViewSalaryBtn
            // 
            this.NViewSalaryBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NViewSalaryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NViewSalaryBtn.Location = new System.Drawing.Point(6, 97);
            this.NViewSalaryBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NViewSalaryBtn.Name = "NViewSalaryBtn";
            this.NViewSalaryBtn.Size = new System.Drawing.Size(176, 28);
            this.NViewSalaryBtn.TabIndex = 18;
            this.NViewSalaryBtn.Text = "Deleted List";
            this.NViewSalaryBtn.UseVisualStyleBackColor = false;
            this.NViewSalaryBtn.Click += new System.EventHandler(this.NViewSalaryBtn_Click);
            // 
            // NStaffHomeBtn
            // 
            this.NStaffHomeBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.NStaffHomeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NStaffHomeBtn.Location = new System.Drawing.Point(7, 66);
            this.NStaffHomeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.NStaffHomeBtn.Name = "NStaffHomeBtn";
            this.NStaffHomeBtn.Size = new System.Drawing.Size(176, 28);
            this.NStaffHomeBtn.TabIndex = 17;
            this.NStaffHomeBtn.Text = "Item Report";
            this.NStaffHomeBtn.UseVisualStyleBackColor = false;
            this.NStaffHomeBtn.Click += new System.EventHandler(this.NStaffHomeBtn_Click);
            // 
            // subLabel2
            // 
            this.subLabel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.subLabel2.Location = new System.Drawing.Point(8, 88);
            this.subLabel2.Margin = new System.Windows.Forms.Padding(2);
            this.subLabel2.Name = "subLabel2";
            this.subLabel2.Size = new System.Drawing.Size(195, 179);
            this.subLabel2.TabIndex = 74;
            this.subLabel2.TabStop = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(736, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 27);
            this.button3.TabIndex = 78;
            this.button3.Text = "View All";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // InventoryProductReportGenerate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.UsrlinkLabel);
            this.Controls.Add(this.ButtonPanel);
            this.Controls.Add(this.subLabel2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button1);
            this.Name = "InventoryProductReportGenerate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InventoryProductReportGenerate";
            this.Load += new System.EventHandler(this.InventoryProductReportGenerate_Load);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ButtonPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnLogOutHeader;
        private System.Windows.Forms.Button btnNoticeMHeader;
        private System.Windows.Forms.Button btnExamMheader;
        private System.Windows.Forms.Button btnLibraryMHeader;
        private System.Windows.Forms.Button btnStudentMHeader;
        private System.Windows.Forms.Button btnResourseMHeader;
        private System.Windows.Forms.Button btnInventoryMHeader;
        private System.Windows.Forms.Button btnEventMHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel UsrlinkLabel;
        private System.Windows.Forms.Panel ButtonPanel;
        private System.Windows.Forms.Button NHomeBtn;
        private System.Windows.Forms.Button NViewLeaveBtn;
        private System.Windows.Forms.PictureBox subLabel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button NViewSalaryBtn;
        private System.Windows.Forms.Button NStaffHomeBtn;
    }
}