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
using BUS_BusinessLayer.unlititi;
using DAL_DataAccessLayer.Models;

namespace GUI_PresentationLayer
{
    public partial class from_doimatkhau : Form
    {
        private IDoimatkhauServices doiMatKhauService;
        private ChuTro chuTro;
        private Unlititi uni = new Unlititi();
        public from_doimatkhau()
        {
            InitializeComponent();
            doiMatKhauService = new DoimatkhauServices();
            Sender = new SendMessage(GetMessage);
            txt_email.Enabled = false;
        }
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        private void GetMessage(string Message)
        {
            txt_email.Text = Message;
        }

        private void btn_changePass_Click(object sender, EventArgs e)
        {
            var email = txt_email.Text;
            var pass = txt_cu.Text;
            var passnew = txt_moi.Text;
            var passnew1 = txt_moinew.Text;
            chuTro = new ChuTro();
            chuTro = doiMatKhauService.chutros(email, pass);
            if (chuTro == null)
            {
                MessageBox.Show("Tài khoản hoặc Mật khẩu không tồn tại !");
                txt_email.Focus();
                txt_email.Enabled = true;
                return;
            }
            else if (passnew != passnew1)
            {
                MessageBox.Show("Mật khẩu không khớp");
                txt_moinew.Focus();
                return;
            }
            else if (email.Length == 0 && pass.Length == 0)
            {
                MessageBox.Show("Không được để trống thông tin");
                return;
            }
            else
            {
                chuTro.MatKhau = passnew1;
                MessageBox.Show(doiMatKhauService.UpdatePass(chuTro));
                this.Close();
                //frm_manhinhchinh.ActiveForm.Hide();
                from_dangnhap frm = new from_dangnhap();
                frm.Show();
            }
        }

        private void txt_cu_TextChanged(object sender, EventArgs e)
        {
            txt_cu.PasswordChar = '*';
        }

        private void txt_moi_TextChanged(object sender, EventArgs e)
        {
            txt_moi.PasswordChar = '*';
        }

        private void txt_moinew_TextChanged(object sender, EventArgs e)
        {
            txt_moinew.PasswordChar = '*';
        }
    }
}
