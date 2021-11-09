using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BUS_BusinessLayer.unlititi
{
   public class Unlititi
    {
        //code csc chức năng không dính dáng đến đối tượng
        public string MaHoaPass(string password)
        {
            //Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = Encoding.ASCII.GetBytes(password);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }
        public string PassRandom(int lengthCode)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, lengthCode)
                .Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }

        public bool checkSDT(string sdt)
        {
            if (sdt.Length < 10 || sdt.Length > 11)
            {
                return true;
            }
            return false;
        }

        public bool checkEmail(string email)
        {
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return true;
            }
            return false;
        }
        public bool checkChu(string test)
        {
            if ((test.All(char.IsDigit)))
            {
                return true;
            }
            else if (Regex.IsMatch(test, @"[\d+]"))
            {
                return true;
            }

            return false;
        }

        public bool checkSo(string test)
        {
            if (Regex.IsMatch(test, @"[^\d+$]"))
            {
                return true;
            }

            return false;
        }

        public bool checkNull(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                return true;
            }
            return false;
        }
    }
}
