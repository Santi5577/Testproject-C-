using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Testproject_C_
{
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        string pid = "";
        SqlConnection sqlCon = null;
        SqlCommand sqlCmd = null;
        string strConn = @"Data Source=SANTILEE\SQLEXPRESS;Initial Catalog=miniDB_4COM1;Integrated Security=True";
        private void frmProducts_Load(object sender, EventArgs e)
        {
            sqlCon = new SqlConnection(strConn);
            sqlCon.Open();
            sqlCmd = new SqlCommand("select * from tbProductType", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dtPT = new DataTable();
            dtPT.Load(sqlDr);
            cboType.DataSource = dtPT;
            cboType.DisplayMember = "ptType_name";
            cboType.ValueMember = "ptTypr_ID";
            showData();
        }
        private void showData()
        {
            sqlCmd = new SqlCommand("select * from tbProducts", sqlCon);
            SqlDataReader sqlDr = sqlCmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sqlDr);
            dgvShowdata.DataSource = dt;
            dgvShowdata.Columns[0].HeaderText = "ລຳດັບ";
            dgvShowdata.Columns[0].Visible = false;
            dgvShowdata.Columns[1].HeaderText = "ລະຫັດສິນຄ້າ";
            dgvShowdata.Columns[2].HeaderText = "ຊື່ສິນຄ້າ";
            dgvShowdata.Columns[3].HeaderText = "ຈຳນວນ";
            dgvShowdata.Columns[4].HeaderText = "ລາຄາຕໍ່ໜ່ວຍ";
            dgvShowdata.Columns[5].HeaderText = "ຫົວໜ່ວຍ";
            dgvShowdata.Columns[6].HeaderText = "ເກນສິນຄ້າເຫຼືອ";
            dgvShowdata.Columns[7].HeaderText = "ຮູບພາບ";
            dgvShowdata.Columns[8].HeaderText = "ປະເພດສິນຄ້າ";
            dgvShowdata.Columns[9].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] btimg = ms.GetBuffer();
            string sqlstr = "insert into tbProducts(pro_id,pro_name,qty,price,unit,ptType_ID,instock,pro_img) values(@pro_id,@pro_name,@qty,@price,@unit,@ptType_ID,@instock,@pro_img)";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@pro_id", txtProNo.Text);
            sqlCmd.Parameters.AddWithValue("@pro_name", txtProName.Text);
            sqlCmd.Parameters.AddWithValue("@qty", txtQty.Text);
            sqlCmd.Parameters.AddWithValue("@price", txtPrice.Text);
            sqlCmd.Parameters.AddWithValue("@unit", txtUnit.Text);
            sqlCmd.Parameters.AddWithValue("@ptType_ID", txtInstock.Text);
            sqlCmd.Parameters.AddWithValue("@instock", btimg);
            sqlCmd.Parameters.AddWithValue("@pro_img", cboType.SelectedValue);
            sqlCmd.ExecuteNonQuery();
            showData();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFdl = new OpenFileDialog();
            opFdl.Filter =" Image Files (* .png;* .jpg;* .gif)|* .png;* .jpg;* .gif";
            if (opFdl.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opFdl.FileName);
            }
        }
        private void dgvShowdata_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int cindex = dgvShowdata.CurrentRow.Index;
            //pid = dgvShowdata.Rows[cindex].Cells[0].Value.ToString();
            txtProNo.Text = dgvShowdata.Rows[cindex].Cells[0].Value.ToString();
            txtProName.Text = dgvShowdata.Rows[cindex].Cells[1].Value.ToString();
            txtQty.Text = dgvShowdata.Rows[cindex].Cells[2].Value.ToString();
            txtPrice.Text = dgvShowdata.Rows[cindex].Cells[3].Value.ToString();
            txtUnit.Text = dgvShowdata.Rows[cindex].Cells[4].Value.ToString();
            txtInstock.Text = dgvShowdata.Rows[cindex].Cells[5].Value.ToString();
            var img = (byte[])dgvShowdata.Rows[cindex].Cells[7].Value;
            MemoryStream ms = new MemoryStream(img);
            pictureBox1.Image = Image.FromStream(ms);
            cboType.SelectedValue = dgvShowdata.Rows[cindex].Cells[6].Value.ToString();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ທ່ານຕ້ອງການລົບຂໍ້ມູນນີ້ຫຼືບໍ່?", "Question",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sqlstr = "Delete from tbProducts where pro_id='" + txtProNo.Text + "'";
                sqlCmd = new SqlCommand(sqlstr, sqlCon);
                sqlCmd.ExecuteNonQuery();
                showData();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            byte[] btimg = ms.GetBuffer();
            string sqlstr = "Update tbproducts set pro_name=@productName,qty=@Quantity,price=@UnitPrice,unit=@Units,ptType_ID=@Instock,instock=@picture,pro_img=@productTypeid where proid='" + txtProNo.Text + "'";
            sqlCmd = new SqlCommand(sqlstr, sqlCon);
            sqlCmd.Parameters.AddWithValue("@productName", txtProName.Text);
            sqlCmd.Parameters.AddWithValue("@Quantity", txtQty.Text);
            sqlCmd.Parameters.AddWithValue("@UnitPrice", txtPrice.Text);
            sqlCmd.Parameters.AddWithValue("@Units", txtUnit.Text);
            sqlCmd.Parameters.AddWithValue("@Instock", txtInstock.Text);
            sqlCmd.Parameters.AddWithValue("@picture", btimg);
            sqlCmd.Parameters.AddWithValue("@productTypeid", cboType.SelectedValue);
            sqlCmd.ExecuteNonQuery();
            showData();
        }
    }
}
