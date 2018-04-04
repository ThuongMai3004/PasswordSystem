namespace PasswordSystem
{
    partial class PracticeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PracticeForm));
            this.userLb = new System.Windows.Forms.Label();
            this.practiceBox = new System.Windows.Forms.TextBox();
            this.checkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seperatorLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userLb
            // 
            this.userLb.AutoSize = true;
            this.userLb.BackColor = System.Drawing.Color.Transparent;
            this.userLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.Location = new System.Drawing.Point(12, 42);
            this.userLb.Name = "userLb";
            this.userLb.Size = new System.Drawing.Size(59, 24);
            this.userLb.TabIndex = 0;
            this.userLb.Text = "User: ";
            // 
            // practiceBox
            // 
            this.practiceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practiceBox.Location = new System.Drawing.Point(115, 74);
            this.practiceBox.Name = "practiceBox";
            this.practiceBox.Size = new System.Drawing.Size(134, 29);
            this.practiceBox.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.Location = new System.Drawing.Point(265, 74);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(75, 29);
            this.checkBtn.TabIndex = 2;
            this.checkBtn.Text = "CHECK";
            this.checkBtn.UseVisualStyleBackColor = true;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Practice your password below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // seperatorLb
            // 
            this.seperatorLb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.seperatorLb.Location = new System.Drawing.Point(-2, 36);
            this.seperatorLb.Name = "seperatorLb";
            this.seperatorLb.Size = new System.Drawing.Size(355, 2);
            this.seperatorLb.TabIndex = 10;
            // 
            // PracticeForm
            // 
            this.AcceptButton = this.checkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(352, 116);
            this.Controls.Add(this.seperatorLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.practiceBox);
            this.Controls.Add(this.userLb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PracticeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Practice Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PracticeForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userLb;
        private System.Windows.Forms.TextBox practiceBox;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label seperatorLb;
    }
}