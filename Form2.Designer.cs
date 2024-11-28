namespace ADO.NET_bài_1
{
    partial class frmtimkiemsach
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
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.thanhtrangthai = new System.Windows.Forms.StatusStrip();
            this.ketquatim = new System.Windows.Forms.ToolStripStatusLabel();
            this.tongsoluong = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.thanhtrangthai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên sách hoặc tên tác giả cần tìm";
            // 
            // txttimkiem
            // 
            this.txttimkiem.Location = new System.Drawing.Point(277, 6);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(373, 22);
            this.txttimkiem.TabIndex = 1;
            this.txttimkiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttimkiem_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(635, 133);
            this.dataGridView1.TabIndex = 2;
            // 
            // thanhtrangthai
            // 
            this.thanhtrangthai.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.thanhtrangthai.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ketquatim,
            this.tongsoluong});
            this.thanhtrangthai.Location = new System.Drawing.Point(0, 153);
            this.thanhtrangthai.Name = "thanhtrangthai";
            this.thanhtrangthai.Size = new System.Drawing.Size(662, 26);
            this.thanhtrangthai.TabIndex = 3;
            this.thanhtrangthai.Text = "statusStrip1";
            // 
            // ketquatim
            // 
            this.ketquatim.Name = "ketquatim";
            this.ketquatim.Size = new System.Drawing.Size(151, 20);
            this.ketquatim.Text = "toolStripStatusLabel1";
            // 
            // tongsoluong
            // 
            this.tongsoluong.Name = "tongsoluong";
            this.tongsoluong.Size = new System.Drawing.Size(151, 20);
            this.tongsoluong.Text = "toolStripStatusLabel1";
            // 
            // frmtimkiemsach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 179);
            this.Controls.Add(this.thanhtrangthai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.label1);
            this.Name = "frmtimkiemsach";
            this.Text = "Tìm kiếm theo nhan đề hoặc tác giả";
            this.Load += new System.EventHandler(this.frmtimkiemsach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.thanhtrangthai.ResumeLayout(false);
            this.thanhtrangthai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip thanhtrangthai;
        private System.Windows.Forms.ToolStripStatusLabel ketquatim;
        private System.Windows.Forms.ToolStripStatusLabel tongsoluong;
    }
}