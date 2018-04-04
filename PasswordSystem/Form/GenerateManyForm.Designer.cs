namespace PasswordSystem
{
    partial class GenerateManyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateManyForm));
            this.titleLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.userLb = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusEmailLb = new System.Windows.Forms.Label();
            this.createEmailPassBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.statusBankLb = new System.Windows.Forms.Label();
            this.createBankPassBtn = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusShopLb = new System.Windows.Forms.Label();
            this.createShopPassBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLb
            // 
            this.titleLb.BackColor = System.Drawing.Color.Transparent;
            this.titleLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLb.Location = new System.Drawing.Point(0, 3);
            this.titleLb.Name = "titleLb";
            this.titleLb.Size = new System.Drawing.Size(582, 36);
            this.titleLb.TabIndex = 0;
            this.titleLb.Text = "CREATING PASSWORD SCHEME";
            this.titleLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(0, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(582, 2);
            this.label2.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "User:";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(0, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(582, 2);
            this.label3.TabIndex = 18;
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.BackColor = System.Drawing.Color.Transparent;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.Location = new System.Drawing.Point(72, 50);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(86, 20);
            this.userLb.TabIndex = 19;
            this.userLb.Text = "svp11111";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.statusEmailLb);
            this.groupBox1.Controls.Add(this.createEmailPassBtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox1.Location = new System.Drawing.Point(16, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 69);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creating Password for Email";
            // 
            // statusEmailLb
            // 
            this.statusEmailLb.AutoSize = true;
            this.statusEmailLb.Location = new System.Drawing.Point(214, 32);
            this.statusEmailLb.Name = "statusEmailLb";
            this.statusEmailLb.Size = new System.Drawing.Size(194, 20);
            this.statusEmailLb.TabIndex = 23;
            this.statusEmailLb.Text = "Ready to create password";
            // 
            // createEmailPassBtn
            // 
            this.createEmailPassBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createEmailPassBtn.Location = new System.Drawing.Point(11, 25);
            this.createEmailPassBtn.Name = "createEmailPassBtn";
            this.createEmailPassBtn.Size = new System.Drawing.Size(172, 34);
            this.createEmailPassBtn.TabIndex = 21;
            this.createEmailPassBtn.Text = "Create password";
            this.createEmailPassBtn.UseVisualStyleBackColor = true;
            this.createEmailPassBtn.Click += new System.EventHandler(this.createEmailPassBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.statusBankLb);
            this.groupBox2.Controls.Add(this.createBankPassBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox2.Location = new System.Drawing.Point(16, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(553, 69);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Creating Password for Banking";
            // 
            // statusBankLb
            // 
            this.statusBankLb.AutoSize = true;
            this.statusBankLb.Location = new System.Drawing.Point(214, 32);
            this.statusBankLb.Name = "statusBankLb";
            this.statusBankLb.Size = new System.Drawing.Size(203, 20);
            this.statusBankLb.TabIndex = 24;
            this.statusBankLb.Text = "Please complete above first";
            // 
            // createBankPassBtn
            // 
            this.createBankPassBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createBankPassBtn.Location = new System.Drawing.Point(11, 25);
            this.createBankPassBtn.Name = "createBankPassBtn";
            this.createBankPassBtn.Size = new System.Drawing.Size(172, 34);
            this.createBankPassBtn.TabIndex = 21;
            this.createBankPassBtn.Text = "Create password";
            this.createBankPassBtn.UseVisualStyleBackColor = true;
            this.createBankPassBtn.Click += new System.EventHandler(this.createBankPassBtn_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.statusShopLb);
            this.groupBox3.Controls.Add(this.createShopPassBtn);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.NavajoWhite;
            this.groupBox3.Location = new System.Drawing.Point(16, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(553, 69);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Creating Password for Shopping";
            // 
            // statusShopLb
            // 
            this.statusShopLb.AutoSize = true;
            this.statusShopLb.ForeColor = System.Drawing.Color.NavajoWhite;
            this.statusShopLb.Location = new System.Drawing.Point(214, 32);
            this.statusShopLb.Name = "statusShopLb";
            this.statusShopLb.Size = new System.Drawing.Size(203, 20);
            this.statusShopLb.TabIndex = 25;
            this.statusShopLb.Text = "Please complete above first";
            // 
            // createShopPassBtn
            // 
            this.createShopPassBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createShopPassBtn.Location = new System.Drawing.Point(11, 25);
            this.createShopPassBtn.Name = "createShopPassBtn";
            this.createShopPassBtn.Size = new System.Drawing.Size(172, 34);
            this.createShopPassBtn.TabIndex = 21;
            this.createShopPassBtn.Text = "Create password";
            this.createShopPassBtn.UseVisualStyleBackColor = true;
            this.createShopPassBtn.Click += new System.EventHandler(this.createShopPassBtn_Click);
            // 
            // GenerateManyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(581, 317);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.userLb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.titleLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GenerateManyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateManyForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GenerateManyForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createEmailPassBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button createBankPassBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button createShopPassBtn;
        private System.Windows.Forms.Label statusEmailLb;
        private System.Windows.Forms.Label statusBankLb;
        private System.Windows.Forms.Label statusShopLb;
    }
}