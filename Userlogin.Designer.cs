namespace Nearby
{
    partial class Userlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Userlogin));
            this.username = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(114, 131);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 0;
            this.username.Text = "Username";
            this.username.Click += new System.EventHandler(this.label1_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(114, 172);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 1;
            this.password.Text = "Password";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(204, 131);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(180, 20);
            this.tbUser.TabIndex = 0;
            this.tbUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbUser_MouseDown);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(204, 165);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(180, 20);
            this.tbPass.TabIndex = 1;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            this.tbPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPass_KeyDown);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(254, 252);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            this.login.KeyDown += new System.Windows.Forms.KeyEventHandler(this.login_KeyDown);
            // 
            // signup
            // 
            this.signup.Location = new System.Drawing.Point(344, 252);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(75, 23);
            this.signup.TabIndex = 5;
            this.signup.Text = "Sign Up";
            this.signup.UseVisualStyleBackColor = true;
            this.signup.Click += new System.EventHandler(this.login_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.ImageLocation = "D:\\";
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 106);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.Location = new System.Drawing.Point(204, 191);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxpass.TabIndex = 7;
            this.checkBoxpass.Text = "Show Password";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            this.checkBoxpass.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(331, 191);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(2, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(33, 33);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Userlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 297);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.signup);
            this.Controls.Add(this.login);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Name = "Userlogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button signup;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

