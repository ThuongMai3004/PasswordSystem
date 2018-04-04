namespace PasswordSystem
{
    partial class GenerateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateForm));
            this.titleLb = new System.Windows.Forms.Label();
            this.userTitle = new System.Windows.Forms.Label();
            this.passwordInfoLb = new System.Windows.Forms.Label();
            this.practiceBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.hintBtn = new System.Windows.Forms.Button();
            this.acceptBtn = new System.Windows.Forms.Button();
            this.seperatorLb = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.userLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // titleLb
            // 
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(-1, 26);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(494, 33);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "Team 48 Password Scheme";
            this.titleLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userTitle
            // 
            this.userTitle.AutoSize = true;
            this.userTitle.BackColor = System.Drawing.Color.Transparent;
            this.userTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTitle.Location = new System.Drawing.Point(2, 76);
            this.userTitle.Name = "userTitle";
            this.userTitle.Size = new System.Drawing.Size(47, 20);
            this.userTitle.TabIndex = 1;
            this.userTitle.Text = "User:";
            // 
            // passwordInfoLb
            // 
            this.passwordInfoLb.AutoSize = true;
            this.passwordInfoLb.BackColor = System.Drawing.Color.Transparent;
            this.passwordInfoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordInfoLb.Location = new System.Drawing.Point(2, 111);
            this.passwordInfoLb.Name = "passwordInfoLb";
            this.passwordInfoLb.Size = new System.Drawing.Size(221, 20);
            this.passwordInfoLb.TabIndex = 3;
            this.passwordInfoLb.Text = "Password generated for user: ";
            // 
            // practiceBtn
            // 
            this.practiceBtn.Location = new System.Drawing.Point(401, 163);
            this.practiceBtn.Name = "practiceBtn";
            this.practiceBtn.Size = new System.Drawing.Size(75, 23);
            this.practiceBtn.TabIndex = 4;
            this.practiceBtn.Text = "Practice";
            this.practiceBtn.UseVisualStyleBackColor = true;
            this.practiceBtn.Click += new System.EventHandler(this.practiceBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(18, 163);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(103, 23);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh Password";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // hintBtn
            // 
            this.hintBtn.Location = new System.Drawing.Point(423, 108);
            this.hintBtn.Name = "hintBtn";
            this.hintBtn.Size = new System.Drawing.Size(56, 23);
            this.hintBtn.TabIndex = 6;
            this.hintBtn.Text = "Hint";
            this.hintBtn.UseVisualStyleBackColor = true;
            this.hintBtn.Click += new System.EventHandler(this.hintBtn_Click);
            // 
            // acceptBtn
            // 
            this.acceptBtn.Location = new System.Drawing.Point(202, 163);
            this.acceptBtn.Name = "acceptBtn";
            this.acceptBtn.Size = new System.Drawing.Size(103, 23);
            this.acceptBtn.TabIndex = 8;
            this.acceptBtn.Text = "Accept Password";
            this.acceptBtn.UseVisualStyleBackColor = true;
            this.acceptBtn.Click += new System.EventHandler(this.acceptBtn_Click);
            // 
            // seperatorLb
            // 
            this.seperatorLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperatorLb.Location = new System.Drawing.Point(-1, 59);
            this.seperatorLb.Name = "seperatorLb";
            this.seperatorLb.Size = new System.Drawing.Size(494, 2);
            this.seperatorLb.TabIndex = 9;
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.BackColor = System.Drawing.SystemColors.Info;
            this.passwordTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxtBox.Location = new System.Drawing.Point(229, 105);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.ReadOnly = true;
            this.passwordTxtBox.Size = new System.Drawing.Size(159, 29);
            this.passwordTxtBox.TabIndex = 10;
            this.passwordTxtBox.Text = "!@m@m@z!ng03";
            this.passwordTxtBox.WordWrap = false;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.BackColor = System.Drawing.Color.Transparent;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.Location = new System.Drawing.Point(46, 76);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(60, 20);
            this.userLb.TabIndex = 11;
            this.userLb.Text = "svp001";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-2, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 2);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(-2, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 2);
            this.label2.TabIndex = 14;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayLogToolStripMenuItem,
            this.displayAccountsToolStripMenuItem,
            this.resetToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // displayLogToolStripMenuItem
            // 
            this.displayLogToolStripMenuItem.Name = "displayLogToolStripMenuItem";
            this.displayLogToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.displayLogToolStripMenuItem.Text = "Display Log";
            this.displayLogToolStripMenuItem.Click += new System.EventHandler(this.displayLogToolStripMenuItem_Click);
            // 
            // displayAccountsToolStripMenuItem
            // 
            this.displayAccountsToolStripMenuItem.Name = "displayAccountsToolStripMenuItem";
            this.displayAccountsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.displayAccountsToolStripMenuItem.Text = "Display accounts";
            this.displayAccountsToolStripMenuItem.Click += new System.EventHandler(this.displayAccountsToolStripMenuItem_Click);
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.resetToolStripMenuItem.Text = "Reset ";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(491, 24);
            this.menuStrip.TabIndex = 13;
            this.menuStrip.Text = "menuStrip1";
            // 
            // GenerateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(491, 195);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.passwordTxtBox);
            this.Controls.Add(this.seperatorLb);
            this.Controls.Add(this.acceptBtn);
            this.Controls.Add(this.hintBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.practiceBtn);
            this.Controls.Add(this.passwordInfoLb);
            this.Controls.Add(this.userTitle);
            this.Controls.Add(this.titleLb);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "GenerateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generating Password Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label userTitle;
        private System.Windows.Forms.Label passwordInfoLb;
        private System.Windows.Forms.Button practiceBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button hintBtn;
        private System.Windows.Forms.Button acceptBtn;
        private System.Windows.Forms.Label seperatorLb;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

