using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using BUS_BusinessLayer.IServices;
using BUS_BusinessLayer.Serivces;
using DAL_DataAccessLayer.DALServices;
using DAL_DataAccessLayer.Models;

namespace GUI_PresentationLayer
{
    public partial class Form1 : Form
    {
        private IQuanLyHopDong _quanLyHopDong;
        private HopDongService _hopDongService;
        private KhachHangService _khachHangService;
        private ChuTroService _chuTroService;
        private List<HopDong> _lstHopDongs;
        public Form1()
        {
            InitializeComponent();
            _lstHopDongs = new List<HopDong>();
            _quanLyHopDong = new QuanLyHopDong();
            _hopDongService = new HopDongService();
            _chuTroService = new ChuTroService();
            _khachHangService = new KhachHangService();
            loaddata();
        }

        void loaddata()
        {
            dgv_hopdong.ColumnCount = 6;
            dgv_hopdong.Columns[0].Name = "mã hợp đồng";
            dgv_hopdong.Columns[1].Name = "tổng tiền";
            dgv_hopdong.Columns[2].Name = "trạng thái";
            dgv_hopdong.Columns[3].Name = "mã phòng trọ";
            dgv_hopdong.Columns[4].Name = "mã khách hàng";
            dgv_hopdong.Columns[5].Name = "tên khách hàng";
            dgv_hopdong.Rows.Clear();
            foreach (var x in _quanLyHopDong.GetLstHopDong())
            {
                dgv_hopdong.Rows.Add(x.MaHopDong, x.TongTien, x.TrangThai == 1?"còn hiệu lực":"hết hiệu lực", x.MaChuTro, x.MaKhachHang,_khachHangService.GetLstKhachHang().Where(c=>c.MaKhachHang == x.MaKhachHang).Select(c=>c.TenKhachHang).FirstOrDefault());

            }
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            _lstHopDongs = new List<HopDong>();
            _lstHopDongs = _quanLyHopDong.TimKiem(txt_timkiem.Text);
            dgv_hopdong.ColumnCount = 5;
            dgv_hopdong.Columns[0].Name = "mã hợp đồng";
            dgv_hopdong.Columns[1].Name = "tổng tiền";
            dgv_hopdong.Columns[2].Name = "trạng thái";
            dgv_hopdong.Columns[3].Name = "mã phòng trọ";
            dgv_hopdong.Columns[4].Name = "mã khách hàng";
            dgv_hopdong.Rows.Clear();
            foreach (var x in _lstHopDongs)
            {
                dgv_hopdong.Rows.Add(x.MaHopDong, x.TongTien, x.TrangThai == 1?"còn hiệu lực" : "hết hiệu lực", x.MaChuTro, x.MaKhachHang, _khachHangService.GetLstKhachHang().Where(c => c.MaKhachHang == x.MaKhachHang).Select(c => c.TenKhachHang).FirstOrDefault());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if ((rowindex == _quanLyHopDong.GetLstHopDong().Count) || rowindex == -1) ;
            txt_mahopdong.Text = dgv_hopdong.Rows[rowindex].Cells[0].Value.ToString();
            txt_tongtien.Text = dgv_hopdong.Rows[rowindex].Cells[1].Value.ToString();
            cbx_conhieuluc.Checked =
                dgv_hopdong.Rows[rowindex].Cells[2].Value.ToString() == "còn hiệu lực" ? true : false;
            cbx_hethieuluc.Checked =
                dgv_hopdong.Rows[rowindex].Cells[2].Value.ToString() == "hết hiệu lực" ? true : false;
            txt_machutro.Text = dgv_hopdong.Rows[rowindex].Cells[3].Value.ToString();
            txt_makhachhang.Text = dgv_hopdong.Rows[rowindex].Cells[4].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HopDong acc = new HopDong();
            acc.MaHopDong = _hopDongService.GetLstHopDong().Count == null
                ? 1
                : _hopDongService.GetLstHopDong().Max(c => c.MaHopDong) + 1;
            acc.TongTien = txt_tongtien.Text;
            acc.TrangThai = Convert.ToInt32(cbx_conhieuluc.Checked ? true : false);
            acc.MaChuTro = Convert.ToInt32(txt_machutro.Text);
            acc.MaKhachHang = Convert.ToInt32(txt_makhachhang.Text);
            MessageBox.Show(_hopDongService.ThemHopDong(acc), "thông báo");
        }
    }
}
