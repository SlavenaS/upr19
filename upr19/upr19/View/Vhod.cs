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
    public partial class Vhod : UserControl
    {
        public Vhod()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="slavena"&&textBox2.Text=="1234")
            {
                this.Hide();
                var admin = new Admin();
                admin.Closed += (s, args) => this.Hide();
                admin.Show();
            }
            else
            {
                MessageBox.Show("ERROR");
            }

        }
    }
}
