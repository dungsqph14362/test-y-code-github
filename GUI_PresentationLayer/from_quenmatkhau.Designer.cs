
namespace GUI_PresentationLayer
{
    partial class from_quenmatkhau
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
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_XacNhanEmail = new System.Windows.Forms.Button();
            this.txt_checkMa = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(312, 116);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 28);
            this.label9.TabIndex = 80;
            this.label9.Text = "Quên mật khẩu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(190, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 78;
            this.label7.Text = "Email ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 234);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 79;
            this.label1.Text = "Mã xác nhân";
            // 
            // btn_XacNhanEmail
            // 
            this.btn_XacNhanEmail.Location = new System.Drawing.Point(342, 287);
            this.btn_XacNhanEmail.Name = "btn_XacNhanEmail";
            this.btn_XacNhanEmail.Size = new System.Drawing.Size(114, 48);
            this.btn_XacNhanEmail.TabIndex = 81;
            this.btn_XacNhanEmail.Text = "Xác nhận Email";
            this.btn_XacNhanEmail.UseVisualStyleBackColor = true;
            this.btn_XacNhanEmail.Click += new System.EventHandler(this.btn_XacNhanEmail_Click);
            // 
            // txt_checkMa
            // 
            this.txt_checkMa.Location = new System.Drawing.Point(342, 227);
            this.txt_checkMa.Name = "txt_checkMa";
            this.txt_checkMa.Size = new System.Drawing.Size(268, 27);
            this.txt_checkMa.TabIndex = 76;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(342, 178);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(268, 27);
            this.txt_Email.TabIndex = 77;
            this.txt_Email.TextChanged += new System.EventHandler(this.txt_Email_TextChanged);
            // 
            // from_quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_XacNhanEmail);
            this.Controls.Add(this.txt_checkMa);
            this.Controls.Add(this.txt_Email);
            this.Name = "from_quenmatkhau";
            this.Text = "from_quenmatkhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_XacNhanEmail;
        private System.Windows.Forms.TextBox txt_checkMa;
        private System.Windows.Forms.TextBox txt_Email;
    }
}