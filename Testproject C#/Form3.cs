using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Testproject_C_
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ComboBox.Items.Add("d MMMM yyyy"); ComboBox.Items.Add("d MM yyyy");
            ComboBox.Items.Add("MMMM dd, yyyy"); ComboBox.Items.Add("dd-MM-yy");
            ComboBox.Items.Add("dd/MM/yyyy");
            ComboBox.Items.Add("dddd, MMMM dd"); ComboBox.Items.Add("hh.mm.ss");
            ComboBox.Items.Add("hh.mm"); ComboBox.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            DateTimeFormatInfo dtInfo;
            string DateStyle = ComboBox.Text; // Get selected format

            // Check which radio button is checked
            if (radioButton2.Checked) // Assuming radioButtonLao is for Lao culture
            {
                CultureInfo laoCulture = new CultureInfo("lo-LA");
                dtInfo = laoCulture.DateTimeFormat;
            }
            else if (radioButton1.Checked) // Assuming radioButtonInvariant is for invariant culture
            {
                dtInfo = DateTimeFormatInfo.InvariantInfo;
            }
            else
            {
                dtInfo = DateTimeFormatInfo.CurrentInfo; // Default to  current culture
            }

            // Format and display the date
            label3.Text = dt.ToString(DateStyle, dtInfo);
        }
    }
}
