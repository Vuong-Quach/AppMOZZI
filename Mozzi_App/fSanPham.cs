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
    public partial class fSanPham : Form
    {
        DBcontext DBcon = new DBcontext();
        public fSanPham()
        {
            InitializeComponent();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMasp.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtGia.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtSoLuong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtDonvi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
                btnAdd.Enabled = false;

            }
            catch (Exception)
            {

            }
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            FillListSP();
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;


        }// load form 

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMasp.Text != "")
                {
                    SP SpDelete = DBcon.SP.FirstOrDefault(p => p.ID_SP.ToString() == txtMasp.Text);
                    if (SpDelete != null)
                    {   

                        DBcon.SP.Remove(SpDelete);
                        DBcon.SaveChanges();
                        FillListSP();
                        loadform();
                        MessageBox.Show($" xóa Sản Phẩm: { SpDelete.Name_SP} thành công", "Thông báo");
                    }
                    else
                        MessageBox.Show($"Ko tìm thấy Mã SP cần xóa : { txtMasp.Text} ", "Thông báo");
                }

            }
            catch (Exception)
            {


            }
        }// nút delete  sp 

        private void label5_Click(object sender, EventArgs e)
        {

        }// nothing

        private bool checkInputData()
        {
            float SoLuong;
            decimal Gia;
            if ((txtName.Text == "") || (txtDonvi.Text == "") || (txtGia.Text == "") || (txtSoLuong.Text == ""))
            {
                MessageBox.Show("khong dược de trống dữ liệu", "Thông báo");
                return false;
            }
            else if (float.TryParse(txtSoLuong.Text, out SoLuong) == false || decimal.TryParse(txtGia.Text, out Gia) == false )
            {
                MessageBox.Show("nhap sai kieu dữ liệu Giá Tiền / Số lượng", "Thông báo");

                return false;
            }
            else
                return true;
        }// check dữ liệu đầu vào 
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                if (checkInputData() == true)
                {

                    SP newsP = new SP();
                    newsP.Name_SP = txtName.Text;
                    newsP.Don_vi_tinh = txtDonvi.Text;
                    newsP.Gia = Convert.ToDecimal(txtGia.Text);
                    newsP.So_Luong = Convert.ToInt32(txtSoLuong.Text);



                    DBcon.SP.AddOrUpdate(newsP);
                    DBcon.SaveChanges();
                    FillListSP();
                        loadform();


                    MessageBox.Show($" Thêm Sản phẩm : { newsP.Name_SP} thành công", "Thông báo");
                }
             }

            catch (Exception)
            {
                MessageBox.Show($" test", "Thông báo");

            }


        }// nút thêm và lưu vào db 

        private void loadform()
        {
            txtMasp.Text = "";
            txtName.Text = "";
            txtGia.Text = "";
            txtDonvi.Text = "";
            txtSoLuong.Text = "0";

        }// hàm load lại form 

        private void FillListSP() // hàm in sp lên bảng sp 
        {
            dataGridView1.Rows.Clear();
            List<SP> sPs = DBcon.SP.ToList();
            
            foreach (var item in sPs)
            {
                int e = dataGridView1.Rows.Add();
                dataGridView1.Rows[e].Cells[0].Value = item.ID_SP;
                dataGridView1.Rows[e].Cells[1].Value = item.Name_SP;
                dataGridView1.Rows[e].Cells[2].Value = item.Gia;
                dataGridView1.Rows[e].Cells[3].Value = item.So_Luong;
                dataGridView1.Rows[e].Cells[4].Value = item.Don_vi_tinh;


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkInputData() == true)
                {

                    SP SpEdit = DBcon.SP.FirstOrDefault(p => p.ID_SP.ToString() == (txtMasp.Text));
                    if(SpEdit != null)
                    {
                        SpEdit.Name_SP = txtName.Text;
                        SpEdit.Don_vi_tinh = txtDonvi.Text;
                        SpEdit.Gia = Convert.ToDecimal(txtGia.Text);
                        SpEdit.So_Luong = Convert.ToInt32(txtSoLuong.Text);



                        DBcon.SP.AddOrUpdate(SpEdit);
                        DBcon.SaveChanges();
                      
                        FillListSP();
                        loadform();


                        MessageBox.Show($" cập nhật Sản phẩm : { SpEdit.Name_SP} thành công", "Thông báo");
                    }
                   
                }
            }

            catch (Exception)
            {
                MessageBox.Show($" test", "Thông báo");

            }
        }// nút sửa sp 

        private void txtMasp_TextChanged(object sender, EventArgs e)
        {

        }// nothing

        private void btnaddsp_Click(object sender, EventArgs e)// nút thêm sp sp mới  
        {
            loadfromsp();
                
        }

        private void loadfromsp()// load lại form 
        {
            txtMasp.Text = "";
            txtDonvi.Text = "";
            txtGia.Text = "";
            txtName.Text = "";
            txtSoLuong.Text = "";
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void txtfind_TextChanged(object sender, EventArgs e)// sự kiện khi thay đổi dữ liệu ô tìm kiếm sp 
        {
           
            findSP();
        }

        private void findSP()
        {
            List<SP> listSP = DBcon.SP.ToList();
            dataGridView1.Rows.Clear();
            foreach (var item in listSP)
            {
                if (item.ID_SP.ToString().Contains(txtfind.Text)
                    || item.Name_SP.Contains(txtfind.Text))
                {

                    int e = dataGridView1.Rows.Add();
                    dataGridView1.Rows[e].Cells[0].Value = item.ID_SP;
                    dataGridView1.Rows[e].Cells[1].Value = item.Name_SP;
                    dataGridView1.Rows[e].Cells[2].Value = item.Gia;
                    dataGridView1.Rows[e].Cells[3].Value = item.So_Luong;
                    dataGridView1.Rows[e].Cells[4].Value = item.Don_vi_tinh;


                }

            }
        }// hàm tìm sp 

        private void btnFindAll_Click(object sender, EventArgs e)// nút tìm tất cả 
        {
            FillListSP();
        }
    }
}
