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

        private void triputatri(object sender, EventArgs e)
        {
            Form Memory3x3 = new Memory3x3();
            Memory3x3.Show();
            this.Hide();
        }
    }
}
