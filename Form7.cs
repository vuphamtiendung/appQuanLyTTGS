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
    public partial class Form7 : DevExpress.XtraEditors.XtraForm
    {
        public Form7()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        // Xử lý sự kiện From Load.
        private void Form7_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTGIASUDataSet4.MonHoc' table. You can move, or remove it, as needed.
            this.monHocTableAdapter.Fill(this.qLTTGIASUDataSet4.MonHoc);
            LoadData();
        }
        // Panel
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        // Chuỗi kết nối.
        string strConnectionString = "Data Source = DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog = QLTTGIASU; Integrated Security = True";
        // Đối tượng kết nối.
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable daMonHoc
        SqlDataAdapter daMonHoc = null;
        // Đối tượng hiển thị dữ liệu lên form.
        DataTable dtMonHoc = null;
        bool Them;
        // Khai báo hàm ở mức class.
        void LoadData()
        {
            try
            {
                // khởi động connection.
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataGridview dtMonHoc.
                daMonHoc = new SqlDataAdapter("Select * From MonHoc", conn);
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();
                daMonHoc.Fill(dtMonHoc);
                // Đưa dữ liệu lên DataGridView.
                dgvMonHoc.DataSource = dtMonHoc;
                // Thay đổi độ rộng của cột
                dgvMonHoc.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel.
                this.txtMaMH.ResetText();
                this.txtTenMH.ResetText();
                this.txtDonvitinh.ResetText();
                this.txtDongia.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy Bỏ.
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
                this.btnThem.Enabled = true;
                this.btnXoa.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnTroVe.Enabled = true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong bảng MonHoc. Lỗi rồi!!!");
            }
        }
        // Xử lý sự kiện Form Load.
        private void Form7_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên.
            dtMonHoc.Dispose();
            dtMonHoc = null;
            // Hủy kết nối
            conn = null;
        }
        // Xử lý sự kiện nút Reload
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý sự kiện nút "Trở Về"
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Xử lý nút thêm.
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong panel.
            this.txtMaMH.ResetText();
            this.txtTenMH.ResetText();
            this.txtDonvitinh.ResetText();
            this.txtDongia.ResetText();
            // Cho thao tác trên các nút Lưu/Hủy bỏ/Panel1.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến textField txtMaMH
            this.txtMaMH.Focus();
        }
        // Xử lý nút sửa.
        private void btnSua_Click(object sender, EventArgs e)
        {
            // kích hoạt biến sửa.
            Them = false;
            // Cho phép thao tác trên Panel.
            this.panel1.Enabled = true;
            // Thứ tự dòng hiện hành.
            int r = dgvMonHoc.CurrentCell.RowIndex;
            // Chuyển thông tin lên Panel.
            this.txtMaMH.Text = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
            this.txtTenMH.Text = dgvMonHoc.Rows[r].Cells[1].Value.ToString();
            this.txtDonvitinh.Text = dgvMonHoc.Rows[r].Cells[2].Value.ToString();
            this.txtDongia.Text = dgvMonHoc.Rows[r].Cells[3].Value.ToString();
            // Cho thao tác trên các nút Lưu/Hủy bỏ/ Panel.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Sửa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = true;
            // Đưa con trỏ đến.
            this.txtMaMH.Focus();
        }

        // Xử lý nút lưu.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối.
            conn.Open();
            // Thêm Dữ liệu.
            if(Them)
            {
                // Thêm dữ liệu.
                try
                {
                    // Thực hiện lệnh.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert Into.
                    cmd.CommandText = System.String.Concat("Insert Into MonHoc Values (" + "'" + this.txtMaMH.Text.ToString() + "', '" + this.txtTenMH.Text.ToString() + "', '" + this.txtDonvitinh.Text.ToString() + "', '" + this.txtDongia.Text.ToString() + "')'");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu trên DataGridView.
                    LoadData();
                    MessageBox.Show("Đã Thêm Xong!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!!!");
                }
            }
            if(!Them)
            {
                try
                {
                    // Thêm dữ liệu.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng hiện hành.
                    int r = dgvMonHoc.CurrentCell.RowIndex;
                    // MaMH hiện hành.
                    string strMaMH = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
                    // Câu Lệnh SQL.
                    cmd.CommandText = System.String.Concat("Update MonHoc TenMH = '" + this.txtTenMH.Text.ToString() + "', DonViTinh='" + this.txtDonvitinh.Text.ToString() + "', DonGia='" + this.txtDongia.Text.ToString() + "' Where MaMH='" + strMaMH + "'");
                    // Cập Nhật.
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load dữ liệu trên dataGridView.
                    MessageBox.Show("Đã sửa xong!!!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không sửa được, lỗi rồi!!!");
                }
            }
        }

        // Xử lý nút Hủy Bỏ.
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Xóa trống các đối tượng trong Panel1.
            this.txtMaMH.ResetText();
            this.txtTenMH.ResetText();
            this.txtDonvitinh.ResetText();
            this.txtDongia.ResetText();
            // Cho thao tác trên các nút Thêm/Sửa/Xóa/Trở Về.
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Lưu/Hủy Bỏ.
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled = false;
        }

        // Xử lý nút xoa. 
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối.
            conn.Open();
            try
            {
                // Thực hiện lệnh.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự record hiện hành.
                int r = dgvMonHoc.CurrentCell.RowIndex;
                // Lấy MaMH của record hiện hành.
                string strMaMH = dgvMonHoc.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL.
                cmd.CommandText = System.String.Concat("Delete From MonHoc Where MaMH ='" + strMaMH + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL.
                cmd.ExecuteNonQuery();
                // Cập nhật lại dữ liệu DataGridView.
                LoadData();
                // Thông Báo
                MessageBox.Show("Đã xóa xong!!!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được, lỗi rổi!!!");
            }
            // Đóng kết nối.
            conn.Close();
        }
    }
}