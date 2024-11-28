using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO.NET_bài_1
{
    public partial class frmKhoa_Docgia : Form
    {
        SqlConnection cn;
        SqlCommand cmdkhoa;
        SqlCommand cmddocgia;
        SqlDataAdapter dakhoa;
        SqlDataAdapter dadocgia;
        DataSet ds;
        SqlCommandBuilder cb;

        public frmKhoa_Docgia()
        {
            InitializeComponent();
        }

        private void Datquanhe(string bangchinh, string bangphu, string khoachinh, string khoaphu, string tenquanhe)
        {
            string connectionString = "server = DESKTOP-Q2SVGPA\\SQLEXPRESS; database = Quanlythuvien; integrated security = true; "; 
            cn = new SqlConnection(connectionString);
            cn.Open();
            cmdkhoa = new SqlCommand("select * from " + bangchinh, cn);
            dakhoa = new SqlDataAdapter(cmdkhoa);
            cmddocgia = new SqlCommand("select * from " + bangphu, cn);
            dadocgia = new SqlDataAdapter(cmddocgia);
            ds = new DataSet();
            dakhoa.Fill(ds, bangchinh);
            dadocgia.Fill(ds, bangphu);
            DataColumn chinh = ds.Tables[bangchinh].Columns[khoachinh];
            DataColumn phu = ds.Tables[bangphu].Columns[khoaphu];
            DataRelation r = new DataRelation(tenquanhe, chinh, phu);
            ds.Relations.Add(r);
        }

        private void BuocCacDieuKhien()
        {
            lstKhoa.DataSource = ds;
            lstKhoa.DisplayMember = "khoa.tenkhoa";
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "khoa.khoa_docgia";
            //khoa_docgia là tên quan hệ của 2 bảng khoa và docgia trong DataSet ds 
            txtMadocgia.DataBindings.Add("Text", ds, "khoa.khoa_docgia.madg");
            txtHoten.DataBindings.Add("Text", ds, "khoa.khoa_docgia.hoten");
            txtNgaysinh.DataBindings.Add("Text", ds, "khoa.khoa_docgia.ngaysinh");
            txtDiachi.DataBindings.Add("Text", ds, "khoa.khoa_docgia.diachi");
            txtNgaylapthe.DataBindings.Add("Text", ds, "khoa.khoa_docgia.ngaylapthe");
            txtMakhoa.DataBindings.Add("Text", ds, "khoa.khoa_docgia.makhoa");
        }

        private void frmKhoa_Docgia_Load(object sender, EventArgs e)
        {
            Datquanhe("khoa", "docgia", "makhoa", "makhoa", "khoa_docgia");
            cb = new SqlCommandBuilder(dadocgia);
            BuocCacDieuKhien();
        }

        private void butBosung_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa.khoa_docgia"].AddNew();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa.khoa_docgia"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    dakhoa.Update(ds, "docgia");
                    MessageBox.Show("Da cap nhat");
                }
                catch (Exception ll) { MessageBox.Show(ll.Message); }
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            int donghientai;
            donghientai = this.BindingContext[ds, "khoa.khoa_docgia"].Position;
            this.BindingContext[ds, "khoa.khoa_docgia"].RemoveAt(donghientai);
        }

        private void butPhuchoi_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa.khoa_docgia"].CancelCurrentEdit();
            ds.RejectChanges();
        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa.khoa_docgia"].Position = 0;
        }

        private void butPre_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa.khoa_docgia"].Position--;
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa.khoa_docgia"].Position++;
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            int ViTri = this.BindingContext[ds, "khoa.khoa_docgia"].Count - 1;
            this.BindingContext[ds, "khoa"].Position = ViTri;
        }
    }
}
