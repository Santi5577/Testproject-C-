using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testproject_C_
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        string strConnect = @"Data Source=SANTILEE\SQLEXPRESS;Initial Catalog=miniDB_4COM1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string pwd = txtPwd.Text;
            string sql = "select * from tbusers where userName='" + username + "' and password_code='" + pwd + "'";
            conn = new SqlConnection(strConnect);
            conn.Open();
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            if (dt.Rows.Count != 0)
            {
                MessageBox.Show("ຍີນດີຕ້ອນຮັບທ່ານເຂົ້າສູ່ລະບົບ");
                FrmMainMenu frm = new FrmMainMenu();
                frm.Show();
                frm.WindowState = FormWindowState.Maximized;
                this.Hide();
            }
            else
            {
                MessageBox.Show("ຊື່ຜູ້ໃຊ້ລະບົບ ຫຼື ລະຫັດບໍ່ຖືກຕ້ອງ!");
            }
        }
    }
}
