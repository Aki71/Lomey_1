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

        public List<int> Brojevi { get; set; } = new List<int>();
        public List<int> IzvuceniBrojevi { get; set; } = new List<int>();
        public loto_game()
        {
            InitializeComponent();
        }
        void unos(string dobitniBrojevi)
        {
            StreamWriter spisak_dobitnih_brojeva = new StreamWriter("spisak_dobitinih_brojeva.txt", true);


            spisak_dobitnih_brojeva.Write(dobitniBrojevi);
            spisak_dobitnih_brojeva.WriteLine();
            spisak_dobitnih_brojeva.WriteLine("----------------");
            spisak_dobitnih_brojeva.Close();
        }

        private void loto_game_Load(object sender, EventArgs e)
        {

            rndbr0.Text = "";
            rndbr1.Text = "";
            rndbr2.Text = "";
            rndbr3.Text = "";
            rndbr4.Text = "";
            rndbr5.Text = "";
            rndbr6.Text = "";

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
            novac = Convert.ToInt32(textBox8.Text);
            StreamReader novac_potrosen = new StreamReader("coin.txt");
            int trenutnoPara = Convert.ToInt32(novac_potrosen.ReadLine());
            novac_potrosen.Close();
            if (novac < 0)
            {
                novac *= -1;
            }
            else if (novac < 100)
            {
                MessageBox.Show("Input value must be over 100");
                return;
            }
            if (novac >= trenutnoPara)
            {
                MessageBox.Show("You don't have enough money.");
                novac_potrosen.Close();
                return;

            }

            trenutnoPara -= novac;
            File.WriteAllText("coin.txt", Convert.ToString(trenutnoPara));
            
             

            Random brojevi = new Random();

            do
            {
                int rndBroj = (brojevi.Next(1, 39));
                var vecPostoji = IzvuceniBrojevi.Where(a => a == rndBroj).ToList();
                if (vecPostoji.Count == 0)
                {
                    IzvuceniBrojevi.Add(rndBroj);
                }
            } while (IzvuceniBrojevi.Count < 7);


            //rndbr6
            List<Label> labele = new List<Label>();

            foreach (var control in Controls)
            {
                if (control.GetType().Name == "Label")
                {
                    if ((control as Label).Name.ToLower().Contains("rndbr"))
                    {
                        labele.Add(control as Label);
                    }
                }
            }


            for (int i = 0; i < IzvuceniBrojevi.Count; i++)
            {
                string imeLabele = $"rndbr{i}";

                Label lblPisi = labele.FirstOrDefault(a => a.Name == imeLabele);
                if (lblPisi != null)
                {
                    lblPisi.Text = IzvuceniBrojevi[i].ToString();
                }
            }


            string izvuceniBrojevi  = string.Join(" ", IzvuceniBrojevi);
            unos(izvuceniBrojevi);

            List<int> pogodjeni = IzvuceniBrojevi.Where(a => Brojevi.Contains(a)).ToList();
            string pogodjeniBrojevi = $"Correct numbers: {string.Join(" ", pogodjeni)}";
            unos(pogodjeniBrojevi);

            IzvuceniBrojevi = new List<int>();
            Brojevi = new List<int>();

            return;

            for (int i = 0; i < 7; i++)
            {


                {
                    if (i == 0)
                    {
                        rndbr0.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera1 = dobitni_brojevi[i];

                    }
                    if (i == 1 && dobitni_brojevi[i] != provera1)
                    {
                        rndbr1.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera2 = dobitni_brojevi[i];

                    }
                    if (i == 2 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2)
                    {
                        rndbr2.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera3 = dobitni_brojevi[i];
                    }
                    if (i == 3 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3)
                    {
                        rndbr3.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera4 = dobitni_brojevi[i];
                    }
                    if (i == 4 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4)
                    {
                        rndbr4.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera5 = dobitni_brojevi[i];
                    }
                    if (i == 5 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4 && dobitni_brojevi[i] != provera5)
                    {
                        rndbr5.Text = Convert.ToString(dobitni_brojevi[i]);
                        provera6 = dobitni_brojevi[i];
                    }
                    if (i == 6 && dobitni_brojevi[i] != provera1 && dobitni_brojevi[i] != provera2 && dobitni_brojevi[i] != provera3 && dobitni_brojevi[i] != provera4 && dobitni_brojevi[i] != provera5 && dobitni_brojevi[i] != provera6)
                    {
                        rndbr6.Text = Convert.ToString(dobitni_brojevi[i]);
                    }

                }
            }
            //unos();
        }
        int broj1 = 0;
        int broj2 = 0;
        int broj3 = 0;
        int broj4 = 0;
        int broj5 = 0;
        int broj6 = 0;
        int broj7 = 0;
        int novac = 0;

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {

            }
            else
            {
                button1.Enabled = true;
                broj1 = Convert.ToInt32(textBox1.Text);
                broj2 = Convert.ToInt32(textBox2.Text);
                broj3 = Convert.ToInt32(textBox3.Text);
                broj4 = Convert.ToInt32(textBox4.Text);
                broj5 = Convert.ToInt32(textBox5.Text);
                broj6 = Convert.ToInt32(textBox6.Text);
                broj7 = Convert.ToInt32(textBox7.Text);

                Brojevi.Add(broj1);
                Brojevi.Add(broj2);
                Brojevi.Add(broj3);
                Brojevi.Add(broj4);
                Brojevi.Add(broj5);
                Brojevi.Add(broj6);
                Brojevi.Add(broj7);


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


                    Random brojevi = new Random();

                    for (int i = 0; i < 7; i++)
                    {

                        int rndBroj = (brojevi.Next(1, 39));
                        var vecPostoji = IzvuceniBrojevi.FirstOrDefault(a => a == rndBroj);
                        if (vecPostoji == null)
                        {
                            IzvuceniBrojevi.Add(rndBroj);
                        }
                    }

                    foreach (var control in Controls)
                    {
                        if (control.GetType().Name.ToLower().Contains("label"))
                        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
