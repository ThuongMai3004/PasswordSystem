namespace PasswordSystem
{
    partial class LoginManyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginManyForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userTitleLb = new System.Windows.Forms.Label();
            this.userLb = new System.Windows.Forms.Label();
            this.EmailGroupBox = new System.Windows.Forms.GroupBox();
            this.statusEmailLb = new System.Windows.Forms.Label();
            this.loginEmailBtn = new System.Windows.Forms.Button();
            this.BankGroupBox = new System.Windows.Forms.GroupBox();
            this.statusBankLb = new System.Windows.Forms.Label();
            this.loginBankBtn = new System.Windows.Forms.Button();
            this.ShopGroupBox = new System.Windows.Forms.GroupBox();
            this.statusShopLb = new System.Windows.Forms.Label();
            this.loginShopBtn = new System.Windows.Forms.Button();
            this.EmailGroupBox.SuspendLayout();
            this.BankGroupBox.SuspendLayout();
            this.ShopGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(470, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN FORM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(472, 2);
            this.label2.TabIndex = 1;
            // 
            // userTitleLb
            // 
            this.userTitleLb.AutoSize = true;
            this.userTitleLb.BackColor = System.Drawing.Color.Transparent;
            this.userTitleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitleLb.Location = new System.Drawing.Point(12, 45);
            this.userTitleLb.Name = "userTitleLb";
            this.userTitleLb.Size = new System.Drawing.Size(47, 20);
            this.userTitleLb.TabIndex = 2;
            this.userTitleLb.Text = "User:";
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.BackColor = System.Drawing.Color.Transparent;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.Location = new System.Drawing.Point(58, 45);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(69, 20);
            this.userLb.TabIndex = 3;
            this.userLb.Text = "svp1111";
            // 
            // EmailGroupBox
            // 
            this.EmailGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.EmailGroupBox.Controls.Add(this.statusEmailLb);
            this.EmailGroupBox.Controls.Add(this.loginEmailBtn);
            this.EmailGroupBox.ForeColor = System.Drawing.Color.NavajoWhite;
            this.EmailGroupBox.Location = new System.Drawing.Point(16, 220);
            this.EmailGroupBox.Name = "EmailGroupBox";
            this.EmailGroupBox.Size = new System.Drawing.Size(441, 65);
            this.EmailGroupBox.TabIndex = 4;
            this.EmailGroupBox.TabStop = false;
            this.EmailGroupBox.Text = "Login to Email Account";
            // 
            // statusEmailLb
            // 
            this.statusEmailLb.AutoSize = true;
            this.statusEmailLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusEmailLb.Location = new System.Drawing.Point(170, 23);
            this.statusEmailLb.Name = "statusEmailLb";
            this.statusEmailLb.Size = new System.Drawing.Size(97, 20);
            this.statusEmailLb.TabIndex = 12;
            this.statusEmailLb.Text = "(3 Attempts)";
            // 
            // loginEmailBtn
            // 
            this.loginEmailBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginEmailBtn.Location = new System.Drawing.Point(16, 19);
            this.loginEmailBtn.Name = "loginEmailBtn";
            this.loginEmailBtn.Size = new System.Drawing.Size(135, 31);
            this.loginEmailBtn.TabIndex = 7;
            this.loginEmailBtn.Text = "Login";
            this.loginEmailBtn.UseVisualStyleBackColor = true;
            this.loginEmailBtn.Click += new System.EventHandler(this.loginEmailBtn_Click);
            // 
            // BankGroupBox
            // 
            this.BankGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.BankGroupBox.Controls.Add(this.statusBankLb);
            this.BankGroupBox.Controls.Add(this.loginBankBtn);
            this.BankGroupBox.ForeColor = System.Drawing.Color.NavajoWhite;
            this.BankGroupBox.Location = new System.Drawing.Point(16, 149);
            this.BankGroupBox.Name = "BankGroupBox";
            this.BankGroupBox.Size = new System.Drawing.Size(441, 65);
            this.BankGroupBox.TabIndex = 5;
            this.BankGroupBox.TabStop = false;
            this.BankGroupBox.Text = "Login to Banking Account";
            // 
            // statusBankLb
            // 
            this.statusBankLb.AutoSize = true;
            this.statusBankLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusBankLb.Location = new System.Drawing.Point(170, 23);
            this.statusBankLb.Name = "statusBankLb";
            this.statusBankLb.Size = new System.Drawing.Size(97, 20);
            this.statusBankLb.TabIndex = 11;
            this.statusBankLb.Text = "(3 Attempts)";
            // 
            // loginBankBtn
            // 
            this.loginBankBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginBankBtn.Location = new System.Drawing.Point(16, 19);
            this.loginBankBtn.Name = "loginBankBtn";
            this.loginBankBtn.Size = new System.Drawing.Size(135, 31);
            this.loginBankBtn.TabIndex = 8;
            this.loginBankBtn.Text = "Login";
            this.loginBankBtn.UseVisualStyleBackColor = true;
            this.loginBankBtn.Click += new System.EventHandler(this.loginBankBtn_Click);
            // 
            // ShopGroupBox
            // 
            this.ShopGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ShopGroupBox.Controls.Add(this.statusShopLb);
            this.ShopGroupBox.Controls.Add(this.loginShopBtn);
            this.ShopGroupBox.ForeColor = System.Drawing.Color.NavajoWhite;
            this.ShopGroupBox.Location = new System.Drawing.Point(16, 78);
            this.ShopGroupBox.Name = "ShopGroupBox";
            this.ShopGroupBox.Size = new System.Drawing.Size(441, 65);
            this.ShopGroupBox.TabIndex = 6;
            this.ShopGroupBox.TabStop = false;
            this.ShopGroupBox.Text = "Login to Shopping Account";
            // 
            // statusShopLb
            // 
            this.statusShopLb.AutoSize = true;
            this.statusShopLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusShopLb.Location = new System.Drawing.Point(170, 26);
            this.statusShopLb.Name = "statusShopLb";
            this.statusShopLb.Size = new System.Drawing.Size(97, 20);
            this.statusShopLb.TabIndex = 10;
            this.statusShopLb.Text = "(3 Attempts)";
            // 
            // loginShopBtn
            // 
            this.loginShopBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginShopBtn.Location = new System.Drawing.Point(16, 22);
            this.loginShopBtn.Name = "loginShopBtn";
            this.loginShopBtn.Size = new System.Drawing.Size(135, 31);
            this.loginShopBtn.TabIndex = 9;
            this.loginShopBtn.Text = "Login";
            this.loginShopBtn.UseVisualStyleBackColor = true;
            this.loginShopBtn.Click += new System.EventHandler(this.loginShopBtn_Click);
            // 
            // LoginManyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(469, 291);
            this.Controls.Add(this.ShopGroupBox);
            this.Controls.Add(this.BankGroupBox);
            this.Controls.Add(this.EmailGroupBox);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.userTitleLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginManyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginManyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginManyForm_FormClosing);
            this.EmailGroupBox.ResumeLayout(false);
            this.EmailGroupBox.PerformLayout();
            this.BankGroupBox.ResumeLayout(false);
            this.BankGroupBox.PerformLayout();
            this.ShopGroupBox.ResumeLayout(false);
            this.ShopGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userTitleLb;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.GroupBox EmailGroupBox;
        private System.Windows.Forms.GroupBox BankGroupBox;
        private System.Windows.Forms.GroupBox ShopGroupBox;
        private System.Windows.Forms.Button loginEmailBtn;
        private System.Windows.Forms.Button loginBankBtn;
        private System.Windows.Forms.Button loginShopBtn;
        private System.Windows.Forms.Label statusEmailLb;
        private System.Windows.Forms.Label statusBankLb;
        private System.Windows.Forms.Label statusShopLb;
    }
}