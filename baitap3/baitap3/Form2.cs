using System.Windows.Forms;
using System;

namespace baitap3
{
    public partial class Form2 : Form
    {
        private Action<string, string, string> _addNhanVien;

        // Constructor nhận vào một action để thêm nhân viên từ Form1
        public Form2(Action<string, string, string> addNhanVien)
        {
            InitializeComponent();
            _addNhanVien = addNhanVien;
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            // Kiểm tra thông tin nhập vào
            if (!string.IsNullOrWhiteSpace(txtMSNV.Text) &&
                !string.IsNullOrWhiteSpace(txtTenNV.Text) &&
                !string.IsNullOrWhiteSpace(txtLuongCB.Text))
            {
                // Gọi action truyền vào để thêm dữ liệu vào DataGridView trên Form1
                _addNhanVien(txtMSNV.Text, txtTenNV.Text, txtLuongCB.Text);

                // Đóng form và trả kết quả OK
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Đóng form nếu không muốn thêm nhân viên
            this.Close();
        }
    }
}
