namespace Nearby
{
    partial class Book
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Book));
            this.label1 = new System.Windows.Forms.Label();
            this.tbsearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tblocation = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(72, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Location";
            // 
            // tbsearch
            // 
            this.tbsearch.Location = new System.Drawing.Point(202, 161);
            this.tbsearch.Name = "tbsearch";
            this.tbsearch.Size = new System.Drawing.Size(188, 20);
            this.tbsearch.TabIndex = 1;
            this.tbsearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(202, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 102);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(75, 206);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(315, 161);
            this.dgv.TabIndex = 3;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(464, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(464, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(526, 245);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(157, 20);
            this.tbname.TabIndex = 6;
            // 
            // tblocation
            // 
            this.tblocation.Location = new System.Drawing.Point(526, 206);
            this.tblocation.Name = "tblocation";
            this.tblocation.Size = new System.Drawing.Size(157, 20);
            this.tblocation.TabIndex = 7;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(608, 344);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.clear_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(516, 344);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 9;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(464, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Phone";
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(526, 287);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(157, 20);
            this.tbphone.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(566, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Details";
            // 
            // Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(765, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.tblocation);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbsearch);
            this.Controls.Add(this.label1);
            this.Name = "Book";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book";
            this.Load += new System.EventHandler(this.Book_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbsearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tblocation;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.Label label5;
    }
}