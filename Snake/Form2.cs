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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        string Username;


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnClose_MouseHover(object sender, EventArgs e)
        {
            BtnClose.Image = BtnCloseHover.Image;
        }

        private void BtnClose_MouseLeave(object sender, EventArgs e)
        {
            BtnClose.Image = BtnCloseNonHover.Image;
        }

        private void BtnNick_Click(object sender, EventArgs e)
        {
            if (usernamebox.Text != "")
                this.Hide();
                new Form1().Show();
                
        }

        private void BtnNick_Hover(object sender, EventArgs e)
        {
            if (usernamebox.Text != "")
                BtnNick.Image = BtnNickHover.Image;

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Settings.Username = usernamebox.Text;
            if (usernamebox.Text != "")
                BtnNick.Image = BtnNickEnable.Image;
                
            else
                BtnNick.Image = BtnNickNormal.Image;
        }

        private void BtnNick_MouseLeave(object sender, EventArgs e)
        {
            if (usernamebox.Text != "")
                BtnNick.Image = BtnNickEnable.Image;
            else
                BtnNick.Image = BtnNickNormal.Image;
        }

        
    }
}
