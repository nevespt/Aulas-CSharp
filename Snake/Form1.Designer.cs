namespace Snake
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg = new System.Windows.Forms.DataGridView();
            this.BtnClose1 = new System.Windows.Forms.PictureBox();
            this.BtnClose1Hover = new System.Windows.Forms.PictureBox();
            this.BtnClose1Normal = new System.Windows.Forms.PictureBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.lblGameOverScore = new System.Windows.Forms.Label();
            this.lblGameOverScore2 = new System.Windows.Forms.Label();
            this.lblGameOverPress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose1Hover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose1Normal)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Location = new System.Drawing.Point(12, 109);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(432, 424);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pontuação: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblScore.Location = new System.Drawing.Point(172, 75);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(32, 33);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "0";
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblGameOver.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.Location = new System.Drawing.Point(58, 255);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(323, 55);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "Fim do Jogo!";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            this.lblGameOver.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.dg);
            this.panel1.Controls.Add(this.BtnClose1);
            this.panel1.Location = new System.Drawing.Point(578, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 553);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dg
            // 
            this.dg.AllowUserToAddRows = false;
            this.dg.AllowUserToDeleteRows = false;
            this.dg.AllowUserToOrderColumns = true;
            this.dg.AllowUserToResizeColumns = false;
            this.dg.AllowUserToResizeRows = false;
            this.dg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dg.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dg.CausesValidation = false;
            this.dg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dg.DefaultCellStyle = dataGridViewCellStyle1;
            this.dg.Enabled = false;
            this.dg.EnableHeadersVisualStyles = false;
            this.dg.Location = new System.Drawing.Point(13, 112);
            this.dg.Name = "dg";
            this.dg.ReadOnly = true;
            this.dg.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dg.Size = new System.Drawing.Size(281, 424);
            this.dg.TabIndex = 6;
            // 
            // BtnClose1
            // 
            this.BtnClose1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose1.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose1.Image")));
            this.BtnClose1.Location = new System.Drawing.Point(246, 15);
            this.BtnClose1.Name = "BtnClose1";
            this.BtnClose1.Size = new System.Drawing.Size(48, 48);
            this.BtnClose1.TabIndex = 5;
            this.BtnClose1.TabStop = false;
            this.BtnClose1.Click += new System.EventHandler(this.BtnClose1_Click);
            this.BtnClose1.MouseLeave += new System.EventHandler(this.BtnClos1e_MouseLeave);
            this.BtnClose1.MouseHover += new System.EventHandler(this.BtnClose1_MouseHover);
            // 
            // BtnClose1Hover
            // 
            this.BtnClose1Hover.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose1Hover.Image")));
            this.BtnClose1Hover.Location = new System.Drawing.Point(522, 523);
            this.BtnClose1Hover.Name = "BtnClose1Hover";
            this.BtnClose1Hover.Size = new System.Drawing.Size(10, 10);
            this.BtnClose1Hover.TabIndex = 10;
            this.BtnClose1Hover.TabStop = false;
            this.BtnClose1Hover.Visible = false;
            // 
            // BtnClose1Normal
            // 
            this.BtnClose1Normal.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose1Normal.Image")));
            this.BtnClose1Normal.Location = new System.Drawing.Point(538, 523);
            this.BtnClose1Normal.Name = "BtnClose1Normal";
            this.BtnClose1Normal.Size = new System.Drawing.Size(10, 10);
            this.BtnClose1Normal.TabIndex = 9;
            this.BtnClose1Normal.TabStop = false;
            this.BtnClose1Normal.Visible = false;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernamelabel.Location = new System.Drawing.Point(5, 12);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(193, 40);
            this.usernamelabel.TabIndex = 11;
            this.usernamelabel.Text = "Username";
            // 
            // lblGameOverScore
            // 
            this.lblGameOverScore.AutoSize = true;
            this.lblGameOverScore.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblGameOverScore.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverScore.Location = new System.Drawing.Point(82, 325);
            this.lblGameOverScore.Name = "lblGameOverScore";
            this.lblGameOverScore.Size = new System.Drawing.Size(265, 37);
            this.lblGameOverScore.TabIndex = 3;
            this.lblGameOverScore.Text = "Pontuação Final";
            this.lblGameOverScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOverScore.Visible = false;
            this.lblGameOverScore.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // lblGameOverScore2
            // 
            this.lblGameOverScore2.AutoSize = true;
            this.lblGameOverScore2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblGameOverScore2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverScore2.ForeColor = System.Drawing.Color.Crimson;
            this.lblGameOverScore2.Location = new System.Drawing.Point(142, 362);
            this.lblGameOverScore2.Name = "lblGameOverScore2";
            this.lblGameOverScore2.Size = new System.Drawing.Size(150, 37);
            this.lblGameOverScore2.TabIndex = 3;
            this.lblGameOverScore2.Text = "0000000";
            this.lblGameOverScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOverScore2.Visible = false;
            this.lblGameOverScore2.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // lblGameOverPress
            // 
            this.lblGameOverPress.AutoSize = true;
            this.lblGameOverPress.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblGameOverPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverPress.Location = new System.Drawing.Point(41, 480);
            this.lblGameOverPress.Name = "lblGameOverPress";
            this.lblGameOverPress.Size = new System.Drawing.Size(351, 37);
            this.lblGameOverPress.TabIndex = 3;
            this.lblGameOverPress.Text = "Press Enter to try again";
            this.lblGameOverPress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOverPress.Visible = false;
            this.lblGameOverPress.Click += new System.EventHandler(this.lblGameOver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 545);
            this.Controls.Add(this.usernamelabel);
            this.Controls.Add(this.BtnClose1Hover);
            this.Controls.Add(this.BtnClose1Normal);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblGameOverPress);
            this.Controls.Add(this.lblGameOverScore2);
            this.Controls.Add(this.lblGameOverScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose1Hover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose1Normal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox BtnClose1;
        private System.Windows.Forms.PictureBox BtnClose1Hover;
        private System.Windows.Forms.PictureBox BtnClose1Normal;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label lblGameOverScore;
        private System.Windows.Forms.Label lblGameOverScore2;
        private System.Windows.Forms.Label lblGameOverPress;
        private System.Windows.Forms.DataGridView dg;
    }
}

