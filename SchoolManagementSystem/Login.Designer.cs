namespace SchoolManagementSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pwdTxtBox = new System.Windows.Forms.TextBox();
            this.unTxtBox = new System.Windows.Forms.TextBox();
            this.LgnBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.LgnImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LgnImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pwdTxtBox
            // 
            this.pwdTxtBox.Location = new System.Drawing.Point(827, 337);
            this.pwdTxtBox.Name = "pwdTxtBox";
            this.pwdTxtBox.PasswordChar = '*';
            this.pwdTxtBox.Size = new System.Drawing.Size(151, 22);
            this.pwdTxtBox.TabIndex = 11;
            // 
            // unTxtBox
            // 
            this.unTxtBox.Location = new System.Drawing.Point(827, 274);
            this.unTxtBox.Name = "unTxtBox";
            this.unTxtBox.Size = new System.Drawing.Size(151, 22);
            this.unTxtBox.TabIndex = 10;
            // 
            // LgnBtn
            // 
            this.LgnBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LgnBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LgnBtn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LgnBtn.Location = new System.Drawing.Point(758, 398);
            this.LgnBtn.Name = "LgnBtn";
            this.LgnBtn.Size = new System.Drawing.Size(136, 56);
            this.LgnBtn.TabIndex = 9;
            this.LgnBtn.Text = "Login";
            this.LgnBtn.UseVisualStyleBackColor = false;
            this.LgnBtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(676, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(676, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 7;
            this.label2.Text = "User Name";
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLbl.ForeColor = System.Drawing.Color.Red;
            this.WelcomeLbl.Location = new System.Drawing.Point(664, 203);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(329, 32);
            this.WelcomeLbl.TabIndex = 6;
            this.WelcomeLbl.Text = "Welcome to School System";
            this.WelcomeLbl.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // LgnImg
            // 
            this.LgnImg.Image = ((System.Drawing.Image)(resources.GetObject("LgnImg.Image")));
            this.LgnImg.Location = new System.Drawing.Point(278, 161);
            this.LgnImg.Name = "LgnImg";
            this.LgnImg.Size = new System.Drawing.Size(285, 320);
            this.LgnImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LgnImg.TabIndex = 12;
            this.LgnImg.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.LgnImg);
            this.Controls.Add(this.pwdTxtBox);
            this.Controls.Add(this.unTxtBox);
            this.Controls.Add(this.LgnBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WelcomeLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "School Management System";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LgnImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pwdTxtBox;
        private System.Windows.Forms.TextBox unTxtBox;
        private System.Windows.Forms.Button LgnBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WelcomeLbl;
        private System.Windows.Forms.PictureBox LgnImg;
    }
}
