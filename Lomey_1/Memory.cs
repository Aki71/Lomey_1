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
    public partial class Memory : Form
    {
        public Memory()
        {
            InitializeComponent();
        }

        private void trixtri(object sender, MouseEventArgs e)
        {
            memory3x31.Show();
        }

        private void Memory_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            memory4x41.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            memory5x51.Show();
        }

        private void Memory_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
