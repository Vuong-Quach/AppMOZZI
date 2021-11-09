
namespace Mozzi_App
{
    partial class f_QL_HoaDon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.dgv_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNameNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.dgvSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvID_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvName_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSo_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDon_Vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvThanh_Tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.datStart = new System.Windows.Forms.DateTimePicker();
            this.datEnd = new System.Windows.Forms.DateTimePicker();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnDAY = new System.Windows.Forms.RadioButton();
            this.rbtnAllTime = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCloseHD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_STT,
            this.dgvIDHD,
            this.dgvDate,
            this.dgvNameNV,
            this.dgvKH,
            this.dgvDiscount,
            this.dgvTotal});
            this.dgvHD.Location = new System.Drawing.Point(11, 17);
            this.dgvHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.RowHeadersWidth = 51;
            this.dgvHD.RowTemplate.Height = 24;
            this.dgvHD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvHD.Size = new System.Drawing.Size(792, 203);
            this.dgvHD.TabIndex = 0;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgv_STT
            // 
            this.dgv_STT.HeaderText = "STT";
            this.dgv_STT.MinimumWidth = 6;
            this.dgv_STT.Name = "dgv_STT";
            this.dgv_STT.ReadOnly = true;
            // 
            // dgvIDHD
            // 
            this.dgvIDHD.HeaderText = "Mã Hóa đơn";
            this.dgvIDHD.MinimumWidth = 6;
            this.dgvIDHD.Name = "dgvIDHD";
            this.dgvIDHD.ReadOnly = true;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "Ngày mua";
            this.dgvDate.MinimumWidth = 6;
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            // 
            // dgvNameNV
            // 
            this.dgvNameNV.HeaderText = "TênNV";
            this.dgvNameNV.MinimumWidth = 6;
            this.dgvNameNV.Name = "dgvNameNV";
            this.dgvNameNV.ReadOnly = true;
            // 
            // dgvKH
            // 
            this.dgvKH.HeaderText = "NameKH";
            this.dgvKH.MinimumWidth = 6;
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.ReadOnly = true;
            // 
            // dgvDiscount
            // 
            this.dgvDiscount.HeaderText = "Giảm Giá";
            this.dgvDiscount.MinimumWidth = 6;
            this.dgvDiscount.Name = "dgvDiscount";
            this.dgvDiscount.ReadOnly = true;
            // 
            // dgvTotal
            // 
            this.dgvTotal.HeaderText = "tổng tiền";
            this.dgvTotal.MinimumWidth = 6;
            this.dgvTotal.Name = "dgvTotal";
            this.dgvTotal.ReadOnly = true;
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.AllowUserToAddRows = false;
            this.dgvCTHD.AllowUserToDeleteRows = false;
            this.dgvCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSTT,
            this.dgvID_SP,
            this.dgvName_SP,
            this.dgvSo_Luong,
            this.dgvDon_Vi,
            this.dgvGia,
            this.dgvThanh_Tien});
            this.dgvCTHD.Location = new System.Drawing.Point(0, 17);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvCTHD.Size = new System.Drawing.Size(792, 110);
            this.dgvCTHD.TabIndex = 1;
            this.dgvCTHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHD_CellContentClick);
            // 
            // dgvSTT
            // 
            this.dgvSTT.HeaderText = "STT";
            this.dgvSTT.MinimumWidth = 6;
            this.dgvSTT.Name = "dgvSTT";
            this.dgvSTT.ReadOnly = true;
            // 
            // dgvID_SP
            // 
            this.dgvID_SP.HeaderText = "Mã SP";
            this.dgvID_SP.MinimumWidth = 6;
            this.dgvID_SP.Name = "dgvID_SP";
            this.dgvID_SP.ReadOnly = true;
            // 
            // dgvName_SP
            // 
            this.dgvName_SP.HeaderText = "Tên SP";
            this.dgvName_SP.MinimumWidth = 6;
            this.dgvName_SP.Name = "dgvName_SP";
            this.dgvName_SP.ReadOnly = true;
            // 
            // dgvSo_Luong
            // 
            this.dgvSo_Luong.HeaderText = "Số lượng ";
            this.dgvSo_Luong.MinimumWidth = 6;
            this.dgvSo_Luong.Name = "dgvSo_Luong";
            this.dgvSo_Luong.ReadOnly = true;
            // 
            // dgvDon_Vi
            // 
            this.dgvDon_Vi.HeaderText = "Đơn Vị";
            this.dgvDon_Vi.MinimumWidth = 6;
            this.dgvDon_Vi.Name = "dgvDon_Vi";
            this.dgvDon_Vi.ReadOnly = true;
            // 
            // dgvGia
            // 
            this.dgvGia.HeaderText = "Giá ";
            this.dgvGia.MinimumWidth = 6;
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            // 
            // dgvThanh_Tien
            // 
            this.dgvThanh_Tien.HeaderText = "Thành Tiền";
            this.dgvThanh_Tien.MinimumWidth = 6;
            this.dgvThanh_Tien.Name = "dgvThanh_Tien";
            this.dgvThanh_Tien.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHD);
            this.groupBox1.Location = new System.Drawing.Point(4, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(824, 232);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Hóa Đơn";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvCTHD);
            this.groupBox2.Location = new System.Drawing.Point(9, 353);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(819, 146);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết hóa đơn -được chọn";
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(458, 29);
            this.btnFindAll.Margin = new System.Windows.Forms.Padding(2);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(98, 32);
            this.btnFindAll.TabIndex = 4;
            this.btnFindAll.Text = "Tất cả ";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // datStart
            // 
            this.datStart.Location = new System.Drawing.Point(282, 30);
            this.datStart.Margin = new System.Windows.Forms.Padding(2);
            this.datStart.Name = "datStart";
            this.datStart.Size = new System.Drawing.Size(144, 20);
            this.datStart.TabIndex = 5;
            this.datStart.ValueChanged += new System.EventHandler(this.datStart_ValueChanged);
            // 
            // datEnd
            // 
            this.datEnd.Location = new System.Drawing.Point(282, 53);
            this.datEnd.Margin = new System.Windows.Forms.Padding(2);
            this.datEnd.Name = "datEnd";
            this.datEnd.Size = new System.Drawing.Size(144, 20);
            this.datEnd.TabIndex = 6;
            this.datEnd.ValueChanged += new System.EventHandler(this.datEnd_ValueChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnDelete.Location = new System.Drawing.Point(610, 47);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 32);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Xóa Hóa đơn";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnDAY);
            this.groupBox3.Controls.Add(this.rbtnAllTime);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtFind);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.datEnd);
            this.groupBox3.Controls.Add(this.datStart);
            this.groupBox3.Controls.Add(this.btnFindAll);
            this.groupBox3.Location = new System.Drawing.Point(20, 10);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(586, 102);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm hóa đơn";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // rbtnDAY
            // 
            this.rbtnDAY.AutoSize = true;
            this.rbtnDAY.Location = new System.Drawing.Point(174, 28);
            this.rbtnDAY.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnDAY.Name = "rbtnDAY";
            this.rbtnDAY.Size = new System.Drawing.Size(78, 17);
            this.rbtnDAY.TabIndex = 13;
            this.rbtnDAY.TabStop = true;
            this.rbtnDAY.Text = "Theo Ngày";
            this.rbtnDAY.UseVisualStyleBackColor = true;
            // 
            // rbtnAllTime
            // 
            this.rbtnAllTime.AutoSize = true;
            this.rbtnAllTime.Location = new System.Drawing.Point(174, 8);
            this.rbtnAllTime.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnAllTime.Name = "rbtnAllTime";
            this.rbtnAllTime.Size = new System.Drawing.Size(93, 17);
            this.rbtnAllTime.TabIndex = 12;
            this.rbtnAllTime.TabStop = true;
            this.rbtnAllTime.Text = "Toàn thời gian";
            this.rbtnAllTime.UseVisualStyleBackColor = true;
            this.rbtnAllTime.CheckedChanged += new System.EventHandler(this.rbtnAllTime_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Số HD / SDT KH cần tìm ";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(17, 44);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(128, 20);
            this.txtFind.TabIndex = 10;
            this.txtFind.TextChanged += new System.EventHandler(this.txtFind_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.Location = new System.Drawing.Point(254, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "đến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.Location = new System.Drawing.Point(256, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Từ";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Red;
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Lime;
            this.groupBox4.Location = new System.Drawing.Point(809, 10);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(154, 114);
            this.groupBox4.TabIndex = 37;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Lưu Ý";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(8, 91);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(140, 17);
            this.label19.TabIndex = 39;
            this.label19.Text = "1000,0000 là 1 Triệu";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(8, 69);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(124, 17);
            this.label18.TabIndex = 38;
            this.label18.Text = "100,0000 là 100 K";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(8, 46);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(108, 17);
            this.label17.TabIndex = 37;
            this.label17.Text = "10,0000 là 10 K";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 20);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 17);
            this.label16.TabIndex = 36;
            this.label16.Text = "1,0000 là 1 K";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 26);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 17);
            this.label15.TabIndex = 35;
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(851, 168);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(101, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(852, 153);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Tổng Doanh Thu";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnPrint.Location = new System.Drawing.Point(610, 86);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(118, 32);
            this.btnPrint.TabIndex = 39;
            this.btnPrint.Text = "In hóa đơn";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(103, 116);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(687, 432);
            this.reportViewer1.TabIndex = 1;
            // 
            // btnCloseHD
            // 
            this.btnCloseHD.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.btnCloseHD.Location = new System.Drawing.Point(738, 86);
            this.btnCloseHD.Margin = new System.Windows.Forms.Padding(2);
            this.btnCloseHD.Name = "btnCloseHD";
            this.btnCloseHD.Size = new System.Drawing.Size(67, 32);
            this.btnCloseHD.TabIndex = 40;
            this.btnCloseHD.Text = "Đóng HD";
            this.btnCloseHD.UseVisualStyleBackColor = true;
            this.btnCloseHD.Click += new System.EventHandler(this.btnCloseHD_Click);
            // 
            // f_QL_HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 560);
            this.Controls.Add(this.btnCloseHD);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "f_QL_HoaDon";
            this.Text = "f_QL_HoaDon";
            this.Load += new System.EventHandler(this.f_QL_HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.DateTimePicker datStart;
        private System.Windows.Forms.DateTimePicker datEnd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvName_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSo_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDon_Vi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvThanh_Tien;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNameNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.RadioButton rbtnAllTime;
        private System.Windows.Forms.RadioButton rbtnDAY;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPrint;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Button btnCloseHD;
    }
}