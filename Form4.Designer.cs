namespace ADO.NET_bài_1
{
    partial class frmKhoa_Docgia
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMadocgia = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtNgaysinh = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtNgaylapthe = new System.Windows.Forms.TextBox();
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butBosung = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butPhuchoi = new System.Windows.Forms.Button();
            this.butFirst = new System.Windows.Forms.Button();
            this.butPre = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.butLast = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lstKhoa = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày lập thẻ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã khoa";
            // 
            // txtMadocgia
            // 
            this.txtMadocgia.Location = new System.Drawing.Point(121, 24);
            this.txtMadocgia.Name = "txtMadocgia";
            this.txtMadocgia.Size = new System.Drawing.Size(481, 22);
            this.txtMadocgia.TabIndex = 6;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(121, 53);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(481, 22);
            this.txtHoten.TabIndex = 7;
            // 
            // txtNgaysinh
            // 
            this.txtNgaysinh.Location = new System.Drawing.Point(121, 83);
            this.txtNgaysinh.Name = "txtNgaysinh";
            this.txtNgaysinh.Size = new System.Drawing.Size(481, 22);
            this.txtNgaysinh.TabIndex = 8;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(121, 113);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(481, 22);
            this.txtDiachi.TabIndex = 9;
            // 
            // txtNgaylapthe
            // 
            this.txtNgaylapthe.Location = new System.Drawing.Point(121, 144);
            this.txtNgaylapthe.Name = "txtNgaylapthe";
            this.txtNgaylapthe.Size = new System.Drawing.Size(481, 22);
            this.txtNgaylapthe.TabIndex = 10;
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Location = new System.Drawing.Point(121, 176);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(481, 22);
            this.txtMakhoa.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNgaylapthe);
            this.groupBox1.Controls.Add(this.txtMakhoa);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNgaysinh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMadocgia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(180, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(608, 208);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // butBosung
            // 
            this.butBosung.Location = new System.Drawing.Point(180, 226);
            this.butBosung.Name = "butBosung";
            this.butBosung.Size = new System.Drawing.Size(75, 32);
            this.butBosung.TabIndex = 13;
            this.butBosung.Text = "Bổ sung";
            this.butBosung.UseVisualStyleBackColor = true;
            this.butBosung.Click += new System.EventHandler(this.butBosung_Click);
            // 
            // butLuu
            // 
            this.butLuu.Location = new System.Drawing.Point(261, 226);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(75, 32);
            this.butLuu.TabIndex = 14;
            this.butLuu.Text = "Lưu";
            this.butLuu.UseVisualStyleBackColor = true;
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(342, 226);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 32);
            this.butXoa.TabIndex = 15;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butPhuchoi
            // 
            this.butPhuchoi.Location = new System.Drawing.Point(423, 226);
            this.butPhuchoi.Name = "butPhuchoi";
            this.butPhuchoi.Size = new System.Drawing.Size(75, 32);
            this.butPhuchoi.TabIndex = 16;
            this.butPhuchoi.Text = "Phục hồi";
            this.butPhuchoi.UseVisualStyleBackColor = true;
            this.butPhuchoi.Click += new System.EventHandler(this.butPhuchoi_Click);
            // 
            // butFirst
            // 
            this.butFirst.Location = new System.Drawing.Point(578, 226);
            this.butFirst.Name = "butFirst";
            this.butFirst.Size = new System.Drawing.Size(48, 32);
            this.butFirst.TabIndex = 17;
            this.butFirst.Text = "|<";
            this.butFirst.UseVisualStyleBackColor = true;
            this.butFirst.Click += new System.EventHandler(this.butFirst_Click);
            // 
            // butPre
            // 
            this.butPre.Location = new System.Drawing.Point(632, 226);
            this.butPre.Name = "butPre";
            this.butPre.Size = new System.Drawing.Size(48, 32);
            this.butPre.TabIndex = 18;
            this.butPre.Text = "<<";
            this.butPre.UseVisualStyleBackColor = true;
            this.butPre.Click += new System.EventHandler(this.butPre_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(686, 226);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(48, 32);
            this.butNext.TabIndex = 19;
            this.butNext.Text = ">>";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butLast
            // 
            this.butLast.Location = new System.Drawing.Point(740, 226);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(48, 32);
            this.butLast.TabIndex = 20;
            this.butLast.Text = ">|";
            this.butLast.UseVisualStyleBackColor = true;
            this.butLast.Click += new System.EventHandler(this.butLast_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(180, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 168);
            this.dataGridView1.TabIndex = 21;
            // 
            // lstKhoa
            // 
            this.lstKhoa.FormattingEnabled = true;
            this.lstKhoa.ItemHeight = 16;
            this.lstKhoa.Location = new System.Drawing.Point(12, 12);
            this.lstKhoa.Name = "lstKhoa";
            this.lstKhoa.Size = new System.Drawing.Size(162, 420);
            this.lstKhoa.TabIndex = 22;
            // 
            // frmKhoa_Docgia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 437);
            this.Controls.Add(this.lstKhoa);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butLast);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPre);
            this.Controls.Add(this.butFirst);
            this.Controls.Add(this.butPhuchoi);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butBosung);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKhoa_Docgia";
            this.Text = "Khoa và độc giả";
            this.Load += new System.EventHandler(this.frmKhoa_Docgia_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMadocgia;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtNgaysinh;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtNgaylapthe;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butBosung;
        private System.Windows.Forms.Button butLuu;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butPhuchoi;
        private System.Windows.Forms.Button butFirst;
        private System.Windows.Forms.Button butPre;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butLast;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ListBox lstKhoa;
    }
}