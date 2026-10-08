using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_On_tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void chkPC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkLaptop_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkMayIn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDienThoai_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh chụp lỗi";
            ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhLoi.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn ảnh chụp lỗi";
            ofd.Filter = "Image Files (*.jpg;*.png)|*.jpg;*.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnhLoi.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text) || string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                MessageBox.Show("Vui lòng nhập Mã phiếu và Người yêu cầu!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string mucDo = "";
            if (radThap.Checked) mucDo = "Thấp";
            else if (radTrungBinh.Checked) mucDo = "Trung bình";
            else if (radKhanCap.Checked) mucDo = "Khẩn cấp";

            string loaiSuCo = cmbLoaiSuCo.Text;
            if (string.IsNullOrEmpty(loaiSuCo)) loaiSuCo = "Chưa chọn";

            List<string> thietBi = new List<string>();
            if (chkPC.Checked) thietBi.Add("Máy tính bàn");
            if (chkLaptop.Checked) thietBi.Add("Laptop");
            if (chkMayIn.Checked) thietBi.Add("Máy in");
            if (chkDienThoai.Checked) thietBi.Add("Điện thoại");

            string dsThietBi = thietBi.Count > 0 ? string.Join(", ", thietBi) : "Không có";

            string tomTat = "=== THÔNG TIN PHIẾU YÊU CẦU ===\n\n" +
                            "Mã phiếu: " + txtMaPhieu.Text + "\n" +
                            "Người yêu cầu: " + txtNguoiYeuCau.Text + "\n" +
                            "Ngày ghi nhận: " + dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy") + "\n" +
                            "Mức độ ưu tiên: " + mucDo + "\n" +
                            "Loại sự cố: " + loaiSuCo + "\n" +
                            "Thiết bị ảnh hưởng: " + dsThietBi + "\n" +
                            "Đã đính kèm ảnh: " + (picAnhLoi.Image != null ? "Có" : "Không");

            MessageBox.Show(tomTat, "Xác nhận gửi yêu cầu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();

            dtpNgayGhiNhan.Value = DateTime.Now;

            radThap.Checked = true;

            cmbLoaiSuCo.SelectedIndex = -1; 

            chkPC.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            picAnhLoi.Image = null;

            txtMaPhieu.Focus();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
