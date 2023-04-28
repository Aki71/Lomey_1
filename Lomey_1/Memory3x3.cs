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
    public partial class Memory3x3 : UserControl
    {
        public Memory3x3()
        {
            InitializeComponent();
        }

        bool pombool = false;
        string pomstring = "";
        string pomupitnik = "";

        private void u1(object sender, MouseEventArgs e)
        {
            if (pombool == true)
            {
                pombool = false;
                foreach(Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik1.Location.X);
                            int Y2 = Convert.ToInt32(upitnik1.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                                if (Convert.ToString((n as PictureBox).Tag) == pomstring)
                                {
                                    upitnik1.Enabled = false;
                                }

                            foreach(Control m in Controls)
                                if (m is PictureBox)
                                    if (Convert.ToString((m as PictureBox).Name) == pomupitnik)
                                    {
                                        (m as PictureBox).Enabled = false;
                                    }
                        }
            }
            else
            {
                pombool = true;
                upitnik1.Hide();
                foreach(Control n in Controls)
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
                pombool = false;
                foreach (Control n in Controls)
                    if (n is PictureBox)
                        if (Convert.ToString((n as PictureBox).Tag) != "u")
                        {
                            int X1 = Convert.ToInt32((n as PictureBox).Location.X);
                            int Y1 = Convert.ToInt32((n as PictureBox).Location.Y);

                            int X2 = Convert.ToInt32(upitnik2.Location.X);
                            int Y2 = Convert.ToInt32(upitnik2.Location.Y);

                            if (X1 == X2 && Y1 == Y2)
                                if (Convert.ToString((n as PictureBox).Tag) == pomstring)
                                {
                                    upitnik1.Enabled = false;
                                }

                            foreach (Control m in Controls)
                                if (m is PictureBox)
                                    if (Convert.ToString((m as PictureBox).Name) == pomupitnik)
                                    {
                                        (m as PictureBox).Enabled = false;
                                    }
                        }
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
    }
}
