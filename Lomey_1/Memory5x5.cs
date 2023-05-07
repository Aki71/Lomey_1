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
    public partial class Memory5x5 : UserControl
    {
        public Memory5x5()
        {
            InitializeComponent();
        }

        bool pombool = false;
        string pomstring = "";
        string pomupitnik = "";
        
        void Netacno(string ime)
        {
            var t = Task.Delay(1500);
            t.Wait();

            foreach (Control n in Controls)
                if (n is PictureBox)
                    if (Convert.ToString((n as PictureBox).Tag) == "u")
                    {
                        if ((n as PictureBox).Name == pomupitnik)
                        {
                            (n as PictureBox).Show();
                        }
                        else if ((n as PictureBox).Name == ime)
                        {
                            (n as PictureBox).Show();
                        }
                    }
        }

        private void u1(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik1.Location.X);
                            int Y2 = Convert.ToInt32(upitnik1.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik1.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik1.Hide();
                                    upitnik1.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik1");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik1.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik1.Location.X);
                            int Y2 = Convert.ToInt32(upitnik1.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik1";
                            }
                        }
            }
        }

        private void u2(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik2.Location.X);
                            int Y2 = Convert.ToInt32(upitnik2.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik2.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik2.Hide();
                                    upitnik2.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik2");
                                }
                            }   
                        }
                    }    
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik2.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik2.Location.X);
                            int Y2 = Convert.ToInt32(upitnik2.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik2";
                            }
                        }
            }
        }

        private void u3(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik3.Location.X);
                            int Y2 = Convert.ToInt32(upitnik3.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik3.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik3.Hide();
                                    upitnik3.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik3");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik3.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik3.Location.X);
                            int Y2 = Convert.ToInt32(upitnik3.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik3";
                            }
                        }
            }
        }

        private void u4(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik4.Location.X);
                            int Y2 = Convert.ToInt32(upitnik4.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik4.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik4.Hide();
                                    upitnik4.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik4");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik4.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik4.Location.X);
                            int Y2 = Convert.ToInt32(upitnik4.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik4";
                            }
                        }
            }
        }

        private void u5(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik5.Location.X);
                            int Y2 = Convert.ToInt32(upitnik5.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik5.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik5.Hide();
                                    upitnik5.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik5");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik5.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik5.Location.X);
                            int Y2 = Convert.ToInt32(upitnik5.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik5";
                            }
                        }
            }
        }

        private void u6(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik6.Location.X);
                            int Y2 = Convert.ToInt32(upitnik6.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik6.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik6.Hide();
                                    upitnik6.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik6");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik6.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik6.Location.X);
                            int Y2 = Convert.ToInt32(upitnik6.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik6";
                            }
                        }
            }
        }

        private void u7(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik7.Location.X);
                            int Y2 = Convert.ToInt32(upitnik7.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik7.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik7.Hide();
                                    upitnik7.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik7");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik7.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik7.Location.X);
                            int Y2 = Convert.ToInt32(upitnik7.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik7";
                            }
                        }
            }
        }

        private void u8(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik8.Location.X);
                            int Y2 = Convert.ToInt32(upitnik8.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik8.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik8.Hide();
                                    upitnik8.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik8");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik8.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik8.Location.X);
                            int Y2 = Convert.ToInt32(upitnik8.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik8";
                            }
                        }
            }
        }

        private void u9(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik9.Location.X);
                            int Y2 = Convert.ToInt32(upitnik9.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik9.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik9.Hide();
                                    upitnik9.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik9");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik9.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik9.Location.X);
                            int Y2 = Convert.ToInt32(upitnik9.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik9";
                            }
                        }
            }
        }

        private void u10(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik10.Location.X);
                            int Y2 = Convert.ToInt32(upitnik10.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik10.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik10.Hide();
                                    upitnik10.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik10");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik10.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik10.Location.X);
                            int Y2 = Convert.ToInt32(upitnik10.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik10";
                            }
                        }
            }
        }

        private void u11(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik11.Location.X);
                            int Y2 = Convert.ToInt32(upitnik11.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik11.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik11.Hide();
                                    upitnik11.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik11");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik11.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik11.Location.X);
                            int Y2 = Convert.ToInt32(upitnik11.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik11";
                            }
                        }
            }
        }

        private void u12(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik12.Location.X);
                            int Y2 = Convert.ToInt32(upitnik12.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik12.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik12.Hide();
                                    upitnik12.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik12");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik12.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik12.Location.X);
                            int Y2 = Convert.ToInt32(upitnik12.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik12";
                            }
                        }
            }
        }

        private void u13(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik13.Location.X);
                            int Y2 = Convert.ToInt32(upitnik13.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik13.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik13.Hide();
                                    upitnik13.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik13");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik13.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik13.Location.X);
                            int Y2 = Convert.ToInt32(upitnik13.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik13";
                            }
                        }
            }
        }
        private void u14(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik14.Location.X);
                            int Y2 = Convert.ToInt32(upitnik14.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik14.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik14.Hide();
                                    upitnik14.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik14");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik14.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik14.Location.X);
                            int Y2 = Convert.ToInt32(upitnik14.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik14";
                            }
                        }
            }
        }
        private void u15(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik15.Location.X);
                            int Y2 = Convert.ToInt32(upitnik15.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik15.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik15.Hide();
                                    upitnik15.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik15");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik15.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik15.Location.X);
                            int Y2 = Convert.ToInt32(upitnik15.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik15";
                            }
                        }
            }
        }
        private void u16(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik16.Location.X);
                            int Y2 = Convert.ToInt32(upitnik16.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik16.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik16.Hide();
                                    upitnik16.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik16");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik16.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik16.Location.X);
                            int Y2 = Convert.ToInt32(upitnik16.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik16";
                            }
                        }
            }
        }

        private void nazad(object sender, MouseEventArgs e)
        {
            foreach (Control n in Controls)
                if (n is PictureBox)
                    if (Convert.ToString((n as PictureBox).Tag) == "u")
                    {
                        (n as PictureBox).Show();
                        (n as PictureBox).Enabled = true;
                    }
            this.Hide();
        }

        private void u17(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik17.Location.X);
                            int Y2 = Convert.ToInt32(upitnik17.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik17.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik17.Hide();
                                    upitnik17.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik17");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik17.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik17.Location.X);
                            int Y2 = Convert.ToInt32(upitnik17.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik17";
                            }
                        }
            }
        }

        private void u18(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik18.Location.X);
                            int Y2 = Convert.ToInt32(upitnik18.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik18.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik18.Hide();
                                    upitnik18.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik18");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik18.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik18.Location.X);
                            int Y2 = Convert.ToInt32(upitnik18.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik18";
                            }
                        }
            }
        }

        private void u19(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik19.Location.X);
                            int Y2 = Convert.ToInt32(upitnik19.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik19.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik19.Hide();
                                    upitnik19.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik19");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik19.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik19.Location.X);
                            int Y2 = Convert.ToInt32(upitnik19.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik19";
                            }
                        }
            }
        }

        private void u20(object sender, EventArgs e)
        {
            if (pombool == true)
            {
                foreach (Control n in Controls)
                    if (n is PictureBox)
                    {
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik20.Location.X);
                            int Y2 = Convert.ToInt32(upitnik20.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                upitnik16.Hide();
                                if (Convert.ToString((n as PictureBox).Tag) == Convert.ToString(pomstring))
                                {
                                    upitnik20.Hide();
                                    upitnik20.Enabled = false;
                                }
                                else
                                {
                                    Netacno("upitnik20");
                                }
                            }
                        }
                    }
                pombool = false;
            }
            else
            {
                pombool = true;
                upitnik20.Hide();
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik20.Location.X);
                            int Y2 = Convert.ToInt32(upitnik20.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                            {
                                pomstring = Convert.ToString((n as PictureBox).Tag);
                                pomupitnik = "upitnik20";
                            }
                        }
            }
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (Control n in Controls)
                if (n is PictureBox)
                    if (Convert.ToString((n as PictureBox).Tag) == "u")
                    {
                        (n as PictureBox).Show();
                        (n as PictureBox).Enabled = true;
                    }
            this.Hide();
        }
    }
}
