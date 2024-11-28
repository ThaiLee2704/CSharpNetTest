using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_bài_1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            frmtimkiemsach a = new frmtimkiemsach();
            a.Show();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            Frmtaomoitk a = new Frmtaomoitk();
            a.Show();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            frmkhoa a = new frmkhoa();
            a.Show();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            frmKhoa_Docgia a = new frmKhoa_Docgia();
            a.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5f;
            frmtimkiemsach a = new frmtimkiemsach();
            a.Show();
            a.FormClosed += (s, args) => this.Opacity = 1;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5f;
            Frmtaomoitk a = new Frmtaomoitk();
            a.Show();
            a.FormClosed += (s, args) => this.Opacity = 1;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5f;
            frmkhoa a = new frmkhoa();
            a.Show();
            a.FormClosed += (s, args) => this.Opacity = 1;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Opacity = 0.5f;
            frmKhoa_Docgia a = new frmKhoa_Docgia();
            a.Show();
            a.FormClosed += (s, args) => this.Opacity = 1;
        }
    }
}
