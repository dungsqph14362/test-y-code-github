
namespace GUI_PresentationLayer
{
    partial class from_doimatkhau
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_moinew = new System.Windows.Forms.TextBox();
            this.txt_moi = new System.Windows.Forms.TextBox();
            this.btn_changePass = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_cu = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(189, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(189, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // txt_moinew
            // 
            this.txt_moinew.Location = new System.Drawing.Point(334, 258);
            this.txt_moinew.Name = "txt_moinew";
            this.txt_moinew.Size = new System.Drawing.Size(268, 27);
            this.txt_moinew.TabIndex = 80;
            this.txt_moinew.TextChanged += new System.EventHandler(this.txt_moinew_TextChanged);
            // 
            // txt_moi
            // 
            this.txt_moi.Location = new System.Drawing.Point(334, 205);
            this.txt_moi.Name = "txt_moi";
            this.txt_moi.Size = new System.Drawing.Size(268, 27);
            this.txt_moi.TabIndex = 81;
            this.txt_moi.TextChanged += new System.EventHandler(this.txt_moi_TextChanged);
            // 
            // btn_changePass
            // 
            this.btn_changePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_changePass.Location = new System.Drawing.Point(334, 308);
            this.btn_changePass.Name = "btn_changePass";
            this.btn_changePass.Size = new System.Drawing.Size(114, 48);
            this.btn_changePass.TabIndex = 79;
            this.btn_changePass.Text = "Đổi mật khẩu";
            this.btn_changePass.UseVisualStyleBackColor = false;
            this.btn_changePass.Click += new System.EventHandler(this.btn_changePass_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_exit.Location = new System.Drawing.Point(497, 372);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 47);
            this.btn_exit.TabIndex = 78;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(334, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 28);
            this.label9.TabIndex = 77;
            this.label9.Text = "Đổi mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 75;
            this.label7.Text = "Email ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Mật khẩu cũ";
            // 
            // txt_cu
            // 
            this.txt_cu.Location = new System.Drawing.Point(334, 148);
            this.txt_cu.Name = "txt_cu";
            this.txt_cu.Size = new System.Drawing.Size(268, 27);
            this.txt_cu.TabIndex = 73;
            this.txt_cu.TextChanged += new System.EventHandler(this.txt_cu_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(334, 95);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(268, 27);
            this.txt_email.TabIndex = 74;
            // 
            // from_doimatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_moinew);
            this.Controls.Add(this.txt_moi);
            this.Controls.Add(this.btn_changePass);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cu);
            this.Controls.Add(this.txt_email);
            this.Name = "from_doimatkhau";
            this.Text = "from_doimatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_moinew;
        private System.Windows.Forms.TextBox txt_moi;
        private System.Windows.Forms.Button btn_changePass;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_cu;
        private System.Windows.Forms.TextBox txt_email;
    }
}