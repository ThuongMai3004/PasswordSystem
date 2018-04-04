namespace PasswordSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.listUserBox = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.clearBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.userNameTitleLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.titleLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listUserBox
            // 
            this.listUserBox.FormattingEnabled = true;
            this.listUserBox.Location = new System.Drawing.Point(12, 68);
            this.listUserBox.Name = "listUserBox";
            this.listUserBox.Size = new System.Drawing.Size(120, 108);
            this.listUserBox.TabIndex = 0;
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(152, 153);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(131, 23);
            this.clearBtn.TabIndex = 1;
            this.clearBtn.Text = "Clear password";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(152, 69);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.Size = new System.Drawing.Size(131, 26);
            this.passwordTxtBox.TabIndex = 2;
            // 
            // userNameTitleLb
            // 
            this.userNameTitleLb.AutoSize = true;
            this.userNameTitleLb.BackColor = System.Drawing.Color.Transparent;
            this.userNameTitleLb.ForeColor = System.Drawing.Color.NavajoWhite;
            this.userNameTitleLb.Location = new System.Drawing.Point(12, 39);
            this.userNameTitleLb.Name = "userNameTitleLb";
            this.userNameTitleLb.Size = new System.Drawing.Size(109, 13);
            this.userNameTitleLb.TabIndex = 3;
            this.userNameTitleLb.Text = "Select your username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(149, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your password below";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(152, 112);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(131, 23);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // titleLb
            // 
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(1, 1);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(301, 26);
            this.titleLb.TabIndex = 6;
            this.titleLb.Text = "LOGIN FORM";
            this.titleLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-2, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 2);
            this.label1.TabIndex = 7;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(301, 186);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.userNameTitleLb);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.listUserBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginFormcs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listUserBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label userNameTitleLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label label1;
    }
}