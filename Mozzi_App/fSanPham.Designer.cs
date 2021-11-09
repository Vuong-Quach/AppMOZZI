
namespace Mozzi_App
{
    partial class fSanPham
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgvID_SP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNameSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSo_Luong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDon_Vi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bHMOZZIDataSet = new Mozzi_App.BHMOZZIDataSet();
            this.txtMasp = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.sPTableAdapter = new Mozzi_App.BHMOZZIDataSetTableAdapters.SPTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDonvi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnaddsp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnFindAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfind = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHMOZZIDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvID_SP,
            this.dgvNameSP,
            this.dgvGia,
            this.dgvSo_Luong,
            this.dgvDon_Vi});
            this.dataGridView1.Location = new System.Drawing.Point(51, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(573, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvID_SP
            // 
            this.dgvID_SP.HeaderText = "Mã SP";
            this.dgvID_SP.MinimumWidth = 6;
            this.dgvID_SP.Name = "dgvID_SP";
            this.dgvID_SP.ReadOnly = true;
            // 
            // dgvNameSP
            // 
            this.dgvNameSP.HeaderText = "Tên SP";
            this.dgvNameSP.MinimumWidth = 6;
            this.dgvNameSP.Name = "dgvNameSP";
            this.dgvNameSP.ReadOnly = true;
            // 
            // dgvGia
            // 
            this.dgvGia.HeaderText = "Giá ";
            this.dgvGia.MinimumWidth = 6;
            this.dgvGia.Name = "dgvGia";
            this.dgvGia.ReadOnly = true;
            // 
            // dgvSo_Luong
            // 
            this.dgvSo_Luong.HeaderText = "Số Lượng";
            this.dgvSo_Luong.MinimumWidth = 6;
            this.dgvSo_Luong.Name = "dgvSo_Luong";
            this.dgvSo_Luong.ReadOnly = true;
            // 
            // dgvDon_Vi
            // 
            this.dgvDon_Vi.HeaderText = "Đơn vị tính ";
            this.dgvDon_Vi.MinimumWidth = 6;
            this.dgvDon_Vi.Name = "dgvDon_Vi";
            this.dgvDon_Vi.ReadOnly = true;
            // 
            // sPBindingSource
            // 
            this.sPBindingSource.DataMember = "SP";
            this.sPBindingSource.DataSource = this.bHMOZZIDataSet;
            // 
            // bHMOZZIDataSet
            // 
            this.bHMOZZIDataSet.DataSetName = "BHMOZZIDataSet";
            this.bHMOZZIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtMasp
            // 
            this.txtMasp.Location = new System.Drawing.Point(172, 28);
            this.txtMasp.Name = "txtMasp";
            this.txtMasp.ReadOnly = true;
            this.txtMasp.Size = new System.Drawing.Size(100, 22);
            this.txtMasp.TabIndex = 1;
            this.txtMasp.TextChanged += new System.EventHandler(this.txtMasp_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(172, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã sp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tên sp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá bán";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(172, 93);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(100, 22);
            this.txtGia.TabIndex = 5;
            this.txtGia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(56, 202);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(137, 202);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(218, 202);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // sPTableAdapter
            // 
            this.sPTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "đơn vi tinh ";
            // 
            // txtDonvi
            // 
            this.txtDonvi.Location = new System.Drawing.Point(172, 149);
            this.txtDonvi.Name = "txtDonvi";
            this.txtDonvi.Size = new System.Drawing.Size(100, 22);
            this.txtDonvi.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "số lượng";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(172, 121);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(100, 22);
            this.txtSoLuong.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnaddsp);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDonvi);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGia);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMasp);
            this.groupBox1.Location = new System.Drawing.Point(643, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(323, 318);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Sản phẩm";
            // 
            // btnaddsp
            // 
            this.btnaddsp.Location = new System.Drawing.Point(101, 247);
            this.btnaddsp.Name = "btnaddsp";
            this.btnaddsp.Size = new System.Drawing.Size(148, 35);
            this.btnaddsp.TabIndex = 14;
            this.btnaddsp.Text = "Thêm sản phẩm ";
            this.btnaddsp.UseVisualStyleBackColor = true;
            this.btnaddsp.Click += new System.EventHandler(this.btnaddsp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnFindAll);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtfind);
            this.groupBox2.Location = new System.Drawing.Point(51, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 67);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm sản phẩm ";
            // 
            // btnFindAll
            // 
            this.btnFindAll.Location = new System.Drawing.Point(440, 26);
            this.btnFindAll.Name = "btnFindAll";
            this.btnFindAll.Size = new System.Drawing.Size(81, 31);
            this.btnFindAll.TabIndex = 16;
            this.btnFindAll.Text = "tất cả ";
            this.btnFindAll.UseVisualStyleBackColor = true;
            this.btnFindAll.Click += new System.EventHandler(this.btnFindAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Nhập Tên/ ID cần tìm ";
            // 
            // txtfind
            // 
            this.txtfind.Location = new System.Drawing.Point(166, 30);
            this.txtfind.Name = "txtfind";
            this.txtfind.Size = new System.Drawing.Size(258, 22);
            this.txtfind.TabIndex = 0;
            this.txtfind.TextChanged += new System.EventHandler(this.txtfind_TextChanged);
            // 
            // fSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "fSanPham";
            this.Text = "Quan Ly San Pham";
            this.Load += new System.EventHandler(this.fSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bHMOZZIDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMasp;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private BHMOZZIDataSet bHMOZZIDataSet;
        private System.Windows.Forms.BindingSource sPBindingSource;
        private BHMOZZIDataSetTableAdapters.SPTableAdapter sPTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDonvi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnaddsp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnFindAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvID_SP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNameSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSo_Luong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDon_Vi;
    }
}