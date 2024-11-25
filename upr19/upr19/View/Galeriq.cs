using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace upr19.View
{
    public partial class Galeriq : Form
    {
        public Galeriq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var close = new Form1();
            close.Closed += (s, args) => this.Close();
            close.Show();
        }
    }
}
