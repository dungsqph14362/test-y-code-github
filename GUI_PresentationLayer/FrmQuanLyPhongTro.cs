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
    public partial class FrmQuanLyPhongTro : Form
    {
        private IQuanLyPhongTro _IQuanLyPhongTro;
        private IQuanLyHinhAnh _IQuanLyHinhAnh;
        private IQuanLyLoaiPhong _IQuanLyLoaiPhong;
        private IQuanLyHopDong _IQuanLyHopDong;
        private HinhAnh _HinhAnh;

        public FrmQuanLyPhongTro()
        {
            InitializeComponent();
            _IQuanLyPhongTro = new QuanLyPhongTro();
            _IQuanLyHinhAnh = new QuanLyHinhAnh();
            _IQuanLyLoaiPhong = new QuanLyLoaiPhong();
            _IQuanLyHopDong = new QuanLyHopDong();
            LoadData();
            loadComboboxLoaiPhong();
            loadComboboxMaHopDong();
        }

        void LoadData()
        {
            dgv_PhongTro.ColumnCount = 10;
            dgv_PhongTro.Columns[0].Name = "Mã Phòng Trọ";
            dgv_PhongTro.Columns[1].Name = "Tên Phòng Trọ";
            dgv_PhongTro.Columns[2].Name = "Giá Phòng";
            dgv_PhongTro.Columns[3].Name = "Dịa Chỉ";
            dgv_PhongTro.Columns[4].Name = "Diện tích";
            dgv_PhongTro.Columns[5].Name = "Trạng Thái";
            dgv_PhongTro.Columns[6].Name = "Loại Phòng";
            dgv_PhongTro.Columns[7].Name = "Mã Hợp Đồng";
            dgv_PhongTro.Columns[8].Name = "Link Hình Ảnh";
            dgv_PhongTro.Columns[9].Name = "Mô Tả";
            dgv_PhongTro.Columns[9].Visible = false;
            dgv_PhongTro.Rows.Clear();
            foreach (var x in _IQuanLyPhongTro.GetLstPhongTro())
            {
                dgv_PhongTro.Rows.Add(x.MaPhongTro,x.TenPhongTro,x.GiaPhong,x.DiaChi,x.DienTich,x.TrangThai == 1?"Đã Thuê":"Còn Trống",
                    _IQuanLyLoaiPhong.GetLstLoaiPhong().Where(c => c.MaLoaiPhong == x.MaLoaiPhong).Select(c => c.TenLoaiPhong).FirstOrDefault(),
                    x.MaHopDong,
                    _IQuanLyHinhAnh.GetLstHinhAnh().Where(c=>c.MaPhongTro == x.MaPhongTro).Select(c=>c.HinhAnhPhong).FirstOrDefault(),
                    x.MoTa);
            }
        }

        private void dgv_PhongTro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if ((rowindex == _IQuanLyPhongTro.GetLstPhongTro().Count) || rowindex == -1);
            txt_MaPhongTro.Text = dgv_PhongTro.Rows[rowindex].Cells[0].Value.ToString();
            txt_TenPhongTro.Text = dgv_PhongTro.Rows[rowindex].Cells[1].Value.ToString();
            txt_GiaPhong.Text = dgv_PhongTro.Rows[rowindex].Cells[2].Value.ToString();
            txt_DiaChi.Text = dgv_PhongTro.Rows[rowindex].Cells[3].Value.ToString();
            txt_DienTich.Text = dgv_PhongTro.Rows[rowindex].Cells[4].Value.ToString();
            rdo_DaThue.Checked = dgv_PhongTro.Rows[rowindex].Cells[5].Value.ToString() == "Đã Thuê" ? true : false;
            rdo_ConTrong.Checked = dgv_PhongTro.Rows[rowindex].Cells[5].Value.ToString() == "Còn Trống" ? true : false;
            cbo_LoaiPhong.Text = dgv_PhongTro.Rows[rowindex].Cells[6].Value.ToString();
            //cbo_LoaiPhong.SelectedIndex = cbo_LoaiPhong.SelectedIndex.t
            //txt_MaHopDong.Text = dgv_PhongTro.Rows[rowindex].Cells[7].Value.ToString();
            cbo_MaHopDong.Text = dgv_PhongTro.Rows[rowindex].Cells[7].Value.ToString();
            txt_LinkHinhAnh.Text = dgv_PhongTro.Rows[rowindex].Cells[8].Value.ToString();
            txt_MoTa.Text = dgv_PhongTro.Rows[rowindex].Cells[9].Value.ToString();
            pic_HinhAnh.ImageLocation = txt_LinkHinhAnh.Text;
            //if (!(string.IsNullOrWhiteSpace(txt_LinkHinhAnh.Text)))
            //{
            //    pic_HinhAnh.ImageLocation = txt_LinkHinhAnh.Text;
            //}

        }

        private void but_ChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenFileDialog = new OpenFileDialog();
            if (OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap Bitmap = new Bitmap(OpenFileDialog.FileName);
                pic_HinhAnh.Image = Bitmap;
                txt_LinkHinhAnh.Text = OpenFileDialog.FileName;
            }
        }

        void loadComboboxLoaiPhong()
        {
            foreach (var x in _IQuanLyLoaiPhong.GetLstLoaiPhong())
            {
                cbo_LoaiPhong.Items.Add(x.TenLoaiPhong);
            }
        }

        void loadComboboxMaHopDong()
        {
            foreach (var x in _IQuanLyHopDong.GetLstHopDong())
            {
                cbo_MaHopDong.Items.Add("HD" + x.MaHopDong);
            }
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_TimKiem.Text))
            {
                LoadData();
            }
            else
            {
                dgv_PhongTro.Rows.Clear();
                foreach (var x in _IQuanLyPhongTro.GetLstPhongTro().Where(c => c.TenPhongTro.StartsWith(txt_TimKiem.Text)))
                {
                    dgv_PhongTro.Rows.Add(x.MaPhongTro,x.TenPhongTro, x.GiaPhong, x.DiaChi, x.DienTich, x.TrangThai == 1 ? "Đã Thuê" : "Còn Trống",
                        _IQuanLyLoaiPhong.GetLstLoaiPhong().Where(c => c.MaLoaiPhong == x.MaLoaiPhong).Select(c => c.TenLoaiPhong).FirstOrDefault(),
                        x.MaHopDong,
                        _IQuanLyHinhAnh.GetLstHinhAnh().Where(c => c.MaPhongTro == x.MaPhongTro).Select(c => c.HinhAnhPhong).FirstOrDefault(),
                        x.MoTa);
                }
            }
        }

        private void but_Them_Click(object sender, EventArgs e)
        {
            //mã hợp đồng phải được null
            if (MessageBox.Show("Bạn có muốn thêm không?", "Thông Báo",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                //Thêm bảng Phòng trọ
                PhongTro PhongTro = new PhongTro();
                PhongTro.TenPhongTro = txt_TenPhongTro.Text;
                PhongTro.GiaPhong = txt_GiaPhong.Text;
                PhongTro.DiaChi = txt_DiaChi.Text;
                PhongTro.DienTich = txt_DienTich.Text;
                PhongTro.TrangThai = rdo_DaThue.Checked == true ? 1 : 0;
                PhongTro.MaLoaiPhong = cbo_LoaiPhong.SelectedIndex + 1;
                PhongTro.MaHopDong = Convert.ToInt32(cbo_MaHopDong.Text);
                PhongTro.MoTa = txt_MoTa.Text;

                //thêm vào bảng phòng trọ
                MessageBox.Show(_IQuanLyPhongTro.ThemPhongTro(PhongTro));

                //Lưu lại phòng trọ
                _IQuanLyPhongTro.LuuPhongTro();

                //Thêm vào trong datagridview
                dgv_PhongTro.Rows.Add(_IQuanLyPhongTro.GetLstPhongTro().Where(c => c.TenPhongTro == txt_TenPhongTro.Text).Select(c => c.MaPhongTro).FirstOrDefault(),
                    PhongTro.TenPhongTro, PhongTro.GiaPhong, PhongTro.DiaChi, PhongTro.DienTich, PhongTro.TrangThai == 1 ? "Đã Thuê" : "Còn Trống",
                    _IQuanLyLoaiPhong.GetLstLoaiPhong().Where(c => c.MaLoaiPhong == PhongTro.MaLoaiPhong).Select(c => c.TenLoaiPhong).FirstOrDefault(),
                    PhongTro.MaHopDong,
                    txt_LinkHinhAnh.Text, PhongTro.MoTa);

                //Thêm bảng hình ảnh
                HinhAnh HinhAnh = new HinhAnh();
                HinhAnh.HinhAnhPhong = txt_LinkHinhAnh.Text;
                HinhAnh.MaPhongTro = Convert.ToInt32(dgv_PhongTro.Rows[_IQuanLyPhongTro.GetLstPhongTro().Count - 1].Cells[0].Value);

                //thêm vào bảng hình ảnh
                _IQuanLyHinhAnh.ThemHinhAnh(HinhAnh);

                //Lưu lại hình ảnh
                _IQuanLyHinhAnh.LuuHinhAnh();

            }
        }

        private void but_Sua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn Sửa không?", "Thông Báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //sửa bảng Phòng trọ
                PhongTro PhongTro = new PhongTro();
                PhongTro.MaPhongTro = _IQuanLyPhongTro.GetLstPhongTro().Where(c => c.TenPhongTro == txt_TenPhongTro.Text).Select(c => c.MaPhongTro).FirstOrDefault();
                //PhongTro.MaPhongTro = Convert.ToInt32(txt_MaPhongTro.Text).AsNoTracking();
                PhongTro.TenPhongTro = txt_TenPhongTro.Text;
                PhongTro.GiaPhong = txt_GiaPhong.Text;
                PhongTro.DiaChi = txt_DiaChi.Text;
                PhongTro.DienTich = txt_DienTich.Text;
                PhongTro.TrangThai = rdo_DaThue.Checked == true ? 1 : 0;
                PhongTro.MaLoaiPhong = cbo_LoaiPhong.SelectedIndex + 1;
                PhongTro.MaHopDong = Convert.ToInt32(cbo_MaHopDong.Text);
                PhongTro.MoTa = txt_MoTa.Text;

                //sửa vào bảng phòng trọ
                MessageBox.Show(_IQuanLyPhongTro.SuaPhongTro(PhongTro));

                //Lưu lại phòng trọ
                _IQuanLyPhongTro.LuuPhongTro();

                ////sửa bảng hình ảnh
                //HinhAnh HinhAnh = new HinhAnh();
                //HinhAnh.Id = _IQuanLyHinhAnh.GetLstHinhAnh().Where(c => c.MaPhongTro == PhongTro.MaPhongTro).Select(c => c.Id).FirstOrDefault();
                //HinhAnh.HinhAnhPhong = txt_LinkHinhAnh.Text;
                //HinhAnh.MaPhongTro = _IQuanLyHinhAnh.GetLstHinhAnh().Where(c => c.Id == HinhAnh.Id).Select(c => c.MaPhongTro).FirstOrDefault();

                ////thêm vào bảng hình ảnh
                //_IQuanLyHinhAnh.SuaHinhAnh(HinhAnh);

                ////Lưu lại hình ảnh
                //_IQuanLyHinhAnh.LuuHinhAnh();

                LoadData();
            }
        }
















    }
}
