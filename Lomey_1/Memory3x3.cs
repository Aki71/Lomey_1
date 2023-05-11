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
        
        void Netacno(string ime)
        {
            
        }

        private void klik(object sender, MouseEventArgs e)
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
            foreach (Control n in Controls)
                if (n is PictureBox)
                    if (Convert.ToString((n as PictureBox).Tag) == "u")
                    {
                        (n as PictureBox).Show();
                        (n as PictureBox).Enabled = true;
                    }
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
