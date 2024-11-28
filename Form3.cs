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
    public partial class frmkhoa : Form
    {
        SqlConnection cn;
        SqlCommand cmdkhoa;
        SqlDataAdapter dakhoa;
        SqlCommandBuilder cb;
        DataSet ds;

        public frmkhoa()
        {
            InitializeComponent();
        }

        private void BuocCacDieuKhien()
        {
            //Buộc dữ liệu vào dataGridView1 
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "khoa";
            // Buộc dữ liệu vào các textBox 
            txtMaKhoa.DataBindings.Add("Text", ds, "khoa.makhoa");
            txtTenKhoa.DataBindings.Add("Text", ds, "khoa.tenkhoa");
            txtDiachi.DataBindings.Add("Text", ds, "khoa.diachi");
            txtSodienthoai.DataBindings.Add("Text", ds, "khoa.sdt");
        }

        private void frmkhoa_Load(object sender, EventArgs e)
        {
            string connectionString = "server = DESKTOP-Q2SVGPA\\SQLEXPRESS; database = Quanlythuvien; integrated security = true; "; 
            cn = new SqlConnection(connectionString);
            cn.Open(); // Kết nối dữ liệu 
            cmdkhoa = new SqlCommand("select * from khoa", cn);
            dakhoa = new SqlDataAdapter(cmdkhoa);
            ds = new DataSet();
            dakhoa.Fill(ds, "khoa");
            BuocCacDieuKhien();
            cb = new SqlCommandBuilder(dakhoa);
        }

        private void butFirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa"].Position = 0;
        }

        private void butPre_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa"].Position--;
        }

        private void butNext_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa"].Position++;
        }

        private void butLast_Click(object sender, EventArgs e)
        {
            int ViTriMauTinCuoiCung = this.BindingContext[ds, "khoa"].Count - 1;
            this.BindingContext[ds, "khoa"].Position = ViTriMauTinCuoiCung;
        }

        private void butBosung_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa"].AddNew();
        }

        private void butLuu_Click(object sender, EventArgs e)
        {
            this.BindingContext[ds, "khoa"].EndCurrentEdit();
            if (ds.HasChanges() == true)
            {
                try
                {
                    dakhoa.Update(ds, "khoa");
                    MessageBox.Show("Da cap nhat");
                }
                catch (Exception ll) { MessageBox.Show(ll.Message); }
            }
        }

        private void butXoa_Click(object sender, EventArgs e)
        {
            int donghientai;
            donghientai = this.BindingContext[ds, "khoa"].Position;
            this.BindingContext[ds, "khoa"].RemoveAt(donghientai);
        }
    }
}
