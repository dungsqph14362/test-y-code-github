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
using DAL_DataAccessLayer.Models;

namespace GUI_PresentationLayer
{
    public partial class from_quenmatkhau : Form
    {
        private IquenmatkhauServices quenmatkhauServices;
        private int timeNow, _Time;
        public delegate void SendMessage(string Message);
        public SendMessage Sender;
        ChuTro _Chutro;
        private string _pass;
        private string _code;
        private System.Windows.Forms.Timer aTimer;

        private int counter = 60;
        private int flag;
        public from_quenmatkhau()
        {
            quenmatkhauServices = new quenmatkhauServices();
            InitializeComponent();
            Sender = new SendMessage(GetMessage);
            txt_Email.Enabled = true;
        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {
            btn_XacNhanEmail.Text = "Xác nhận Email";
        }

        private void btn_XacNhanEmail_Click(object sender, EventArgs e)
        {
            if (btn_XacNhanEmail.Text == "Xác nhận Email")
            {
                flag = 0;
                txt_Email.Enabled = false;
                if (quenmatkhauServices.checkEmail(txt_Email.Text) == false)
                {
                    MessageBox.Show("Email không tồn tại trong hệ thống", "thông báo");
                    return;
                }
                else
                {
                    var sendPassCode = quenmatkhauServices.SenderMail(txt_Email.Text);
                    if (sendPassCode == null)
                    {
                        MessageBox.Show("Lỗi");
                        return;
                    }
                    else
                    {
                        _pass = sendPassCode.pass;
                        _code = sendPassCode.code;

                        btn_XacNhanEmail.Text = "Xác nhận mã code";
                        MessageBox.Show("Mã xác nhận đã được gửi qua gmail", "thông báo");
                        _Time = DateTime.Now.Minute;
                    }
                }
            }
            else if (btn_XacNhanEmail.Text == "Xác nhận mã code")
            {
                timeNow = DateTime.Now.Minute;

                if (timeNow - _Time > 1)
                {
                    MessageBox.Show("Đã quá thời gian giây .\n Mã code đã vô hiệu hóa");
                    btn_XacNhanEmail.Text = "Xác nhận Email";
                }
                else if (flag == 3)
                {
                    MessageBox.Show("Đã quá 3 lần xác nhân .\n Mã code đã vô hiệu hóa");
                    btn_XacNhanEmail.Text = "Xác nhận Email";
                }
                else if (txt_checkMa.Text == _code)
                {
                    _Chutro = new ChuTro();
                    _Chutro = quenmatkhauServices.chutros(txt_Email.Text);
                    _Chutro.MatKhau = _pass;
                    MessageBox.Show(quenmatkhauServices.suaMK(_Chutro), "thông báo");
                    from_dangnhap fromdb = new from_dangnhap();
                    fromdb.Show();
                    this.Close();
                }
                else
                {
                    flag += 1;
                    MessageBox.Show("Mã code không hợp lệ", "thông báo");
                }
            }
        }

        private void GetMessage(string Message)
        {
            txt_Email.Text = Message;
        }
    }
}
