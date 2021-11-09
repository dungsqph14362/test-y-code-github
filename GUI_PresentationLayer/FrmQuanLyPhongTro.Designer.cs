
namespace GUI_PresentationLayer
{
    partial class FrmQuanLyPhongTro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_PhongTro = new System.Windows.Forms.DataGridView();
            this.txt_MaPhongTro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_TenPhongTro = new System.Windows.Forms.TextBox();
            this.txt_GiaPhong = new System.Windows.Forms.TextBox();
            this.txt_DienTich = new System.Windows.Forms.TextBox();
            this.txt_MoTa = new System.Windows.Forms.RichTextBox();
            this.pic_HinhAnh = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.but_Them = new System.Windows.Forms.Button();
            this.but_Sua = new System.Windows.Forms.Button();
            this.but_Xoa = new System.Windows.Forms.Button();
            this.txt_XoaTrang = new System.Windows.Forms.Button();
            this.but_Thoat = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_LinkHinhAnh = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rdo_DaThue = new System.Windows.Forms.RadioButton();
            this.rdo_ConTrong = new System.Windows.Forms.RadioButton();
            this.but_ChonAnh = new System.Windows.Forms.Button();
            this.txt_DiaChi = new System.Windows.Forms.RichTextBox();
            this.cbo_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.cbo_MaHopDong = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_PhongTro
            // 
            this.dgv_PhongTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhongTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhongTro.Location = new System.Drawing.Point(12, 401);
            this.dgv_PhongTro.Name = "dgv_PhongTro";
            this.dgv_PhongTro.RowTemplate.Height = 25;
            this.dgv_PhongTro.Size = new System.Drawing.Size(954, 177);
            this.dgv_PhongTro.TabIndex = 0;
            this.dgv_PhongTro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_PhongTro_CellClick);
            // 
            // txt_MaPhongTro
            // 
            this.txt_MaPhongTro.Enabled = false;
            this.txt_MaPhongTro.Location = new System.Drawing.Point(126, 79);
            this.txt_MaPhongTro.Name = "txt_MaPhongTro";
            this.txt_MaPhongTro.Size = new System.Drawing.Size(161, 23);
            this.txt_MaPhongTro.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(24, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Phòng Trọ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(24, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Phòng Trọ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(24, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(24, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(24, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mô Tả";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(357, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Diện Tích";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(612, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hình Ảnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(360, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 15);
            this.label8.TabIndex = 9;
            this.label8.Text = "Trạng Tái";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(344, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 10;
            this.label9.Text = "Loại Phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(332, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Mã Hợp Đồng";
            // 
            // txt_TenPhongTro
            // 
            this.txt_TenPhongTro.Location = new System.Drawing.Point(126, 116);
            this.txt_TenPhongTro.Name = "txt_TenPhongTro";
            this.txt_TenPhongTro.Size = new System.Drawing.Size(161, 23);
            this.txt_TenPhongTro.TabIndex = 12;
            // 
            // txt_GiaPhong
            // 
            this.txt_GiaPhong.Location = new System.Drawing.Point(126, 153);
            this.txt_GiaPhong.Name = "txt_GiaPhong";
            this.txt_GiaPhong.Size = new System.Drawing.Size(161, 23);
            this.txt_GiaPhong.TabIndex = 13;
            // 
            // txt_DienTich
            // 
            this.txt_DienTich.Location = new System.Drawing.Point(433, 74);
            this.txt_DienTich.Name = "txt_DienTich";
            this.txt_DienTich.Size = new System.Drawing.Size(161, 23);
            this.txt_DienTich.TabIndex = 15;
            // 
            // txt_MoTa
            // 
            this.txt_MoTa.Location = new System.Drawing.Point(79, 233);
            this.txt_MoTa.Name = "txt_MoTa";
            this.txt_MoTa.Size = new System.Drawing.Size(245, 98);
            this.txt_MoTa.TabIndex = 19;
            this.txt_MoTa.Text = "";
            // 
            // pic_HinhAnh
            // 
            this.pic_HinhAnh.Location = new System.Drawing.Point(676, 82);
            this.pic_HinhAnh.Name = "pic_HinhAnh";
            this.pic_HinhAnh.Size = new System.Drawing.Size(290, 252);
            this.pic_HinhAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_HinhAnh.TabIndex = 20;
            this.pic_HinhAnh.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(383, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 32);
            this.label11.TabIndex = 21;
            this.label11.Text = "Quản Lý Phòng Trọ";
            // 
            // but_Them
            // 
            this.but_Them.ForeColor = System.Drawing.Color.Black;
            this.but_Them.Location = new System.Drawing.Point(44, 601);
            this.but_Them.Name = "but_Them";
            this.but_Them.Size = new System.Drawing.Size(97, 33);
            this.but_Them.TabIndex = 22;
            this.but_Them.Text = "Thêm";
            this.but_Them.UseVisualStyleBackColor = true;
            this.but_Them.Click += new System.EventHandler(this.but_Them_Click);
            // 
            // but_Sua
            // 
            this.but_Sua.ForeColor = System.Drawing.Color.Black;
            this.but_Sua.Location = new System.Drawing.Point(202, 601);
            this.but_Sua.Name = "but_Sua";
            this.but_Sua.Size = new System.Drawing.Size(97, 33);
            this.but_Sua.TabIndex = 23;
            this.but_Sua.Text = "Sửa";
            this.but_Sua.UseVisualStyleBackColor = true;
            this.but_Sua.Click += new System.EventHandler(this.but_Sua_Click);
            // 
            // but_Xoa
            // 
            this.but_Xoa.ForeColor = System.Drawing.Color.Black;
            this.but_Xoa.Location = new System.Drawing.Point(360, 601);
            this.but_Xoa.Name = "but_Xoa";
            this.but_Xoa.Size = new System.Drawing.Size(97, 33);
            this.but_Xoa.TabIndex = 24;
            this.but_Xoa.Text = "Xóa";
            this.but_Xoa.UseVisualStyleBackColor = true;
            // 
            // txt_XoaTrang
            // 
            this.txt_XoaTrang.ForeColor = System.Drawing.Color.Black;
            this.txt_XoaTrang.Location = new System.Drawing.Point(676, 601);
            this.txt_XoaTrang.Name = "txt_XoaTrang";
            this.txt_XoaTrang.Size = new System.Drawing.Size(97, 33);
            this.txt_XoaTrang.TabIndex = 26;
            this.txt_XoaTrang.Text = "Xóa Trắng";
            this.txt_XoaTrang.UseVisualStyleBackColor = true;
            // 
            // but_Thoat
            // 
            this.but_Thoat.ForeColor = System.Drawing.Color.Black;
            this.but_Thoat.Location = new System.Drawing.Point(834, 601);
            this.but_Thoat.Name = "but_Thoat";
            this.but_Thoat.Size = new System.Drawing.Size(97, 33);
            this.but_Thoat.TabIndex = 27;
            this.but_Thoat.Text = "Thoát";
            this.but_Thoat.UseVisualStyleBackColor = true;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(433, 361);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(161, 23);
            this.txt_TimKiem.TabIndex = 29;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(366, 369);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 15);
            this.label12.TabIndex = 28;
            this.label12.Text = "Tìm Kiếm";
            // 
            // txt_LinkHinhAnh
            // 
            this.txt_LinkHinhAnh.Enabled = false;
            this.txt_LinkHinhAnh.Location = new System.Drawing.Point(344, 248);
            this.txt_LinkHinhAnh.Name = "txt_LinkHinhAnh";
            this.txt_LinkHinhAnh.Size = new System.Drawing.Size(250, 83);
            this.txt_LinkHinhAnh.TabIndex = 31;
            this.txt_LinkHinhAnh.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(344, 230);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 15);
            this.label13.TabIndex = 30;
            this.label13.Text = "Link Hình Ảnh";
            // 
            // rdo_DaThue
            // 
            this.rdo_DaThue.AutoSize = true;
            this.rdo_DaThue.Location = new System.Drawing.Point(433, 116);
            this.rdo_DaThue.Name = "rdo_DaThue";
            this.rdo_DaThue.Size = new System.Drawing.Size(68, 19);
            this.rdo_DaThue.TabIndex = 32;
            this.rdo_DaThue.TabStop = true;
            this.rdo_DaThue.Text = "Đã Thuê";
            this.rdo_DaThue.UseVisualStyleBackColor = true;
            // 
            // rdo_ConTrong
            // 
            this.rdo_ConTrong.AutoSize = true;
            this.rdo_ConTrong.Location = new System.Drawing.Point(514, 115);
            this.rdo_ConTrong.Name = "rdo_ConTrong";
            this.rdo_ConTrong.Size = new System.Drawing.Size(80, 19);
            this.rdo_ConTrong.TabIndex = 33;
            this.rdo_ConTrong.TabStop = true;
            this.rdo_ConTrong.Text = "Còn Trống";
            this.rdo_ConTrong.UseVisualStyleBackColor = true;
            // 
            // but_ChonAnh
            // 
            this.but_ChonAnh.ForeColor = System.Drawing.Color.Black;
            this.but_ChonAnh.Location = new System.Drawing.Point(676, 340);
            this.but_ChonAnh.Name = "but_ChonAnh";
            this.but_ChonAnh.Size = new System.Drawing.Size(97, 33);
            this.but_ChonAnh.TabIndex = 34;
            this.but_ChonAnh.Text = "Chọn Ảnh";
            this.but_ChonAnh.UseVisualStyleBackColor = true;
            this.but_ChonAnh.Click += new System.EventHandler(this.but_ChonAnh_Click);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(126, 195);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(161, 32);
            this.txt_DiaChi.TabIndex = 35;
            this.txt_DiaChi.Text = "";
            // 
            // cbo_LoaiPhong
            // 
            this.cbo_LoaiPhong.FormattingEnabled = true;
            this.cbo_LoaiPhong.Location = new System.Drawing.Point(433, 148);
            this.cbo_LoaiPhong.Name = "cbo_LoaiPhong";
            this.cbo_LoaiPhong.Size = new System.Drawing.Size(161, 23);
            this.cbo_LoaiPhong.TabIndex = 36;
            // 
            // cbo_MaHopDong
            // 
            this.cbo_MaHopDong.FormattingEnabled = true;
            this.cbo_MaHopDong.Location = new System.Drawing.Point(433, 185);
            this.cbo_MaHopDong.Name = "cbo_MaHopDong";
            this.cbo_MaHopDong.Size = new System.Drawing.Size(161, 23);
            this.cbo_MaHopDong.TabIndex = 37;
            // 
            // FrmQuanLyPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 662);
            this.Controls.Add(this.cbo_MaHopDong);
            this.Controls.Add(this.cbo_LoaiPhong);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.but_ChonAnh);
            this.Controls.Add(this.rdo_ConTrong);
            this.Controls.Add(this.rdo_DaThue);
            this.Controls.Add(this.txt_LinkHinhAnh);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txt_TimKiem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.but_Thoat);
            this.Controls.Add(this.txt_XoaTrang);
            this.Controls.Add(this.but_Xoa);
            this.Controls.Add(this.but_Sua);
            this.Controls.Add(this.but_Them);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pic_HinhAnh);
            this.Controls.Add(this.txt_MoTa);
            this.Controls.Add(this.txt_DienTich);
            this.Controls.Add(this.txt_GiaPhong);
            this.Controls.Add(this.txt_TenPhongTro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_MaPhongTro);
            this.Controls.Add(this.dgv_PhongTro);
            this.ForeColor = System.Drawing.Color.Blue;
            this.Name = "FrmQuanLyPhongTro";
            this.Text = "FrmQuanLyPhongTro";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhongTro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_HinhAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_PhongTro;
        private System.Windows.Forms.TextBox txt_MaPhongTro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_TenPhongTro;
        private System.Windows.Forms.TextBox txt_GiaPhong;
        private System.Windows.Forms.TextBox txt_DienTich;
        private System.Windows.Forms.RichTextBox txt_MoTa;
        private System.Windows.Forms.PictureBox pic_HinhAnh;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button but_Them;
        private System.Windows.Forms.Button but_Sua;
        private System.Windows.Forms.Button but_Xoa;
        private System.Windows.Forms.Button txt_XoaTrang;
        private System.Windows.Forms.Button but_Thoat;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox txt_LinkHinhAnh;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton rdo_DaThue;
        private System.Windows.Forms.RadioButton rdo_ConTrong;
        private System.Windows.Forms.Button but_ChonAnh;
        private System.Windows.Forms.RichTextBox txt_DiaChi;
        private System.Windows.Forms.ComboBox cbo_LoaiPhong;
        private System.Windows.Forms.ComboBox cbo_MaHopDong;
    }
}