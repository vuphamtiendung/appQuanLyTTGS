using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace QLTTGIASU_V0._2
{
    public partial class Form8 : DevExpress.XtraEditors.XtraForm
    {
        public Form8()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        // Xử lý Form Load.
        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTGIASUDataSet5.BienLai' table. You can move, or remove it, as needed.
            this.bienLaiTableAdapter.Fill(this.qLTTGIASUDataSet5.BienLai);
            LoadData();
        }
        // Khai báo mức class.
        // Dùng chuỗi kết nối.
        string strConnectionString = "Data Source = DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog = QLTTGIASU; Integrated Security = true";
        // Đối tượng kết nối.
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtBienLai.
        SqlDataAdapter daBienLai = null;
        // Đối tượng hiển thị dữ liệu lên Form.
        DataTable dtBienLai = null;
        bool Them;

        // Khai báo mức class
        void LoadData()
        {
            try
            {
                // Khởi động Connection.
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtBienLai.
                daBienLai = new SqlDataAdapter("Select * From BienLai", conn);
                dtBienLai = new DataTable();
                dtBienLai.Clear();
                daBienLai.Fill(dtBienLai);
                // Đưa dữ liệu lên DataGridView.
                dgvBienLai.DataSource = dtBienLai;
                // Thay đổi độ rộng của cột.
                dgvBienLai.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel.
                this.txtMaBL.ResetText();
                this.txtMaHV.ResetText();
                this.txtMaNV.ResetText();
                this.txtNgayKT.ResetText();
                this.txtNgayLapHD.ResetText();
                this.txtNgayVH.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy Bỏ/
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table BienLai, Lỗi rồi!!!");
            }
        }
        
        // Xử lý sự kiện Form Closing.
        private void Form8_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên.
            dtBienLai.Dispose();
            dtBienLai = null;
            // Hủy Kết nối.
            conn = null;
        }

        // Xử lý sự kiện nút Reload.
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        // Xử lý sự kiện nút Close.
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lý sự kiện nút Thêm.
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong panel.
            this.txtMaBL.ResetText();
            this.txtMaHV.ResetText();
            this.txtMaNV.ResetText();
            this.txtNgayKT.ResetText();
            this.txtNgayLapHD.ResetText();
            this.txtNgayVH.ResetText();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ/Panel.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Đưa con trỏ đến txtMaBL
            this.txtMaBL.Focus();
        }
        
        // Xử lý sự kiện nút Sửa.
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa.
            Them = true;
            // Cho phép thao tác trên panel.
            this.panel1.Enabled = true;
            // Thứ tự dòng hiện hành.
            int r = dgvBienLai.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel.
            this.txtMaBL.Text = dgvBienLai.Rows[r].Cells[0].Value.ToString();
            this.txtMaHV.Text = dgvBienLai.Rows[r].Cells[1].Value.ToString();
            this.txtMaNV.Text = dgvBienLai.Rows[r].Cells[2].Value.ToString();
            this.txtNgayLapHD.Text = dgvBienLai.Rows[r].Cells[3].Value.ToString();
            this.txtNgayVH.Text = dgvBienLai.Rows[r].Cells[4].Value.ToString();
            this.txtNgayKT.Text = dgvBienLai.Rows[r].Cells[5].Value.ToString();
            // Cho thao tác trên các nút Lưu/Hủy/Panel.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaBL
            this.txtMaBL.Focus();
        }

        // Xử lý nút Lưu.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối.
            conn.Open();
            // Thêm dữ liệu.
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Insert Into
                    cmd.CommandText = System.String.Concat("Insert Into BienLai Value(" + "'" + this.txtMaBL.Text.ToString() + "'" + this.txtMaHV.Text.ToString() + "'" + this.txtMaNV.Text.ToString() + "'" + this.txtNgayKT.Text.ToString() + "'" + this.txtNgayLapHD.Text.ToString() + "'" + this.txtNgayVH.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    LoadData();
                    MessageBox.Show("Đã thêm xong");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!!!");
                }
            }
            if(!Them)
            {
                try
                {
                    // Thực hiện lệnh.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành.
                    int r = dgvBienLai.CurrentCell.RowIndex;
                    // MaBL hiện hành.
                    string strMaBL = dgvBienLai.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL.
                    cmd.CommandText = System.String.Concat("Update BienLai set MaHV='" + this.txtMaHV.Text.ToString() + "', MaNV='" + this.txtMaNV.Text.ToString() + "', NgayLapHD=" + this.txtNgayLapHD.Text.ToString() + "', NgayVaoHoc=" + this.txtNgayVH.Text.ToString() + "', NgayKetThuc=" + this.txtNgayKT.Text.ToString() + "' Where MaBL='" + strMaBL + "'");
                    // Cập nhật.
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load dữ liệu lên DataGridView.
                    LoadData();
                    MessageBox.Show("Đã sửa xong!!!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!!!");
                }
            }
        }

        // Xử lý nút Hủy Bỏ.
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng
            this.txtMaBL.ResetText();
            this.txtMaHV.ResetText();
            this.txtMaNV.ResetText();
            this.txtNgayKT.ResetText();
            this.txtNgayLapHD.ResetText();
            this.txtNgayVH.ResetText();
            // Cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu/Hủy/Panel
            this.btnHuyBo.Enabled = false;
            this.btnLuu.Enabled = false;
            this.panel1.Enabled = false;
        }

        // Xử lý nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            try
            {
                // thực hiện lệnh
                // dùng SqlCommand để chọn kiểu tương tác
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành.
                int r = dgvBienLai.CurrentCell.RowIndex;
                // Lấy MaBL của record hiện hành
                string strMaBL = dgvBienLai.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh Sql
                cmd.CommandText = System.String.Concat("Delete From BienLai Where MaBL '" + strMaBL + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại dữ liệu DataGridView
                LoadData();
                MessageBox.Show("Đã xóa xong");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, lỗi rồi!!!");
            }
        }
    }
}