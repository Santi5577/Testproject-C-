using _4COM1_IT2024;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testproject_C_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form2());
            //Application.Run(new Form3());
            //Application.Run(new Form6());
            //Application.Run(new FrmLogin());
            //Application.Run(new frmProductType());
            //Application.Run(new tbCustomers());
            Application.Run(new frmProducts());
            //Application.Run(new FrmSupplier());


        }
    }
}
