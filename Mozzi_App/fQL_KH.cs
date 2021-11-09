using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mozzi_App.Model;

namespace Mozzi_App
{
    public partial class fQL_KH : Form
    {
        DBcontext DBcon = new DBcontext(); // liên kết DB
        public fQL_KH()
        {
            InitializeComponent();
        }

        private void fQL_KH_Load(object sender, EventArgs e)
        {
            FormLoad();
            LoadDGV();

        }

        private void LoadDGV() // load DGV (tất cả KH)
        {
            List<KH> kHs = DBcon.KH.ToList(); //lấy ds kh 
            fillListKH(kHs);// in ds kh ra dgv 
        }

        private void fillListKH(List<KH> kHs)// in list kiểu dữ kiêu KH  lên DGV
        {
            dataGridView1.Rows.Clear();// xóa trắng 
            foreach (var item in kHs)// dò trong list 
            {
                int e = dataGridView1.Rows.Add(); //tạo 1 dòng in ra item 
                dataGridView1.Rows[e].Cells[0].Value = item.ID_KH;
                dataGridView1.Rows[e].Cells[1].Value = item.Name_KH;
                dataGridView1.Rows[e].Cells[2].Value = item.SDT;
                dataGridView1.Rows[e].Cells[3].Value = item.Address;
                dataGridView1.Rows[e].Cells[4].Value = item.Points;


            }
        }

        private void FormLoad()
        {
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            txtIDKH.Text = "";
            txtNameKH.Text = "";
            txtAddress.Text = "";
            txtSDT.Text = "";
            txtDiem.Text = "0";
        }
        private bool checkInputData()
        {
            int Diem;
            
            if ((txtNameKH.Text == "") || (txtSDT.Text == "")  )
            {
                MessageBox.Show("khong dược de trống dữ liệu : Tên KH / SDT KH", "Thông báo");
                return false;
            }
            else if (int.TryParse(txtDiem.Text, out Diem) == false )
            {
                MessageBox.Show("nhap sai kieu dữ liệu Diem ", "Thông báo");

                return false;
            }
            else
                return true;
        }

        private void txtDiem_TextChanged(object sender, EventArgs e)
        {
            if (txtDiem.Text=="")
            {
                txtDiem.Text = "0";
            }
            int Diem;

            if (int.TryParse(txtDiem.Text, out Diem) == false)
            {
                MessageBox.Show("nhap sai kieu dữ liệu Điểm , vui lòng nhập ' số nguyên' !!! ", "Thông báo");

            }
        }// kiểm tra dữ liệu khi nhập điểm 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtIDKH.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtNameKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtSDT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (dataGridView1.CurrentRow.Cells[3].Value != null)
                {
                    txtAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                }
                else
                    txtAddress.Text = "";

                txtDiem.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;

            }
            catch (Exception)
            {

            }
        }

        private void btnAddKH_Click(object sender, EventArgs e)
        {
            FormLoad();
            btnAdd.Enabled = true;

        }

        private void btnFind_Click(object sender, EventArgs e)// nut hiện tất cả khách hàng 
        {
            LoadDGV();
        }
        private void FindKH(List<KH> listKH)// hàm  tìm khách hàng 
        {
            dataGridView1.Rows.Clear();
            foreach (var item in listKH)
            {
                if (item.Name_KH.ToString().Contains(txtFind.Text) || 
                    item.SDT.Contains(txtFind.Text)|| 
                        item.ID_KH.ToString().Contains(txtFind.Text) )
                {
                    int e = dataGridView1.Rows.Add();
                    dataGridView1.Rows[e].Cells[0].Value = item.ID_KH;
                    dataGridView1.Rows[e].Cells[1].Value = item.Name_KH;
                    dataGridView1.Rows[e].Cells[2].Value = item.SDT;
                    dataGridView1.Rows[e].Cells[3].Value = item.Address;
                    dataGridView1.Rows[e].Cells[4].Value = item.Points;
                }


            }

        }

        private void btnAdd_Click(object sender, EventArgs e)// thêm khách hàng 
        {

            try
            {
                if (checkInputData() == true)
                {
                     KH lastKH = new KH();

                    List<KH> listKH = DBcon.KH.ToList();
                    lastKH = listKH[listKH.Count - 1];

                    KH newKH = new KH();
                    newKH.ID_KH = lastKH.ID_KH + 1;
                    newKH.Name_KH = txtNameKH.Text;
                    newKH.SDT = txtSDT.Text;
                    newKH.Address = txtAddress.Text;
                    newKH.Points = Convert.ToInt32(txtDiem.Text);



                    DBcon.KH.AddOrUpdate(newKH);
                    DBcon.SaveChanges();
                    LoadDGV();

                    FormLoad();
                    MessageBox.Show($" Thêm Khách Hàng: { newKH.Name_KH} thành công", "Thông báo");

                }
            }

            catch (Exception)
            {
                MessageBox.Show($" test", "Thông báo");

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)// sửa tt khách hàng 
        {
            try
            {
                if (checkInputData() == true)
                {

                    KH KhEdit = DBcon.KH.FirstOrDefault(p => p.ID_KH.ToString() == (txtIDKH.Text));
                    if (KhEdit != null)
                    {
                        KhEdit.Name_KH = txtNameKH.Text;
                        KhEdit.SDT = txtSDT.Text;
                        KhEdit.Address = txtAddress.Text;
                        KhEdit.Points = Convert.ToInt32(txtDiem.Text);



                        DBcon.KH.AddOrUpdate(KhEdit);
                        DBcon.SaveChanges();
                        LoadDGV();
                        FormLoad();
                        MessageBox.Show($" cập nhật Khách Hàng : { KhEdit.Name_KH} thành công", "Thông báo");
                    }

                }
            }

            catch (Exception)
            {
                MessageBox.Show($" test", "Thông báo");

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)// xáo khách hàng 
        {
            try
            {
                if (txtIDKH.Text != null)
                {
                    KH KhDelete = DBcon.KH.FirstOrDefault(p => p.ID_KH.ToString() == txtIDKH.Text);
                    if (KhDelete != null)
                    {

                        DBcon.KH.Remove(KhDelete);
                        DBcon.SaveChanges();
                        LoadDGV();// load lại DGV 
                        FormLoad();// load lại form 
                        MessageBox.Show($" xóa KH: { KhDelete.Name_KH} thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show($"Ko tìm thấy Mã khách hàng  cần xóa : { txtIDKH.Text} ", "Thông báo");
                }

            }
            catch (Exception)
            {


            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e) // khi thay đổi dữ liệu sẽ tự tìm kiếm kh phù hợp 
        {
            List<KH> listKH = DBcon.KH.ToList();
            FindKH(listKH);
        }
    }
}
