using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lomey_1
{
    public partial class Memory5x5 : UserControl
    {
        public Memory5x5()
        {
            InitializeComponent();
        }

        bool pombool = false;
        string pomstring = "";
        string pomupitnik = "";

        void RandomLoading()
        {
            foreach (Control n in Controls)
                if (n is PictureBox)
                    if (Convert.ToString((n as PictureBox).Tag) == "u")
                    {
                        (n as PictureBox).Show();
                        (n as PictureBox).Enabled = true;
                    }

            Random r = new Random();
            int[] brojevi = new int[21];
            for (int i = 0; i < 20; i++) brojevi[i] = i + 1;
            int[,] matrica = new int[4, 5];
            int indeks = 20;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    while (brojevi[indeks] == 0)
                    {
                        indeks = r.Next(0, 20);
                        matrica[i, j] = brojevi[indeks];
                    }
                    brojevi[indeks] = 0;
                }
            }

            string rec = "broj" + Convert.ToString(matrica[0, 0]);
            Control ctn = this.Controls[rec];
            ctn.Location = new Point(176, 17);

            rec = "broj" + Convert.ToString(matrica[0, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(300, 17);

            rec = "broj" + Convert.ToString(matrica[0, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(418, 17);

            rec = "broj" + Convert.ToString(matrica[0, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(533, 17);

            rec = "broj" + Convert.ToString(matrica[0, 4]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(654, 17);

            rec = "broj" + Convert.ToString(matrica[1, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(176, 123);

            rec = "broj" + Convert.ToString(matrica[1, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(300, 123);

            rec = "broj" + Convert.ToString(matrica[1, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(418, 123);

            rec = "broj" + Convert.ToString(matrica[1, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(533, 123);

            rec = "broj" + Convert.ToString(matrica[1, 4]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(654, 123);

            rec = "broj" + Convert.ToString(matrica[2, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(176, 230);

            rec = "broj" + Convert.ToString(matrica[2, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(300, 230);

            rec = "broj" + Convert.ToString(matrica[2, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(418, 230);

            rec = "broj" + Convert.ToString(matrica[2, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(533, 230);

            rec = "broj" + Convert.ToString(matrica[2, 4]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(654, 230);

            rec = "broj" + Convert.ToString(matrica[3, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(176, 342);
            
            rec = "broj" + Convert.ToString(matrica[3, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(300, 342);
            
            rec = "broj" + Convert.ToString(matrica[3, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(418, 342);
            
            rec = "broj" + Convert.ToString(matrica[3, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(533, 342);
            
            rec = "broj" + Convert.ToString(matrica[3, 4]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(654, 342);
        }

        private void klik(object sender, MouseEventArgs e)
        {
            if (!upitnik1.Visible && !upitnik2.Visible && !upitnik3.Visible && !upitnik4.Visible && !upitnik5.Visible && !upitnik6.Visible && !upitnik7.Visible && !upitnik8.Visible && !upitnik9.Visible && !upitnik10.Visible && !upitnik11.Visible && !upitnik12.Visible && !upitnik13.Visible && !upitnik14.Visible && !upitnik15.Visible && !upitnik16.Visible && !upitnik17.Visible && !upitnik18.Visible && !upitnik19.Visible && !upitnik20.Visible)
            {

            }

            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32((sender as PictureBox).Location.X);
                            int Y2 = Convert.ToInt32((sender as PictureBox).Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                (sender as PictureBox).Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    (sender as PictureBox).Hide();
                                    (sender as PictureBox).Enabled = false;
                                }
                                else
                                {
                                    var t = Task.Delay(1500);
                                    t.Wait();

                                    foreach (Control h in Controls)
                                        if (h is PictureBox)
                                            if (Convert.ToString((h as PictureBox).Tag) == "u")
                                            {
                                                if ((h as PictureBox).Name == pomupitnik)
                                                {
                                                    (h as PictureBox).Show();
                                                }
                                                else if ((h as PictureBox).Name == (sender as PictureBox).Name)
                                                {
                                                    (h as PictureBox).Show();
                                                }
                                            }
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                (sender as PictureBox).Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32((sender as PictureBox).Location.X);
                            int Y2 = Convert.ToInt32((sender as PictureBox).Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = (sender as PictureBox).Name;
                            }
                        }
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            RandomLoading();
            this.Hide();
        }

        private void Memory5x5_Load(object sender, EventArgs e)
        {
            RandomLoading();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (upitnik1.Visible == false && upitnik2.Visible == false && upitnik3.Visible == false && upitnik4.Visible == false && upitnik5.Visible == false && upitnik6.Visible == false && upitnik7.Visible == false && upitnik8.Visible == false && upitnik9.Visible == false && upitnik10.Visible == false && upitnik11.Visible == false && upitnik12.Visible == false && upitnik13.Visible == false && upitnik14.Visible == false && upitnik15.Visible == false && upitnik16.Visible == false)
            {
                timer1.Enabled = false;
                StreamReader coin = new StreamReader("coin.txt");
                int b = Convert.ToInt32(coin.ReadLine());
                int a = b + 30;
                coin.Close();
                File.WriteAllText("coin.txt", Convert.ToString(a));
                string message = "Congratulations!" +
                    "  Do you want to close this window?";
                string title = "Congratulations";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Hide();
                }
            }
        }
    }
}
