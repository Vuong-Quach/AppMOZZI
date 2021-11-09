using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mozzi_App.Model;
using Microsoft.Reporting.WinForms;

namespace Mozzi_App
{
    public partial class f_QL_HoaDon : Form
    {
        DBcontext DBcon = new DBcontext();//khởi tạo db 
        public f_QL_HoaDon()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)// hiện cthd lên datagidview khi click vào 
        {
            var a = dgvHD.CurrentRow.Cells[1].Value;
            btnDelete.Enabled = true;

            fillListCTHD(a);
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)// hiện cthd lên datagidview khi click vào 
        {
            var a = dgvHD.CurrentRow.Cells[1].Value;
            btnDelete.Enabled = true;
            fillListCTHD(a);
        }
        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)// ko có gì 
        {

        }

        private void f_QL_HoaDon_Load(object sender, EventArgs e) // fill list hd khi mở from 
        {
            rbtnAllTime.Checked = true;
            btnDelete.Enabled = false;
            fillListHD();
            TongThu();
            this.reportViewer1.RefreshReport();
            reportViewer1.Visible = false;
            btnCloseHD.Enabled = false;
        }

        private void TongThu()
        {
            try
            {
                decimal total = 0;
                for (int i = 0; i < dgvHD.RowCount; i++)
                {
                    total = total + decimal.Parse(dgvHD.Rows[i].Cells[6].Value.ToString());
                }
                txtTotal.Text = total.ToString();
            }
            catch (Exception)
            {

                
            }
           
        }

        private void fillListHD()// hàm fill list hd 
        {
            dgvHD.Rows.Clear();
            List<HD> hDs = DBcon.HD.ToList();
            int stt = 1;
            foreach (var item in hDs)
            {
                int e = dgvHD.Rows.Add();
                dgvHD.Rows[e].Cells[0].Value = stt;
                dgvHD.Rows[e].Cells[1].Value = item.ID_HD;
                dgvHD.Rows[e].Cells[2].Value = item.Date_HD;
                dgvHD.Rows[e].Cells[3].Value = item.TK_NV.Name_NV;
                if (item.ID_KH != null)
                { dgvHD.Rows[e].Cells[4].Value = item.KH.Name_KH; }
                else
                {
                    dgvHD.Rows[e].Cells[4].Value = "Khách lẻ";
                }
                dgvHD.Rows[e].Cells[5].Value = item.M_Discount;
                dgvHD.Rows[e].Cells[6].Value = item.M_Total;
                stt++;
            }
            stt = 1;
        }
        private void fillListCTHD(object a)// hàm fill list cthd 
        {
            dgvCTHD.Rows.Clear();
            List<CTHD> cTHDs = DBcon.CTHD.ToList();
            int stt = 1;
            foreach (var item in cTHDs)
            {
                if (item.ID_HD.ToString() == a.ToString())
                {
                    int e = dgvCTHD.Rows.Add();
                    dgvCTHD.Rows[e].Cells[0].Value = stt;
                    dgvCTHD.Rows[e].Cells[1].Value = item.ID_SP;
                    dgvCTHD.Rows[e].Cells[2].Value = item.Name_SP;
                    dgvCTHD.Rows[e].Cells[3].Value = item.So_Luong;
                    dgvCTHD.Rows[e].Cells[4].Value = item.Don_vi_tinh;
                    dgvCTHD.Rows[e].Cells[5].Value = item.Gia;
                    dgvCTHD.Rows[e].Cells[6].Value = item.Thanh_Tien;
                    stt++;
                }

            }
            stt = 1;
        }

        private void btnFindAll_Click(object sender, EventArgs e)// hiện tao bo HD khi bam vao nut tat cả
        {
            rbtnAllTime.Checked = true;
            txtFind.Text = "";
            fillListHD();
            TongThu();

        }

        private void FindHD()// hàm tìm hd theo đk 
        {
            try
            {   
                List<HD> listHD = DBcon.HD.ToList();
                dgvHD.Rows.Clear();
                dgvCTHD.Rows.Clear();
                int stt = 1;
                int IDkh=-1;


                if (rbtnAllTime.Checked == true)// nếu  check  toang thời gian == true => tìm theo từ khóa ( toàn thời gian ) 
                {
                    foreach (var item in listHD) // duyệt ds hd
                    {
                        List<KH> kHs = DBcon.KH.ToList();
                        foreach (var kh in kHs)// duyệt ds kh 
                        {
                            if (kh.SDT.Contains(txtFind.Text)) // tìm id kh phù hợp sdt 
                            {
                                IDkh = kh.ID_KH; // tìm đc gán id kh  vào biến tạm 
                                if (item.ID_KH == IDkh)//  nếu id kh trong hd = id kh timg đc  thì in ra hóa đơn đó
                                {
                                    int e = dgvHD.Rows.Add();
                                    dgvHD.Rows[e].Cells[0].Value = stt;
                                    dgvHD.Rows[e].Cells[1].Value = item.ID_HD;
                                    dgvHD.Rows[e].Cells[2].Value = item.Date_HD;
                                    dgvHD.Rows[e].Cells[3].Value = item.TK_NV.Name_NV;
                                    if (item.ID_KH != null)
                                    { dgvHD.Rows[e].Cells[4].Value = item.KH.Name_KH; }
                                    else
                                    {
                                        dgvHD.Rows[e].Cells[4].Value = "Khách lẻ";
                                    }
                                    dgvHD.Rows[e].Cells[5].Value = item.M_Discount;
                                    dgvHD.Rows[e].Cells[6].Value = item.M_Total;
                                    stt++;


                                }
                            }
                        }
                        if (item.ID_HD.ToString().Contains(txtFind.Text)) // tìm id hd  phù hợp  từ khóa , nếu thấy in  hóa đơn đó 
                        {
                            int e = dgvHD.Rows.Add();
                            dgvHD.Rows[e].Cells[0].Value = stt;
                            dgvHD.Rows[e].Cells[1].Value = item.ID_HD;
                            dgvHD.Rows[e].Cells[2].Value = item.Date_HD;
                            dgvHD.Rows[e].Cells[3].Value = item.TK_NV.Name_NV;
                            if (item.ID_KH != null)
                            { dgvHD.Rows[e].Cells[4].Value = item.KH.Name_KH; }
                            else
                            {
                                dgvHD.Rows[e].Cells[4].Value = "Khách lẻ";
                            }
                            dgvHD.Rows[e].Cells[5].Value = item.M_Discount;
                            dgvHD.Rows[e].Cells[6].Value = item.M_Total;
                            stt++;




                        }
                        

                    }
                    stt = 1;
                }
                else// nguoc lại  tìm theo ngày  và từu khóa 
                {
                    foreach (var item in listHD) // duyệt ds hd
                    {
                        List<KH> kHs = DBcon.KH.ToList();
                        foreach (var kh in kHs)// duyệt ds kh 
                        {
                            if (kh.SDT.Contains(txtFind.Text)) // tìm id kh phù hợp sdt 
                            {
                                IDkh = kh.ID_KH; // tìm đc gán id kh  vào biến tạm 
                                if (item.ID_KH == IDkh && item.Date_HD >= datStart.Value && item.Date_HD <= datEnd.Value.AddHours(24))// add hours 24 để lấy được hóa đơn  hết ngày hôm đó //  nếu id kh trong hd = id kh timg đc  thì in ra hóa đơn đó
                                {
                                    int e = dgvHD.Rows.Add();
                                    dgvHD.Rows[e].Cells[0].Value = stt;
                                    dgvHD.Rows[e].Cells[1].Value = item.ID_HD;
                                    dgvHD.Rows[e].Cells[2].Value = item.Date_HD;
                                    dgvHD.Rows[e].Cells[3].Value = item.TK_NV.Name_NV;
                                    if (item.ID_KH != null)
                                    { dgvHD.Rows[e].Cells[4].Value = item.KH.Name_KH; }
                                    else
                                    {
                                        dgvHD.Rows[e].Cells[4].Value = "Khách lẻ";
                                    }
                                    dgvHD.Rows[e].Cells[5].Value = item.M_Discount;
                                    dgvHD.Rows[e].Cells[6].Value = item.M_Total;
                                    stt++;


                                }
                            }
                        }
                        if (item.ID_HD.ToString().Contains(txtFind.Text) && item.Date_HD >= datStart.Value && item.Date_HD <= datEnd.Value.AddHours(24))// add hours 24 để lấy được hóa đơn  hết ngày hôm đó ) // tìm id hd  phù hợp  từ khóa , nếu thấy in  hóa đơn đó 
                        {
                            int e = dgvHD.Rows.Add();
                            dgvHD.Rows[e].Cells[0].Value = stt;
                            dgvHD.Rows[e].Cells[1].Value = item.ID_HD;
                            dgvHD.Rows[e].Cells[2].Value = item.Date_HD;
                            dgvHD.Rows[e].Cells[3].Value = item.TK_NV.Name_NV;
                            if (item.ID_KH != null)
                            { dgvHD.Rows[e].Cells[4].Value = item.KH.Name_KH; }
                            else
                            {
                                dgvHD.Rows[e].Cells[4].Value = "Khách lẻ";
                            }
                            dgvHD.Rows[e].Cells[5].Value = item.M_Discount;
                            dgvHD.Rows[e].Cells[6].Value = item.M_Total;
                            stt++;




                        }


                    }
                    stt = 1;

                }
            }
            catch (Exception)
            {

        
            }
            

        }

        private void datStart_ValueChanged(object sender, EventArgs e)// sự kiện khi thay đổi dữ liệu ô ngày bắt đầu 
        {
            checkDay();
            FindHD();
            TongThu();

        }

        private void checkDay()// cehck ngày bắt đầu và ngày kết thúc (nếu nhập sai trả ngày bắt đầu và ngày kết thúc bằng ngày hôm nay )
        {
            if (datStart.Value > datEnd.Value)
            {
                MessageBox.Show("Ngày bắt đầu  phải bé hơn hoặc bằng ngày kết thúc !!!", "thông báo ");
                datStart.Value = DateTime.Today;
                datEnd.Value = DateTime.Now;

            }
        }

        private void datEnd_ValueChanged(object sender, EventArgs e)// sự kiện khi thay đổi dữ liệu ô ngày bắt đầu
        {
            checkDay();
            FindHD();
            TongThu();


        }

        private void rbtnAllTime_CheckedChanged(object sender, EventArgs e)// sự kiện khi check vào radiobutton 
        {
            if (rbtnAllTime.Checked == true)
            {
                datStart.Enabled = false;
                datEnd.Enabled = false;
            }
            else
            {
                datStart.Enabled = true;
                datEnd.Enabled = true;
            }

        }

        private void txtFind_TextChanged(object sender, EventArgs e)//sự kiện khi thay đổi giá trị ô txtFind
        {
            FindHD();
            TongThu();


        }



        private void groupBox3_Enter(object sender, EventArgs e)// no thing
        {

        }

       
        private void btnDelete_Click(object sender, EventArgs e)//sự kiện khi bấm vào nút xóa hóa đơn 
        {
            var a = dgvHD.CurrentRow.Cells[1].Value; // lấy id hóa đơn được chọn gán vào A
            DialogResult dlr = MessageBox.Show($"Bạn có muốn xóa HD: {a}","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);// tạo biến  sự kiên 
            if ( dlr == DialogResult.Yes)
            {
                DeleteHD(a);
                btnDelete.Enabled = false;// sau khi xáo ẩn út delete 
            }

        }

        private void DeleteHD(object a)
        {
            try
            {
                if (a.ToString()!="")
                {   // xóa ctHD
                    List<CTHD> cTHDs = DBcon.CTHD.ToList();// lấy ds cthd 
                    foreach (var cTHD in cTHDs)// dò trong ds 
                    {
                        if (cTHD.ID_HD.ToString() == a.ToString())// neus id hd = id hd được chọn  
                        {
                            DBcon.CTHD.Remove(cTHD);// xóa cthd  có id đó 
                            DBcon.SaveChanges();//lưu lại DB
                        } 
                    }
                    // Xóa HD 
                    HD HDDelete = DBcon.HD.FirstOrDefault(p => p.ID_HD.ToString() == a.ToString());
                    if (HDDelete != null)
                    {
                        DBcon.HD.Remove(HDDelete);
                        DBcon.SaveChanges();//lưu lại DB
                        fillListHD();// tải lại list hóa đơn
                        MessageBox.Show($"Xóa HD:{a} thành công ");
                    }
                }
             
            }
            catch (Exception)
            {

                
            }

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)// nút xuất rp để in hóa đơn được chọn 
        {
            var idHD = dgvHD.CurrentRow.Cells[1].Value; // lấy id hóa đơn được chọn gán vào idHD
            xuatRP(idHD);
            btnCloseHD.Enabled = true;
        }

        private void xuatRP(object idHD)
        {
            HD selecHD = DBcon.HD.FirstOrDefault(p => p.ID_HD.ToString() == idHD.ToString());
            reportViewer1.Visible = true;// hiện rp lên 

            List<CTHD> listCTHD = DBcon.CTHD.Where(p => p.ID_HD == selecHD.ID_HD).ToList();// lấy cthd của hd vừa được chọn  
            // dặt biến tạm 
            decimal total = 0;
            decimal tt = 0;
            decimal Discount = 0;
            string NameKH = "Khách Lẻ";
            string SDT = " ";
            if (selecHD.ID_KH != null)// nếu có id khách thì  tên kh được gán / nếu ko mặc định là khách lẻ 
            {
                NameKH = selecHD.KH.Name_KH.ToString();
                SDT = selecHD.KH.SDT.ToString();
            }

            if (listCTHD.Count() == 0)// nếu  ko tìm đc các phần tử cthd của  hd cuối  ( báo lỗi ko timf đc hd ) 
            {
                MessageBox.Show("ko tìm thấy đơn hàng ", "thông báo");
                return;
            }
            foreach (var item in listCTHD)// chạy toàn bộ list cthd 
            {
                total = item.Thanh_Tien + total;// tổng tiền thuc tế trong bill 

            }
            tt = selecHD.M_Total;         // tổng tiền  cần thanh toán 
            Discount = total - tt; // số tiền thực tế được giảm 
            ReportParameter[] param = new ReportParameter[8]; // gán giá trị parameter 
            param[0] = new ReportParameter("paraDAY", string.Format("Ngày: " + selecHD.Date_HD.ToString()));

            param[1] = new ReportParameter("paraNameKH", NameKH.ToString());
            param[2] = new ReportParameter("paraSDT", SDT.ToString());
            param[3] = new ReportParameter("paraNameNV", selecHD.TK_NV.Name_NV.ToString());
            param[4] = new ReportParameter("paraTotal", total.ToString());
            param[5] = new ReportParameter("paraDiscount", Discount.ToString());
            param[6] = new ReportParameter("paraTT", tt.ToString());
            param[7] = new ReportParameter("paraIDHD", "HD " + selecHD.ID_HD.ToString());


            this.reportViewer1.LocalReport.ReportPath = "./Report/ReportBill.rdlc";// lấy form rp 
            reportViewer1.LocalReport.SetParameters(param);// gán   dữ liệu  parameter vào 

            ReportDataSource ReportDataSource = new ReportDataSource("DataSetCTHD", listCTHD);// lấy bảng đata
            reportViewer1.LocalReport.DataSources.Clear();// xóa dỡ liệu cũ 
            reportViewer1.LocalReport.DataSources.Add(ReportDataSource);// add dữ liệu mới 
            reportViewer1.LocalReport.DisplayName = "Hóa đơn ";// tên của rp 



            this.reportViewer1.RefreshReport();// làm mới  để thấy đc rp (ko có sẽ ko laod rp ra )
        }

        private void btnCloseHD_Click(object sender, EventArgs e)
        {
            reportViewer1.Visible = false;
            btnCloseHD.Enabled = false;
        }
    }
}
