using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_C
{
    public partial class Form1 : Form
    {
        /* Setting */
        int tentativas = 5;




        /* vvvvvv  NO TOUCH  vvvvvv*/

        List<string> listaPalavras = new List<string>();
        List<int> NoRepeat = new List<int>();               // Não repetir palavras ao iniciar novo jogo
        int animatetimer = -1;
        string show_palavra = "";                           // Texto de exibição da palavra escolhida pelo rnd
        string palavraAEcontrar = "";                       // String temporária da palavra escolhida pelo rnd
        int counter = 0;                                    // contar letras usadas
        string letras_Usadas = "";                          // Texto de exibição das letras usadas


        /* extra para encontrar e gravar letras */
        char[] palavraAEncontrar_array;                     // Gravar as letras seguindo a palavra escolhida pelo rnd
        int[] palavraAEncontra_position;                    // Verificar onde a letra se encontra na palavra e a bloquear
        bool LetraEncontrada = false;                       // Verificar se a letra já foi encontrada para nao se repetir ou ser substituida
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            CriarListaPalavras();

            

        }





        private void CriarListaPalavras()
        {
            // lista com 15 palavras

            listaPalavras.Add("Portugal");      // 1
            listaPalavras.Add("Lisboa");        // 2
            listaPalavras.Add("Verde");         // 3
            listaPalavras.Add("Sporting");      // 4
            listaPalavras.Add("Porto");         // 5
            listaPalavras.Add("Benfica");       // 6
            listaPalavras.Add("Carlos");        // 7
            listaPalavras.Add("Maria");         // 8
            listaPalavras.Add("Amadeu");        // 9
            listaPalavras.Add("Carla");         // 10
            listaPalavras.Add("Circo");         // 11
            listaPalavras.Add("Calculadora");   // 12
            listaPalavras.Add("Nacional");      // 13
            listaPalavras.Add("Ontem");         // 14
            listaPalavras.Add("Perfume");       // 15



        }


        private string NewWord()
        {
            bool NaoUsada = false;

            string show_palavra = "Jogo da Forca";

            try
            {
                while (NaoUsada == false)
                {
                    int index = rnd.Next(0, 14);

                    if (!NoRepeat.Exists(e => e == index))
                    {
                        show_palavra = listaPalavras[index];
                        NoRepeat.Add(index);
                        NaoUsada = true;
                        break;
                    }
                    else
                    {
                        NaoUsada = false;
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            return show_palavra.ToUpper();
        }





        private void timeranimation_Tick_1(object sender, EventArgs e)
        {
            animatetimer++;

            if (tentativas - counter == 3)
            {
                lbl_attempts.ForeColor = Color.Yellow;
            }
            if (tentativas - counter == 2)
            {
                lbl_attempts.ForeColor = Color.OrangeRed;
            }
            if (tentativas - counter == 1)
            {
                timeranimation.Start();
                

                if (animatetimer % 2 == 0)
                {
                    lbl_attempts.ForeColor = Color.DarkRed;
                }
                else
                {
                    lbl_attempts.ForeColor = Color.Red;
                }
            }

            if (tentativas - counter == 0)
            {
                animatetimer = -1;
                lbl_attempts.ForeColor = SystemColors.ControlText;
                timeranimation.Stop();
                
            }
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            NewGame();
            normal();


        }



        private void NewGame()
        {
            try
            {
                palavraAEcontrar = NewWord();
                palavraAEcontrar = palavraAEcontrar.ToUpper();
                palavraAEncontrar_array = palavraAEcontrar.ToCharArray();

                palavraAEncontra_position = new int[palavraAEcontrar.Length];


                show_palavra = "";
                for (int i = 0; i < palavraAEcontrar.Length; i++)
                {
                    show_palavra += "•";
                }

                letras_Usadas = "";
                counter = 0;

                lbl_palavra.Text = show_palavra.ToUpper();
                lbl_falhadas.Text = letras_Usadas;
                lbl_attempts.Text = tentativas.ToString();
                Application.DoEvents();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }




        private void search_letra(string letra)
        {


            try
            {
                if (counter < tentativas)
                {

                    LetraEncontrada = false;
                    for (int i = 0; i < palavraAEncontrar_array.Length; i++)
                    {
                        if (letra[0] == palavraAEncontrar_array[i])
                        {
                            palavraAEncontra_position[i] = 1;
                            LetraEncontrada = true;
                        }
                    }

                    if (LetraEncontrada == false)
                    {
                        if (counter == 0)
                        {
                            letras_Usadas += letra;
                            counter++;
                            lbl_attempts.Text = (tentativas - counter).ToString();
                        }
                        else
                        {
                            letras_Usadas += " - " + letra;
                            counter++;
                            lbl_attempts.Text = (tentativas - counter).ToString();
                        }
                    }

                    show_palavra = "";
                    for (int i = 0; i < palavraAEncontrar_array.Length; i++)
                    {
                        if (palavraAEncontra_position[i] == 1)
                        {
                            show_palavra += palavraAEncontrar_array[i].ToString();
                        }
                        else
                        {
                            show_palavra += "•";
                        }
                    }

                    lbl_palavra.Text = show_palavra.ToUpper();
                    lbl_falhadas.Text = letras_Usadas;

                    if (tentativas - counter == 1)
                    {
                        timeranimation.Start();
                    }

                    if (tentativas - counter == 0)
                    {
                        derrota();
                    }


                    if (palavraAEncontra_position.All(e => e == 1))
                    {
                        vitoria();
                    }
                }
                else
                {
                    
                    
                }
                
            }

            /* Mensagem de erro */
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }










        private void lbl_attempts_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void btn_a_Click_1(object sender, EventArgs e)
        {
            search_letra(btn_a.Text);
            btn_a.Enabled = false;
        }


        private void btn_b_Click(object sender, EventArgs e)
        {
            search_letra(btn_b.Text);
            btn_b.Enabled = false;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            search_letra(btn_c.Text);
            btn_c.Enabled = false;
        }

        private void btn_d_Click(object sender, EventArgs e)
        {
            search_letra(btn_d.Text);
            btn_d.Enabled = false;
        }

        private void btn_e_Click(object sender, EventArgs e)
        {
            search_letra(btn_e.Text);
            btn_e.Enabled = false;
        }

        private void btn_f_Click(object sender, EventArgs e)
        {
            search_letra(btn_f.Text);
            btn_f.Enabled = false;
        }

        private void btn_g_Click(object sender, EventArgs e)
        {
            search_letra(btn_g.Text);
            btn_g.Enabled = false;
        }

        private void btn_h_Click(object sender, EventArgs e)
        {
            search_letra(btn_h.Text);
            btn_h.Enabled = false;
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            search_letra(btn_i.Text);
            btn_i.Enabled = false;
        }

        private void btn_j_Click(object sender, EventArgs e)
        {
            search_letra(btn_j.Text);
            btn_j.Enabled = false;
        }

        private void btn_k_Click(object sender, EventArgs e)
        {
            search_letra(btn_k.Text);
            btn_k.Enabled = false;
        }

        private void btn_l_Click(object sender, EventArgs e)
        {
            search_letra(btn_l.Text);
            btn_l.Enabled = false;
        }

        private void btn_m_Click(object sender, EventArgs e)
        {
            search_letra(btn_m.Text);
            btn_m.Enabled = false;
        }

        private void btn_n_Click(object sender, EventArgs e)
        {
            search_letra(btn_n.Text);
            btn_n.Enabled = false;
        }

        private void btn_o_Click(object sender, EventArgs e)
        {
            search_letra(btn_o.Text);
            btn_o.Enabled = false;
        }

        private void btn_p_Click(object sender, EventArgs e)
        {
            search_letra(btn_p.Text);
            btn_p.Enabled = false;
        }

        private void btn_q_Click(object sender, EventArgs e)
        {
            search_letra(btn_q.Text);
            btn_q.Enabled = false;
        }

        private void btn_r_Click(object sender, EventArgs e)
        {
            search_letra(btn_r.Text);
            btn_r.Enabled = false;
        }

        private void btn_s_Click(object sender, EventArgs e)
        {
            search_letra(btn_s.Text);
            btn_s.Enabled = false;
        }

        private void btn_t_Click_1(object sender, EventArgs e)
        {
            search_letra(btn_t.Text);
            btn_t.Enabled = false;
        }

        private void btn_u_Click_1(object sender, EventArgs e)
        {
            search_letra(btn_u.Text);
            btn_u.Enabled = false;
        }

        private void btn_v_Click(object sender, EventArgs e)
        {
            search_letra(btn_v.Text);
            btn_v.Enabled = false;
        }

        private void btn_w_Click(object sender, EventArgs e)
        {
            search_letra(btn_w.Text);
            btn_w.Enabled = false;
        }

        private void btn_x_Click(object sender, EventArgs e)
        {
            search_letra(btn_x.Text);
            btn_x.Enabled = false;
        }
        
        private void btn_y_Click(object sender, EventArgs e)
        {
            search_letra(btn_y.Text);
            btn_y.Enabled = false;
        }

        private void btn_z_Click(object sender, EventArgs e)
        {
            search_letra(btn_z.Text);
            btn_z.Enabled = false;
        }




        private void vitoria() {
            groupBox1.Enabled = false;
            btn_iniciar.Enabled = true;
            animatetimer = -1;
            lbl_attempts.ForeColor = SystemColors.ControlText;
            timeranimation.Stop();
            this.BackColor = Color.LimeGreen;
            lbl_falhadas.ForeColor = ColorTranslator.FromHtml("#444444");
            lbl_palavra.Text = palavraAEcontrar;
            lbl_palavra.ForeColor = Color.White;


            btn_a.BackColor = Color.Green;
            btn_b.BackColor = Color.Green;
            btn_c.BackColor = Color.Green;
            btn_d.BackColor = Color.Green;
            btn_e.BackColor = Color.Green;
            btn_f.BackColor = Color.Green;
            btn_g.BackColor = Color.Green;
            btn_h.BackColor = Color.Green;
            btn_i.BackColor = Color.Green;
            btn_j.BackColor = Color.Green;
            btn_k.BackColor = Color.Green;
            btn_l.BackColor = Color.Green;
            btn_m.BackColor = Color.Green;
            btn_n.BackColor = Color.Green;
            btn_o.BackColor = Color.Green;
            btn_p.BackColor = Color.Green;
            btn_q.BackColor = Color.Green;
            btn_r.BackColor = Color.Green;
            btn_s.BackColor = Color.Green;
            btn_t.BackColor = Color.Green;
            btn_u.BackColor = Color.Green;
            btn_v.BackColor = Color.Green;
            btn_w.BackColor = Color.Green;
            btn_x.BackColor = Color.Green;
            btn_y.BackColor = Color.Green;
            btn_z.BackColor = Color.Green;




        }

        private void derrota()
        {
            groupBox1.Enabled = false;
            btn_iniciar.Enabled = true;
            animatetimer = -1;
            lbl_attempts.ForeColor = SystemColors.ControlText;
            timeranimation.Stop();
            this.BackColor = Color.Crimson;
            lbl_falhadas.ForeColor = ColorTranslator.FromHtml("#444444");
            lbl_palavra.Text = palavraAEcontrar;
            lbl_palavra.ForeColor = Color.White;


            btn_a.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_b.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_c.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_d.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_e.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_f.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_g.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_h.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_i.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_j.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_k.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_l.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_m.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_n.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_o.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_p.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_q.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_r.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_s.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_t.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_u.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_v.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_w.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_x.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_y.BackColor = ColorTranslator.FromHtml("#AD1130");
            btn_z.BackColor = ColorTranslator.FromHtml("#AD1130");
            
        }


        private void normal()
        {
            ativarbtn();
            groupBox1.Enabled = true;
            btn_iniciar.Enabled = false;
            lbl_attempts.ForeColor = SystemColors.ControlText;
            this.BackColor = Color.MediumTurquoise;
            lbl_falhadas.ForeColor = Color.Crimson;
            lbl_palavra.ForeColor = Color.Gray;


            btn_a.BackColor = Color.LightSeaGreen;
            btn_b.BackColor = Color.LightSeaGreen;
            btn_c.BackColor = Color.LightSeaGreen;
            btn_d.BackColor = Color.LightSeaGreen;
            btn_e.BackColor = Color.LightSeaGreen;
            btn_f.BackColor = Color.LightSeaGreen;
            btn_g.BackColor = Color.LightSeaGreen;
            btn_h.BackColor = Color.LightSeaGreen;
            btn_i.BackColor = Color.LightSeaGreen;
            btn_j.BackColor = Color.LightSeaGreen;
            btn_k.BackColor = Color.LightSeaGreen;
            btn_l.BackColor = Color.LightSeaGreen;
            btn_m.BackColor = Color.LightSeaGreen;
            btn_n.BackColor = Color.LightSeaGreen;
            btn_o.BackColor = Color.LightSeaGreen;
            btn_p.BackColor = Color.LightSeaGreen;
            btn_q.BackColor = Color.LightSeaGreen;
            btn_r.BackColor = Color.LightSeaGreen;
            btn_s.BackColor = Color.LightSeaGreen;
            btn_t.BackColor = Color.LightSeaGreen;
            btn_u.BackColor = Color.LightSeaGreen;
            btn_v.BackColor = Color.LightSeaGreen;
            btn_w.BackColor = Color.LightSeaGreen;
            btn_x.BackColor = Color.LightSeaGreen;
            btn_y.BackColor = Color.LightSeaGreen;
            btn_z.BackColor = Color.LightSeaGreen;

        }


        private void ativarbtn()
        {

            btn_a.Enabled = true;
            btn_b.Enabled = true;
            btn_c.Enabled = true;
            btn_d.Enabled = true;
            btn_e.Enabled = true;
            btn_f.Enabled = true;
            btn_g.Enabled = true;
            btn_h.Enabled = true;
            btn_i.Enabled = true;
            btn_j.Enabled = true;
            btn_k.Enabled = true;
            btn_l.Enabled = true;
            btn_m.Enabled = true;
            btn_n.Enabled = true;
            btn_o.Enabled = true;
            btn_p.Enabled = true;
            btn_q.Enabled = true;
            btn_r.Enabled = true;
            btn_s.Enabled = true;
            btn_t.Enabled = true;
            btn_u.Enabled = true;
            btn_v.Enabled = true;
            btn_w.Enabled = true;
            btn_x.Enabled = true;
            btn_y.Enabled = true;
            btn_z.Enabled = true;

        }









        private void lbl_falhadas_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
