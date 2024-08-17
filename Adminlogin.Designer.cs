namespace Nearby
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.adminusername = new System.Windows.Forms.Label();
            this.adminpassword = new System.Windows.Forms.Label();
            this.admintbUser = new System.Windows.Forms.TextBox();
            this.admintbPass = new System.Windows.Forms.TextBox();
            this.adminlogin = new System.Windows.Forms.Button();
            this.adminpictureBox1 = new System.Windows.Forms.PictureBox();
            this.admincheckBoxpass = new System.Windows.Forms.CheckBox();
            this.adminbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.adminpictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminusername
            // 
            this.adminusername.AutoSize = true;
            this.adminusername.ForeColor = System.Drawing.Color.White;
            this.adminusername.Location = new System.Drawing.Point(114, 131);
            this.adminusername.Name = "adminusername";
            this.adminusername.Size = new System.Drawing.Size(55, 13);
            this.adminusername.TabIndex = 0;
            this.adminusername.Text = "Username";
            this.adminusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // adminpassword
            // 
            this.adminpassword.AutoSize = true;
            this.adminpassword.ForeColor = System.Drawing.Color.White;
            this.adminpassword.Location = new System.Drawing.Point(114, 172);
            this.adminpassword.Name = "adminpassword";
            this.adminpassword.Size = new System.Drawing.Size(53, 13);
            this.adminpassword.TabIndex = 1;
            this.adminpassword.Text = "Password";
            // 
            // admintbUser
            // 
            this.admintbUser.Location = new System.Drawing.Point(204, 131);
            this.admintbUser.Name = "admintbUser";
            this.admintbUser.Size = new System.Drawing.Size(180, 20);
            this.admintbUser.TabIndex = 0;
            this.admintbUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.admintbUser_MouseDown);
            // 
            // admintbPass
            // 
            this.admintbPass.Location = new System.Drawing.Point(204, 165);
            this.admintbPass.Name = "admintbPass";
            this.admintbPass.Size = new System.Drawing.Size(180, 20);
            this.admintbPass.TabIndex = 1;
            this.admintbPass.UseSystemPasswordChar = true;
            this.admintbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            this.admintbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.admintbPass_KeyDown);
            // 
            // adminlogin
            // 
            this.adminlogin.Location = new System.Drawing.Point(254, 252);
            this.adminlogin.Name = "adminlogin";
            this.adminlogin.Size = new System.Drawing.Size(75, 23);
            this.adminlogin.TabIndex = 4;
            this.adminlogin.Text = "Login";
            this.adminlogin.UseVisualStyleBackColor = true;
            this.adminlogin.Click += new System.EventHandler(this.login_Click);
            this.adminlogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminlogin_KeyDown);
            // 
            // adminpictureBox1
            // 
            this.adminpictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("adminpictureBox1.ErrorImage")));
            this.adminpictureBox1.ImageLocation = "D:\\";
            this.adminpictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("adminpictureBox1.InitialImage")));
            this.adminpictureBox1.Location = new System.Drawing.Point(180, 12);
            this.adminpictureBox1.Name = "adminpictureBox1";
            this.adminpictureBox1.Size = new System.Drawing.Size(134, 106);
            this.adminpictureBox1.TabIndex = 6;
            this.adminpictureBox1.TabStop = false;
            // 
            // admincheckBoxpass
            // 
            this.admincheckBoxpass.AutoSize = true;
            this.admincheckBoxpass.Location = new System.Drawing.Point(204, 191);
            this.admincheckBoxpass.Name = "admincheckBoxpass";
            this.admincheckBoxpass.Size = new System.Drawing.Size(102, 17);
            this.admincheckBoxpass.TabIndex = 7;
            this.admincheckBoxpass.Text = "Show Password";
            this.admincheckBoxpass.UseVisualStyleBackColor = true;
            this.admincheckBoxpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // adminbutton1
            // 
            this.adminbutton1.BackColor = System.Drawing.Color.LightGray;
            this.adminbutton1.Location = new System.Drawing.Point(331, 191);
            this.adminbutton1.Name = "adminbutton1";
            this.adminbutton1.Size = new System.Drawing.Size(53, 23);
            this.adminbutton1.TabIndex = 2;
            this.adminbutton1.Text = "Clear";
            this.adminbutton1.UseVisualStyleBackColor = false;
            this.adminbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adminbutton1);
            this.Controls.Add(this.admincheckBoxpass);
            this.Controls.Add(this.adminpictureBox1);
            this.Controls.Add(this.adminlogin);
            this.Controls.Add(this.admintbPass);
            this.Controls.Add(this.admintbUser);
            this.Controls.Add(this.adminpassword);
            this.Controls.Add(this.adminusername);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminpictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adminusername;
        private System.Windows.Forms.Label adminpassword;
        private System.Windows.Forms.TextBox admintbUser;
        private System.Windows.Forms.TextBox admintbPass;
        private System.Windows.Forms.Button adminlogin;
        private System.Windows.Forms.PictureBox adminpictureBox1;
        private System.Windows.Forms.CheckBox admincheckBoxpass;
        private System.Windows.Forms.Button adminbutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

