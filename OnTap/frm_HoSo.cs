using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap
{
    public partial class frm_HoSo : Form
    {
        
        LopDungChung lopchung = new LopDungChung();

        public void load_KhachHang()
        {
            string sql = "select * from KHACHHANG";
            dt_KhachHang.AutoGenerateColumns = true;
            dt_KhachHang.DataSource = lopchung.LoadDL(sql);
        }
        public void LoadCBGiaoVien()
        {
            string sql = "Select * from GIAOVIEN";
            cb_TenGV.DataSource = lopchung.LoadDL(sql);
            cb_TenGV.DisplayMember = "TENGVHD";
            cb_TenGV.ValueMember = "MSGVHD";
        }
        private void frm_HoSo_Load(object sender, EventArgs e)
        {
            try
            {
                load_KhachHang();
                LoadCBGiaoVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        public frm_HoSo()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dt_KhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txt_MaKH.Text = dt_KhachHang.CurrentRow.Cells["MSKH"].Value.ToString();
            txt_HoTen.Text = dt_KhachHang.CurrentRow.Cells["HOTEN"].Value.ToString();
            txt_DiaChi.Text = dt_KhachHang.CurrentRow.Cells["DIACHI"].Value.ToString();
            date_NgaySinh.Text = dt_KhachHang.CurrentRow.Cells["NGAYSINH"].Value.ToString();
            cb_TenGV.SelectedValue = dt_KhachHang.CurrentRow.Cells["MSGVHD"].Value.ToString();*/
            if (dt_KhachHang.CurrentRow != null)
            {
                txt_MaKH.Text = dt_KhachHang.CurrentRow.Cells["MSKH"]?.Value?.ToString();
                txt_HoTen.Text = dt_KhachHang.CurrentRow.Cells["HOTEN"]?.Value?.ToString();
                txt_DiaChi.Text = dt_KhachHang.CurrentRow.Cells["DIACHI"]?.Value?.ToString();
                date_NgaySinh.Text = dt_KhachHang.CurrentRow.Cells["NGAYSINH"]?.Value?.ToString();
                cb_TenGV.SelectedValue = dt_KhachHang.CurrentRow.Cells["MSGVHD"]?.Value?.ToString();
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into KHACHHANG (MSKH, HOTEN, DIACHI, NGAYSINH, MSGVHD) " +
             "values ('" + txt_MaKH.Text + "','" + txt_HoTen.Text + "','" +
             txt_DiaChi.Text + "', convert(datetime,'" + date_NgaySinh.Text +
             "',103), '" + cb_TenGV.SelectedValue + "')";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Thêm sách thành công");
            else MessageBox.Show("Thêm sách thất bại");
            load_KhachHang();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string sql = "Update KHACHHANG set HOTEN = '" + txt_HoTen.Text +
             "', DIACHI = '" + txt_DiaChi.Text +
             "', NGAYSINH = convert(datetime,'" + date_NgaySinh.Text + "',103), " +
             "MSGVHD = '" + cb_TenGV.SelectedValue +
             "' where MSKH = '" + txt_MaKH.Text + "'";
            int kq = lopchung.ThemXoaSua(sql);
            if (kq >= 1) MessageBox.Show("Cập nhật sách thành công");
            else MessageBox.Show("Cập nhật sách thất bại");
            load_KhachHang();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban thuc su co muon xoa hay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                string xoasv = "Delete KHACHHANG where MSKH = N'" + txt_MaKH.Text + "'";
                int kq = lopchung.ThemXoaSua(xoasv);
                if (kq >= 1)
                {
                    MessageBox.Show("Xoa khach hang thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xoa khach hang that bai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                load_KhachHang();
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("Ban thuc su co muon thoat hay khong", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
