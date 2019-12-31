using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace Project_A
{
    public partial class Form1 : Form
    {

        Button[,] botoes;
        String Mark = "X";
        int verifica = 0;
        bool havencedor = false;
        bool verhistorico = false;
        int sj1 = 0;
        int sj2 = 0;
        int rounda = 0;
        bool enablebtn1 = false;
        bool enablebtn2 = false;

        public Form1()
        {
            botoes = new Button[3, 3];
            InitializeComponent();

            botoes[0, 0] = button1;
            botoes[0, 1] = button2;
            botoes[0, 2] = button3;
            botoes[1, 0] = button4;
            botoes[1, 1] = button5;
            botoes[1, 2] = button6;
            botoes[2, 0] = button7;
            botoes[2, 1] = button8;
            botoes[2, 2] = button9;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void resetGame()
        {
            for (int n=0; n < 3; n++)
            {
                for (int m = 0; m < 3; m++)
                {
                    botoes[n, m].Text = "";
                    botoes[n, m].Enabled = true;
                    botoes[n, m].BackColor = Color.LightCyan;
                    botoes[n, m].ForeColor = SystemColors.ControlText;

                }
            }

            lbl_score1.Text = sj1.ToString();
            lbl_score2.Text = sj2.ToString();

            if (rounda > 9)
                rounda = 0;

            rounda++;

            gbJogo.Enabled = true;
            verifica = 0;
            havencedor = false;


            if (sj1 > sj2)
            {
                lbl_score1.ForeColor = Color.Crimson;
                lbl_score2.ForeColor = Color.Gray;
            }
            if (sj1 < sj2)
            {
                lbl_score2.ForeColor = Color.Crimson;
                lbl_score1.ForeColor = Color.Gray;
            }
            if (sj1 == sj2)
            {
                lbl_score1.ForeColor = Color.Gray;
                lbl_score2.ForeColor = Color.Gray;
            }


        }

        private void Historico()
        {
            if (rounda == 1)
            {
                his1_.Visible = true;
                his1_p1.Text = jogadorX.Text;
                his1_s1.Text = sj1.ToString();
                his1_p2.Text = jogadorO.Text;
                his1_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his1_s1.ForeColor = Color.Crimson;
                    his1_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his1_s2.ForeColor = Color.Crimson;
                    his1_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his1_s1.ForeColor = Color.Gray;
                    his1_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 2)
            {
                his2_.Visible = true;
                his2_p1.Text = jogadorX.Text;
                his2_s1.Text = sj1.ToString();
                his2_p2.Text = jogadorO.Text;
                his2_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his2_s1.ForeColor = Color.Crimson;
                    his2_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his2_s2.ForeColor = Color.Crimson;
                    his2_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his2_s1.ForeColor = Color.Gray;
                    his2_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 3)
            {
                his3_.Visible = true;
                his3_p1.Text = jogadorX.Text;
                his3_s1.Text = sj1.ToString();
                his3_p2.Text = jogadorO.Text;
                his3_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his3_s1.ForeColor = Color.Crimson;
                    his3_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his3_s2.ForeColor = Color.Crimson;
                    his3_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his3_s1.ForeColor = Color.Gray;
                    his3_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 4)
            {
                his4_.Visible = true;
                his4_p1.Text = jogadorX.Text;
                his4_s1.Text = sj1.ToString();
                his4_p2.Text = jogadorO.Text;
                his4_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his4_s1.ForeColor = Color.Crimson;
                    his4_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his4_s2.ForeColor = Color.Crimson;
                    his4_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his4_s1.ForeColor = Color.Gray;
                    his4_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 5)
            {
                his5_.Visible = true;
                his5_p1.Text = jogadorX.Text;
                his5_s1.Text = sj1.ToString();
                his5_p2.Text = jogadorO.Text;
                his5_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his5_s1.ForeColor = Color.Crimson;
                    his5_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his5_s2.ForeColor = Color.Crimson;
                    his5_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his5_s1.ForeColor = Color.Gray;
                    his5_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 6)
            {
                his6_.Visible = true;
                his6_p1.Text = jogadorX.Text;
                his6_s1.Text = sj1.ToString();
                his6_p2.Text = jogadorO.Text;
                his6_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his6_s1.ForeColor = Color.Crimson;
                    his6_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his6_s2.ForeColor = Color.Crimson;
                    his6_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his6_s1.ForeColor = Color.Gray;
                    his6_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 7)
            {
                his7_.Visible = true;
                his7_p1.Text = jogadorX.Text;
                his7_s1.Text = sj1.ToString();
                his7_p2.Text = jogadorO.Text;
                his7_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his7_s1.ForeColor = Color.Crimson;
                    his7_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his7_s2.ForeColor = Color.Crimson;
                    his7_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his7_s1.ForeColor = Color.Gray;
                    his7_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 8)
            {
                his8_.Visible = true;
                his8_p1.Text = jogadorX.Text;
                his8_s1.Text = sj1.ToString();
                his8_p2.Text = jogadorO.Text;
                his8_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his8_s1.ForeColor = Color.Crimson;
                    his8_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his8_s2.ForeColor = Color.Crimson;
                    his8_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his8_s1.ForeColor = Color.Gray;
                    his8_s2.ForeColor = Color.Gray;
                }
            }

            if (rounda == 9)
            {
                his9_.Visible = true;
                his9_p1.Text = jogadorX.Text;
                his9_s1.Text = sj1.ToString();
                his9_p2.Text = jogadorO.Text;
                his9_s2.Text = sj2.ToString();
                if (sj1 > sj2)
                {
                    his9_s1.ForeColor = Color.Crimson;
                    his9_s2.ForeColor = Color.Gray;
                }
                if (sj1 < sj2)
                {
                    his9_s2.ForeColor = Color.Crimson;
                    his9_s1.ForeColor = Color.Gray;
                }
                if (sj1 == sj2)
                {
                    his9_s1.ForeColor = Color.Gray;
                    his9_s2.ForeColor = Color.Gray;
                }
            }

        }

            private void button1_Click(object sender, EventArgs e)
        {
            Button bt_atual = (Button)sender;

            

            if (bt_atual.Text.Length == 0)
            {
                bt_atual.Text = Mark;
                if (bt_atual.Text.Equals("X"))
                {
                    Mark = "O";
                    bt_atual.ForeColor = Color.Crimson;
                }
                else
                {
                    Mark = "X";
                    bt_atual.ForeColor = Color.Teal;
                }

                
                verifica++;
            }

            String Vencedor = ver_vencedor();
            if (Vencedor.Length > 0)
            {

                if (Vencedor.Equals("X"))
                {
                    sj1++;
                    gbJogo.Enabled = false;
                    MessageBox.Show("Ganhou o " + lbl_jogadorX.Text + " (" + jogadorX.Text + ")");
                }

                if (Vencedor.Equals("O"))
                {
                    sj2++;
                    gbJogo.Enabled = false;
                    MessageBox.Show("Ganhou o " + lbl_jogadorO.Text + " (" + jogadorO.Text + ")");
                }

                Historico();
                lbl_score1.Text = sj1.ToString();
                lbl_score2.Text = sj2.ToString();

                DialogResult cx = MessageBox.Show("Deseja continuar como " + jogadorX.Text + " e " + jogadorO.Text + "", "Continuar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cx == DialogResult.Yes)
                    resetGame();



            }


        }


        private string ver_vencedor()
        {
            // Ver galo em linha
            for (int n = 0; n < 3; n++)
            {
                if (botoes[n,0].Text.Length>0 &&
                    botoes[n,0].Text.Equals(botoes[n,1].Text) &&
                    botoes[n, 1].Text.Equals(botoes[n, 2].Text))
                {
                    botoes[n, 0].BackColor = Color.Green;
                    botoes[n, 0].ForeColor = Color.White;
                    botoes[n, 1].BackColor = Color.Green;
                    botoes[n, 1].ForeColor = Color.White;
                    botoes[n, 2].BackColor = Color.Green;
                    botoes[n, 2].ForeColor = Color.White;
                    
                    havencedor = true;
                    return botoes[n, 0].Text;
                }
            }


            // Ver galo em coluna
            for (int n = 0; n < 3; n++)
            {
                if (botoes[0, n].Text.Length > 0 &&
                    botoes[0, n].Text.Equals(botoes[1, n].Text) &&
                    botoes[1, n].Text.Equals(botoes[2, n].Text))
                {
                    botoes[0, n].BackColor = Color.Green;
                    botoes[0, n].ForeColor = Color.White;
                    botoes[1, n].BackColor = Color.Green;
                    botoes[1, n].ForeColor = Color.White;
                    botoes[2, n].BackColor = Color.Green;
                    botoes[2, n].ForeColor = Color.White;

                    havencedor = true;
                    return botoes[0, n].Text;
                    
                }
            }


            // Ver galo em diagonal Esquerda -> Direita
            if (botoes[0, 0].Text.Length > 0 &&
                botoes[0, 0].Text.Equals(botoes[1, 1].Text) &&
                botoes[1, 1].Text.Equals(botoes[2, 2].Text))
            {
                botoes[0, 0].BackColor = Color.Green;
                botoes[0, 0].ForeColor = Color.White;
                botoes[1, 1].BackColor = Color.Green;
                botoes[1, 1].ForeColor = Color.White;
                botoes[2, 2].BackColor = Color.Green;
                botoes[2, 2].ForeColor = Color.White;

                havencedor = true;
                return botoes[0, 0].Text;
                
            }


            // Ver galo em diagonal Direita -> Esquerda
            if (botoes[0, 2].Text.Length > 0 &&
                botoes[0, 2].Text.Equals(botoes[1, 1].Text) &&
                botoes[1, 1].Text.Equals(botoes[2, 0].Text))
            {
                botoes[0, 2].BackColor = Color.Green;
                botoes[0, 2].ForeColor = Color.White;
                botoes[1, 1].BackColor = Color.Green;
                botoes[1, 1].ForeColor = Color.White;
                botoes[2, 0].BackColor = Color.Green;
                botoes[2, 0].ForeColor = Color.White;

                havencedor = true;
                return botoes[0, 2].Text;
                
            }


            if (verifica == 9 && havencedor == false)
                {
                MessageBox.Show("Jogo empatado!");
                rounda--;
                resetGame();
                }



            return "";
        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }



        private void novosNomesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelnomes.Enabled = true;
            panelnomes.Visible = true;
            timer1.Enabled = true;
            textBox1.Text = "";
            textBox2.Text = "";

            this.Size = new Size(688, 458);


        }

        private void manterNomesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            resetGame();

            sj1 = 0;
            sj2 = 0;

            lbl_score1.Text = sj1.ToString();
            lbl_score1.ForeColor = Color.Gray;
            lbl_score2.Text = sj2.ToString();
            lbl_score2.ForeColor = Color.Gray;
            manterNomesToolStripMenuItem.Enabled = true;
            MessageBox.Show("Clique OK para começar novamente...", "Tudo Pronto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void continuarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void históricoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mostrarHistóricoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (verhistorico == false)
            {
                verhistorico = true;
                mostrarHistóricoToolStripMenuItem.Text = "Fechar Histórico";
                this.Size = new Size(688, 458);
            }
            else
            {
                verhistorico = false;
                mostrarHistóricoToolStripMenuItem.Text = "Mostrar Histórico";
                this.Size = new Size(344, 458);
            }

        }

        private void versão1227Dez2019ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {

            jogadorX.Text = textBox1.Text;
            jogadorO.Text = textBox2.Text;

            panelnomes.Enabled = false;
            panelnomes.Visible = false;
            timer1.Enabled = false;


            lbl_jogadorX.Visible = true;
            lbl_jogadorO.Visible = true;

            if (verhistorico == false)
            {
                this.Size = new Size(344, 458);
            }
            else
            {
                this.Size = new Size(688, 458);
            }

            resetGame();
            sj1 = 0;
            sj2 = 0;
            lbl_score1.Text = sj1.ToString();
            lbl_score2.Text = sj2.ToString();
            manterNomesToolStripMenuItem.Enabled = true;
            MessageBox.Show("Clique OK para começar...", "Tudo Pronto", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (textBox1.Text.Length != 0 && textBox1.Text.Equals(textBox2.Text))
            {
                button10.BackColor = Color.DarkGray;
                button10.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("Os nomes não podem ser iguais.", "Verifique os Nomes", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (textBox1.Text != "" && textBox2.Text != "")
            {
                button10.BackColor = Color.LightSeaGreen;
                button10.Enabled = true;
            }
            else
            {
                button10.BackColor = Color.DarkGray;
                button10.Enabled = false;
            }
        }

        private void porPauloCardosoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
