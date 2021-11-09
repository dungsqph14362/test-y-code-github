
namespace GUI_PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.dgv_hopdong = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahopdong = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_makhachhang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_machutro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_tongtien = new System.Windows.Forms.TextBox();
            this.cbx_conhieuluc = new System.Windows.Forms.CheckBox();
            this.cbx_hethieuluc = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hopdong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(663, 183);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(125, 27);
            this.txt_timkiem.TabIndex = 0;
            this.txt_timkiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // dgv_hopdong
            // 
            this.dgv_hopdong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hopdong.Location = new System.Drawing.Point(12, 216);
            this.dgv_hopdong.Name = "dgv_hopdong";
            this.dgv_hopdong.RowHeadersWidth = 51;
            this.dgv_hopdong.RowTemplate.Height = 29;
            this.dgv_hopdong.Size = new System.Drawing.Size(776, 222);
            this.dgv_hopdong.TabIndex = 1;
            this.dgv_hopdong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm kiếm";
            // 
            // txt_mahopdong
            // 
            this.txt_mahopdong.Location = new System.Drawing.Point(170, 19);
            this.txt_mahopdong.Name = "txt_mahopdong";
            this.txt_mahopdong.Size = new System.Drawing.Size(125, 27);
            this.txt_mahopdong.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "mã hợp đồng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "tổng tiền";
            // 
            // txt_makhachhang
            // 
            this.txt_makhachhang.Location = new System.Drawing.Point(170, 154);
            this.txt_makhachhang.Name = "txt_makhachhang";
            this.txt_makhachhang.Size = new System.Drawing.Size(125, 27);
            this.txt_makhachhang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "trạng thái";
            // 
            // txt_machutro
            // 
            this.txt_machutro.Location = new System.Drawing.Point(170, 121);
            this.txt_machutro.Name = "txt_machutro";
            this.txt_machutro.Size = new System.Drawing.Size(125, 27);
            this.txt_machutro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "mã chủ trọ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "mã khách hàng";
            // 
            // txt_tongtien
            // 
            this.txt_tongtien.Location = new System.Drawing.Point(170, 55);
            this.txt_tongtien.Name = "txt_tongtien";
            this.txt_tongtien.Size = new System.Drawing.Size(125, 27);
            this.txt_tongtien.TabIndex = 11;
            // 
            // cbx_conhieuluc
            // 
            this.cbx_conhieuluc.AutoSize = true;
            this.cbx_conhieuluc.Location = new System.Drawing.Point(170, 89);
            this.cbx_conhieuluc.Name = "cbx_conhieuluc";
            this.cbx_conhieuluc.Size = new System.Drawing.Size(111, 24);
            this.cbx_conhieuluc.TabIndex = 13;
            this.cbx_conhieuluc.Text = "còn hiệu lực";
            this.cbx_conhieuluc.UseVisualStyleBackColor = true;
            // 
            // cbx_hethieuluc
            // 
            this.cbx_hethieuluc.AutoSize = true;
            this.cbx_hethieuluc.Location = new System.Drawing.Point(277, 89);
            this.cbx_hethieuluc.Name = "cbx_hethieuluc";
            this.cbx_hethieuluc.Size = new System.Drawing.Size(108, 24);
            this.cbx_hethieuluc.TabIndex = 14;
            this.cbx_hethieuluc.Text = "hết hiệu lực";
            this.cbx_hethieuluc.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbx_hethieuluc);
            this.Controls.Add(this.cbx_conhieuluc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_tongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_machutro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_makhachhang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_mahopdong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_hopdong);
            this.Controls.Add(this.txt_timkiem);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hopdong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.DataGridView dgv_hopdong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mahopdong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_makhachhang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_machutro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_tongtien;
        private System.Windows.Forms.CheckBox cbx_conhieuluc;
        private System.Windows.Forms.CheckBox cbx_hethieuluc;
        private System.Windows.Forms.Button button1;
    }
}

