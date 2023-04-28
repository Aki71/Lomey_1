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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        SoundPlayer background_music = new SoundPlayer();

        //user : U1 pass:u1
        //user : U2 pass:u2
        //user : U3 pass:u3
        //user : U4 pass:u4
        private void button1_Click(object sender, EventArgs e)
        {
            if(login_pass.Text == "u1" && login_user.Text == "U1")
            {
                Form Main = new Main();
                Main.Show();
                background_music.Stop();
                this.Hide();
            }
            if(login_pass.Text == "u2" && login_user.Text == "U2")
            {
                Form Main = new Main();
                Main.Show();
                background_music.Stop();
                this.Hide();
            }
            if(login_pass.Text == "u3" && login_user.Text == "U3")
            {
                Form Main = new Main();
                Main.Show();
                background_music.Stop();
                this.Hide();
            }
            if(login_pass.Text == "u4" && login_user.Text == "U4")
            {
                Form Main = new Main();
                Main.Show();
                background_music.Stop();
                this.Hide();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.sound_off;
            // background_music.Stop();
        }

        private void login_Load(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.sound_on;
            /*
            background_music.SoundLocation = "ChillNoons.wav";
            background_music.PlayLooping();
           */
        }
    }
}
