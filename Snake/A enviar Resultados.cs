using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class A_enviar_Resultados : Form
    {
        string usernametemp = Settings.Username;
        public A_enviar_Resultados()
        {
            InitializeComponent();

            string usernametemp = Settings.Username;
            usernamelabel.Text = usernametemp;

            string gameOverScore2 = "" + Settings.Score + "";
            lblGameOverScore2.Text = gameOverScore2.PadLeft(7, '0');

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGameOverScore2_Click(object sender, EventArgs e)
        {

        }
    }
}
