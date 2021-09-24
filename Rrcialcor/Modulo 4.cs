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
    public partial class Modulo_4 : Form
    {
        public Modulo_4()
        {
            InitializeComponent();
        }
        string invertir;
        public string Reverse(string textBox1)
        {
            char[] cArray = textBox1.ToCharArray();
            string invertir = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                invertir += cArray[i];
            }
            return invertir;
            textBox2.Text = invertir.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
