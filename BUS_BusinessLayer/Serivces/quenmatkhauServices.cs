using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using BUS_BusinessLayer.IServices;
using BUS_BusinessLayer.Model;
using BUS_BusinessLayer.unlititi;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.IDALServices;
using DAL_DataAccessLayer.Models;

namespace BUS_BusinessLayer.Serivces
{
    public class quenmatkhauServices : IquenmatkhauServices
    {
        private IChuTroService _ct;
        private Unlititi uni = new Unlititi();
        private PassXn _sendPass;
        private List<ChuTro> _lstChuTros;
        private string pass;
        private string code;

        public quenmatkhauServices()
        {
            _ct = new ChuTroService();
            _lstChuTros = _ct.GetLstChuTro();
        }
        public PassXn SenderMail(string mail)
        {
            try
            {
                pass = uni.PassRandom(6);
                code = uni.PassRandom(6);
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25);
                NetworkCredential cred = new NetworkCredential("dangvhhph14199@fpt.edu.vn", "Dangvd238");
                MailMessage mgs = new MailMessage();
                mgs.From = new MailAddress("dangvhhph14199@fpt.edu.vn");
                mgs.To.Add(mail);
                mgs.Subject = "Quên mật khẩu";
                mgs.Body = "Mật khẩu mới của bạn là: " + pass + "\nMã xác nhận của bạn là :" + code + "\n Mã sẽ vô hiệu lực sau 60 giây";
                client.Credentials = cred;
                client.EnableSsl = true;
                client.Send(mgs);
                _sendPass = new PassXn(pass, code);
                return _sendPass;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool checkEmail(string email)
        {
            try
            {
                bool ktra = _lstChuTros.Any(c => c.Email == email);
                return ktra;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public string suaMK(ChuTro ct)
        {
            try
            {
                _ct.SuaChuTro(ct);
                _ct.LuuChuTro();
                return "Mật khẩu đã được đổi thành công";

            }
            catch (Exception e)
            {
                return "Lỗi không đổi được mật khẩu";
            }
        }

        public ChuTro chutros(string email)
        {
            try
            {
                return _lstChuTros.FirstOrDefault(c => c.Email == email);
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
