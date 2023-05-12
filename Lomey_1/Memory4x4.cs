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
    public partial class Memory4x4 : UserControl
    {
        public Memory4x4()
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
            int[] brojevi = new int[17];
            for (int i = 0; i < 16; i++) brojevi[i] = i + 1;
            int[,] matrica = new int[4, 4];
            int indeks = 16;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    while (brojevi[indeks] == 0)
                    {
                        indeks = r.Next(0, 16);
                        matrica[i, j] = brojevi[indeks];
                    }
                    brojevi[indeks] = 0;
                }
            }

            string rec = "broj" + Convert.ToString(matrica[0, 0]);
            Control ctn = this.Controls[rec];
            ctn.Location = new Point(210, 18);

            rec = "broj" + Convert.ToString(matrica[0, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(334, 18);

            rec = "broj" + Convert.ToString(matrica[0, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(452, 18);

            rec = "broj" + Convert.ToString(matrica[0, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(567, 18);

            rec = "broj" + Convert.ToString(matrica[1, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(210, 124);

            rec = "broj" + Convert.ToString(matrica[1, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(334, 124);

            rec = "broj" + Convert.ToString(matrica[1, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(452, 124);

            rec = "broj" + Convert.ToString(matrica[1, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(567, 124);

            rec = "broj" + Convert.ToString(matrica[2, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(210, 231);

            rec = "broj" + Convert.ToString(matrica[2, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(334, 231);

            rec = "broj" + Convert.ToString(matrica[2, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(452, 231);

            rec = "broj" + Convert.ToString(matrica[2, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(567, 231);
            
            rec = "broj" + Convert.ToString(matrica[3, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(210, 343);
            
            rec = "broj" + Convert.ToString(matrica[3, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(334, 343);
            
            rec = "broj" + Convert.ToString(matrica[3, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(452, 343);
            
            rec = "broj" + Convert.ToString(matrica[3, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(567, 343);
        }

        private void klik(object sender, MouseEventArgs e)
        {
            if (!upitnik1.Visible && !upitnik2.Visible && !upitnik3.Visible && !upitnik4.Visible && !upitnik5.Visible && !upitnik6.Visible && !upitnik7.Visible && !upitnik8.Visible && !upitnik9.Visible && !upitnik10.Visible && !upitnik11.Visible && !upitnik12.Visible && !upitnik13.Visible && !upitnik14.Visible && !upitnik15.Visible && !upitnik16.Visible)
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

        private void nazad(object sender, MouseEventArgs e)
        {
            RandomLoading();
            this.Hide();
        }

        private void Memory4x4_Load(object sender, EventArgs e)
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
                int a = b + 20;
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
