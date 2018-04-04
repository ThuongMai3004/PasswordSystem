namespace PasswordSystem
{
    partial class MenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuForm));
            this.TitleMenuLb = new System.Windows.Forms.Label();
            this.createPasswordBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.createMassBtn = new System.Windows.Forms.Button();
            this.loginMassBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBankingAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayShoppingAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleMenuLb
            // 
            this.TitleMenuLb.BackColor = System.Drawing.Color.Transparent;
            this.TitleMenuLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleMenuLb.Location = new System.Drawing.Point(0, 24);
            this.TitleMenuLb.Name = "TitleMenuLb";
            this.TitleMenuLb.Size = new System.Drawing.Size(336, 23);
            this.TitleMenuLb.TabIndex = 0;
            this.TitleMenuLb.Text = "TEAM 48 PASSWORD SCHEME";
            this.TitleMenuLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createPasswordBtn
            // 
            this.createPasswordBtn.Location = new System.Drawing.Point(6, 19);
            this.createPasswordBtn.Name = "createPasswordBtn";
            this.createPasswordBtn.Size = new System.Drawing.Size(112, 23);
            this.createPasswordBtn.TabIndex = 1;
            this.createPasswordBtn.Text = "Create password";
            this.createPasswordBtn.UseVisualStyleBackColor = true;
            this.createPasswordBtn.Click += new System.EventHandler(this.createPasswordBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(6, 58);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(112, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.createPasswordBtn);
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 90);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Part 2";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.createMassBtn);
            this.groupBox2.Controls.Add(this.loginMassBtn);
            this.groupBox2.Location = new System.Drawing.Point(179, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(145, 90);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Part 3";
            // 
            // createMassBtn
            // 
            this.createMassBtn.Location = new System.Drawing.Point(20, 19);
            this.createMassBtn.Name = "createMassBtn";
            this.createMassBtn.Size = new System.Drawing.Size(112, 23);
            this.createMassBtn.TabIndex = 1;
            this.createMassBtn.Text = "Create Password";
            this.createMassBtn.UseVisualStyleBackColor = true;
            this.createMassBtn.Click += new System.EventHandler(this.createMassBtn_Click);
            // 
            // loginMassBtn
            // 
            this.loginMassBtn.Location = new System.Drawing.Point(20, 58);
            this.loginMassBtn.Name = "loginMassBtn";
            this.loginMassBtn.Size = new System.Drawing.Size(112, 23);
            this.loginMassBtn.TabIndex = 2;
            this.loginMassBtn.Text = "Login";
            this.loginMassBtn.UseVisualStyleBackColor = true;
            this.loginMassBtn.Click += new System.EventHandler(this.loginMassBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayLogToolStripMenuItem,
            this.displayAccountsToolStripMenuItem,
            this.displayBankingAccountsToolStripMenuItem,
            this.displayShoppingAccountsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // displayLogToolStripMenuItem
            // 
            this.displayLogToolStripMenuItem.Name = "displayLogToolStripMenuItem";
            this.displayLogToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.displayLogToolStripMenuItem.Text = "Display Log";
            this.displayLogToolStripMenuItem.Click += new System.EventHandler(this.displayLogToolStripMenuItem_Click);
            // 
            // displayAccountsToolStripMenuItem
            // 
            this.displayAccountsToolStripMenuItem.Name = "displayAccountsToolStripMenuItem";
            this.displayAccountsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.displayAccountsToolStripMenuItem.Text = "Display Accounts/Email";
            this.displayAccountsToolStripMenuItem.Click += new System.EventHandler(this.displayAccountsToolStripMenuItem_Click);
            // 
            // displayBankingAccountsToolStripMenuItem
            // 
            this.displayBankingAccountsToolStripMenuItem.Name = "displayBankingAccountsToolStripMenuItem";
            this.displayBankingAccountsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.displayBankingAccountsToolStripMenuItem.Text = "Display Banking Accounts";
            this.displayBankingAccountsToolStripMenuItem.Click += new System.EventHandler(this.displayBankingAccountsToolStripMenuItem_Click);
            // 
            // displayShoppingAccountsToolStripMenuItem
            // 
            this.displayShoppingAccountsToolStripMenuItem.Name = "displayShoppingAccountsToolStripMenuItem";
            this.displayShoppingAccountsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.displayShoppingAccountsToolStripMenuItem.Text = "Display Shopping Accounts";
            this.displayShoppingAccountsToolStripMenuItem.Click += new System.EventHandler(this.displayShoppingAccountsToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(336, 159);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TitleMenuLb);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleMenuLb;
        private System.Windows.Forms.Button createPasswordBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createMassBtn;
        private System.Windows.Forms.Button loginMassBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBankingAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayShoppingAccountsToolStripMenuItem;
    }
}