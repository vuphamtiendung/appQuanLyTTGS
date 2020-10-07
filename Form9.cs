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
    public partial class Form9 : DevExpress.XtraEditors.XtraForm
    {
        public Form9()
        {
            InitializeComponent();
            this.CenterToScreen();
        }



        // Xử lý Form 9.
        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLTTGIASUDataSet6.ChiTietBienLai' table. You can move, or remove it, as needed.
            this.chiTietBienLaiTableAdapter.Fill(this.qLTTGIASUDataSet6.ChiTietBienLai);
            LoadData();
        }
        // Chuỗi kết nối
        string strConnectionString = "Data Source = DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog = QLTTGIASU; Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa vào dữ liệu DataTable daChiTietBienLai.
        SqlDataAdapter daChiTietBienLai = null;
        // Đối tượng hiển thị dữ liệu lên Form.
        DataTable dtChiTietBienLai = null;
        // Đối tượng đưa dữ liệu vào DataTable dtBienLai
        SqlDataAdapter daBienLai = null;
        // Đối tượng hiển thị dữ liệu lên Form.
        DataTable dtBienLai = null;
        // Đối tượng đưa dữ liệu vào DataTable dtMonHoc.
        SqlDataAdapter daMonHoc = null;
        // Đối tượng hiển thị dữ liệu lên Form.
        DataTable dtMonHoc = null;
        bool Them;
        // Khai báo tại mức class.
        void LoadData()
        {
            try
            {
                // Khởi động Connection.
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu vào DataTable dtBienLai
                daBienLai = new SqlDataAdapter("Select * From BienLai", conn);
                dtBienLai = new DataTable();
                dtBienLai.Clear();
                daBienLai.Fill(dtBienLai);
                // Vận chuyển dữ liệu vào DataTable dtMonHoc
                daMonHoc = new SqlDataAdapter("Select * From MonHoc", conn);
                dtMonHoc = new DataTable();
                dtMonHoc.Clear();
                daMonHoc.Fill(dtMonHoc);
                // Vận chuyển dữ liệu vào DataTable dtChiTietBienLai.
                daChiTietBienLai = new SqlDataAdapter("Select * From ChiTietBienLai", conn);
                dtChiTietBienLai = new DataTable();
                daChiTietBienLai.Fill(dtChiTietBienLai);
                // Đưa dữ liệu lên DataGridView.
                dgvChiTietBienLai.DataSource = dtChiTietBienLai;
                // Xóa trống các đối tượng trong Panel.
                this.txtSoLuong.ResetText();
                // Không cho thao tác trên các nút Lưu/Hủy.
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
                MessageBox.Show("Không lấy được nội dung trên Table ChiTietHoaDon, Lỗi rồi!!!");
            }
        }



        // Xử lý sự kiện Form Closing.
        private void Form9_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giải phóng tài nguyên.
            dtChiTietBienLai.Dispose();
            dtChiTietBienLai = null;
            // Hủy kết nối.
            conn = null; 

        }




        // Xử lý nút Reload.
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }
        // Xử lý nút Trở Về.
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý nút Thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            // kích hoạt biến Thêm.
            Them = true;
            // Xóa trống các đối tượng trong Panel.
            this.txtSoLuong.ResetText();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ/Panel.
            this.btnLuu.Enabled = true;
            this.btnHuyBo.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Xóa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa dữ liệu lên ComboBox
            this.cbMaBL.DataSource = dtBienLai;
            this.cbMaBL.DisplayMember = "MaBL";
            this.cbMaMH.DataSource = dtMonHoc;
            this.cbMaMH.DisplayMember = "MaMH";
            // Đưa con trỏ đến TextField txtSoLuong.
            this.txtSoLuong.Focus();
        }



        // Xử lý nút Sửa.
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kích hoạt biến sửa.
            Them = true;
            // Đưa dữ liệu lên ComboBox.
            this.cbMaBL.DataSource = dtBienLai;
            this.cbMaBL.DisplayMember = "MaBL";
            this.cbMaMH.DataSource = dtMonHoc;
            this.cbMaMH.DisplayMember = "MaMH";
            // Cho phép thao tác trên Panel
            this.panel1.Enabled = true;
            // Thứ tự dòng lệnh hiện hành.
            int r = dgvChiTietBienLai.CurrentCell.RowIndex;
            // Chuyển thông tin lên Panel.
            this.txtSoLuong.Text = dgvChiTietBienLai.Rows[r].Cells[0].Value.ToString();
            this.cbMaBL.SelectedValue = dgvChiTietBienLai.Rows[r].Cells[1].Value.ToString();
            this.cbMaMH.SelectedValue = dgvChiTietBienLai.Rows[r].Cells[2].Value.ToString();
            // Cho thao tác trên các nút Lưu/Hủy Bỏ/Panel.
            this.btnHuyBo.Enabled = true;
            this.btnLuu.Enabled = true;
            this.panel1.Enabled = true;
            // Không cho thao tác trên các nút Thêm/Sửa/Xóa/Trở Về.
            this.btnThem.Enabled = false;
            this.btnSua.Enabled = false;
            this.btnXoa.Enabled = false;
            this.btnTroVe.Enabled = false;
            // Đưa con trỏ đến TextField txtSoLuong
            this.txtSoLuong.Focus();
        }


        // Xử lý nút lưu.
        private void btnLuu_Click(object sender, EventArgs e)
        {
            // Mở kết nối
            conn.Open();
            // Thêm dữ liệu
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Lệnh Insert Into
                    cmd.CommandText = System.String.Concat("Insert Into ChiTietBienLai Values(" + " ' " + this.txtSoLuong.Text.ToString() + "', '" + this.cbMaBL.SelectedValue.ToString() + "', '" + this.cbMaMH.SelectedValue.ToString() + "')");
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load dữ liệu lên DataGridview.
                    LoadData();
                    // thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không thêm được, lỗi rổi!");
                }
            }
            if(!Them)
            {
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    // Thứ tự dòng lệnh hiện hành
                    int r = dgvChiTietBienLai.CurrentCell.RowIndex;
                    // MaBL hiện hành
                    string strMaBL = dgvChiTietBienLai.Rows[r].Cells[0].Value.ToString();
                    // Câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Update ChiTietBienLai set SoMH = + '" + this.txtSoLuong.Text.ToString() + "', MaBL= '" + this.cbMaBL.SelectedValue.ToString() + "', MaMH= '" + this.cbMaMH.SelectedValue.ToString() + "' Where MaBL='" + strMaBL + "'");
                    // Cập nhật 
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    // Load lại dữ liệu lên DataGridView.
                    LoadData();
                    MessageBox.Show("Đã sửa xong!");
                }
                catch(SqlException)
                {
                    MessageBox.Show("Không sửa được, lỗi rồi!");
                }
            }
            // Đóng kết nối
            conn.Close();
        }


        // Xử lý nút Hủy Bỏ
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            // Cho thao tác trên các nút Thêm/Sửa/Xóa/Trở về.
            this.btnThem.Enabled = true;
            this.btnSua.Enabled = true;
            this.btnXoa.Enabled = true;
            this.btnTroVe.Enabled = true;
            // không cho thao tác trên các nút Lưu/Hủy Bỏ/Panel.
            this.btnLuu.Enabled = false;
            this.btnHuyBo.Enabled = false;
            this.panel1.Enabled = false;
        }


        // Xử lý nút Xóa
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
                // Lất thứ tự record hiện hành.
                int r = dgvChiTietBienLai.CurrentCell.RowIndex;
                // Lấy mã BL của record hiện hành.
                string strMaBL = dgvChiTietBienLai.Rows[r].Cells[0].Value.ToString();
                // Viết câu lệnh SQL.
                cmd.CommandText = System.String.Concat("Delete From ChiTietBienLai Where MaBL'" + strMaBL + "'");
                cmd.CommandType = CommandType.Text;
                // Thực hiện câu lệnh SQL
                cmd.ExecuteNonQuery();
                // Cập nhật lại DataGridView.
                LoadData();
                MessageBox.Show("Đã xóa xong!");
            }
            catch(SqlException)
            {
                MessageBox.Show("Không xóa được, lỗi rổi!");
            }

            // Đóng kết nối.
            conn.Close();
        }

        private void cbMaBL_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}