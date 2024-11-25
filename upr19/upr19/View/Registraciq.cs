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
    public partial class Registraciq : UserControl
    {
        public Registraciq()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "slavena" && textBox2.Text == "1234"&& textBox3.Text == textBox2.Text)
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
