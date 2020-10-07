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
    public partial class Form5 : DevExpress.XtraEditors.XtraForm
    {
        public Form5()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        // xử lý textbox.
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // xử lý toàn bộ Form!.
        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTGIASUDataSet2.HocVien' table. You can move, or remove it, as needed.
            this.hocVienTableAdapter.Fill(this.qLTTGIASUDataSet2.HocVien);
            LoadData();
        }
        // thực hiện viết chuỗi kết nối.
        // Initial Catalog, đây là chỉ định cách kết nối tới cơ sở dữ liệu. 
        // Trên máy của chúng ta thường để Windows Authentication cho nên tham số Integrated Security mang giá trị True như trên khi kết nối.
        string strConnectionString = "Data Source = DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog = QLTTGIASU; Integrated Security = true";
        // Đối tượng kết nối.
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable dtHocVien.
        SqlDataAdapter daHocVien = null;
        // Đối tượng hiển thị dữ liệu lên Form
        DataTable dtHocVien = null;
        // Đối tượng đưa dữ liệu vào DataTable dtTinhThanhPho.
        SqlDataAdapter daTinhThanhPho = null;
        // Đối tượng hiển thị dữ liệu lên form
        DataTable dtTinhthanhPho = null;
        // khai báo biến thêm hay sửa dữ liệu.
        bool Them;
        void LoadData()
        {
            try
            {
                // khởi động connection
                conn = new SqlConnection(strConnectionString);
                // vận chuyển dữ liệu vào DataTable dtTinhThanhPho.
                daTinhThanhPho = new SqlDataAdapter("Select * From Tinh_ThanhPho", conn);
                dtTinhthanhPho = new DataTable();
                dtTinhthanhPho.Clear();
                daTinhThanhPho.Fill(dtTinhthanhPho);
                // vận chuyển dữ liệu vào DataTable dtHocVien.
                daHocVien = new SqlDataAdapter("Select * From HocVien", conn);
                dtHocVien = new DataTable();
                dtHocVien.Clear();
                daHocVien.Fill(dtHocVien);
                // Đưa dữ liệu lên DataGridView.
                dgvHOCVIEN.DataSource = dtHocVien;
                // Xóa trống đối tượng trong Panel.
                this.txtMaHV.ResetText();
                this.txtTenHV.ResetText();
                this.txtTenTruong.ResetText();
                this.txtDiaChi.ResetText();
                // không cho thao tác trên các nút lưu và nút hủy bỏ.
                this.btnLuu.Enabled = false;
                this.btnHuyBo.Enabled = false;
                this.panel1.Enabled = false;
                // Cho thao tác trên các nút Thêm/Xóa/Trở về/Sửa.
                this.btnThem.Enabled = true;
                this.btnSua.Enabled = true;
                this.btnXoa.Enabled = true;
            }
            catch(SqlException)
            {
                MessageBox.Show("Không thêm được, lỗi rồi nè!!!");
            }
        }
        // Xử lý sự kiện nút Reload.
        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý sự kiện nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            // Xóa trống các đối tượng trong Panel.
            this.txtMaHV.ResetText();
            this.txtTenTruong.ResetText();
            this.txtDiaChi.ResetText();
            this.txtTenHV.ResetText();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ/Panel/Trở Về.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            this.btnTroVe.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa.
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            // Đưa dữ liệu lên ComboBox.
            this.cbThanhPho.DataSource = dtTinhthanhPho;
            // DisplayMember chứa cột trong bảng dữ liệu hiển thị cho mình thấy.
            this.cbThanhPho.DisplayMember = "TinhTPVT";
            // valumeMember chứa cột trong bảng dữ liệu khi lựa chọn ở combobox.
            this.cbThanhPho.ValueMember = "TenTinh_ThanhPho";
            // Đưa con trỏ đến TextField txtMaHV.
            this.txtMaHV.Focus();
        }
        // xử lý nút Sửa.
        private void btnSua_Click(object sender, EventArgs e)
        {
            // kích hoạt biến Sửa.
            Them = false;
            // Đưa dữ liệu lên ComboBox.
            // DisplayMember chứa cột trong bảng dữ liệu hiển thị cho mình thấy.
            this.cbThanhPho.DisplayMember = "TinhTPVT";
            // valumeMember chứa cột trong bảng dữ liệu khi lựa chọn ở combobox.
            this.cbThanhPho.ValueMember = "TenTinh_ThanhPho";
            // Cho thao tác trên Panel.
            this.panel1.Enabled = true;
            // Thứ tự dòng hiện hành.
            int r = dgvHOCVIEN.CurrentCell.RowIndex;
            // Chuyển thông tin lên Panel.
            this.txtMaHV.Text = dgvHOCVIEN.Rows[r].Cells[0].Value.ToString();
            this.txtTenHV.Text = dgvHOCVIEN.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text = dgvHOCVIEN.Rows[r].Cells[2].Value.ToString();
            this.cbThanhPho.SelectedValue = dgvHOCVIEN.Rows[r].Cells[3].Value.ToString();
            this.txtTenTruong.Text = dgvHOCVIEN.Rows[r].Cells[4].Value.ToString();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ/ và Panel.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHV
            this.txtMaHV.Focus();
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
                    // thực hiện lệnh.
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert Into.
                    cmd.CommandText = System.String.Concat("Insert Into HocVien Values(" + " ' " + this.txtMaHV.Text.ToString() + " ','" + this.txtTenTruong.Text.ToString() + "','" + this.txtDiaChi.Text.ToString() + "','" + this.cbThanhPho.SelectedValue.ToString() + "','" + this.txtTenHV.Text.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load dữ liệu lên DataGridView.
                    LoadData();
                    // thông báo.
                    MessageBox.Show("Đã Thêm Xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!");
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
                    int r = dgvHOCVIEN.CurrentCell.RowIndex;
                    // MaHV hiện hành.
                    string strMaHV = dgvHOCVIEN.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL.
                    cmd.CommandText = System.String.Concat("Update HocVien Set TenHV='" + this.txtTenHV.Text.ToString() + "' TinhTPVT='" + this.cbThanhPho.SelectedValue.ToString() + "' TenTruong='" + this.txtTenTruong.Text.ToString() + "' TinhTPVT='" + this.cbThanhPho.SelectedValue.ToString() + "' DiaChi ='" + this.txtDiaChi.Text.ToString() + "' Where MaHV = '" + strMaHV + "'");
                    // cập nhật.
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu lên DataGridView.
                    LoadData();
                    // Thông Báo.
                    MessageBox.Show("Đã Sửa Xong!");
                    }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rồi!");
                }
                }
            // Đóng kết nối.
            conn.Close();
        }

        private void dgvHOCVIEN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Xử lý nút trở về.
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý nút Xóa.
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            try
            {
                // Thực hiện lệnh.
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                // Lấy thứ tự Record hiện hành.
                int r = dgvHOCVIEN.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành.
                string strMaHV = dgvHOCVIEN.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL
                cmd.CommandText = System.String.Concat("Delete From HocVien Where MaHV='" + strMaHV + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện lệnh SQL.
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridview.
                LoadData();
                // Thông báo
                MessageBox.Show("Đã Xóa xong!");
            }
            catch (SqlException)
            {
                // Thông Báo.
                MessageBox.Show("Không xóa được, lỗi rồi!!!");
            }
            // Đóng kết nối
            conn.Close();
        }

        private void cbThanhPho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
 
}