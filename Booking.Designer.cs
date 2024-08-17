namespace Nearby
{
    partial class Booking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.delete = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.view = new System.Windows.Forms.Button();
            this.print = new System.Windows.Forms.Button();
            this.tbname = new System.Windows.Forms.TextBox();
            this.ppd = new System.Windows.Forms.PrintPreviewDialog();
            this.pdoc = new System.Drawing.Printing.PrintDocument();
            this.tbphone = new System.Windows.Forms.TextBox();
            this.tblocation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(367, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 133);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(566, 384);
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
            this.dgv.Location = new System.Drawing.Point(230, 151);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(423, 227);
            this.dgv.TabIndex = 14;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(273, 384);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(75, 23);
            this.view.TabIndex = 15;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.button_Click);
            // 
            // print
            // 
            this.print.Location = new System.Drawing.Point(415, 384);
            this.print.Name = "print";
            this.print.Size = new System.Drawing.Size(75, 23);
            this.print.TabIndex = 16;
            this.print.Text = "Print";
            this.print.UseVisualStyleBackColor = true;
            this.print.Click += new System.EventHandler(this.button_Click);
            // 
            // tbname
            // 
            this.tbname.Location = new System.Drawing.Point(760, 152);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(100, 20);
            this.tbname.TabIndex = 17;
            // 
            // ppd
            // 
            this.ppd.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppd.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppd.ClientSize = new System.Drawing.Size(400, 300);
            this.ppd.Enabled = true;
            this.ppd.Icon = ((System.Drawing.Icon)(resources.GetObject("ppd.Icon")));
            this.ppd.Name = "printPreviewDialog1";
            this.ppd.Visible = false;
            // 
            // pdoc
            // 
            this.pdoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdoc_PrintPage);
            // 
            // tbphone
            // 
            this.tbphone.Location = new System.Drawing.Point(760, 271);
            this.tbphone.Name = "tbphone";
            this.tbphone.Size = new System.Drawing.Size(100, 20);
            this.tbphone.TabIndex = 18;
            // 
            // tblocation
            // 
            this.tblocation.Location = new System.Drawing.Point(760, 214);
            this.tblocation.Name = "tblocation";
            this.tblocation.Size = new System.Drawing.Size(100, 20);
            this.tblocation.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(691, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(688, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Location";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(688, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phone";
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(912, 428);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tblocation);
            this.Controls.Add(this.tbphone);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.print);
            this.Controls.Add(this.view);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.Load += new System.EventHandler(this.Booking_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button print;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.PrintPreviewDialog ppd;
        private System.Drawing.Printing.PrintDocument pdoc;
        private System.Windows.Forms.TextBox tbphone;
        private System.Windows.Forms.TextBox tblocation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}