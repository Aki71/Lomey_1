using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lomey_1
{
    public partial class loto_game : Form
    {
        public loto_game()
        {
            InitializeComponent();
        }
        private void loto_game_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form Main = new Main();
            Main.Show();
            this.Hide();
        }

        private void loto_game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        string[] dobitni_brojevi = new string[10];
        private void button1_Click(object sender, EventArgs e)
        {
            Random brojevi = new Random();
            for(int i = 0; i< 7; i++)
            {
                dobitni_brojevi[i] = Convert.ToString(brojevi.Next(1,39));
                textBox1.Text += " " +  dobitni_brojevi[i];
                
            }
            pictureBox1.ImageLocation = "";

        }
    }
}
