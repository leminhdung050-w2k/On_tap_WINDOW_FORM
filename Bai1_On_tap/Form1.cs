using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_On_tap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double donGia;
            int soLuong;
            double giamGia;
  
            bool isDonGiaValid = double.TryParse(txtDonGia.Text, out donGia);
            bool isSoLuongValid = int.TryParse(txtSoLuong.Text, out soLuong);
 
            bool isGiamGiaValid = true;
            if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                giamGia = 0;
            }
            else
            {
                isGiamGiaValid = double.TryParse(txtGiamGia.Text, out giamGia);
            }

            if (!isDonGiaValid || !isSoLuongValid || !isGiamGiaValid)
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào các ô nhập liệu! Không được để trống Đơn giá và Số lượng.",
                                "Lỗi nhập liệu",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; 
            }

            double tongTien = (donGia * soLuong) * ((100 - giamGia) / 100.0);
            lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();

            lblTongTien.Text = "0 VNĐ";

     
            txtDonGia.Focus();
        }
    }
}
