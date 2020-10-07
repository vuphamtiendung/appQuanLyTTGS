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
    public partial class FormDoimatkhau : Form
    {
        public FormDoimatkhau()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void FormDoimatkhau_Load(object sender, EventArgs e)
        {

        }
        public string userName
        {
            get;
            set;
        }
        public string password
        {
            get;
            set;
        }
        // xử lý form đổi mật khẩu
        private void changePassword()
        {
            if(textBox6.Text == userName)
            {
                if(textBox7.Text == password)
                {
                    if(textBox7.Text == textBox7Repeat.Text)
                    {
                        MessageBox.Show("Password đã được thay đổi");
                        password = textBox7.Text;
                    }
                    else
                    {
                        textBox7Repeat.Focus();
                        MessageBox.Show("Password repeate không giống nhau");
                    }
                }
                else
                {
                    textBox7.Focus();
                    MessageBox.Show("sai Password");
                }
            }
            else
            {
                textBox6.Focus();
                MessageBox.Show("không tồn tại user này !");
            }
        }
        // Xử lý button "Đồng Ý"
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox6.Text == "")
            {
                MessageBox.Show("bạn chưa đăng nhập 'tên đăng nhập'!");
                textBox6.Focus();
            }
            else if(textBox7.Text ==" ")
            {
                MessageBox.Show("Bạn chưa đăng nhập 'Mật Khẩu Cũ'!");
                textBox7.Focus();
            }
            else if (textBox8.Text == " ")
            {
                MessageBox.Show("Bạn chưa nhập 'Mật Khẩu Mới'!");
                textBox8.Focus();
            }
            else if(textBox7Repeat.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập lại mật khẩu !");
                textBox7Repeat.Focus();
            }
            MessageBox.Show("Đổi Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
        // Xử lý nút thoát trên Form đổi mật khẩu.
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
