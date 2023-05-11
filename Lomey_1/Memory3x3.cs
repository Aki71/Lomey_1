﻿using System;
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
    public partial class Memory3x3 : UserControl
    {
        public Memory3x3()
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
            int[] brojevi = new int[13];
            for (int i = 0; i < 12; i++) brojevi[i] = i + 1;
            int[,] matrica = new int[3, 4];
            int indeks = 12;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    while (brojevi[indeks] == 0)
                    {
                        indeks = r.Next(0, 12);
                        matrica[i, j] = brojevi[indeks];
                    }
                    brojevi[indeks] = 0;
                }
            }

            string rec = "broj" + Convert.ToString(matrica[0, 0]);
            Control ctn = this.Controls[rec];
            ctn.Location = new Point(206, 78);

            rec = "broj" + Convert.ToString(matrica[0, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(330, 78);

            rec = "broj" + Convert.ToString(matrica[0, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(448, 78);

            rec = "broj" + Convert.ToString(matrica[0, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(563, 78);

            rec = "broj" + Convert.ToString(matrica[1, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(206, 184);

            rec = "broj" + Convert.ToString(matrica[1, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(330, 184);

            rec = "broj" + Convert.ToString(matrica[1, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(448, 184);

            rec = "broj" + Convert.ToString(matrica[1, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(563, 184);

            rec = "broj" + Convert.ToString(matrica[2, 0]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(206, 291);

            rec = "broj" + Convert.ToString(matrica[2, 1]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(330, 291);

            rec = "broj" + Convert.ToString(matrica[2, 2]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(448, 291);

            rec = "broj" + Convert.ToString(matrica[2, 3]);
            ctn = this.Controls[rec];
            ctn.Location = new Point(563, 291);
        }

        private void klik(object sender, MouseEventArgs e)
        {
            if (!upitnik1.Visible && !upitnik2.Visible && !upitnik3.Visible && !upitnik4.Visible && !upitnik5.Visible && !upitnik6.Visible && !upitnik7.Visible && !upitnik8.Visible && !upitnik9.Visible && !upitnik10.Visible && !upitnik11.Visible && !upitnik12.Visible)
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

        private void Memory3x3_Load(object sender, EventArgs e)
        {
            RandomLoading();
        }
    }
}
