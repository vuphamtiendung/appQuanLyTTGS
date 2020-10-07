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
    public partial class Form6 : DevExpress.XtraEditors.XtraForm
    {
        public Form6()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        // ô text tên.
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        // xử lý trong toàn bộ form 6.
        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTGIASUDataSet3.NhanVien' table. You can move, or remove it, as needed.
            this.nhanVienTableAdapter.Fill(this.qLTTGIASUDataSet3.NhanVien);

            // load dữ liệu vào Form 6.
            LoadData();
        }
        // thực hiện chuỗi kết nối
        // Initial Security, đây là chỉ định cách kết nối tới cơ sở dữ liệu.
        // Trên máy của chúng ta thường để mặc định là Windows Authentication nên tham số Integrated Security mang giá trị true như khi kết nối.
        string strConnectionString = "Data Source = DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog = QLTTGIASU; Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào bảng dữ liệu Nhân Viên (DataTable dtNhanVien).
        SqlDataAdapter daNhanVien = null;
        // Đối tượng hiển thị dữ liệu lên Form (hiển thị).
        DataTable dtNhanVien = null;
        // Khai báo biến kiểm tra việc Thêm hay Sửa dữ liệu.
        bool Them;
        // Khai báo ở mức class
        void LoadData()
        {
            try
            {
                // Khởi động kết nối.
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtNhanVien.
                daNhanVien = new SqlDataAdapter("Select * From NhanVien", conn);
                dtNhanVien = new DataTable();
                dtNhanVien.Clear();
                daNhanVien.Fill(dtNhanVien);
                // Đưa dữ liệu lên DataGridView.
                dgvNhanVien.DataSource = dtNhanVien;
                // Thay đổi độ rộng của cột.
                dgvNhanVien.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel().
                this.txtMaNV.ResetText();
                this.txtHoLot.ResetText();
                this.txtTen.ResetText();
                this.txtNgaySinh.ResetText();
                this.txtDiaChi.ResetText();
                this.txtDienThoai.ResetText();
                this.txtChucVu.ResetText();
                // Không cho thao tác trên các nút lưu/hủy bỏ.
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                // Cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            catch (SqlException)
            {
                // Tạo Form hiển thị thông báo.
                MessageBox.Show("Không lấy được nội dung trong table NhanVien. Lỗi rồi!!!");
            }
        }
        // xử lý DataGridview.
        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Xử lý sự kiện Form Closing.
        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên.
            dtNhanVien.Dispose();
            dtNhanVien = null;
            // Hủy kết nối.
            conn = null;
        }
        // Xử lý sự kiện các nút.
        // nút Reload.
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý sự kiện nút trở về.
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý sự kiện nút thêm.
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng.
            this.txtMaNV.ResetText();
            this.txtHoLot.ResetText();
            this.txtTen.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtChucVu.ResetText();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            this.btnSua.Enabled = false;
            // Đưa con trỏ lên TextFied txtMaNV
            this.txtMaNV.Focus();
        }
        // Xử lý nút sửa.
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa.
            Them = false;
            // Cho thao tác trên các thuộc tính.
            this.txtMaNV.Enabled = true;
            this.txtNgaySinh.Enabled = true;
            this.txtTen.Enabled = true;
            this.txtHoLot.Enabled = true;
            this.txtDiaChi.Enabled = true;
            this.txtDienThoai.Enabled = true;
            this.txtChucVu.Enabled = true;
            // Thứ tự dạng hiện hành.
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên các thuộc tính.
            this.txtMaNV.Text = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtHoLot.Text = dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtTen.Text = dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtNgaySinh.Text = dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtDiaChi.Text = dgvNhanVien.Rows[r].Cells[4].Value.ToString();
            this.txtDienThoai.Text = dgvNhanVien.Rows[r].Cells[5].Value.ToString();
            this.txtChucVu.Text = dgvNhanVien.Rows[r].Cells[6].Value.ToString();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaNV.
            this.txtMaNV.Focus();
        }
        // Xử lý nút Hủy Bỏ
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng.
            this.txtMaNV.ResetText();
            this.txtHoLot.ResetText();
            this.txtTen.ResetText();
            this.txtNgaySinh.ResetText();
            this.txtDiaChi.ResetText();
            this.txtDienThoai.ResetText();
            this.txtChucVu.ResetText();
            // Cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu/Hủy Bỏ.
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
        }
        // Xử lý nút Xóa.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối.
            conn.Open();
            try
            {
                // Thực hiện lệnh.
                // Đối tượng SqlCommand cho phép chọn kiểu tương tác mà bạn muốn thực hiện với database.
                // Cách tạo một đối tượng SqlCommand là: SqlCommand cmd = new SqlCommand(“select CategoryName from Categories”, conn);
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự Record hiện hành
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Lấy MaNV của record hiện hành
                string strMaNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh Sql
                cmd.CommandText = System.String.Concat("Delete From NhanVien Where MaNV='" + strMaNV + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lênh SQL.
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridview
                LoadData();
                // Thông Báo.
                MessageBox.Show("Đã Xóa Xong");
            }
            catch (SqlException)
            {
                // Thông báo.
                MessageBox.Show("Không thêm được, lỗi rồi!!!");
            }
            // Đóng kết nối
            conn.Close();
        }
        // Xử lý nút lưu.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở Kết Nối.
            conn.Open();
            // Thêm dữ liệu
            /* Kiểm tra điều kiện biến đưa vào phải là Them mới 
               cho phép thực hiện các khối lệnh trong if.*/
            if(Them)
            {
                // Sử dụng cặp lệnh try catch để bắt khối dữ liệu.
                try
                {
                    // Thực hiện lệnh.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    /*Sử dụng lệnh Insert Into để thêm dữ liệu vào bảng nhân viên 
                     gồm các giá trị mã nhân viên; họ lót; địa chỉ; tên; điện thoại.*/
                    cmd.CommandText = System.String.Concat("Insert Into NhanVien Values(" + "'" + this.txtMaNV.Text.ToString() + "', '" + this.txtHoLot.Text.ToString() + "', '" +this.txtDiaChi.Text.ToString() + "', '" + this.txtTen.Text.ToString() + "','" + this.txtDienThoai.Text.ToString() + "', '" + this.txtChucVu.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView.
                    LoadData();
                    // Thông Báo.
                    MessageBox.Show("Đã Thêm Xong!!!");
                }
                catch(SqlException)
                {
                    // Thông Báo.
                    MessageBox.Show("Không thêm được. Lỗi Rồi!!!");
                }
            }
            if(!Them)
            {
                // Sử dụng cặp lệnh try - catch để bắt lỗi dữ liệu.
                try
                {
                    // Thực hiện câu lệnh kết nối.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành.
                    int r = dgvNhanVien.CurrentCell.RowIndex;
                    // MaNV Hiện hành.
                    string strMaNV = dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                    /* Viết câu lệnh SQL thực hiện update dữ liệu vào bảng nhân viên bao gồm
                     * các thông tin cơ bản như họ tên; địa chỉ; điện thoại; tên; với điều kiện
                     * mã nhân viên nhập vào bằng giá trị mã sinh viên có trong bảng dữ liệu.*/
                    cmd.CommandText = System.String.Concat("Update NhanVien Set HoLot ='" + this.txtHoLot.Text.ToString() + "', Ten ='" + this.txtTen.Text.ToString() + "', DiaChi ='" + this.txtDiaChi.Text.ToString() + "', ChucVu='" + this.txtChucVu.Text.ToString() + "' Where MaNV = '" + strMaNV + "'");
                    // Cập Nhật.
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu lên DataGridview.
                    LoadData();
                    // Thông Báo.
                    MessageBox.Show("Đã sửa xong!!!");
                }
                // Tìm ra lỗi thì đưa ra thông báo không sửa được.
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được, lỗi rồi!!!");
                }
                // Đóng kết nối
                conn.Close();
            }
        }
    }
}