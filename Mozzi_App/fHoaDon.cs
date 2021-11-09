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
using Microsoft.Reporting.WinForms;

namespace Mozzi_App
{
    public partial class fHoaDon : Form
    {
        DBcontext DBcon = new DBcontext();
        public fHoaDon()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)// khởi tạo hóa đơn và load trong hóa đơn 
        {

            List<TK_NV> listNV = DBcon.TK_NV.ToList();
            fillDataCBB(listNV);
            txtGiamGia.Text = "0";
            List<SP> listSP = DBcon.SP.ToList();
            FillListSP(listSP);
            List<KH> listKH = DBcon.KH.ToList();
            FillListKH(listKH);
            FormLoad();
            this.reportViewer1.RefreshReport();
            

        }

        private void FillListKH(List<KH> listKH)
        {
            dgvKH.Rows.Clear();
            foreach (var item in listKH)
            {
                int e = dgvKH.Rows.Add();
                dgvKH.Rows[e].Cells[0].Value = item.ID_KH;
                dgvKH.Rows[e].Cells[1].Value = item.Name_KH;
                dgvKH.Rows[e].Cells[2].Value = item.SDT;
                dgvKH.Rows[e].Cells[3].Value = item.Points;
            }
        }// load lish kh 

        private void fillDataCBB(List<TK_NV> listNV)// hàm lấy tên nhân viên vào list view 
        {
            cbbNV.DataSource = listNV;
            cbbNV.DisplayMember = "Name_NV";
            cbbNV.ValueMember = "ID_NV";
        }

        void FillListSP(List<SP> listSP) // hàm in sp lên bảng sp 
        {
            dataGridView2.Rows.Clear();
            foreach (var item in listSP)
            {
                int e = dataGridView2.Rows.Add();
                dataGridView2.Rows[e].Cells[0].Value = item.ID_SP;
                dataGridView2.Rows[e].Cells[1].Value = item.Name_SP;
                dataGridView2.Rows[e].Cells[2].Value = item.Gia;
                dataGridView2.Rows[e].Cells[3].Value = item.So_Luong;
                dataGridView2.Rows[e].Cells[4].Value = item.Don_vi_tinh;


            }
        }
        private void btnFindAll_Click(object sender, EventArgs e)// load lại bảng sp , hiển thị toàn bộ sp 
        {
            List<SP> listSP = DBcon.SP.ToList();
            FillListSP(listSP);
            txtFind.Text = "";
        }


        private bool checknum(string a) // check kieu du lieu  co phai dạng Số thập phâm  không 
        {

            decimal c;
            bool success = false;
            success = decimal.TryParse(a, out c);
            return success;
        }
        private decimal sum()// tính tổng bill 
        {
            decimal total = 0;
            decimal b;
            for (int i = 0; i < dgvBILL.RowCount; i++)
            {
                decimal.TryParse(dgvBILL.Rows[i].Cells[5].Value.ToString(), out b);
                total = total + b;
            }
            if (txtIDKH.Text != "")
            {
                int x = int.Parse(txtIDKH.Text);

                KH selectKH = DBcon.KH.FirstOrDefault(p => p.ID_KH == x);
                if (selectKH.Points >= 160)
                {
                    total = total - (total / 100 * 15) - decimal.Parse(txtGiamGia.Text);
                    txtGiamKHTT.Text = "15 %";
                }
                else

                    if (selectKH.Points >= 80)
                {
                    total = total - (total / 100 * 9) - decimal.Parse(txtGiamGia.Text);
                    txtGiamKHTT.Text = "9 %";
                }
                else
                if (selectKH.Points >= 40)
                {
                    total = total - (total / 100 * 6) - decimal.Parse(txtGiamGia.Text);
                    txtGiamKHTT.Text = "6 %";
                }
                else
                        if (selectKH.Points >= 20)
                {
                    total = total - (total / 100 * 3) - decimal.Parse(txtGiamGia.Text);
                    txtGiamKHTT.Text = "3 %";
                }
                else
                {
                    total = total - decimal.Parse(txtGiamGia.Text);
                    txtGiamKHTT.Text = "0 %";
                }



            }
            else
            {
                total = total - decimal.Parse(txtGiamGia.Text);

            }
            return total;
        }
        public int checknull(string a, string b, string c, string d, string f)// hàm check du lieu null 
        {
            if ((txtIDSP.Text == "") || (txtName.Text == "") || (txtGia.Text == "") || (txtSoLuong.Text == "") || (txtDonvi.Text == ""))
            {
                return 1;
            }

            return -1;
        }
        public int checktrung(string id)
        {


            if (dgvBILL.RowCount <= 0) //nếu list view không có hàng nào thì không làm gì cả
                return -1;
            else

                for (int i = 0; i < dgvBILL.RowCount; i++) //tạo vòng lặp từ hàng đầu tiên đến hàng cuối cùng có dữ liệu trong listview

                    if (txtIDSP.Text == dgvBILL.Rows[i].Cells[1].Value.ToString())  //nếu dữ liệu của text trùng với hàng thứ i thì xuất câu thông báo
                    {

                        return i;

                    }
            return -1;
        }// check trùng sp trong giỏ hàng 

        public void reloadstt()
        {
            int stt = 1;
            for (int i = 0; i < dgvBILL.RowCount; i++)
            {
                dgvBILL.Rows[i].Cells[0].Value = stt;
                stt++;
            }

        }// dánh lại stt các sp trong giở hàng  sau khi thao tác thêm / xóa / sửa 

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtIDSP.Text;
            string ten = txtName.Text;
            string gia = txtGia.Text;
            string soluong = txtSoLuong.Text;
            string donvi = txtDonvi.Text;

            int stt = dgvBILL.RowCount;
            if (checknull(id, ten, gia, soluong, donvi) == -1) // check thông tin null
            {


               
                if (checknum(txtSoLuong.Text) == false)// check kiểu dữ liệu  của số lượng 

                    MessageBox.Show("nhập sai kiểu dữ liệu trong tài khoản ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);

                else// nếu kiểu dữ liệu số lượng đúng thì  làm bước tiếp theo ( kiểm tra kho )  
                {
                    decimal thanhtien = (decimal.Parse(txtGia.Text) * decimal.Parse(txtSoLuong.Text));// tính thành tiền khi thêm sp vào giỏ hàng 
                    SP productselect = DBcon.SP.FirstOrDefault(p => p.ID_SP.ToString() == id); // lấy sp dang chọn 
                    if (float.Parse(txtSoLuong.Text) < 0 || float.Parse(txtSoLuong.Text) > productselect.So_Luong) // kiểm tra đủ kho hay không 
                    {
                        MessageBox.Show($" số lượng sp trong kho không đủ; còn {productselect.So_Luong} {productselect.Don_vi_tinh} ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else // nếu số lượng kho đủ thì (check sp đã có trong giỏ chưa ) 
                    {
                        if (checktrung(txtIDSP.Text) == -1) // check đã có sp trong gio hàng chua 
                        {// nếu chưa  thêm sp vào giỏ  
                            stt++;
                            int c = dgvBILL.Rows.Add();
                            dgvBILL.Rows[c].Cells[0].Value = stt;
                            dgvBILL.Rows[c].Cells[1].Value = id;
                            dgvBILL.Rows[c].Cells[2].Value = ten;
                            dgvBILL.Rows[c].Cells[3].Value = gia;
                            dgvBILL.Rows[c].Cells[4].Value = soluong;
                            dgvBILL.Rows[c].Cells[5].Value = thanhtien;
                            dgvBILL.Rows[c].Cells[6].Value = donvi;

                            txtTotal.Text = sum().ToString();// cập nhật tổng tiền 





                        }
                        else// nếu đã có thì  cập nhật gio hiang
                        {
                            var i = checktrung(txtIDSP.Text);
                            dgvBILL.Rows[i].Cells[2].Value = ten;
                            dgvBILL.Rows[i].Cells[3].Value = gia;
                            dgvBILL.Rows[i].Cells[4].Value = soluong;
                            dgvBILL.Rows[i].Cells[5].Value = thanhtien;
                            dgvBILL.Rows[i].Cells[6].Value = donvi;


                            txtTotal.Text = sum().ToString();// cập nhật tổng tiền 

                            //   MessageBox.Show("cập nhật dữ liệu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }
                    }
                }

            }
            else// nếu chưa chọn sp để hiện thông tin lên  text box thì sẽ báo chọn sp 
                MessageBox.Show("vui long chọn sản phẩm ");
        }// thêm sp vào giỏ hàng 


        private void btnDeletesp_Click(object sender, EventArgs e)
        {
            if (dgvBILL.RowCount <= 0)// nếu giỏ hàng trống thì báo giở hàng đang trống 
            {
                MessageBox.Show("giỏ hàng trống ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else // nếu giỏ hàng có sp  thì dò sp cần xóa 
            {
                int check = 0;

                for (int i = 0; i < dgvBILL.RowCount; i++) //duyệt tất cả các item trong list
                {


                    if (dgvBILL.Rows[i].Cells[1].Value.ToString() == txtIDSP.Text.ToString())//nếu item đó = id sp 
                    {
                        check++; // tăng biến check 
                        dgvBILL.Rows.RemoveAt(i); // xoa iten thu i
                        reloadstt();  // đánh lại stt cho sp trong gio hàng
                        txtTotal.Text = sum().ToString();


                    }
                }
                if (check <= 0)// check khác <= 0 suy ra ko  tìm đc sp cần xóa khỏi giỏ 
                {
                    MessageBox.Show($"không tìm thấy sp: {txtName.Text} trong giở hàng  ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else// đặt lại check = 0 (ko có vẫn được )
                    check = 0;
            }


        }// xóa sp khỏi giỏ hàng 


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }//ko có gì 
        private void findSP(List<SP> listSP)// hàm tìm sp theo tên / ID  
        {
            dataGridView2.Rows.Clear(); // xóa list sp đang hiện trên dgv 
            foreach (var item in listSP)// duyệt mãng sp  được chọn 
            {
                if (item.ID_SP.ToString().Contains(txtFind.Text)// nếu từ khóa có ký tự giống ID  
                    || item.Name_SP.Contains(txtFind.Text))// nếu từ khóa có ký tự giống tên sp  
                {

                    int e = dataGridView2.Rows.Add();// thêm dòng dgv  và add sp vào 
                    dataGridView2.Rows[e].Cells[0].Value = item.ID_SP;
                    dataGridView2.Rows[e].Cells[1].Value = item.Name_SP;
                    dataGridView2.Rows[e].Cells[2].Value = item.Gia;
                    dataGridView2.Rows[e].Cells[3].Value = item.So_Luong;
                    dataGridView2.Rows[e].Cells[4].Value = item.Don_vi_tinh;


                }

            }
        }
        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)// sự kiện khi nhấp vào sp trong bảng tìm sp 
        {
            try
            {
                // in dữ liệu sp được chọn lên text box 
                txtIDSP.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

                txtGia.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtDonvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

                txtSoLuong.Text = "1";// mặc định só lượng để add vào giỏ hàng là 1  () có thể thay đổi 


            }
            catch (Exception)
            {

            }
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)// sự kiện khi nhấp vào sp trong bảng tìm sp 
        {
            try
            {// in dữ liệu sp được chọn lên text box 

                txtIDSP.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                txtName.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();

                txtGia.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                txtDonvi.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();

                txtSoLuong.Text = "1";// mặc định só lượng để add vào giỏ hàng là 1  () có thể thay đổi


            }
            catch (Exception)
            {

            }
        }

        private void txtGiamGia_TextChanged(object sender, EventArgs e)// sự kiện khi thay đổi giá trị ô tiền giảm giá 
        {
            try
            {
                if (txtGiamGia.Text == "")// nếu xóa hết ký tự o giảm giá , ặc định sẽ đưua về "0" 
                {
                    txtGiamGia.Text = "0";
                }
                if (checknum(txtGiamGia.Text))// check ký tự nhập vào nếu là chữ  báo lỗi  nhập đúng vẫn được nhập tiếp 
                    txtTotal.Text = sum().ToString();
                else
                    MessageBox.Show("Nhâp sai kiểu dữ liệu Tiền Giảm Giá");

            }
            catch (Exception)
            {
            }
        }

        private void dgvBILL_CellContentClick(object sender, DataGridViewCellEventArgs e)// sự kiện khi nhấp vào sp trong giỏ hàng 
        {
            try
            {// in dữ liệu sp được chọn vào text box 
                txtIDSP.Text = dgvBILL.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvBILL.CurrentRow.Cells[2].Value.ToString();
                txtGia.Text = dgvBILL.CurrentRow.Cells[3].Value.ToString();
                txtSoLuong.Text = dgvBILL.CurrentRow.Cells[4].Value.ToString();
                txtDonvi.Text = dgvBILL.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }
        private void dgvBILL_CellClick(object sender, DataGridViewCellEventArgs e)// sự kiện khi nhấp vào sp trong giỏ hàng 
        {
            try
            {// in dữ liệu sp được chọn vào text box 
                
                    txtIDSP.Text = dgvBILL.CurrentRow.Cells[1].Value.ToString();
                txtName.Text = dgvBILL.CurrentRow.Cells[2].Value.ToString();
                txtGia.Text = dgvBILL.CurrentRow.Cells[3].Value.ToString();
                txtSoLuong.Text = dgvBILL.CurrentRow.Cells[4].Value.ToString();
                txtDonvi.Text = dgvBILL.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception)
            {

            }
        }

        private void btnTT_Click(object sender, EventArgs e)// sự kiện khi nhấp vào nút thêm để thêm sp vào giỏ 
        {
            try
            {
                if (dgvBILL.RowCount <= 0)// nếu giỏ hàng trống , báo lỗi ko có sp trong giỏ hàng 
                {
                    MessageBox.Show("không có sp trong giỏ hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else// nếu có sp  tiền hành thanh toán 
                {   // đặt biến tạm để lưu dữ liệu 
                    decimal h = decimal.Parse(txtM_Khach_Dua.Text);
                    decimal g = decimal.Parse(txtTotal.Text);
                    decimal j = decimal.Parse(txtGiamGia.Text);

                    if (h < g)// nếu số tiền khách đưa  < số tiền tổng bill ( báo lỗi ) , mặc định số tiền khách đưa == tổng bill 
                    { MessageBox.Show("Tiền khách đưa ko đủ !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }


                    else
                    {
                        HD newHD = new HD();// tạo hóa đơn mới 
                        List<HD> LISThDs = DBcon.HD.ToList();// lấy list hóa đơn trong db 
                        int i = LISThDs[LISThDs.Count()-1].ID_HD;// ;ấy id phầm tử cuối  của  list hd                       
                        newHD.ID_HD = i + 1;// id hd mới  = id hd cuối cùng +1 
                        newHD.ID_NV = int.Parse(cbbNV.SelectedValue.ToString());// id nhân viên = mã nhân viên trong combobox nv 
                        newHD.Date_HD = DateTime.Now;// thời gian hóa đơn = thời gian hiện tại 
                        if (txtIDKH.Text != "")// thêm id khách hành vào hd nếu có 
                        {
                            if (checknum(txtIDKH.Text) == true)
                                newHD.ID_KH = int.Parse(txtIDKH.Text);
                        }
                        else
                            newHD.ID_KH = null;// nếu ko id kh = null 

                        newHD.M_Discount = j;
                        newHD.M_Total = sum();// lấy tổng tiền 

                        DBcon.HD.Add(newHD);// thêm hóa đơn vào db 
                        DBcon.SaveChanges();// lưu thay đổi 
                        decimal a = refund();// gán số tiền thối vào biến ảo  để dùng ở messagebox
                        MessageBox.Show($" Thanh toán Thành Công , Thối khách {a }VND", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TruKho();// thanh toán thành cồn tiền hành trừ kho các sp trong bill 
                        AddCTHD(newHD);// lưu lại cthd 
                        if (newHD.ID_KH != null)// nếu bill mới có lưu id kh thì tích điểm 
                        {
                            tichdiem(newHD.M_Total);// gọi hàm tích điểm 
                        }
                        xuatRP();// hàm xuất rp để in bill 
                      //  FormLoad();

                    }
                }
            }
            catch (Exception)
            {
               
            }

        }

        private void xuatRP()
        {
            HD newHD = new HD();//tạo 1 biếm tạm hóa đơn 
            List<HD> listHD = DBcon.HD.ToList();// lấy list hd 
            newHD = listHD[listHD.Count-1]; // gán biến hóa đơn =  hóa đơn cuối cùng ( hóa đơn vừa thành toán )
            reportViewer1.Visible = true;// hiện rp lên 

            List<CTHD> listCTHD = DBcon.CTHD.Where(p => p.ID_HD == newHD.ID_HD).ToList();// lấy cthd của hd vừa được chọn  
            // dặt biến tạm 
            decimal total = 0;
            decimal tt = 0;
            decimal Discount = 0;
            string NameKH ="Khách Lẻ";
            string SDT = " ";
            if (newHD.ID_KH !=null )// nếu có id khách thì  tên kh được gán / nếu ko mặc định là khách lẻ 
            {
                NameKH = newHD.KH.Name_KH.ToString();
                SDT = newHD.KH.SDT.ToString();
            }

            if ( listCTHD.Count() == 0)// nếu  ko tìm đc các phần tử cthd của  hd cuối  ( báo lỗi ko timf đc hd ) 
            {
                MessageBox.Show("ko tìm thấy đơn hàng ", "thông báo");
                return;
            }
            foreach (var item in listCTHD)// chạy toàn bộ list cthd 
            {
                 total = item.Thanh_Tien +total;// tổng tiền thuc tế trong bill 
                 
            }
            tt = newHD.M_Total;         // tổng tiền  cần thanh toán 
            Discount = total - tt; // số tiền thực tế được giảm 
            ReportParameter[] param = new ReportParameter[8]; // gán giá trị parameter 
            param[0] = new ReportParameter("paraDAY", string.Format("Ngày: " + newHD.Date_HD.ToString()));

            param[1] = new ReportParameter("paraNameKH", NameKH.ToString());
            param[2] = new ReportParameter("paraSDT", SDT.ToString());
            param[3] = new ReportParameter("paraNameNV", newHD.TK_NV.Name_NV.ToString());
            param[4] = new ReportParameter("paraTotal", total.ToString());
            param[5] = new ReportParameter("paraDiscount", Discount.ToString());
            param[6] = new ReportParameter("paraTT", tt.ToString());
            param[7] = new ReportParameter("paraIDHD","HD " + newHD.ID_HD.ToString());





            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportBill.rdlc";// lấy form rp 
            reportViewer1.LocalReport.SetParameters(param);// gán   dữ liệu  parameter vào 

            ReportDataSource ReportDataSource = new ReportDataSource("DataSetCTHD", listCTHD);// lấy bảng đata
            reportViewer1.LocalReport.DataSources.Clear();// xóa dỡ liệu cũ 
            reportViewer1.LocalReport.DataSources.Add(ReportDataSource);// add dữ liệu mới 
            reportViewer1.LocalReport.DisplayName = "Hóa đơn ";// tên của rp 

        

            this.reportViewer1.RefreshReport();// làm mới  để thấy đc rp (ko có sẽ ko laod rp ra )
        }

        private void tichdiem(decimal m_Total)// truyền vào biến  tổng tiềm 
        {
            int x = int.Parse(txtIDKH.Text);// đặt biến tạm 
            KH selectKH = DBcon.KH.FirstOrDefault(p => p.ID_KH == x);// tìm kh  trong db KH 
            if (selectKH != null&& selectKH.ID_KH!=0) // nếu tìm đc kh 
            {
                string z = selectKH.Points.ToString();// lấy điểm của kh 
                int y = int.Parse(z); // ép kiểu để + điểm 
                if (m_Total < 500)// nếu < 500k 
                {
                    selectKH.Points = y + 0;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else // nếu từ 500k- < 1 triệu 
                if (500 <= m_Total && m_Total < 1000)
                {
                    selectKH.Points = y + 10;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else// nếu từ 1 triệu - < 2 triệu 
                    if (1000 <= m_Total && m_Total < 2000)
                {
                    selectKH.Points = y + 25;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else// nếu từ 2 triệu - < 3 triệu 
                    if (2000 <= m_Total && m_Total < 3000)
                {
                    selectKH.Points = y + 40;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else// nếu từ 3 triệu - < 4 triệu 
                    if (3000 <= m_Total && m_Total < 4000)
                {
                    selectKH.Points = y + 55;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else// nếu từ 4 triệu - < 5 triệu 
                    if (4000 <= m_Total && m_Total < 5000)
                {
                    selectKH.Points = y + 70;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else// nếu từ 5 triệu - < 6 triệu 
                    if (5000 <= m_Total && m_Total < 6000)
                {
                    selectKH.Points = y + 90;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }
                else// nếu từ  6 triệu trở lên 
                    if (6000 <= m_Total)
                {
                    selectKH.Points = y + 120;
                    DBcon.KH.AddOrUpdate(selectKH);
                    DBcon.SaveChanges();
                }

            }




        }//hàm tích điểm lưu và DB

        private void FormLoad()// load lại form 
        {
            List<SP> listSP = DBcon.SP.ToList();
            FillListSP(listSP);// reload lại list sp 
            reportViewer1.Visible = false;
            txtIDSP.Text = "";
            txtName.Text = "";
            txtGia.Text = "";
            txtSoLuong.Text = "";
            txtDonvi.Text = "";
            txtIDKH.Text = "";
            txtGiamGia.Text = "0";
            txtTotal.Text = "0";
            txtM_Khach_Dua.Text = "0";
            txtFind.Text = "";
            txtGiamKHTT.Text = "0 %";
            dgvBILL.Rows.Clear();
            List<KH> listKH = DBcon.KH.ToList();
            FillListKH(listKH);// load lại list kh 



        }

        private void AddCTHD(HD newHD)// thêm cthd vào DB 
        {
            if (dgvBILL.RowCount != 0)// nếu giỏ hàng  có sp 
            {

                for (int i = 0; i < dgvBILL.RowCount; i++) // chạy  từng sp trong giỏ hàng 
                {
                    List<CTHD> cTHDs = DBcon.CTHD.ToList();
                    CTHD newCTHD = new CTHD();// tạo biến cthd mới 
                    int k = cTHDs[cTHDs.Count() - 1].ID_CTHD;// lấy id cthd cuối cùng 
                    newCTHD.ID_CTHD = k + 1;// mã cthd tăng dần 
                    newCTHD.ID_HD = newHD.ID_HD;
                    newCTHD.ID_SP = Convert.ToInt32(dgvBILL.Rows[i].Cells[1].Value.ToString());
                    newCTHD.Name_SP = dgvBILL.Rows[i].Cells[2].Value.ToString();
                    newCTHD.So_Luong = Convert.ToDouble(dgvBILL.Rows[i].Cells[4].Value.ToString());
                    newCTHD.Don_vi_tinh = (dgvBILL.Rows[i].Cells[6].Value.ToString());
                    newCTHD.Gia = Convert.ToDecimal(dgvBILL.Rows[i].Cells[3].Value.ToString());
                    newCTHD.Thanh_Tien = Convert.ToDecimal(dgvBILL.Rows[i].Cells[5].Value.ToString());
                    DBcon.CTHD.Add(newCTHD);// thêm cthd 
                    DBcon.SaveChanges();//save DB
                    //MessageBox.Show($" test cthd", "Thông báo"); // dùng để check lưu cthd 
                }
            }
        }
        private void TruKho()// trừ kho và lưu vào DB sau khi thanh toán 
        {
            try
            {
                if (dgvBILL.RowCount != 0)
                {

                    for (int i = 0; i < dgvBILL.RowCount; i++)
                    {
                        string x = dgvBILL.Rows[i].Cells[1].Value.ToString(); //lấy dữ liệu mã sp 
                        int t;
                        int.TryParse(x, out t);// ép kiểu  mã sp sang int 
                        SP SpEdit = DBcon.SP.FirstOrDefault(p => p.ID_SP == t); //dung linq tìm sp có mã giống mã sp 
                        if (SpEdit != null)// tìm đc 
                        {
                            double Q = SpEdit.So_Luong;// lấy sp hiện tại
                            double k = double.Parse(dgvBILL.Rows[i].Cells[4].Value.ToString());// ép kiểu số lượng  gán vào biến ảo 
                            SpEdit.So_Luong = Q - k; // thay đổi số lượng  còn lại = số lượng ban đầu - số lượng đã mua 

                            DBcon.SP.AddOrUpdate(SpEdit); // update 
                            DBcon.SaveChanges();//save 
                                                // MessageBox.Show($" cập nhật sp thành công ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);// đùng để check  ko có ko sao 

                        }

                    }

                }
            }

            catch (Exception)
            {
                //MessageBox.Show($" test", "Thông báo");

            }
        }

        private decimal refund()// tính số tiền thối lại 
        {
            decimal refund = 0;
            decimal a = sum();
            decimal b = decimal.Parse(txtM_Khach_Dua.Text);
            refund = b - a;

            return refund;
        }


        private void txtM_Khach_Dua_TextChanged(object sender, EventArgs e)// sự kiện khi thay đổi số tiền khách đưa 
        {
            try
            {
                if (checknum(txtM_Khach_Dua.Text) != true)
                    MessageBox.Show("Nhâp sai kiểu dữ liệu Tiền khách đưa");


            }
            catch (Exception)
            {

            }
        }

        private void txtFind_TextChanged(object sender, EventArgs e)// sự kieenhj khi thay đổi ô tìm kiếm sp 
        {
            List<SP> listSP = DBcon.SP.ToList();
            findSP(listSP);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//sự kiện chọn khách hàng khi nhấp vào  khách hàng 
        {
            txtIDKH.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
            txtTotal.Text = sum().ToString();

        }
        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)//sự kiện chọn khách hàng khi nhấp vào  khách hàng 
        {
            txtIDKH.Text = dgvKH.CurrentRow.Cells[0].Value.ToString();
            txtTotal.Text = sum().ToString();
        }

        private void btnFindKH_Click(object sender, EventArgs e)// nút tìm tất cả  khách hàng  
        {
            List<KH> listKH = DBcon.KH.ToList();
            FillListKH(listKH);
        }

        private void textBox1_TextChanged(object sender, EventArgs e) // thay đổi dũ liệu khung tim khách hàng
        {
            List<KH> listKH = DBcon.KH.ToList();
            FindKH(listKH);
        }

        private void FindKH(List<KH> listKH)// hàm  tìm khách hàng 
        {
            dgvKH.Rows.Clear();
            foreach (var item in listKH)
            {
                if (item.Name_KH.ToString().Contains(txtFindKH.Text)
                    || item.SDT.Contains(txtFindKH.Text)||
                    item.ID_KH.ToString().Contains(txtIDKH.Text))
                {
                    int e = dgvKH.Rows.Add();
                    dgvKH.Rows[e].Cells[0].Value = item.ID_KH;
                    dgvKH.Rows[e].Cells[1].Value = item.Name_KH;
                    dgvKH.Rows[e].Cells[2].Value = item.SDT;
                    dgvKH.Rows[e].Cells[3].Value = item.Points;
                }


            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }// ko co gì 

        private void label14_Click(object sender, EventArgs e)
        {

        }// ko có gì 

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }// nút thoát  hóa đơn 

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {
            txtM_Khach_Dua.Text = sum().ToString();// mặc định iền kahwchs đưa =  tổng tiền hóa đơn
        }// sựu kiện khi tổng tiền thay đổi 

        private void button1_Click(object sender, EventArgs e)// nút xóa ô id kh  khi kachs mua là khách lẻ 
        {
            txtIDKH.Text = "";
            txtTotal.Text = sum().ToString();// tính lại tổng tiền 
        }

        private void label15_Click(object sender, EventArgs e)//nothing
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)// nút load lại trong hóa đơn 
        {
            FormLoad();
        }
    }
}