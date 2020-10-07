namespace QLTTGIASU_V0._2
{
    partial class Form4
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
            this.txtTenThanhPho = new System.Windows.Forms.TextBox();
            this.txtThanhPho = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvTHANHPHO = new System.Windows.Forms.DataGridView();
            this.tinhTPVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTinhThanhPhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhThanhPhoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLTTGIASUDataSet1 = new QLTTGIASU_V0._2.QLTTGIASUDataSet1();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuyBo = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.tinh_ThanhPhoTableAdapter = new QLTTGIASU_V0._2.QLTTGIASUDataSet1TableAdapters.Tinh_ThanhPhoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhThanhPhoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenThanhPho);
            this.panel1.Controls.Add(this.txtThanhPho);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(27, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(477, 106);
            this.panel1.TabIndex = 0;
            // 
            // txtTenThanhPho
            // 
            this.txtTenThanhPho.ForeColor = System.Drawing.Color.Lime;
            this.txtTenThanhPho.Location = new System.Drawing.Point(222, 61);
            this.txtTenThanhPho.Name = "txtTenThanhPho";
            this.txtTenThanhPho.Size = new System.Drawing.Size(228, 26);
            this.txtTenThanhPho.TabIndex = 3;
            // 
            // txtThanhPho
            // 
            this.txtThanhPho.ForeColor = System.Drawing.Color.Lime;
            this.txtThanhPho.Location = new System.Drawing.Point(222, 16);
            this.txtThanhPho.Name = "txtThanhPho";
            this.txtThanhPho.Size = new System.Drawing.Size(228, 26);
            this.txtThanhPho.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tỉnh, thành phố:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tỉnh, thành phố viế tắt:";
            // 
            // dgvTHANHPHO
            // 
            this.dgvTHANHPHO.AutoGenerateColumns = false;
            this.dgvTHANHPHO.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTHANHPHO.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvTHANHPHO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTHANHPHO.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tinhTPVTDataGridViewTextBoxColumn,
            this.tenTinhThanhPhoDataGridViewTextBoxColumn});
            this.dgvTHANHPHO.DataSource = this.tinhThanhPhoBindingSource;
            this.dgvTHANHPHO.Location = new System.Drawing.Point(27, 140);
            this.dgvTHANHPHO.Name = "dgvTHANHPHO";
            this.dgvTHANHPHO.Size = new System.Drawing.Size(477, 172);
            this.dgvTHANHPHO.TabIndex = 1;
            // 
            // tinhTPVTDataGridViewTextBoxColumn
            // 
            this.tinhTPVTDataGridViewTextBoxColumn.DataPropertyName = "TinhTPVT";
            this.tinhTPVTDataGridViewTextBoxColumn.HeaderText = "TinhTPVT";
            this.tinhTPVTDataGridViewTextBoxColumn.Name = "tinhTPVTDataGridViewTextBoxColumn";
            // 
            // tenTinhThanhPhoDataGridViewTextBoxColumn
            // 
            this.tenTinhThanhPhoDataGridViewTextBoxColumn.DataPropertyName = "TenTinh_ThanhPho";
            this.tenTinhThanhPhoDataGridViewTextBoxColumn.HeaderText = "TenTinh_ThanhPho";
            this.tenTinhThanhPhoDataGridViewTextBoxColumn.Name = "tenTinhThanhPhoDataGridViewTextBoxColumn";
            // 
            // tinhThanhPhoBindingSource
            // 
            this.tinhThanhPhoBindingSource.DataMember = "Tinh_ThanhPho";
            this.tinhThanhPhoBindingSource.DataSource = this.qLTTGIASUDataSet1;
            // 
            // qLTTGIASUDataSet1
            // 
            this.qLTTGIASUDataSet1.DataSetName = "QLTTGIASUDataSet1";
            this.qLTTGIASUDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnReload.ForeColor = System.Drawing.Color.Lime;
            this.btnReload.Location = new System.Drawing.Point(27, 324);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(104, 43);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.ForeColor = System.Drawing.Color.Lime;
            this.btnLuu.Location = new System.Drawing.Point(27, 374);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 42);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.ForeColor = System.Drawing.Color.Lime;
            this.btnThem.Location = new System.Drawing.Point(154, 325);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(98, 42);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuyBo.ForeColor = System.Drawing.Color.Lime;
            this.btnHuyBo.Location = new System.Drawing.Point(154, 374);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(98, 42);
            this.btnHuyBo.TabIndex = 5;
            this.btnHuyBo.Text = "Hủy Bỏ";
            this.btnHuyBo.UseVisualStyleBackColor = false;
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSua.ForeColor = System.Drawing.Color.Lime;
            this.btnSua.Location = new System.Drawing.Point(286, 325);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 42);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.ForeColor = System.Drawing.Color.Lime;
            this.btnXoa.Location = new System.Drawing.Point(286, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 42);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTroVe.ForeColor = System.Drawing.Color.Lime;
            this.btnTroVe.Location = new System.Drawing.Point(438, 325);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(66, 91);
            this.btnTroVe.TabIndex = 8;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // tinh_ThanhPhoTableAdapter
            // 
            this.tinh_ThanhPhoTableAdapter.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(531, 453);
            this.ControlBox = false;
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.dgvTHANHPHO);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Red;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form4";
            this.Text = "Quản Lý Danh Mục Tỉnh, Thành Phố";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTHANHPHO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhThanhPhoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTTGIASUDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtTenThanhPho;
        private System.Windows.Forms.TextBox txtThanhPho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvTHANHPHO;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnHuyBo;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnTroVe;
        private QLTTGIASUDataSet1 qLTTGIASUDataSet1;
        private System.Windows.Forms.BindingSource tinhThanhPhoBindingSource;
        private QLTTGIASUDataSet1TableAdapters.Tinh_ThanhPhoTableAdapter tinh_ThanhPhoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTPVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTinhThanhPhoDataGridViewTextBoxColumn;
    }
}