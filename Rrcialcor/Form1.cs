using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rrcialcor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Modulo_1 Modulo1 = new Modulo_1();
            Modulo1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Modulo_2 Modulo2 = new Modulo_2();
            Modulo2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Modulo_3 Modulo3 = new Modulo_3();
            //Modulo3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Modulo_4 Modulo4 = new Modulo_4();
            Modulo4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Modulo_5 Modulo5 = new Modulo_5();
            Modulo5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Modulo_6 Modulo6 = new Modulo_6();
            Modulo6.Show();
        }
    }
}
