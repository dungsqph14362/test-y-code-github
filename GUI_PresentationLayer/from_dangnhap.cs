using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_BusinessLayer.IServices;
using BUS_BusinessLayer.Serivces;

namespace GUI_PresentationLayer
{
    public partial class from_dangnhap : Form
    {
        private IdangnhapServices _dangnhapServices;
        public from_dangnhap()
        {
            _dangnhapServices = new dangnhapServices();
            InitializeComponent();
        }

        private void llbl_forgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                from_quenmatkhau frmQuenMatKhau = new from_quenmatkhau();
                frmQuenMatKhau.Sender(txt_emailLogin.Text);
                frmQuenMatKhau.MdiParent = this.MdiParent;
                frmQuenMatKhau.Show();
            }
            catch
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            var email = txt_emailLogin.Text;
            var pass = txt_pass.Text;
            var kq = _dangnhapServices.checkLogin(email, pass);
            if (kq == 1)
            {
                if (_dangnhapServices.checkHD(txt_emailLogin.Text))
                {
                    MessageBox.Show("Tài khoản không còn hoạt động vui lòng dùng tài khoản khác", "Thông báo");
                    return;
                }
                //frm_manhinhchinh frmManhinhchinh = new frm_manhinhchinh();
                //frmManhinhchinh.Sender1(txt_emailLogin.Text);
                //frmManhinhchinh.Show();
                //frmManhinhchinh.openMenuQL();
                //if (_dangnhapServices.checkflag(email) == false)
                //{
                    from_doimatkhau frm = new from_doimatkhau();
                    frm.Sender(email);
                    this.Hide();
                    frm.Show();

                //}

                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else if (kq == 0)
            {
                if (_dangnhapServices.checkHD(txt_emailLogin.Text))
                {
                    MessageBox.Show("Tài khoản không còn hoạt động vui lòng dùng tài khoản khác", "Thông báo");
                    return;
                }
                //frm_manhinhchinh main = new frm_manhinhchinh();
                //main.Sender1(txt_emailLogin.Text);
                //main.Show();
                //main.openMenuNV();
                //if (_dangnhapServices.checkflag(email) == false)
                //{
                    from_doimatkhau frm = new from_doimatkhau();
                    frm.Sender(email);
                    this.Hide();
                    frm.Show();
                //}
                MessageBox.Show("Đăng nhập thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Thông báo");
            }
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            txt_pass.PasswordChar = '*';
        }

    }
}
