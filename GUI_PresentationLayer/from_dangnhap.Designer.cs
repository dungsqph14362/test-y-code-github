
namespace GUI_PresentationLayer
{
    partial class from_dangnhap
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
            this.cbx_saveLogin = new System.Windows.Forms.CheckBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.llbl_forgotPass = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_emailLogin = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 70;
            this.label2.Text = "Bạn không nhớ mật khẩu";
            // 
            // cbx_saveLogin
            // 
            this.cbx_saveLogin.AutoSize = true;
            this.cbx_saveLogin.Location = new System.Drawing.Point(538, 208);
            this.cbx_saveLogin.Name = "cbx_saveLogin";
            this.cbx_saveLogin.Size = new System.Drawing.Size(147, 24);
            this.cbx_saveLogin.TabIndex = 69;
            this.cbx_saveLogin.Text = "Ghi nhớ tài khoản";
            this.cbx_saveLogin.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Login.Location = new System.Drawing.Point(341, 232);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(114, 48);
            this.btn_Login.TabIndex = 68;
            this.btn_Login.Text = "Đăng nhập";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_exit.Location = new System.Drawing.Point(561, 368);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(114, 47);
            this.btn_exit.TabIndex = 67;
            this.btn_exit.Text = "Thoát";
            this.btn_exit.UseVisualStyleBackColor = false;
            // 
            // llbl_forgotPass
            // 
            this.llbl_forgotPass.ActiveLinkColor = System.Drawing.Color.Gainsboro;
            this.llbl_forgotPass.AutoSize = true;
            this.llbl_forgotPass.Location = new System.Drawing.Point(294, 337);
            this.llbl_forgotPass.Name = "llbl_forgotPass";
            this.llbl_forgotPass.Size = new System.Drawing.Size(120, 20);
            this.llbl_forgotPass.TabIndex = 66;
            this.llbl_forgotPass.TabStop = true;
            this.llbl_forgotPass.Text = "Quên mật khẩu ?";
            this.llbl_forgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbl_forgotPass_LinkClicked);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(265, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(223, 28);
            this.label9.TabIndex = 65;
            this.label9.Text = "Đăng Nhập Hệ Thống ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 63;
            this.label7.Text = "Email Đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Mật khẩu";
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(281, 164);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(268, 27);
            this.txt_pass.TabIndex = 61;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            // 
            // txt_emailLogin
            // 
            this.txt_emailLogin.Location = new System.Drawing.Point(281, 114);
            this.txt_emailLogin.Name = "txt_emailLogin";
            this.txt_emailLogin.Size = new System.Drawing.Size(268, 27);
            this.txt_emailLogin.TabIndex = 62;
            // 
            // from_dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_saveLogin);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.llbl_forgotPass);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_emailLogin);
            this.Name = "from_dangnhap";
            this.Text = "from_dangnhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbx_saveLogin;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.LinkLabel llbl_forgotPass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_emailLogin;
    }
}