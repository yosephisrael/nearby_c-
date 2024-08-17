namespace Nearby
{
    partial class Signup
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
            System.Windows.Forms.PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.firstname = new System.Windows.Forms.Label();
            this.lastname = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.tbpassword = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.tblastname = new System.Windows.Forms.TextBox();
            this.tbfirstname = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.checkBoxpass = new System.Windows.Forms.CheckBox();
            this.pictureBoxback = new System.Windows.Forms.PictureBox();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxback)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            pictureBox1.ImageLocation = "";
            pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            pictureBox1.Location = new System.Drawing.Point(229, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(126, 133);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // firstname
            // 
            this.firstname.AutoSize = true;
            this.firstname.ForeColor = System.Drawing.Color.White;
            this.firstname.Location = new System.Drawing.Point(124, 173);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(57, 13);
            this.firstname.TabIndex = 0;
            this.firstname.Text = "First Name";
            // 
            // lastname
            // 
            this.lastname.AutoSize = true;
            this.lastname.ForeColor = System.Drawing.Color.White;
            this.lastname.Location = new System.Drawing.Point(123, 211);
            this.lastname.Name = "lastname";
            this.lastname.Size = new System.Drawing.Size(58, 13);
            this.lastname.TabIndex = 1;
            this.lastname.Text = "Last Name";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.ForeColor = System.Drawing.Color.White;
            this.password.Location = new System.Drawing.Point(123, 281);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 2;
            this.password.Text = "Password";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.ForeColor = System.Drawing.Color.White;
            this.username.Location = new System.Drawing.Point(123, 247);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(55, 13);
            this.username.TabIndex = 3;
            this.username.Text = "Username";
            // 
            // tbpassword
            // 
            this.tbpassword.Location = new System.Drawing.Point(195, 281);
            this.tbpassword.Name = "tbpassword";
            this.tbpassword.Size = new System.Drawing.Size(204, 20);
            this.tbpassword.TabIndex = 4;
            this.tbpassword.UseSystemPasswordChar = true;
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(195, 247);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(204, 20);
            this.tbusername.TabIndex = 3;
            // 
            // tblastname
            // 
            this.tblastname.Location = new System.Drawing.Point(195, 211);
            this.tblastname.Name = "tblastname";
            this.tblastname.Size = new System.Drawing.Size(204, 20);
            this.tblastname.TabIndex = 1;
            // 
            // tbfirstname
            // 
            this.tbfirstname.Location = new System.Drawing.Point(195, 173);
            this.tbfirstname.Name = "tbfirstname";
            this.tbfirstname.Size = new System.Drawing.Size(204, 20);
            this.tbfirstname.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(219, 343);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 5;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.submit_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(324, 343);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 6;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // checkBoxpass
            // 
            this.checkBoxpass.AutoSize = true;
            this.checkBoxpass.ForeColor = System.Drawing.Color.White;
            this.checkBoxpass.Location = new System.Drawing.Point(297, 307);
            this.checkBoxpass.Name = "checkBoxpass";
            this.checkBoxpass.Size = new System.Drawing.Size(102, 17);
            this.checkBoxpass.TabIndex = 10;
            this.checkBoxpass.Text = "Show Password";
            this.checkBoxpass.UseVisualStyleBackColor = true;
            // 
            // pictureBoxback
            // 
            this.pictureBoxback.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxback.Image")));
            this.pictureBoxback.Location = new System.Drawing.Point(3, 12);
            this.pictureBoxback.Name = "pictureBoxback";
            this.pictureBoxback.Size = new System.Drawing.Size(30, 37);
            this.pictureBoxback.TabIndex = 12;
            this.pictureBoxback.TabStop = false;
            this.pictureBoxback.Click += new System.EventHandler(this.pictureBoxback_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(566, 392);
            this.Controls.Add(this.pictureBoxback);
            this.Controls.Add(pictureBox1);
            this.Controls.Add(this.checkBoxpass);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tbfirstname);
            this.Controls.Add(this.tblastname);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbpassword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.password);
            this.Controls.Add(this.lastname);
            this.Controls.Add(this.firstname);
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxback)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstname;
        private System.Windows.Forms.Label lastname;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.TextBox tbpassword;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.TextBox tblastname;
        private System.Windows.Forms.TextBox tbfirstname;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.CheckBox checkBoxpass;
        private System.Windows.Forms.PictureBox pictureBoxback;
    }
}