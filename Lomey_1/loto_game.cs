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
    public partial class loto_game : Form
    {
        public loto_game()
        {
            InitializeComponent();
        }
        void unos()
        {
            StreamWriter spisak_dobitnih_brojeva = new StreamWriter("spisak_dobitinih_brojeva.txt", true);
            for (int i = 0; i < 7; i++)
            {
                spisak_dobitnih_brojeva.Write(i+1+"." + dobitni_brojevi[i]+" ");
                if (i == 6)
                {
                    spisak_dobitnih_brojeva.WriteLine();
                    spisak_dobitnih_brojeva.WriteLine("----------------");
                }
            }
            spisak_dobitnih_brojeva.Close();
        }
        
        private void loto_game_Load(object sender, EventArgs e)
        {
            
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            label8.Text = "";
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
        int[] dobitni_brojevi = new int[7];
        int provera1 = 0;
        int provera2 = 0;
        int provera3 = 0;
        int provera4 = 0;
        int provera5 = 0;
        int provera6 = 0;
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Random brojevi = new Random();

            for(int i = 0; i< 7; i++)
            {
                dobitni_brojevi[i] = (brojevi.Next(1,39));
                
                {
                    if (i == 0)
                    {
                        label2.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera1 = dobitni_brojevi[i];
                        
                    }
                    if (i == 1 && dobitni_brojevi[i]!= provera1)
                    {
                        label3.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera2 = dobitni_brojevi[i];
                      
                    }
                    if (i == 2 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2)
                    {
                        label4.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera3 = dobitni_brojevi[i];
                    }
                    if (i == 3 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3)
                    {
                        label5.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera4 = dobitni_brojevi[i];
                    } 
                    if (i == 4 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4)
                    {
                        label6.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera5 = dobitni_brojevi[i];
                    }
                    if (i == 5 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4 && dobitni_brojevi[i] != provera5)
                    {
                        label7.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera6 = dobitni_brojevi[i];
                    }
                    if (i == 6 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4 && dobitni_brojevi[i] != provera5 && dobitni_brojevi[i] != provera6)
                    {
                        label8.Text = Convert.ToString(dobitni_brojevi[i]);
                    }
                    
                }  
            }
        }
        int broj1 = 0;
        int broj2 = 0;
        int broj3 = 0;
        int broj4 = 0;
        int broj5 = 0;
        int broj6 = 0;
        int broj7 = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {

            }
            else
            {
                int broj1 = Convert.ToInt32(textBox1.Text);
                int broj2 = Convert.ToInt32(textBox2.Text);
                int broj3 = Convert.ToInt32(textBox3.Text);
                int broj4 = Convert.ToInt32(textBox4.Text);
                int broj5 = Convert.ToInt32(textBox5.Text);
                int broj6 = Convert.ToInt32(textBox6.Text);
                int broj7 = Convert.ToInt32(textBox7.Text);
            }
        }

        private void loto_game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
                {

                }
                else
                {
                    int broj1 = Convert.ToInt32(textBox1.Text);
                    int broj2 = Convert.ToInt32(textBox2.Text);
                    int broj3 = Convert.ToInt32(textBox3.Text);
                    int broj4 = Convert.ToInt32(textBox4.Text);
                    int broj5 = Convert.ToInt32(textBox5.Text);
                    int broj6 = Convert.ToInt32(textBox6.Text);
                    int broj7 = Convert.ToInt32(textBox7.Text);

                    Random brojevi = new Random();

                    for (int i = 0; i < 7; i++)
                    {
                        dobitni_brojevi[i] = (brojevi.Next(1, 39));

                        {
                            if (i == 0)
                            {
                                label2.Text = Convert.ToString(dobitni_brojevi[i]);
                                provera1 = dobitni_brojevi[i];
                                unos();
                            }
                            if (i == 1 && dobitni_brojevi[i] != provera1)
                            {
                                label3.Text = Convert.ToString(dobitni_brojevi[i]);
                                provera2 = dobitni_brojevi[i];
                            }
                            if (i == 2 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2)
                            {
                                label4.Text = Convert.ToString(dobitni_brojevi[i]);
                                provera3 = dobitni_brojevi[i];
                            }
                            if (i == 3 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3)
                            {
                                label5.Text = Convert.ToString(dobitni_brojevi[i]);
                                provera4 = dobitni_brojevi[i];
                            }
                            if (i == 4 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4)
                            {
                                label6.Text = Convert.ToString(dobitni_brojevi[i]);
                                provera5 = dobitni_brojevi[i];
                            }
                            if (i == 5 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4 && dobitni_brojevi[i] != provera5)
                            {
                                label7.Text = Convert.ToString(dobitni_brojevi[i]);
                                provera6 = dobitni_brojevi[i];
                            }
                            if (i == 6 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4 && dobitni_brojevi[i] != provera5 && dobitni_brojevi[i] != provera6)
                            {
                                label8.Text = Convert.ToString(dobitni_brojevi[i]);
                            }
                        }
                    }
                }

                
            }
        }
    }
}
