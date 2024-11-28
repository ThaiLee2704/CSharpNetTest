using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ADO.NET_bài_1
{
    public partial class Frmtaomoitk : Form
    {
        SqlConnection cn;
        SqlCommand cmdSelect;
        SqlCommand cmdInsert;
        SqlCommand cmdXoa;
        int i;

        public Frmtaomoitk()
        {
            InitializeComponent();
        }

        private void Moketnoi()
        {
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
        }
        private void LoadListView()
        {
            Moketnoi();
            cmdSelect = new SqlCommand("select * from nhanvien", cn);
            SqlDataReader r = cmdSelect.ExecuteReader();
            listView1.Items.Clear(); // Xóa tất cả dữ liệu trong listView1
            while (r.Read())
            {
                string[] st = new string[5];
                st[0] = r[0].ToString();
                st[1] = r[1].ToString();
                st[2] = r[2].ToString();// Không hiển thị mật khẩu, nên không có r[3]
                st[3] = r[3].ToString();
                st[4] = r[5].ToString();
                ListViewItem lv = new ListViewItem(st);
                listView1.Items.Add(lv);
            }
            cmdSelect.Dispose();
        }

        private void LoadItem(int i)
        {
            txtmanv.Text = listView1.Items[i].Text;
            txthoten.Text = listView1.Items[i].SubItems[1].Text;
            txtdiachi.Text = listView1.Items[i].SubItems[2].Text;
            txttendangnhap.Text = listView1.Items[i].SubItems[3].Text;
            comboBox1.Text = listView1.Items[i].SubItems[4].Text;
        }

        private void LoadCombox()
        {
            comboBox1.Items.Add("Admin");
            comboBox1.Items.Add("Sinhvien");
            comboBox1.Items.Add("ThuThu");
            comboBox1.Text = "Admin";
        }

        private void XoaTextBox()
        {
            txtmanv.Clear();
            txthoten.Clear();
            txtdiachi.Clear();
            txttendangnhap.Clear();
            txtmanv.Focus();
        }

        private int KiemTraMa(string ma)
        {
            Moketnoi();
            cmdSelect = new SqlCommand("select count(*) from nhanvien where manv ='"+ma.Trim()+"'");
            cmdSelect.Connection = cn;
            return (int)cmdSelect.ExecuteScalar();
        }

        private void Frmtaomoitk_Load(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "server = DESKTOP-Q2SVGPA\\SQLEXPRESS; database = Quanlythuvien;integrated security = true; ";
                cn = new SqlConnection(connectionString);
                cn.Open();
            }
            catch //(Exception loi)
            {
                MessageBox.Show("Không thể kết nối được");
            }
            LoadListView(); //Nạp dữ liệu vào cho listView1
            i = 0;
            LoadItem(i);// Nạp dữ liệu vào cho các textBox và comboBox1
            LoadCombox();
        }

        private void butdau_Click(object sender, EventArgs e)
        {
            i = 0;
            LoadItem(i);
        }

        private void buttien_Click(object sender, EventArgs e)
        {
            i++;
            if (i == listView1.Items.Count) i = listView1.Items.Count - 1;
            LoadItem(i);
        }

        private void butlui_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0) i = 0;
            LoadItem(i);
        }

        private void butcuoi_Click(object sender, EventArgs e)
        {
            i = listView1.Items.Count - 1;
            LoadItem(i);
        }

        private void buttaomoi_Click(object sender, EventArgs e)
        {
            if (buttaomoi.Text.Equals("Tạo mới"))
            {
                XoaTextBox();
                buttaomoi.Text = "Luu";
            }
            else// Kiểm tra xem mã nhân viên này có hay chưa ?
                if (KiemTraMa(txtmanv.Text) == 1)
            {
                MessageBox.Show("Mã này đã có");
                txtmanv.Clear();
                txtmanv.Focus();
            }
            else
            {
                string ma = txtmanv.Text;
                string hoten = txthoten.Text;
                string diachi = txtdiachi.Text;
                string tendangnhap = txttendangnhap.Text;
                string matkhau = "";// Khi tạo 1 tài khoản thì mật khẩu ban đầu là rỗng
                string quyenhan = comboBox1.Text;
                Moketnoi();
                string sql = "insert into nhanvien values(" + "'" + ma + "','" + hoten + "','" + diachi + "','" + tendangnhap + "','" + matkhau + "','" + quyenhan + "')";
                cmdInsert = new SqlCommand(sql, cn);
                cmdInsert.ExecuteNonQuery();
                MessageBox.Show("Đã lưu thành công");
                LoadListView(); //Nạp lại dữ liệu mới vào listView1
                buttaomoi.Text = "Tạo mới";
                cmdInsert.Dispose();
            }
        }

        private void buttimkiem_Click(object sender, EventArgs e)
        {
            Moketnoi();
            string sql = "select * from nhanvien where manv='" + txtmanv.Text + "'";
            cmdSelect = new SqlCommand(sql, cn);
            SqlDataReader dr = cmdSelect.ExecuteReader();
            if (dr.Read())// Đã tìm thấy
            {
                txtmanv.Text = dr[0].ToString();
                txthoten.Text = dr[1].ToString();
                txtdiachi.Text = dr[2].ToString();
                txttendangnhap.Text = dr[4].ToString();
                comboBox1.Text = dr[5].ToString();
            }
            else
                MessageBox.Show("Không tìm thấy");
        }

        private void butxoabo_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Chắc chắn xóa hay không ?", "Thông báo",MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes) // Nếu người sử dụng chọn nút yes
            {
                Moketnoi(); string Sql = "delete from nhanvien where manv='" + txtmanv.Text + "'";
                cmdXoa = new SqlCommand(Sql, cn);
                if (cmdXoa.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Xóa thành công");
                    LoadListView();
                    LoadItem(0);
                }
                else
                    MessageBox.Show("Không tồn tại mã nhân viên " + txtmanv.Text);
                cmdXoa.Dispose();
            }
        }

        private void butthoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
