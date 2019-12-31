namespace Snake
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.Devs = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            this.BtnCloseHover = new System.Windows.Forms.PictureBox();
            this.BtnCloseNonHover = new System.Windows.Forms.PictureBox();
            this.BtnNick = new System.Windows.Forms.PictureBox();
            this.BtnNickEnable = new System.Windows.Forms.PictureBox();
            this.BtnNickHover = new System.Windows.Forms.PictureBox();
            this.BtnNickNormal = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseNonHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNick)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNickEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNickHover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNickNormal)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(314, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insira o seu Nickname";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamebox
            // 
            this.usernamebox.BackColor = System.Drawing.Color.Gray;
            this.usernamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamebox.Location = new System.Drawing.Point(319, 255);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(222, 38);
            this.usernamebox.TabIndex = 1;
            this.usernamebox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Devs
            // 
            this.Devs.AutoSize = true;
            this.Devs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Devs.ForeColor = System.Drawing.Color.Cyan;
            this.Devs.Location = new System.Drawing.Point(645, 520);
            this.Devs.Name = "Devs";
            this.Devs.Size = new System.Drawing.Size(227, 16);
            this.Devs.TabIndex = 2;
            this.Devs.Text = "Ruben Ribeiro • Paulo Cardoso";
            this.Devs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnClose
            // 
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.Location = new System.Drawing.Point(824, 12);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(48, 48);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            this.BtnClose.MouseLeave += new System.EventHandler(this.BtnClose_MouseLeave);
            this.BtnClose.MouseHover += new System.EventHandler(this.BtnClose_MouseHover);
            // 
            // BtnCloseHover
            // 
            this.BtnCloseHover.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseHover.Image")));
            this.BtnCloseHover.Location = new System.Drawing.Point(12, 12);
            this.BtnCloseHover.Name = "BtnCloseHover";
            this.BtnCloseHover.Size = new System.Drawing.Size(1, 1);
            this.BtnCloseHover.TabIndex = 4;
            this.BtnCloseHover.TabStop = false;
            this.BtnCloseHover.Visible = false;
            // 
            // BtnCloseNonHover
            // 
            this.BtnCloseNonHover.Image = ((System.Drawing.Image)(resources.GetObject("BtnCloseNonHover.Image")));
            this.BtnCloseNonHover.Location = new System.Drawing.Point(12, 437);
            this.BtnCloseNonHover.Name = "BtnCloseNonHover";
            this.BtnCloseNonHover.Size = new System.Drawing.Size(1, 1);
            this.BtnCloseNonHover.TabIndex = 5;
            this.BtnCloseNonHover.TabStop = false;
            this.BtnCloseNonHover.Visible = false;
            // 
            // BtnNick
            // 
            this.BtnNick.Image = ((System.Drawing.Image)(resources.GetObject("BtnNick.Image")));
            this.BtnNick.Location = new System.Drawing.Point(547, 255);
            this.BtnNick.Name = "BtnNick";
            this.BtnNick.Size = new System.Drawing.Size(38, 38);
            this.BtnNick.TabIndex = 6;
            this.BtnNick.TabStop = false;
            this.BtnNick.Click += new System.EventHandler(this.BtnNick_Click);
            this.BtnNick.MouseLeave += new System.EventHandler(this.BtnNick_MouseLeave);
            this.BtnNick.MouseHover += new System.EventHandler(this.BtnNick_Hover);
            // 
            // BtnNickEnable
            // 
            this.BtnNickEnable.Image = ((System.Drawing.Image)(resources.GetObject("BtnNickEnable.Image")));
            this.BtnNickEnable.Location = new System.Drawing.Point(439, 523);
            this.BtnNickEnable.Name = "BtnNickEnable";
            this.BtnNickEnable.Size = new System.Drawing.Size(10, 10);
            this.BtnNickEnable.TabIndex = 7;
            this.BtnNickEnable.TabStop = false;
            this.BtnNickEnable.Visible = false;
            // 
            // BtnNickHover
            // 
            this.BtnNickHover.Image = ((System.Drawing.Image)(resources.GetObject("BtnNickHover.Image")));
            this.BtnNickHover.Location = new System.Drawing.Point(455, 523);
            this.BtnNickHover.Name = "BtnNickHover";
            this.BtnNickHover.Size = new System.Drawing.Size(10, 10);
            this.BtnNickHover.TabIndex = 7;
            this.BtnNickHover.TabStop = false;
            this.BtnNickHover.Visible = false;
            // 
            // BtnNickNormal
            // 
            this.BtnNickNormal.Image = ((System.Drawing.Image)(resources.GetObject("BtnNickNormal.Image")));
            this.BtnNickNormal.Location = new System.Drawing.Point(423, 523);
            this.BtnNickNormal.Name = "BtnNickNormal";
            this.BtnNickNormal.Size = new System.Drawing.Size(10, 10);
            this.BtnNickNormal.TabIndex = 8;
            this.BtnNickNormal.TabStop = false;
            this.BtnNickNormal.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "v2.1.2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(884, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnNickNormal);
            this.Controls.Add(this.BtnNickHover);
            this.Controls.Add(this.BtnNickEnable);
            this.Controls.Add(this.BtnNick);
            this.Controls.Add(this.BtnCloseNonHover);
            this.Controls.Add(this.BtnCloseHover);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.Devs);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCloseNonHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNick)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNickEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNickHover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNickNormal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.Label Devs;
        private System.Windows.Forms.PictureBox BtnClose;
        private System.Windows.Forms.PictureBox BtnCloseHover;
        private System.Windows.Forms.PictureBox BtnCloseNonHover;
        private System.Windows.Forms.PictureBox BtnNick;
        private System.Windows.Forms.PictureBox BtnNickEnable;
        private System.Windows.Forms.PictureBox BtnNickHover;
        private System.Windows.Forms.PictureBox BtnNickNormal;
        private System.Windows.Forms.Label label2;
    }
}