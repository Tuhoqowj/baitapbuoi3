using System;
using System.Windows.Forms;

namespace baitap3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvNhanVien.Columns.Add("MSNV", "MSNV");
            dgvNhanVien.Columns.Add("TenNV", "Tên NV");
            dgvNhanVien.Columns.Add("LuongCB", "Lương CB");
        }





        private void btnThem_Click(object sender, EventArgs e)
        {
            // Mở Form2 và truyền vào một delegate để thêm nhân viên vào DataGridView
            var form2 = new Form2((msnv, tenNV, luongCB) =>
            {
                // Thêm thông tin vào DataGridView
                dgvNhanVien.Rows.Add(msnv, tenNV, luongCB);
            });

            form2.ShowDialog(); // Hiển thị Form2
        }





        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.SelectedRows.Count > 0)
            {
                dgvNhanVien.Rows.RemoveAt(dgvNhanVien.SelectedRows[0].Index);
            }
        }


    }
}
