namespace ADO.NET_bài_1
{
    partial class Frmtaomoitk
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Manv = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tendn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.butthoat = new System.Windows.Forms.Button();
            this.butxoabo = new System.Windows.Forms.Button();
            this.buttimkiem = new System.Windows.Forms.Button();
            this.buttaomoi = new System.Windows.Forms.Button();
            this.butcuoi = new System.Windows.Forms.Button();
            this.buttien = new System.Windows.Forms.Button();
            this.butlui = new System.Windows.Forms.Button();
            this.butdau = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txttendangnhap = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Quyen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Manv,
            this.Ten,
            this.DC,
            this.tendn,
            this.Quyen});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(796, 208);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Manv
            // 
            this.Manv.Text = "Mã nhân viên";
            this.Manv.Width = 116;
            // 
            // Ten
            // 
            this.Ten.Text = "Tên nhân viên";
            this.Ten.Width = 130;
            // 
            // DC
            // 
            this.DC.Text = "Địa chỉ";
            this.DC.Width = 79;
            // 
            // tendn
            // 
            this.tendn.Text = "Tên đăng nhập";
            this.tendn.Width = 126;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.butthoat);
            this.groupBox1.Controls.Add(this.butxoabo);
            this.groupBox1.Controls.Add(this.buttimkiem);
            this.groupBox1.Controls.Add(this.buttaomoi);
            this.groupBox1.Controls.Add(this.butcuoi);
            this.groupBox1.Controls.Add(this.buttien);
            this.groupBox1.Controls.Add(this.butlui);
            this.groupBox1.Controls.Add(this.butdau);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txttendangnhap);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.txtmanv);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(796, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin cơ bản";
            // 
            // butthoat
            // 
            this.butthoat.Location = new System.Drawing.Point(651, 167);
            this.butthoat.Name = "butthoat";
            this.butthoat.Size = new System.Drawing.Size(94, 30);
            this.butthoat.TabIndex = 17;
            this.butthoat.Text = "Thoát";
            this.butthoat.UseVisualStyleBackColor = true;
            this.butthoat.Click += new System.EventHandler(this.butthoat_Click);
            // 
            // butxoabo
            // 
            this.butxoabo.Location = new System.Drawing.Point(651, 121);
            this.butxoabo.Name = "butxoabo";
            this.butxoabo.Size = new System.Drawing.Size(94, 30);
            this.butxoabo.TabIndex = 16;
            this.butxoabo.Text = "Xoá bỏ";
            this.butxoabo.UseVisualStyleBackColor = true;
            this.butxoabo.Click += new System.EventHandler(this.butxoabo_Click);
            // 
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(651, 78);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(94, 30);
            this.buttimkiem.TabIndex = 15;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            this.buttimkiem.Click += new System.EventHandler(this.buttimkiem_Click);
            // 
            // buttaomoi
            // 
            this.buttaomoi.Location = new System.Drawing.Point(651, 30);
            this.buttaomoi.Name = "buttaomoi";
            this.buttaomoi.Size = new System.Drawing.Size(94, 30);
            this.buttaomoi.TabIndex = 14;
            this.buttaomoi.Text = "Tạo mới";
            this.buttaomoi.UseVisualStyleBackColor = true;
            this.buttaomoi.Click += new System.EventHandler(this.buttaomoi_Click);
            // 
            // butcuoi
            // 
            this.butcuoi.Location = new System.Drawing.Point(512, 167);
            this.butcuoi.Name = "butcuoi";
            this.butcuoi.Size = new System.Drawing.Size(94, 30);
            this.butcuoi.TabIndex = 13;
            this.butcuoi.Text = ">|";
            this.butcuoi.UseVisualStyleBackColor = true;
            this.butcuoi.Click += new System.EventHandler(this.butcuoi_Click);
            // 
            // buttien
            // 
            this.buttien.Location = new System.Drawing.Point(512, 121);
            this.buttien.Name = "buttien";
            this.buttien.Size = new System.Drawing.Size(94, 30);
            this.buttien.TabIndex = 12;
            this.buttien.Text = ">";
            this.buttien.UseVisualStyleBackColor = true;
            this.buttien.Click += new System.EventHandler(this.buttien_Click);
            // 
            // butlui
            // 
            this.butlui.Location = new System.Drawing.Point(512, 78);
            this.butlui.Name = "butlui";
            this.butlui.Size = new System.Drawing.Size(94, 30);
            this.butlui.TabIndex = 11;
            this.butlui.Text = "<";
            this.butlui.UseVisualStyleBackColor = true;
            this.butlui.Click += new System.EventHandler(this.butlui_Click);
            // 
            // butdau
            // 
            this.butdau.Location = new System.Drawing.Point(512, 31);
            this.butdau.Name = "butdau";
            this.butdau.Size = new System.Drawing.Size(94, 30);
            this.butdau.TabIndex = 10;
            this.butdau.Text = "|<";
            this.butdau.UseVisualStyleBackColor = true;
            this.butdau.Click += new System.EventHandler(this.butdau_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(226, 199);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // txttendangnhap
            // 
            this.txttendangnhap.Location = new System.Drawing.Point(226, 161);
            this.txttendangnhap.Name = "txttendangnhap";
            this.txttendangnhap.Size = new System.Drawing.Size(155, 26);
            this.txttendangnhap.TabIndex = 8;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(226, 115);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(155, 26);
            this.txtdiachi.TabIndex = 7;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(226, 72);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(155, 26);
            this.txthoten.TabIndex = 6;
            // 
            // txtmanv
            // 
            this.txtmanv.Location = new System.Drawing.Point(226, 35);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(155, 26);
            this.txtmanv.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quyền hạn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên";
            // 
            // Quyen
            // 
            this.Quyen.Text = "Quyền hạn";
            this.Quyen.Width = 107;
            // 
            // Frmtaomoitk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.Name = "Frmtaomoitk";
            this.Text = "Tạo mới một tài khoản";
            this.Load += new System.EventHandler(this.Frmtaomoitk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Manv;
        private System.Windows.Forms.ColumnHeader Ten;
        private System.Windows.Forms.ColumnHeader DC;
        private System.Windows.Forms.ColumnHeader tendn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butthoat;
        private System.Windows.Forms.Button butxoabo;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.Button buttaomoi;
        private System.Windows.Forms.Button butcuoi;
        private System.Windows.Forms.Button buttien;
        private System.Windows.Forms.Button butlui;
        private System.Windows.Forms.Button butdau;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txttendangnhap;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.ColumnHeader Quyen;
    }
}

