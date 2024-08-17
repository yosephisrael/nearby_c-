namespace Nearby
{
    partial class Hotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hotel));
            this.hotelname = new System.Windows.Forms.Label();
            this.hotelstar = new System.Windows.Forms.Label();
            this.hotellocation = new System.Windows.Forms.Label();
            this.bedroom = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbstar = new System.Windows.Forms.TextBox();
            this.tblocation = new System.Windows.Forms.TextBox();
            this.tbbedroom = new System.Windows.Forms.TextBox();
            this.clear = new System.Windows.Forms.Button();
            this.submit = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelname
            // 
            this.hotelname.AutoSize = true;
            this.hotelname.ForeColor = System.Drawing.Color.White;
            this.hotelname.Location = new System.Drawing.Point(123, 138);
            this.hotelname.Name = "hotelname";
            this.hotelname.Size = new System.Drawing.Size(63, 13);
            this.hotelname.TabIndex = 0;
            this.hotelname.Text = "Hotel Name";
            // 
            // hotelstar
            // 
            this.hotelstar.AutoSize = true;
            this.hotelstar.ForeColor = System.Drawing.Color.White;
            this.hotelstar.Location = new System.Drawing.Point(123, 175);
            this.hotelstar.Name = "hotelstar";
            this.hotelstar.Size = new System.Drawing.Size(26, 13);
            this.hotelstar.TabIndex = 1;
            this.hotelstar.Text = "Star";
            this.hotelstar.Click += new System.EventHandler(this.label2_Click);
            // 
            // hotellocation
            // 
            this.hotellocation.AutoSize = true;
            this.hotellocation.ForeColor = System.Drawing.Color.White;
            this.hotellocation.Location = new System.Drawing.Point(123, 222);
            this.hotellocation.Name = "hotellocation";
            this.hotellocation.Size = new System.Drawing.Size(76, 13);
            this.hotellocation.TabIndex = 2;
            this.hotellocation.Text = "Hotel Location";
            // 
            // bedroom
            // 
            this.bedroom.AutoSize = true;
            this.bedroom.ForeColor = System.Drawing.Color.White;
            this.bedroom.Location = new System.Drawing.Point(123, 264);
            this.bedroom.Name = "bedroom";
            this.bedroom.Size = new System.Drawing.Size(83, 13);
            this.bedroom.TabIndex = 3;
            this.bedroom.Text = "No of Bedrooms";
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(229, 135);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(223, 20);
            this.tbname.TabIndex = 4;
            // 
            // tbstar
            // 
            this.tbstar.Location = new System.Drawing.Point(229, 175);
            this.tbstar.Name = "tbstar";
            this.tbstar.Size = new System.Drawing.Size(223, 20);
            this.tbstar.TabIndex = 5;
            // 
            // tblocation
            // 
            this.tblocation.Location = new System.Drawing.Point(229, 215);
            this.tblocation.Name = "tblocation";
            this.tblocation.Size = new System.Drawing.Size(223, 20);
            this.tblocation.TabIndex = 6;
            // 
            // tbbedroom
            // 
            this.tbbedroom.Location = new System.Drawing.Point(229, 257);
            this.tbbedroom.Name = "tbbedroom";
            this.tbbedroom.Size = new System.Drawing.Size(223, 20);
            this.tbbedroom.TabIndex = 7;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(124, 313);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 8;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button_Click);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(229, 313);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 9;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(406, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 97);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(327, 313);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 12;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.button_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(419, 313);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 13;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.button_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(520, 135);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(368, 201);
            this.dgv.TabIndex = 14;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(797, 341);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 15;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.button_Click);
            // 
            // Hotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(910, 376);
            this.Controls.Add(this.view);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.tbbedroom);
            this.Controls.Add(this.tblocation);
            this.Controls.Add(this.tbstar);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.bedroom);
            this.Controls.Add(this.hotellocation);
            this.Controls.Add(this.hotelstar);
            this.Controls.Add(this.hotelname);
            this.Name = "Hotel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label hotelname;
        private System.Windows.Forms.Label hotelstar;
        private System.Windows.Forms.Label hotellocation;
        private System.Windows.Forms.Label bedroom;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbstar;
        private System.Windows.Forms.TextBox tblocation;
        private System.Windows.Forms.TextBox tbbedroom;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button view;
    }
}