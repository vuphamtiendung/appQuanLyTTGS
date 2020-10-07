using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QLTTGIASU_V0._2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        // Chuỗi Kết Nối
        string strConnectionString = "Data Source= DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog= QLTTGIASU; Integrated Security = True";
        // Đối Tượng Kết Nối
        SqlConnection conn = null;
        // Đối tượng dữ liệu DataTable dtThanhPho
        SqlDataAdapter daTinhThanhPho = null;
        // Đối tượng hiển thị dữ liệu lên Form.
        DataTable dtTinhThanhPho = null;
        bool Them; //Khai báo biến kiểm tra việc thêm hay sửa dữ liệu.
        void LoadData()
        {
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable dtTinhThanhPho
                daTinhThanhPho = new SqlDataAdapter("SELECT * FROM Tinh_ThanhPho", conn);
                dtTinhThanhPho = new DataTable();
                dtTinhThanhPho.Clear();
                daTinhThanhPho.Fill(dtTinhThanhPho);
                // Đưa dữ liệu lên DataGridView.
                dgvTHANHPHO.DataSource = dtTinhThanhPho;
                // Thay đổi độ rộng của cột.
                dgvTHANHPHO.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel.
                this.txtThanhPho.ResetText();
                this.txtTenThanhPho.ResetText();
                // Không cho thao tác trên các nút lưu và nút hủy.
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm/Sửa/Xóa/Trở Về
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Không Lấy được nội dung trong table Tinh_ThanhPho. Lỗi Rồi!!!");
            }
        }
        // Form Load
        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTGIASUDataSet1.Tinh_ThanhPho' table. You can move, or remove it, as needed.
            this.tinh_ThanhPhoTableAdapter.Fill(this.qLTTGIASUDataSet1.Tinh_ThanhPho);
            LoadData();
        }
        // Xử lý sự kiện nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Thêm
            Them = true;
            // Xóa trống các đối tượng trong Panel
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Lưu/Hủy/ và Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Trở Về
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextFied txtThanhPho.
            this.txtThanhPho.Focus();
        }
        // Xử lý sự kiện Form Closing
        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên
            dtTinhThanhPho.Dispose();
            dtTinhThanhPho = null;
            // Hủy Kết Nối
            conn = null;
        }
        // Xử lý sự kiện nút Reload
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý sự kiện nút Trở Về
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý sự kiện nút Sửa.
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến Sửa.
            Them = false;
            // Cho thao tác trên Panel.
            this.panel1.Enabled = true;
            // Thứ tự dòng hiện hành.
            int r = dgvTHANHPHO.CurrentCell.RowIndex;
            // Chuyển thông tin lên Panel.
            this.txtThanhPho.Text = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
            this.txtTenThanhPho.Text = dgvTHANHPHO.Rows[r].Cells[1].Value.ToString();
            // Cho thao tác trên các nút Lưu/Hủy và Panel
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaKH
            this.txtThanhPho.Focus();
        }
        // Xử lý nút Xóa.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở Kết nối.
            conn.Open();
            try
            {
                // thực hiện lệnh.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự Record hiện hành.
                int r = dgvTHANHPHO.CurrentCell.RowIndex;
                // Lấy mã KH của Record hiện hành.
                string strTHANHPHO = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL.
                cmd.CommandText = System.String.Concat("Delete From Tinh_ThanhPho Where TinhTPVT = '"+strTHANHPHO+"'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL.
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridview.
                LoadData();
                // Thông Báo.
                MessageBox.Show("Đã Xóa Xong");
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
            // Đóng kết nối.
            conn.Close();
        }
        // Xử lý nút Hủy Bỏ
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống đối tượng trong panel.
            this.txtThanhPho.ResetText();
            this.txtTenThanhPho.ResetText();
            // Cho thao tác trên các nút Thêm/Sửa/Xóa/Trở Về.
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu/Hủy Bỏ và panel.
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled = false;
        }
        // Xử lý button Lưu.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối.
            conn.Open();
            // Thêm Dữ Liệu.
            if(Them)
            {
                try
                {
                    // thực hiện lệnh.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert Into.
                    cmd.CommandText = System.String.Concat("Insert Into Tinh_ThanhPho Values(" + "'" + this.txtThanhPho.Text.ToString() + "','" + this.txtTenThanhPho.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load dữ liệu DataGridView.
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã Thêm Xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!");
                }
            }
            if(!Them)
            {
                // Thực hiện lệnh.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Thứ tự dòng hiện hành
                int r = dgvTHANHPHO.CurrentCell.RowIndex;
                // MaKH hiện hành
                string strTHANHPHO = dgvTHANHPHO.Rows[r].Cells[0].Value.ToString();
                // Câu lệnh Sql
                cmd.CommandText = System.String.Concat("Update Tinh_ThanhPho set TenThanhPho = '" + this.txtTenThanhPho.Text.ToString() + "' Where Tinh_ThanhPho = '" + strTHANHPHO + "'");
                // Cập Nhật
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                // Load lại dữ liệu trên DataGridView.
                LoadData();
                // Thông Báo
                MessageBox.Show("Đã sửa xong!");
            }
            // Đóng kết nối.
            conn.Close();
        }
    }
}
