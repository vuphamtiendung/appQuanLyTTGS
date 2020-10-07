using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTTGIASU_V0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            Form frm = new frmlogin();
            frm.ShowDialog();
        }
        private void lbfooter_Click(object sender, EventArgs e)
        {

        }
        // Xử lý sự kiệm timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbfooter.Location = new Point(lbfooter.Location.X + i, lbfooter.Location.Y);
            if(lbfooter.Location.X>678 || lbfooter.Location.Y<10)
            {
                lbfooter.Location = new Point(lbfooter.Location.X - 678, lbfooter.Location.Y);
            }
            // gán giá trị ban đầu bằng 30
            //int i = 30;
            /*trong hàm timer1_Tick(), dịch chuyển bắt đầu từ cuối dòng sang phải một đơn vị*/
            /*lbfooter.Left -= 25;
            if(lbfooter.Left > this.Width - lbfooter.Width || lbfooter.Left <=0)
            {
               i =-1;
            } */
        }
        // tạo hàm Load, gọi hàm timer1 khi mỗi lần load giao diện
        private int i = 10;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Xử lý Form đổi mật khẩu
        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new FormDoimatkhau();
            frm.Text = "Doi mat khau";
            frm.ShowDialog();
        }
        void XemDanhMuc(int intDanhMuc)
        {
            Form frm = new Form3();
            frm.Text = intDanhMuc.ToString();
            frm.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        // Danh Mục Thành Phố
        private void danhMụcTỉnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(1);
        }
        // Danh Mục Học Viên
        private void danhMụcHọcViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(2);
        }
        // Danh Mục Nhân Viên
        private void danhMụcNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(3);
        }
        // Danh Mục Môn Học
        private void danhMụcMônHọcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(4);
        }
        // Danh Mục Biên Lai
        private void danhMụcBiênLaiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            XemDanhMuc(5);
        }
        // Danh Mục Chi Tiết Biên Lai
        private void danhMụcChiTiếtBiênLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemDanhMuc(6);
        }
        // Xử lý danh mục tỉnh, thành phố
        private void danhMụcTỉnhThànhPhốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form4();
            frm.Text = "Quản Lý Danh Mục Tỉnh, Thành Phố";
            frm.ShowDialog();
        }
        // Test thử ẩn quản lý danh mục.
        // Kết quả Test Thành Công.
        private void quảnLýDanhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.quảnLýDanhMụcToolStripMenuItem.Enabled = true;
        }
        // kết nối đến Form 5.
        private void danhMụcHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // khai báo Form 5.
            Form frm = new Form5();
            // đặt tên cho form 5, tên này sẽ hiển thị ở đầu form.
            frm.Text = "Quản lý danh mục Học Viên";
            // lệnh cho phép hiển thị form 5.
            frm.ShowDialog();
        }
        //Xử lý danh mục nhân viên.
        //kết nối đến form 6 quản lý danh mục nhân viên.
        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //gán đến vị trí form 6.
            Form frm = new Form6();
            // form login sẽ hiển thị dòng chữ.
            frm.Text = "Quản lý danh mục Nhân Viên";
            //hiển thị form login
            frm.ShowDialog();
        }
        // Xử lý mục quản lý danh mục môn học.
        private void danhMụcMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form7();
            frm.Text = "Quản lý danh mục Môn Học";
            frm.ShowDialog();
        }

        // Xử lý danh mục Biên Lai
        private void danhMụcBiênLaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form8();
            frm.Text = "Quản lý danh mục Biên Lai";
            frm.ShowDialog();
        }
        // Xử lý danh mục chi tiết biên lai.
        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new Form9();
            frm.Text = "Quản lý danh mục Chi Tiết Biên Lai";
            frm.ShowDialog();
        }
        //
        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
           
        }
    }
}
