using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mozzi_App
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnloginQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fLogin frm = new fLogin();
            frm.Show();
        }

        private void btnloginNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnNewHD_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fHoaDon fHoaDon = new fHoaDon();
            fHoaDon.MdiParent = this;
            fHoaDon.Show();
        }

        private void btnlogoutNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show($"Bạn có muốn  thoát chương trình ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);// tạo biến  sự kiên 
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }



        }

        private void btnQL_SP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            fSanPham fSanPham = new fSanPham();
            fSanPham.MdiParent = this;
            fSanPham.Show();
        }

        private void btnlogoutQL_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dlr = MessageBox.Show($"Bạn có muốn  thoát chương trình ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);// tạo biến  sự kiên 
            if (dlr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void barCheckItem1_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            f_QL_HoaDon f_QL_Hoa = new f_QL_HoaDon();
            f_QL_Hoa.MdiParent = this;
            f_QL_Hoa.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) // btn thêm khach hang
        {
            // MessageBox.Show("xin lỗi chức năng 1 sẽ sớm được hoàn thiện ", " SORY ");
            fQL_KH fKH = new fQL_KH();
            fKH.MdiParent = this;
            fKH.Show();
        }

        private void btnNewPNK_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("xin lỗi chức năng 2 sẽ sớm được hoàn thiện ", " SORY ");

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("xin lỗi chức năng 3 sẽ sớm được hoàn thiện ", " SORY ");

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("xin lỗi chức năng 4 sẽ sớm được hoàn thiện ", " SORY ");

        }
    }
}
