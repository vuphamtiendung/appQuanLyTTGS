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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        // Khai Báo
        //chuỗi kết nối
        string strConnectionString = "Data Source= DESKTOP-5PSSEM5\\SQLEXPRESS; Initial Catalog= QLTTGIASU; Integrated Security = True";
        // Đối tượng kết nối
        SqlConnection conn = null;
        // Đối tượng đưa dữ liệu vào DataTable daTable
        SqlDataAdapter daTable = null;
        // Đối tượng hiển thị dữ liệu lên Form.
        DataTable dtTable = null;
        // Xử lý tại Form 3
        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                // Khởi động Connection
                conn = new SqlConnection(strConnectionString);
                // xử lý danh mục
                int intDM = Convert.ToInt32(this.Text);
                switch (intDM)
                {
                    //xemDanhMụcToolStripMenuItem
                    case 1:
                        lblDanhMuc.Text = "Danh Mục Thành Phố";
                        daTable = new SqlDataAdapter("SELECT TinhTPVT, TenTinh_ThanhPho FROM Tinh_ThanhPho", conn);
                        break;
                    case 2:
                        lblDanhMuc.Text = "Danh Mục Học Viên";
                        daTable = new SqlDataAdapter("SELECT MaHV, TenHV, TenTruong, DiaChi, TinhTPVT FROM HocVien", conn);
                        break;
                    case 3:
                        lblDanhMuc.Text = "Danh Mục Nhân Viên";
                        daTable = new SqlDataAdapter("SELECT MaNV, HoLot, Ten, NgaySinh, DiaChi, DienThoai, ChucVu FROM NhanVien", conn);
                        break;
                    case 4:
                        lblDanhMuc.Text = "Danh Mục Môn Học";
                        daTable = new SqlDataAdapter("SELECT MaMH, TenMH, DonViTinh, DonGia FROM MonHoc", conn);
                        break;
                    case 5:
                        lblDanhMuc.Text = "Danh Mục Biên Lai";
                        daTable = new SqlDataAdapter("SELECT MaBL, MaHV, MaNV, NgayLapBL, NgayVaoHoc, NgayKetThuc FROM BienLai", conn);
                        break;
                    case 6:
                        lblDanhMuc.Text = "Danh Mục Chi Tiết Biên Lai";
                        daTable = new SqlDataAdapter("SELECT MaBL, MaMH, SoMH FROM ChiTietBienLai", conn);
                        break;
                    default:
                        break;
                }
                // Vận chuyển dữ liệu lên DataTable dtTable
                dtTable = new DataTable();
                dtTable.Clear();
                daTable.Fill(dtTable);
                // Đưa dữ liệu lên DataGridview
                dgvDanhMuc.DataSource = dtTable;
                // Thay đổi độ rộng của cột
                dgvDanhMuc.AutoResizeColumns();
            }
            catch(SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table. Lỗi rồi!!!");
            }
        }
        // Xử lý nút Trở Về
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý DataGridview
        private void dgvDanhMuc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
