using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class LapPhieuKham : Form
    {
        public LapPhieuKham()
        {
            InitializeComponent();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ThanhToan form2 = new ThanhToan();
            form2.ShowDialog();
            this.Close();
        }

        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangKyKham form2 = new DangKyKham();
            form2.ShowDialog();
            this.Close();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap form2 = new DangNhap();
            form2.ShowDialog();
            this.Close();
        }
    }
}
