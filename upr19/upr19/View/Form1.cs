using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using upr19.View;

namespace upr19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            vhod1.Hide();
            registraciq1.Hide();
            zaNas1.Hide();
        }

        private void галериаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var gallery = new Galeriq();
            gallery.Closed += (s, args) => this.Close();
            gallery.Show();
        }

        private void услугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var uslugi = new Uslugi();
            uslugi.Closed += (s, args) => this.Close();
            uslugi.Show();
        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Hide();
            registraciq1.Hide();
            zaNas1.Show();

            zaNas1.BringToFront();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Hide();
            registraciq1.Hide();
            zaNas1.Hide();
        }

        private void входToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Show();
            registraciq1.Hide();
            zaNas1.Hide();

            vhod1.BringToFront();
        }

        private void регистрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vhod1.Hide();
            registraciq1.Show();
            zaNas1.Hide();

            registraciq1.BringToFront();
        }
    }
}
