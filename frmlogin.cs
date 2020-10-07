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
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        //
        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
        //
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // Xử lý nút đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            if((this.txtUser.Text == "vuphamtiendung@gmail.com") && (this.txtPass.Text == "@_lethanhbinh_1992"))
            {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông Báo !");
                this.Close();
            }
            else
            {
                MessageBox.Show("không đúng tên đăng nhập / Mật khẩu !!!", "Thông Báo!");
                this.txtUser.Focus();
            }
        }
        // xử lý nút exit trên form đăng nhập
        private void frmlogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        // Xử lý nút button "thoát"
        private void button2_Click(object sender, EventArgs e)
        {
            // dùng biến kiểu DialogResult để lưu lại kết quả trả về của phương thức MessageBox.Show
            DialogResult traloi;
            traloi = MessageBox.Show("   Chắc Không? ", "Trả Lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(traloi == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
