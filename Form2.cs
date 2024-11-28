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
    public partial class frmtimkiemsach : Form
    {
        SqlConnection cn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        private int Tongsoluong()
        {
            int s = 0;
            foreach (DataRow r in ds.Tables["sach"].Rows)
            {
                s += (int)r["soluong"];
            }
            return s;
        }

        private int Tongsoluongtk(DataView dv)
        {
            int s = 0;
            foreach (DataRow r in dv.ToTable("sach").Rows)
            {
                s += (int)r["soluong"];
            }
            return s;
        }

        private void frmtimkiemsach_Load(object sender, EventArgs e)
        {
            string connectionString = "server = DESKTOP-Q2SVGPA\\SQLEXPRESS; database = Quanlythuvien;integrated security = true; "; 
            cn = new SqlConnection(connectionString);
            cn.Open(); // Mở kết nối 
            cmd = new SqlCommand();
            da = new SqlDataAdapter();
            ds = new DataSet();
            cmd.CommandText = "select top 4 * from sach order by ngaynhap desc";
            cmd.Connection = cn;
            da.SelectCommand = cmd;
            da.Fill(ds, "sach"); // Nạp dữ liệu vào DataSet 
            dataGridView1.DataSource = ds.Tables["sach"];
            // Nạp dữ liệu vào dataGridView1 
            // Nạp dữ liệu vào thanh trạng thái 
            thanhtrangthai.Items[0].Text = "Tổng số sách:" + ds.Tables["sach"].Rows.Count.ToString();
            thanhtrangthai.Items[1].Text = "Tổng số lượng:" + Tongsoluong().ToString();
        }

        public frmtimkiemsach()
        {
            InitializeComponent();
        }

        private void txttimkiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                DataView dv = new DataView(ds.Tables["sach"]);
                //Nạp dữ liệu vào DataView 
                //bắt đầu lọc dữ liệu 
                dv.RowFilter = "nhande like '%" + txttimkiem.Text + "%' or tacgia like '%" + txttimkiem.Text + "%'"; 
                dataGridView1.DataSource = dv;
                //Nạp kết quả lọc trong dv vào dataGridView1 
                // Đưa số quyển sách và tổng số lượng sách lọc được vào thanh trang thái 
                thanhtrangthai.Items[0].Text = "Số kết quả tìm thấy được: " + dv.Count.ToString() + "/" + ds.Tables["sach"].Rows.Count.ToString();
                thanhtrangthai.Items[1].Text = "Tổng số lượng tìm thấy được:" + Tongsoluongtk(dv).ToString() + "/" + Tongsoluong().ToString();
            }
        }
    }
}
