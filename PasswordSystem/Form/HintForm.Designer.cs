namespace PasswordSystem
{
    partial class HintForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HintForm));
            this.label1 = new System.Windows.Forms.Label();
            this.dayHintLb = new System.Windows.Forms.Label();
            this.keyLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.TabIndex = 0;
            this.label1.Text = "a -> @\r\nb -> 8\r\ni  -> !\r\ns -> $\r\no -> 0\r\nt -> +\r\n";
            // 
            // dayHintLb
            // 
            this.dayHintLb.BackColor = System.Drawing.Color.Transparent;
            this.dayHintLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayHintLb.Location = new System.Drawing.Point(8, 54);
            this.dayHintLb.Name = "dayHintLb";
            this.dayHintLb.Size = new System.Drawing.Size(100, 36);
            this.dayHintLb.TabIndex = 1;
            this.dayHintLb.Text = "16 -> Day";
            // 
            // keyLb
            // 
            this.keyLb.BackColor = System.Drawing.Color.Transparent;
            this.keyLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyLb.Location = new System.Drawing.Point(8, 15);
            this.keyLb.Name = "keyLb";
            this.keyLb.Size = new System.Drawing.Size(186, 39);
            this.keyLb.TabIndex = 2;
            this.keyLb.Text = "Key: iamamazing";
            // 
            // HintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(206, 91);
            this.Controls.Add(this.keyLb);
            this.Controls.Add(this.dayHintLb);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HintForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hint from programmers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HintForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label dayHintLb;
        private System.Windows.Forms.Label keyLb;
    }
}