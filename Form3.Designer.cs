namespace ADO.NET_bài_1
{
    partial class frmkhoa
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
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtSodienthoai = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butBosung = new System.Windows.Forms.Button();
            this.butLuu = new System.Windows.Forms.Button();
            this.butXoa = new System.Windows.Forms.Button();
            this.butFirst = new System.Windows.Forms.Button();
            this.butPre = new System.Windows.Forms.Button();
            this.butNext = new System.Windows.Forms.Button();
            this.butLast = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khoa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số điện thoại";
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(151, 21);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(523, 22);
            this.txtMaKhoa.TabIndex = 4;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(151, 55);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(523, 22);
            this.txtTenKhoa.TabIndex = 5;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(151, 91);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(523, 22);
            this.txtDiachi.TabIndex = 6;
            // 
            // txtSodienthoai
            // 
            this.txtSodienthoai.Location = new System.Drawing.Point(151, 126);
            this.txtSodienthoai.Name = "txtSodienthoai";
            this.txtSodienthoai.Size = new System.Drawing.Size(523, 22);
            this.txtSodienthoai.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSodienthoai);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtTenKhoa);
            this.groupBox1.Controls.Add(this.txtMaKhoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(8, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 161);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // butBosung
            // 
            this.butBosung.Location = new System.Drawing.Point(8, 172);
            this.butBosung.Name = "butBosung";
            this.butBosung.Size = new System.Drawing.Size(75, 23);
            this.butBosung.TabIndex = 9;
            this.butBosung.Text = "Bổ sung";
            this.butBosung.UseVisualStyleBackColor = true;
            this.butBosung.Click += new System.EventHandler(this.butBosung_Click);
            // 
            // butLuu
            // 
            this.butLuu.Location = new System.Drawing.Point(89, 172);
            this.butLuu.Name = "butLuu";
            this.butLuu.Size = new System.Drawing.Size(75, 23);
            this.butLuu.TabIndex = 10;
            this.butLuu.Text = "Lưu";
            this.butLuu.UseVisualStyleBackColor = true;
            this.butLuu.Click += new System.EventHandler(this.butLuu_Click);
            // 
            // butXoa
            // 
            this.butXoa.Location = new System.Drawing.Point(170, 172);
            this.butXoa.Name = "butXoa";
            this.butXoa.Size = new System.Drawing.Size(75, 23);
            this.butXoa.TabIndex = 11;
            this.butXoa.Text = "Xóa";
            this.butXoa.UseVisualStyleBackColor = true;
            this.butXoa.Click += new System.EventHandler(this.butXoa_Click);
            // 
            // butFirst
            // 
            this.butFirst.Location = new System.Drawing.Point(390, 172);
            this.butFirst.Name = "butFirst";
            this.butFirst.Size = new System.Drawing.Size(75, 23);
            this.butFirst.TabIndex = 12;
            this.butFirst.Text = "|<";
            this.butFirst.UseVisualStyleBackColor = true;
            this.butFirst.Click += new System.EventHandler(this.butFirst_Click);
            // 
            // butPre
            // 
            this.butPre.Location = new System.Drawing.Point(471, 172);
            this.butPre.Name = "butPre";
            this.butPre.Size = new System.Drawing.Size(75, 23);
            this.butPre.TabIndex = 13;
            this.butPre.Text = "<<";
            this.butPre.UseVisualStyleBackColor = true;
            this.butPre.Click += new System.EventHandler(this.butPre_Click);
            // 
            // butNext
            // 
            this.butNext.Location = new System.Drawing.Point(552, 172);
            this.butNext.Name = "butNext";
            this.butNext.Size = new System.Drawing.Size(75, 23);
            this.butNext.TabIndex = 14;
            this.butNext.Text = ">>";
            this.butNext.UseVisualStyleBackColor = true;
            this.butNext.Click += new System.EventHandler(this.butNext_Click);
            // 
            // butLast
            // 
            this.butLast.Location = new System.Drawing.Point(633, 172);
            this.butLast.Name = "butLast";
            this.butLast.Size = new System.Drawing.Size(75, 23);
            this.butLast.TabIndex = 15;
            this.butLast.Text = ">|";
            this.butLast.UseVisualStyleBackColor = true;
            this.butLast.Click += new System.EventHandler(this.butLast_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 201);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(700, 237);
            this.dataGridView1.TabIndex = 16;
            // 
            // frmkhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butLast);
            this.Controls.Add(this.butNext);
            this.Controls.Add(this.butPre);
            this.Controls.Add(this.butFirst);
            this.Controls.Add(this.butXoa);
            this.Controls.Add(this.butLuu);
            this.Controls.Add(this.butBosung);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmkhoa";
            this.Text = "Thông tin về bảng Khoa";
            this.Load += new System.EventHandler(this.frmkhoa_Load);
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
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtSodienthoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butBosung;
        private System.Windows.Forms.Button butLuu;
        private System.Windows.Forms.Button butXoa;
        private System.Windows.Forms.Button butFirst;
        private System.Windows.Forms.Button butPre;
        private System.Windows.Forms.Button butNext;
        private System.Windows.Forms.Button butLast;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}