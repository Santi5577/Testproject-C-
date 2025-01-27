using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testproject_C_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("15 + 5 = " + (15 + 5));
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.BackColor = Color.Yellow;
            button4.ForeColor = Color.Red;
            button4.Text = "Calculate";
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Text = "buttom";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.BackColor = Color.White;
            button4.ForeColor = Color.Black;
            button4.Text = "buttom";
        }
    }
}
