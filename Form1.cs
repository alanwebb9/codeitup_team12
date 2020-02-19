using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Device.Location;

namespace ECare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btnsearch_Click(object sender, EventArgs e)
        {
            Form1 Form2 = new Form1();
            //Form2.MdiParent = this;
            Form2.Show();
        }

        private void txtGps_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
