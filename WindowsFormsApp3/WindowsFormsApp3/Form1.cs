using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApp3
{
    public partial class Exercicio01 : Form
    {
        public Exercicio01()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerClock.Interval = 1000; // one second
            timerClock.Enabled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            btn_3.FlatAppearance.BorderColor = Color.White;
            btn_3.FlatAppearance.BorderSize = 1;
            label1.Text = "Boa Noite!";
            label1.ForeColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 22f, FontStyle.Bold);
            pic_grande.Image = Image.FromFile("C:/Users/NevesPT/Pictures/pic33.png");
            ActiveForm.BackColor = System.Drawing.Color.DarkBlue;
            Close.Visible = true;


        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            btn_2.FlatAppearance.BorderColor = Color.White;
            btn_2.FlatAppearance.BorderSize = 1;
            label1.Text = "Bom Tarde!";
            label1.ForeColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 22f, FontStyle.Bold);
            pic_grande.Image = Image.FromFile("C:/Users/NevesPT/Pictures/pic22.png");
            ActiveForm.BackColor = System.Drawing.Color.LightBlue;
            Close.Visible = true;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_1.FlatAppearance.BorderColor = Color.White;
            btn_1.FlatAppearance.BorderSize = 1;
            label1.Text = "Bom Dia!";
            label1.ForeColor = Color.White;
            label1.Font = new Font("Microsoft Sans Serif", 22f, FontStyle.Bold);
            pic_grande.Image = Image.FromFile("C:/Users/NevesPT/Pictures/pic11.png");
            ActiveForm.BackColor = System.Drawing.Color.Orange;
            Close.Visible = true;



        }



        private void btn_1_MouseHover(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.White;
            btn_1.ForeColor = Color.Black;
            btn_1.FlatAppearance.BorderColor = Color.Orange;
            btn_1.FlatAppearance.BorderSize = 1;
        }


        private void btn_1_MouseOut(object sender, EventArgs e)
        {
            btn_1.BackColor = Color.Black;
            btn_1.ForeColor = Color.White;
            btn_1.FlatAppearance.BorderColor = Color.White;
            btn_1.FlatAppearance.BorderSize = 1;
        }




        private void pic_dia_MouseHover(object sender, EventArgs e)
        {

            button1_Click(sender, e);
            Close.Visible = false;

        }

        private void pic_tarde_MouseHover(object sender, EventArgs e)
        {
            button2_Click(sender, e);
            Close.Visible = false;

        }

        private void pic_noite_MouseHover(object sender, EventArgs e)
        {
            button3_Click(sender, e);
            Close.Visible = false;

        }

        private void pic_dia_MouseLeave(object sender, EventArgs e)
        {
            Close_Click(sender, e);

        }

        private void pic_tarde_MouseLeave(object sender, EventArgs e)
        {
            Close_Click(sender, e);

        }

        private void pic_noite_MouseLeave(object sender, EventArgs e)
        {
            Close_Click(sender, e);

        }

        private void pic_noite_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            pic_grande.Image = null;
            label1.Text = "";
            ActiveForm.BackColor = System.Drawing.Color.DimGray;
            Close.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timerClock_Tick(object sender, EventArgs e)
        {

            int h = DateTime.Now.Hour;
            pbSecond.Value = DateTime.Now.Second;
            lblHour.Text = h.ToString().PadLeft(2, '0'); ;
            lblMinute.Text = DateTime.Now.Minute.ToString().PadLeft(2, '0'); ;
            lblSecond.Text = DateTime.Now.Second.ToString().PadLeft(2, '0'); ;
            lblDate.Text = DateTime.Now.ToLongDateString();

            if (pbSecond.Value >= pbSecond.Maximum)
            {
                FlashWindow.Flash(this);
            }
            else
                {
                }

        }

        private void lblHour_Click(object sender, EventArgs e)
        {

        }



        private void radioButton6_Click(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(pbSecond, 1);
        }

        private void radioButton4_Click(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(pbSecond, 3);
        }

        private void radioButton5_Click(object sender, EventArgs e)
        {
            ModifyProgressBarColor.SetState(pbSecond, 2);
        }

        private void lblSecond_Click(object sender, EventArgs e)
        {

        }
    }
}