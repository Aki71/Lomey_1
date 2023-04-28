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

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(label1.Text);
            if (a >= 100)
            {
                pictureBox7.Hide();
                a = a - 100;
                label1.Text = Convert.ToString(a);
            }
        }
    }
}
