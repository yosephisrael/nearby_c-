namespace Nearby
{
    partial class Continueas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Continueas));
            this.admin = new System.Windows.Forms.Button();
            this.user = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // admin
            // 
            this.admin.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin.Location = new System.Drawing.Point(93, 180);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(147, 43);
            this.admin.TabIndex = 0;
            this.admin.Text = "Admin";
            this.admin.UseVisualStyleBackColor = true;
            this.admin.Click += new System.EventHandler(this.admin_Click);
            this.admin.MouseLeave += new System.EventHandler(this.admin_MouseLeave);
            this.admin.MouseHover += new System.EventHandler(this.admin_MouseHover);
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.Location = new System.Drawing.Point(308, 180);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(146, 43);
            this.user.TabIndex = 1;
            this.user.Text = "User";
            this.user.UseVisualStyleBackColor = true;
            this.user.Click += new System.EventHandler(this.admin_Click);
            this.user.MouseLeave += new System.EventHandler(this.user_MouseLeave);
            this.user.MouseHover += new System.EventHandler(this.user_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(158, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 122);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Continueas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(537, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.admin);
            this.Name = "Continueas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button admin;
        private System.Windows.Forms.Button user;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}