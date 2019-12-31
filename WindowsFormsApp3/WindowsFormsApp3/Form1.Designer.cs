namespace WindowsFormsApp3
{
    partial class Exercicio01
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio01));
            this.btn_1 = new System.Windows.Forms.Button();
            this.btn_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pic_dia = new System.Windows.Forms.PictureBox();
            this.pic_tarde = new System.Windows.Forms.PictureBox();
            this.pic_noite = new System.Windows.Forms.PictureBox();
            this.pic_grande = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbSecond = new System.Windows.Forms.ProgressBar();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_dia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tarde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_noite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_grande)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.BackColor = System.Drawing.Color.Black;
            this.btn_1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_1.ForeColor = System.Drawing.Color.White;
            this.btn_1.Location = new System.Drawing.Point(70, 12);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(75, 23);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "Bom Dia";
            this.btn_1.UseVisualStyleBackColor = false;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            this.btn_1.MouseLeave += new System.EventHandler(this.btn_1_MouseOut);
            this.btn_1.MouseHover += new System.EventHandler(this.btn_1_MouseHover);
            // 
            // btn_2
            // 
            this.btn_2.BackColor = System.Drawing.Color.Black;
            this.btn_2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btn_2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_2.ForeColor = System.Drawing.Color.White;
            this.btn_2.Location = new System.Drawing.Point(151, 12);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(75, 23);
            this.btn_2.TabIndex = 1;
            this.btn_2.Text = "Boa Tarde";
            this.btn_2.UseVisualStyleBackColor = false;
            this.btn_2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_3
            // 
            this.btn_3.BackColor = System.Drawing.Color.Black;
            this.btn_3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkBlue;
            this.btn_3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_3.ForeColor = System.Drawing.Color.White;
            this.btn_3.Location = new System.Drawing.Point(232, 12);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(75, 23);
            this.btn_3.TabIndex = 2;
            this.btn_3.Text = "Boa Noite";
            this.btn_3.UseVisualStyleBackColor = false;
            this.btn_3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = " ";
            // 
            // pic_dia
            // 
            this.pic_dia.Image = ((System.Drawing.Image)(resources.GetObject("pic_dia.Image")));
            this.pic_dia.Location = new System.Drawing.Point(90, 287);
            this.pic_dia.Name = "pic_dia";
            this.pic_dia.Size = new System.Drawing.Size(144, 144);
            this.pic_dia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_dia.TabIndex = 4;
            this.pic_dia.TabStop = false;
            this.pic_dia.MouseLeave += new System.EventHandler(this.pic_dia_MouseLeave);
            this.pic_dia.MouseHover += new System.EventHandler(this.pic_dia_MouseHover);
            // 
            // pic_tarde
            // 
            this.pic_tarde.Image = ((System.Drawing.Image)(resources.GetObject("pic_tarde.Image")));
            this.pic_tarde.Location = new System.Drawing.Point(386, 287);
            this.pic_tarde.Name = "pic_tarde";
            this.pic_tarde.Size = new System.Drawing.Size(144, 144);
            this.pic_tarde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_tarde.TabIndex = 5;
            this.pic_tarde.TabStop = false;
            this.pic_tarde.MouseLeave += new System.EventHandler(this.pic_tarde_MouseLeave);
            this.pic_tarde.MouseHover += new System.EventHandler(this.pic_tarde_MouseHover);
            // 
            // pic_noite
            // 
            this.pic_noite.Image = ((System.Drawing.Image)(resources.GetObject("pic_noite.Image")));
            this.pic_noite.Location = new System.Drawing.Point(682, 287);
            this.pic_noite.Name = "pic_noite";
            this.pic_noite.Size = new System.Drawing.Size(144, 144);
            this.pic_noite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pic_noite.TabIndex = 6;
            this.pic_noite.TabStop = false;
            this.pic_noite.Click += new System.EventHandler(this.pic_noite_Click);
            this.pic_noite.MouseLeave += new System.EventHandler(this.pic_noite_MouseLeave);
            this.pic_noite.MouseHover += new System.EventHandler(this.pic_noite_MouseHover);
            // 
            // pic_grande
            // 
            this.pic_grande.BackColor = System.Drawing.Color.Gray;
            this.pic_grande.Location = new System.Drawing.Point(70, 157);
            this.pic_grande.Name = "pic_grande";
            this.pic_grande.Size = new System.Drawing.Size(776, 83);
            this.pic_grande.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_grande.TabIndex = 7;
            this.pic_grande.TabStop = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.Red;
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(823, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 8;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = false;
            this.Close.Visible = false;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 458);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pbSecond
            // 
            this.pbSecond.BackColor = System.Drawing.Color.White;
            this.pbSecond.ForeColor = System.Drawing.Color.Maroon;
            this.pbSecond.Location = new System.Drawing.Point(70, 239);
            this.pbSecond.Maximum = 59;
            this.pbSecond.Name = "pbSecond";
            this.pbSecond.Size = new System.Drawing.Size(776, 10);
            this.pbSecond.Step = 1;
            this.pbSecond.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pbSecond.TabIndex = 10;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.Color.White;
            this.lblHour.Location = new System.Drawing.Point(772, 253);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(24, 16);
            this.lblHour.TabIndex = 11;
            this.lblHour.Text = "00";
            this.lblHour.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHour.Click += new System.EventHandler(this.lblHour_Click);
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.Color.White;
            this.lblMinute.Location = new System.Drawing.Point(808, 253);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(24, 16);
            this.lblMinute.TabIndex = 12;
            this.lblMinute.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.Color.White;
            this.lblSecond.Location = new System.Drawing.Point(829, 257);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(17, 12);
            this.lblSecond.TabIndex = 13;
            this.lblSecond.Text = "00";
            this.lblSecond.Click += new System.EventHandler(this.lblSecond_Click);
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(72, 250);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(207, 22);
            this.lblDate.TabIndex = 14;
            this.lblDate.Text = "date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton6);
            this.groupBox1.Location = new System.Drawing.Point(680, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 42);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(61, 20);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(56, 17);
            this.radioButton4.TabIndex = 17;
            this.radioButton4.Text = "Yellow";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.Click += new System.EventHandler(this.radioButton4_Click);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.ForeColor = System.Drawing.Color.White;
            this.radioButton5.Location = new System.Drawing.Point(119, 20);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(45, 17);
            this.radioButton5.TabIndex = 16;
            this.radioButton5.Text = "Red";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.Click += new System.EventHandler(this.radioButton5_Click);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Checked = true;
            this.radioButton6.ForeColor = System.Drawing.Color.White;
            this.radioButton6.Location = new System.Drawing.Point(6, 20);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(54, 17);
            this.radioButton6.TabIndex = 15;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Green";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.Click += new System.EventHandler(this.radioButton6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(792, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "h";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(686, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Progress Bar";
            // 
            // Exercicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Controls.Add(this.pbSecond);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pic_grande);
            this.Controls.Add(this.pic_noite);
            this.Controls.Add(this.pic_tarde);
            this.Controls.Add(this.pic_dia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btn_2);
            this.Controls.Add(this.btn_1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Exercicio01";
            this.Text = "Exercicio 01";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_dia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tarde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_noite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_grande)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pic_dia;
        private System.Windows.Forms.PictureBox pic_tarde;
        private System.Windows.Forms.PictureBox pic_noite;
        private System.Windows.Forms.PictureBox pic_grande;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar pbSecond;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

