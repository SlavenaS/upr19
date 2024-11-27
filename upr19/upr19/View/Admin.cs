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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database11DataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.database11DataSet.Admin);
            // TODO: This line of code loads data into the 'database11DataSet.Gallery' table. You can move, or remove it, as needed.
        //    this.galleryTableAdapter.Fill(this.database11DataSet.Gallery);
            // TODO: This line of code loads data into the 'database11DataSet.Admin' table. You can move, or remove it, as needed.
          //  this.adminTableAdapter.Fill(this.database11DataSet.Admin);

        }
    }
}
