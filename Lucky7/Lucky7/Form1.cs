using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lucky7
{
    public partial class Form1 : Form
    {

        Image[] imagens = new Image[10];
        Image[] imagensalt = new Image[10];
        
        int contador;
        int animate = -1;
        int animatetimer = -1;
        int tempo = 30;
        int creditos = 100;


        public Form1()
        {
            InitializeComponent();
            lblcreditos.Text = creditos.ToString();

            animation1.Start();

            imagens[0] = Image.FromFile("banana.png");
            imagens[1] = Image.FromFile("bbarry.png");
            imagens[2] = Image.FromFile("cherry.png");
            imagens[3] = Image.FromFile("grapes.png");
            imagens[4] = Image.FromFile("orange.png");
            imagens[5] = Image.FromFile("pear.png");
            imagens[6] = Image.FromFile("pineapple.png");
            imagens[7] = Image.FromFile("seven.png");
            imagens[8] = Image.FromFile("sbarry.png");
            imagens[9] = Image.FromFile("watermelon.png");

            imagensalt[0] = Image.FromFile("bananaalt.png");
            imagensalt[1] = Image.FromFile("bbarryalt.png");
            imagensalt[2] = Image.FromFile("cherryalt.png");
            imagensalt[3] = Image.FromFile("grapesalt.png");
            imagensalt[4] = Image.FromFile("orangealt.png");
            imagensalt[5] = Image.FromFile("pearalt.png");
            imagensalt[6] = Image.FromFile("pineapplealt.png");
            imagensalt[7] = Image.FromFile("sevenalt.png");
            imagensalt[8] = Image.FromFile("sbarryalt.png");
            imagensalt[9] = Image.FromFile("watermelonalt.png");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {

            /* Ativar Botão */
            btnPlay.Enabled = false;
            btnPlay.BackColor = Color.DarkSlateGray;


            /* Play Sound */
            System.Media.SoundPlayer play = new
            System.Media.SoundPlayer(@"roll.wav");
            play.Play();


            /* Contador para o fim do timer*/
            contador = 0;

            /* Iniciar o Timer */
            timer1.Start();
            timer2.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /* Label 1 */
            Random rnd = new Random();
            int n1 = 7;// rnd.Next(0, 9);
            lbl1.Text = n1.ToString();

            /* Label 2 */
            int n2 = 7;// rnd.Next(0, 9);
            lbl2.Text = n2.ToString();

            /* Label 3 */
            int n3 = rnd.Next(0, 9);
            lbl3.Text = n3.ToString();


            /* Atribuir imagem */
            final1.Image = imagens[n1];
            final2.Image = imagens[n2];
            final3.Image = imagens[n3];


            /* adicionar 1 ao contador */
            contador++;

            if (contador > 65)
            {

                /* Parar o Timer */
                timer1.Stop();

                /* Ativar Botão */
                btnPlay.Enabled = true;
                btnPlay.BackColor = Color.Teal;

                // Avaliar resultados

                if ((n1 == 7) && (n1 == 7) && (n3 == 7))
                {

                    /* Play Sound */
                    System.Media.SoundPlayer playwin = new
                    System.Media.SoundPlayer(@"win.wav");
                    playwin.Play();


                    /* creditos */
                    creditos += 500;

                }

                else if ((n1 == 7) && (n1 == 7) && (n3 != 7) ||
                         (n1 == 7) && (n1 != 7) && (n3 == 7) ||
                         (n1 != 7) && (n1 == 7) && (n3 == 7))
                {
                    creditos += 100;
                    
                }

                else if ((n1 == 7) && (n1 != 7) && (n3 != 7) ||
                         (n1 != 7) && (n1 == 7) && (n3 != 7) ||
                         (n1 != 7) && (n1 != 7) && (n3 == 7))
                    creditos += 50;

                else
                    creditos -= 30;


                lblcreditos.Text = creditos.ToString();

                if (creditos < 0)
                {
                    btnPlay.Visible = false;
                    

                    /* Play Sound */
                    System.Media.SoundPlayer playloser = new
                    System.Media.SoundPlayer(@"loser.wav");
                    playloser.Play();


                    /* Pop-up */
                    MessageBox.Show(this, "Feed Me With Coins!","End",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    
                    /* Fechar Form */
                    this.Close();
                }

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /* reduzir 1 ao timer */
            tempo--;


            /* Escrever o tempo no Form */
            lbltime.Text = tempo.ToString();

            if (tempo <= 20)
                timeranimation.Start();

            if (tempo == 0)
            {

                timer2.Stop();

                btnPlay.Enabled = false;
                btnPlay.BackColor = Color.LightSeaGreen;
                btnPlay.ForeColor = Color.Teal;
                btnPlay.Text = "TIME OVER!";

                lbltime.Text = "Time Over!";

                /* Play Sound */
                System.Media.SoundPlayer playtimer = new
                System.Media.SoundPlayer(@"alarm.wav");
                playtimer.PlayLooping();


                /* Pop-up */
                MessageBox.Show(this, "Time is Over!\nFicou com " + creditos + " creditos!", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                /* Fechar Form */
                this.Close();
            }

        }

        private void animation1_Tick(object sender, EventArgs e)
        {
            {

                animate++;
                label1.Text = animate.ToString();

                if (animate == 0)
                {
                    pic1.Image = imagens[1];
                    pic7.Image = imagensalt[7];
                }
                if (animate == 1)
                {
                    pic7.Image = imagens[7];
                    pic0.Image = imagensalt[0];
                }
                if (animate == 2)
                {
                    pic0.Image = imagens[0];
                    pic5.Image = imagensalt[5];
                }
                if (animate == 3)
                {
                    pic5.Image = imagens[5];
                    pic4.Image = imagensalt[4];
                }
                if (animate == 4)
                {
                    pic4.Image = imagens[4];
                    pic6.Image = imagensalt[6];
                }
                if (animate == 5)
                {
                    pic6.Image = imagens[6];
                    pic2.Image = imagensalt[2];
                }
                if (animate == 6)
                {
                    pic2.Image = imagens[2];
                    pic8.Image = imagensalt[8];
                }
                if (animate == 7)
                {
                    pic8.Image = imagens[8];
                    pic9.Image = imagensalt[9];
                }
                if (animate == 8)
                {
                    pic9.Image = imagens[9];
                    pic3.Image = imagensalt[3];
                }
                if (animate == 9)
                {
                    pic3.Image = imagens[3];
                    pic1.Image = imagensalt[1];
                    animate = -1;
                }

            }
        }

        private void timeranimation_Tick(object sender, EventArgs e)
        {
            animatetimer++;
            if (animatetimer % 2 == 0)
            {
                lbltime.ForeColor = Color.DarkRed;
            }
            else
            {
                lbltime.ForeColor = Color.Red;
            }
        }

        
    }
}
