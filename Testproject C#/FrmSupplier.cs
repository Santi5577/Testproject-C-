using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4COM1_IT2024
{
    public partial class FrmSupplier : Form
    {
        string strConnect = @"Data Source=SANTILEE\SQLEXPRESS;Initial Catalog=miniDB_4COM1;Integrated Security=True;";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        SqlDataReader dr;

        public FrmSupplier()
        {
            InitializeComponent();
            connectionDB_Checking();
            getData();
        }

        private void connectionDB_Checking()
        {
            try
            {
                sqlCon = new SqlConnection(strConnect);
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection Error: " + ex.Message);
            }
        }

        private void getData()
        {
            try
            {
                string sql = "SELECT * FROM tbSuppliers";
                sqlCmd = new SqlCommand(sql, sqlCon);
                dr = sqlCmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].HeaderText = "ລະຫັດຜູ້ສະໜອງ";
                dataGridView1.Columns[1].HeaderText = "ຊື່ຜູ້ສະໜອງ";
                dataGridView1.Columns[2].HeaderText = "ຊື່ຜູ້ຕິດຕໍ່";
                dataGridView1.Columns[3].HeaderText = "ທີ່ຢູ່";
                dataGridView1.Columns[4].HeaderText = "ເບີໂທລະສັບ";
                dataGridView1.Columns[5].HeaderText = "ອີເມວ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO tbSuppliers (supplier_id, supplier_name, contract_name, address, telephone, email) VALUES ('"
                     + supplier_id.Text + "', N'"
                     + supplier_name.Text + "', N'"
                     + contract_name.Text + "', N'"
                     + address.Text + "', '"
                     + telephone.Text + "', '"
                     + email.Text + "')";
                sqlCmd = new SqlCommand(sql, sqlCon);
                sqlCmd.ExecuteNonQuery();
                getData();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding record: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "UPDATE tbSuppliers SET supplier_name = N'"
                    + supplier_name.Text + "', contract_name = N'"
                    + contract_name.Text + "', address = N'"
                    + address.Text + "', telephone = '"
                    + telephone.Text + "', email = '"
                    + email.Text + "' WHERE supplier_id = '"
                    + supplier_id.Text + "'";
                sqlCmd = new SqlCommand(sql, sqlCon);
                sqlCmd.ExecuteNonQuery();
                getData();
                clearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating record: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ບໍ່?", "Question", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    string sql = "DELETE FROM tbSuppliers WHERE supplier_id='" + supplier_id.Text + "'";
                    sqlCmd = new SqlCommand(sql, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    getData();
                    clearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting record: " + ex.Message);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    int currentIndex = dataGridView1.CurrentRow.Index;
                    supplier_id.Text = dataGridView1.Rows[currentIndex].Cells[0].Value.ToString();
                    supplier_name.Text = dataGridView1.Rows[currentIndex].Cells[1].Value.ToString();
                    contract_name.Text = dataGridView1.Rows[currentIndex].Cells[2].Value.ToString();
                    address.Text = dataGridView1.Rows[currentIndex].Cells[3].Value.ToString();
                    telephone.Text = dataGridView1.Rows[currentIndex].Cells[4].Value.ToString();
                    email.Text = dataGridView1.Rows[currentIndex].Cells[5].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error selecting record: " + ex.Message);
            }
        }

        private void clearFields()
        {
            supplier_id.Clear();
            supplier_name.Clear();
            contract_name.Clear();
            address.Clear();
            telephone.Clear();
            email.Clear();
            supplier_id.Focus();
        }

        private void FrmSupplier_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (sqlCon != null && sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
        }
    }
}