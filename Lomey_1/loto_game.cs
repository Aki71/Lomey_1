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
                spisak_dobitnih_brojeva.Write(dobitni_brojevi[i] + " ");
                
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
            unos();
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

                            int tacan_1 = Convert.ToInt32(label2.Text);
                            int tacan_2 = Convert.ToInt32(label3.Text);
                            int tacan_3 = Convert.ToInt32(label4.Text);
                            int tacan_4 = Convert.ToInt32(label5.Text);
                            int tacan_5 = Convert.ToInt32(label6.Text);
                            int tacan_6 = Convert.ToInt32(label7.Text);
                            int tacan_7 = Convert.ToInt32(label8.Text);
                            bool tacno = false;
                            if(tacan_1 == broj1 || tacan_1 == broj2 || tacan_1 == broj3 || tacan_1 == broj4 || tacan_1 == broj5 || tacan_1 == broj6 || tacan_1 == broj7 && tacan_2 == broj1 || tacan_2 == broj2 || tacan_2 == broj3 || tacan_2 == broj4 || tacan_2 == broj5 || tacan_2 == broj6 || tacan_2 == broj7 && tacan_3 == broj1 || tacan_3 == broj2 || tacan_3 == broj3 || tacan_3 == broj4 || tacan_3 == broj5 || tacan_3 == broj6 || tacan_3 == broj7 && tacan_4 == broj1 || tacan_4 == broj2 || tacan_4 == broj3 || tacan_4 == broj4 || tacan_4 == broj5 || tacan_4 == broj6 || tacan_4 == broj7 && tacan_5 == broj1 || tacan_5 == broj2 || tacan_5 == broj3 || tacan_5 == broj4 || tacan_5 == broj5 || tacan_5 == broj6 || tacan_5 == broj7 && tacan_6 == broj1 || tacan_6 == broj2 || tacan_6 == broj3 || tacan_6 == broj4 || tacan_6 == broj5 || tacan_6 == broj6 || tacan_6 == broj7 && tacan_7 == broj1 || tacan_7 == broj2 || tacan_7 == broj3 || tacan_7 == broj4 || tacan_7 == broj5 || tacan_7 == broj6 || tacan_7 == broj7)
                            {
                                tacno = true;
                                MessageBox.Show("Pobeda!!!");
                            }
                        }
                    }
                }

                
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader ispis = new StreamReader("spisak_dobitinih_brojeva.txt");
            while (!ispis.EndOfStream)
            {
                string red = ispis.ReadLine();
                listBox1.Items.Add(red);
            }
            ispis.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
