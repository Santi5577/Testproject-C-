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
    public partial class tbCustomers : Form
    {
        string strConnect = @"Data Source=SANTILEE\SQLEXPRESS;Initial Catalog=miniDB_4COM1;Integrated Security=True;";
        SqlConnection conn = null;
        SqlCommand cmd = null;
        SqlDataReader dr;
        SqlDataAdapter dar = null;
        public tbCustomers()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }

        private void getData() {
            string sql = "select * from tbCustomers";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            ShowData.DataSource = dt;
            ShowData.Columns[0].HeaderText = "ລະຫັດລູກຄ້າ";
            ShowData.Columns[1].HeaderText = "ຊື່ລູກຄ້າ";
            ShowData.Columns[2].HeaderText = "ທີ່ຢູ່";
            ShowData.Columns[3].HeaderText = "ເບີໂທລະສັບ";
        }

        private void connectionDB_Checking()
        {
            conn = new SqlConnection(strConnect);
            conn.Open();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO tbCustomers (cust_id, cust_Name, cust_Address, telephone) VALUES ('"
                 + cust_id.Text + "', N'"
                 + cust_Name.Text + "', N'"
                 + cust_Address.Text + "', '"
                 + telephone.Text + "')";

            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE tbCustomers SET cust_Name = N'"
               + cust_Name.Text + "', cust_Address = N'"
               + cust_Address.Text + "', telephone = '"
               + telephone.Text + "' WHERE cust_id = '"
               + cust_id.Text + "'";

            cmd = new SqlCommand(@sql, conn);
            cmd.ExecuteNonQuery();
            getData();
        }

        private void ShowData_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = ShowData.CurrentRow.Index;
            cust_id.Text = ShowData.Rows[cindex].Cells[0].Value.ToString();
            cust_Name.Text = ShowData.Rows[cindex].Cells[1].Value.ToString();
            cust_Address.Text = ShowData.Rows[cindex].Cells[2].Value.ToString();
            telephone.Text = ShowData.Rows[cindex].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                string sql = "delete from tbCustomers  where cust_id='" + cust_id.Text + "'";
                cmd = new SqlCommand(@sql, conn);
                cmd.ExecuteNonQuery();
                getData();
            }
        }
    }
   }
