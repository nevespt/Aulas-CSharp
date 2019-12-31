using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_BG
{
    public partial class Form1 : Form
    {

        // Variaveis

        bool darkmode = true;





        //DarkMode & Button

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (darkmode == true)
            {
                darkmode = false;
                this.BackColor = Color.FromArgb(255, 255, 255);
                panel1.BackColor = Color.FromArgb(200, 200, 200);
                pictureBox4.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_toggle_off_white_24dpHover.png");
                
                // texto
                labeldarkmode.ForeColor = Color.Black;
                this.texto1.ForeColor = labeldarkmode.ForeColor;
                this.label1.ForeColor = labeldarkmode.ForeColor;
                this.label2.ForeColor = labeldarkmode.ForeColor;
                this.label3.ForeColor = labeldarkmode.ForeColor;
                this.label4.ForeColor = labeldarkmode.ForeColor; 
                this.label5.ForeColor = labeldarkmode.ForeColor;
                this.label6.ForeColor = labeldarkmode.ForeColor;
                this.label7.ForeColor = labeldarkmode.ForeColor;
                this.label9.ForeColor = labeldarkmode.ForeColor;
                this.label10.ForeColor = labeldarkmode.ForeColor;
                this.label11.ForeColor = labeldarkmode.ForeColor;


                this.Refresh();
            }
            else if (darkmode == false)
            {
                darkmode = true;
                this.BackColor = Color.FromArgb(37, 40, 48);
                panel1.BackColor = Color.FromArgb(17, 19, 23);
                pictureBox4.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_toggle_on_white_24dpHover.png");
                
                // texto
                labeldarkmode.ForeColor = Color.White;
                this.texto1.ForeColor = labeldarkmode.ForeColor;
                this.label1.ForeColor = labeldarkmode.ForeColor;
                this.label2.ForeColor = labeldarkmode.ForeColor;
                this.label3.ForeColor = labeldarkmode.ForeColor;
                this.label4.ForeColor = labeldarkmode.ForeColor;
                this.label5.ForeColor = labeldarkmode.ForeColor;
                this.label6.ForeColor = labeldarkmode.ForeColor;
                this.label7.ForeColor = labeldarkmode.ForeColor;
                this.label9.ForeColor = labeldarkmode.ForeColor;
                this.label10.ForeColor = labeldarkmode.ForeColor;
                this.label11.ForeColor = labeldarkmode.ForeColor;

                this.Refresh();
            }
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            if (darkmode == true)
            {
                pictureBox4.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_toggle_on_white_24dpHover.png");
            }
            else if (darkmode == false)
            {
                pictureBox4.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_toggle_off_white_24dpHover.png");
            }
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            if (darkmode == true)
            {
                pictureBox4.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_toggle_on_white_24dp.png");
            }
            else if (darkmode == false)
            {
                pictureBox4.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_toggle_off_black_24dp.png");
            }
        }




        

        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////7
        /// </summary>


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        //Border

        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(new Pen(Color.White, 3),
                                     this.DisplayRectangle);

        }


        //Close Button

        private void pictureBox1_Click(object sender, EventArgs e) 
        {
            this.Close();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (darkmode == true)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_clear_white_24dpHover.png");
            }
            else if (darkmode == false)
            {
                pictureBox1.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_clear_white_24dpHoverLight.png");
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_clear_white_24dp.png");
        }



        //Minimize Buttom

        private void pictureBox3_Click(object sender, EventArgs e) 
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            if (darkmode == true)
            {
                pictureBox3.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_minimize_white_24dpHover.png");
            }
            else if (darkmode == false)
            {
                pictureBox3.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_minimize_white_24dpHoverLight.png");
            }
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Image.FromFile("C:/Users/NevesPT/Pictures/programa BG/1x/baseline_minimize_white_24dp.png");
        }



        //Drag Window

        private bool mouseDown;
        private Point lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }


        private void field1_Enter(object sender, EventArgs e)
        {
            field1.BackColor = this.BackColor;
        }

        private void field1_Leave(object sender, EventArgs e)
        {
            field1.BackColor = corinput.BackColor;
        }

        private void monthCalendar2_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "#";
        }
    }
}
