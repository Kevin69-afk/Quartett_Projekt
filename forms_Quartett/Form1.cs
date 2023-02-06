using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms_Quartett
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int category = 0;



        private void buttonPS_Click(object sender, EventArgs e)
        {
            category = 1;
        }

        private void buttonKmH_Click(object sender, EventArgs e)
        {
            category = 2;
        }

        private void buttonMaxSpd_Click(object sender, EventArgs e)
        {
            category = 3;
        }

        private void buttonWert_Click(object sender, EventArgs e)
        {
            category = 4;
        }

        private void buttonGewicht_Click(object sender, EventArgs e)
        {
            category = 5;
        }

        private void buttonBaujahr_Click(object sender, EventArgs e)
        {
            category = 6;
        }
    }
}
