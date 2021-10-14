
namespace LoginForm
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLinkRegister = new System.Windows.Forms.LinkLabel();
            this.txtLinkForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbErrorLogin = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbErrorLogin
            // 
            lbErrorLogin.AutoSize = true;
            lbErrorLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbErrorLogin.ForeColor = System.Drawing.Color.Red;
            lbErrorLogin.LiveSetting = System.Windows.Forms.Automation.AutomationLiveSetting.Assertive;
            lbErrorLogin.Location = new System.Drawing.Point(84, 27);
            lbErrorLogin.Margin = new System.Windows.Forms.Padding(0);
            lbErrorLogin.Name = "lbErrorLogin";
            lbErrorLogin.Size = new System.Drawing.Size(246, 15);
            lbErrorLogin.TabIndex = 9;
            lbErrorLogin.Text = "Tên đăng nhập hoặc mật khẩu không đúng!";
            lbErrorLogin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            lbErrorLogin.UseMnemonic = false;
            lbErrorLogin.Visible = false;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbEmail.Location = new System.Drawing.Point(18, 59);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(128, 15);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email/Tên Đăng Nhập:";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mật khẩu:";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(152, 56);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.PlaceholderText = "Nhập email hoặc tên đăng nhập";
            this.txtBoxEmail.Size = new System.Drawing.Size(223, 23);
            this.txtBoxEmail.TabIndex = 3;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.Location = new System.Drawing.Point(152, 105);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.PasswordChar = '*';
            this.txtBoxPass.PlaceholderText = "Nhập mật khẩu";
            this.txtBoxPass.Size = new System.Drawing.Size(222, 23);
            this.txtBoxPass.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(152, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLinkRegister
            // 
            this.txtLinkRegister.AutoSize = true;
            this.txtLinkRegister.Location = new System.Drawing.Point(27, 254);
            this.txtLinkRegister.Name = "txtLinkRegister";
            this.txtLinkRegister.Size = new System.Drawing.Size(240, 15);
            this.txtLinkRegister.TabIndex = 6;
            this.txtLinkRegister.TabStop = true;
            this.txtLinkRegister.Text = "Bạn chưa có tài khoản, nhấn vào đây để tạo!";
            // 
            // txtLinkForgotPass
            // 
            this.txtLinkForgotPass.AutoSize = true;
            this.txtLinkForgotPass.Location = new System.Drawing.Point(296, 254);
            this.txtLinkForgotPass.Name = "txtLinkForgotPass";
            this.txtLinkForgotPass.Size = new System.Drawing.Size(97, 15);
            this.txtLinkForgotPass.TabIndex = 7;
            this.txtLinkForgotPass.TabStop = true;
            this.txtLinkForgotPass.Text = "Quên mật khẩu ?";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(278, 158);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 38);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(lbErrorLogin);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtBoxPass);
            this.groupBox1.Controls.Add(this.txtBoxEmail);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbEmail);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(402, 207);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng nhập";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLinkForgotPass);
            this.Controls.Add(this.txtLinkRegister);
            this.Name = "Form1";
            this.Text = "Đăng nhập vào chương trình chính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.TextBox txtBoxPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel txtLinkRegister;
        private System.Windows.Forms.LinkLabel txtLinkForgotPass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbErrorLogin;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

