namespace Snake
{
    partial class A_enviar_Resultados
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
            this.labelsending = new System.Windows.Forms.Label();
            this.painelsending = new System.Windows.Forms.Panel();
            this.lblGameOverScore2 = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.painelsending.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelsending
            // 
            this.labelsending.AutoSize = true;
            this.labelsending.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsending.Location = new System.Drawing.Point(147, 247);
            this.labelsending.Name = "labelsending";
            this.labelsending.Size = new System.Drawing.Size(591, 55);
            this.labelsending.TabIndex = 0;
            this.labelsending.Text = "A enviar os resultados...";
            // 
            // painelsending
            // 
            this.painelsending.Controls.Add(this.lblGameOverScore2);
            this.painelsending.Controls.Add(this.usernamelabel);
            this.painelsending.Controls.Add(this.labelsending);
            this.painelsending.Location = new System.Drawing.Point(-14, -18);
            this.painelsending.Name = "painelsending";
            this.painelsending.Size = new System.Drawing.Size(912, 580);
            this.painelsending.TabIndex = 13;
            // 
            // lblGameOverScore2
            // 
            this.lblGameOverScore2.AutoSize = true;
            this.lblGameOverScore2.BackColor = System.Drawing.Color.Transparent;
            this.lblGameOverScore2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOverScore2.ForeColor = System.Drawing.Color.Crimson;
            this.lblGameOverScore2.Location = new System.Drawing.Point(351, 389);
            this.lblGameOverScore2.Name = "lblGameOverScore2";
            this.lblGameOverScore2.Size = new System.Drawing.Size(150, 37);
            this.lblGameOverScore2.TabIndex = 13;
            this.lblGameOverScore2.Text = "0000000";
            this.lblGameOverScore2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOverScore2.Visible = false;
            this.lblGameOverScore2.Click += new System.EventHandler(this.lblGameOverScore2_Click);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.usernamelabel.Location = new System.Drawing.Point(326, 349);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(193, 40);
            this.usernamelabel.TabIndex = 12;
            this.usernamelabel.Text = "Username";
            // 
            // A_enviar_Resultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 545);
            this.Controls.Add(this.painelsending);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "A_enviar_Resultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A_enviar_Resultados";
            this.painelsending.ResumeLayout(false);
            this.painelsending.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelsending;
        private System.Windows.Forms.Panel painelsending;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Label lblGameOverScore2;
    }
}