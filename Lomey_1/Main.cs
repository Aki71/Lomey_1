using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Lomey_1
{
    public partial class Main : Form
    {

         
        public Main()
        {
            InitializeComponent();
             
        }
        SoundPlayer background_music = new SoundPlayer();
        private void Main_Load(object sender, EventArgs e)
        {
            StreamReader kupio = new StreamReader("Kupio.txt");
            string otkljucano = kupio.ReadLine();
            if(otkljucano == "da")
            {
                pictureBox7.Visible = false;
                int a = Convert.ToInt32(label1.Text);
                a = a - 100;
                label1.Text = Convert.ToString(a);
            }
            kupio.Close();
            StreamReader coin = new StreamReader("coin.txt");
            label1.Text = Convert.ToString(coin.ReadLine());
            coin.Close();
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form loto_game = new loto_game();
            loto_game.Show();
            this.Hide();
        }
        bool otkljucano = false;
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);
            if (a >= 100)
            {
                File.WriteAllText("Kupio.txt", "");
                StreamWriter kupio = new StreamWriter("Kupio.txt", true);
                kupio.Write("da");
                kupio.Close();
                otkljucano = true;
                pictureBox7.Hide();
                a = a - 100;
                label1.Text = Convert.ToString(a);
            }
        }

        private void im(object sender, EventArgs e)
        {
            Form Memory = new Memory();
            Memory.Show();
            this.Hide();
        }
    }
}
