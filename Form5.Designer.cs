namespace QLTTGIASU_V0._2
{
    partial class Form5
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbThanhPho = new System.Windows.Forms.ComboBox();
            this.txtTenHV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenTruong = new System.Windows.Forms.TextBox();
            this.txtMaHV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHOCVIEN = new System.Windows.Forms.DataGridView();
            this.maHVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTruongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTPVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hocVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTGIASUDataSet2 = new QLTTGIASU_V0._2.QLTTGIASUDataSet2();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.qLTTGIASUDataSet1 = new QLTTGIASU_V0._2.QLTTGIASUDataSet1();
            this.qLTTGIASUDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hocVienTableAdapter = new QLTTGIASU_V0._2.QLTTGIASUDataSet2TableAdapters.HocVienTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOCVIEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.cbThanhPho);
            this.panel1.Controls.Add(this.txtTenHV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.txtTenTruong);
            this.panel1.Controls.Add(this.txtMaHV);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 141);
            this.panel1.TabIndex = 0;
            // 
            // cbThanhPho
            // 
            this.cbThanhPho.ForeColor = System.Drawing.Color.Lime;
            this.cbThanhPho.FormattingEnabled = true;
            this.cbThanhPho.Location = new System.Drawing.Point(544, 22);
            this.cbThanhPho.Name = "cbThanhPho";
            this.cbThanhPho.Size = new System.Drawing.Size(163, 21);
            this.cbThanhPho.TabIndex = 12;
            this.cbThanhPho.SelectedIndexChanged += new System.EventHandler(this.cbThanhPho_SelectedIndexChanged);
            // 
            // txtTenHV
            // 
            this.txtTenHV.ForeColor = System.Drawing.Color.Lime;
            this.txtTenHV.Location = new System.Drawing.Point(142, 59);
            this.txtTenHV.Name = "txtTenHV";
            this.txtTenHV.Size = new System.Drawing.Size(159, 21);
            this.txtTenHV.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(22, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tên Học Viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(394, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tỉnh, Thành Phố:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.ForeColor = System.Drawing.Color.Lime;
            this.txtDiaChi.Location = new System.Drawing.Point(545, 59);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(162, 21);
            this.txtDiaChi.TabIndex = 5;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtTenTruong
            // 
            this.txtTenTruong.ForeColor = System.Drawing.Color.Lime;
            this.txtTenTruong.Location = new System.Drawing.Point(142, 98);
            this.txtTenTruong.Name = "txtTenTruong";
            this.txtTenTruong.Size = new System.Drawing.Size(159, 21);
            this.txtTenTruong.TabIndex = 4;
            // 
            // txtMaHV
            // 
            this.txtMaHV.ForeColor = System.Drawing.Color.Lime;
            this.txtMaHV.Location = new System.Drawing.Point(142, 20);
            this.txtMaHV.Name = "txtMaHV";
            this.txtMaHV.Size = new System.Drawing.Size(159, 21);
            this.txtMaHV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(393, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = " Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Trường:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Học Viên:";
            // 
            // dgvHOCVIEN
            // 
            this.dgvHOCVIEN.AutoGenerateColumns = false;
            this.dgvHOCVIEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHOCVIEN.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvHOCVIEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHOCVIEN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHVDataGridViewTextBoxColumn,
            this.tenHVDataGridViewTextBoxColumn,
            this.tenTruongDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.tinhTPVTDataGridViewTextBoxColumn});
            this.dgvHOCVIEN.DataSource = this.hocVienBindingSource;
            this.dgvHOCVIEN.Location = new System.Drawing.Point(12, 154);
            this.dgvHOCVIEN.Name = "dgvHOCVIEN";
            this.dgvHOCVIEN.Size = new System.Drawing.Size(744, 160);
            this.dgvHOCVIEN.TabIndex = 1;
            this.dgvHOCVIEN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHOCVIEN_CellContentClick);
            // 
            // maHVDataGridViewTextBoxColumn
            // 
            this.maHVDataGridViewTextBoxColumn.DataPropertyName = "MaHV";
            this.maHVDataGridViewTextBoxColumn.HeaderText = "MaHV";
            this.maHVDataGridViewTextBoxColumn.Name = "maHVDataGridViewTextBoxColumn";
            // 
            // tenHVDataGridViewTextBoxColumn
            // 
            this.tenHVDataGridViewTextBoxColumn.DataPropertyName = "TenHV";
            this.tenHVDataGridViewTextBoxColumn.HeaderText = "TenHV";
            this.tenHVDataGridViewTextBoxColumn.Name = "tenHVDataGridViewTextBoxColumn";
            // 
            // tenTruongDataGridViewTextBoxColumn
            // 
            this.tenTruongDataGridViewTextBoxColumn.DataPropertyName = "TenTruong";
            this.tenTruongDataGridViewTextBoxColumn.HeaderText = "TenTruong";
            this.tenTruongDataGridViewTextBoxColumn.Name = "tenTruongDataGridViewTextBoxColumn";
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "DiaChi";
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            // 
            // tinhTPVTDataGridViewTextBoxColumn
            // 
            this.tinhTPVTDataGridViewTextBoxColumn.DataPropertyName = "TinhTPVT";
            this.tinhTPVTDataGridViewTextBoxColumn.HeaderText = "TinhTPVT";
            this.tinhTPVTDataGridViewTextBoxColumn.Name = "tinhTPVTDataGridViewTextBoxColumn";
            // 
            // hocVienBindingSource
            // 
            this.hocVienBindingSource.DataMember = "HocVien";
            this.hocVienBindingSource.DataSource = this.qLTTGIASUDataSet2;
            // 
            // qLTTGIASUDataSet2
            // 
            this.qLTTGIASUDataSet2.DataSetName = "QLTTGIASUDataSet2";
            this.qLTTGIASUDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.ForeColor = System.Drawing.Color.Lime;
            this.btnReload.Location = new System.Drawing.Point(12, 330);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(106, 37);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Lime;
            this.btnThem.Location = new System.Drawing.Point(124, 330);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Lime;
            this.btnSua.Location = new System.Drawing.Point(233, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 37);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.Lime;
            this.btnLuu.Location = new System.Drawing.Point(343, 330);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(110, 37);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuyBo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyBo.ForeColor = System.Drawing.Color.Lime;
            this.btnHuyBo.Location = new System.Drawing.Point(459, 330);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(99, 37);
            this.btnHuyBo.TabIndex = 6;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Lime;
            this.btnXoa.Location = new System.Drawing.Point(564, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 37);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTroVe.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.Lime;
            this.btnTroVe.Location = new System.Drawing.Point(664, 330);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(92, 37);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // qLTTGIASUDataSet1
            // 
            this.qLTTGIASUDataSet1.DataSetName = "QLTTGIASUDataSet1";
            this.qLTTGIASUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qLTTGIASUDataSet1BindingSource
            // 
            this.qLTTGIASUDataSet1BindingSource.DataSource = this.qLTTGIASUDataSet1;
            this.qLTTGIASUDataSet1BindingSource.Position = 0;
            // 
            // hocVienTableAdapter
            // 
            this.hocVienTableAdapter.ClearBeforeFill = true;
            // 
            // Form5
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gray;
            this.Appearance.ForeColor = System.Drawing.Color.Red;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 403);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvHOCVIEN);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Quản Lý Danh Mục Khách Hàng";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHOCVIEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hocVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenTruong;
        private System.Windows.Forms.TextBox txtMaHV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHOCVIEN;
        private System.Windows.Forms.BindingSource qLTTGIASUDataSet1BindingSource;
        private QLTTGIASUDataSet1 qLTTGIASUDataSet1;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTroVe;
        private QLTTGIASUDataSet2 qLTTGIASUDataSet2;
        private System.Windows.Forms.BindingSource hocVienBindingSource;
        private QLTTGIASUDataSet2TableAdapters.HocVienTableAdapter hocVienTableAdapter;
        private System.Windows.Forms.TextBox txtTenHV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTruongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTPVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cbThanhPho;
    }
}