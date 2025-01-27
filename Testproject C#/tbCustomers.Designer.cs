namespace Testproject_C_
{
    partial class tbCustomers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tbCustomers));
            this.cust_Name = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ShowData = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cust_id = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.sfssf = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.cust_Address = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // cust_Name
            // 
            this.cust_Name.Location = new System.Drawing.Point(202, 211);
            this.cust_Name.Multiline = true;
            this.cust_Name.Name = "cust_Name";
            this.cust_Name.Size = new System.Drawing.Size(358, 36);
            this.cust_Name.TabIndex = 16;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Phetsarath OT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox1.Location = new System.Drawing.Point(2, -5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 64);
            this.textBox1.TabIndex = 11;
            this.textBox1.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ShowData
            // 
            this.ShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShowData.Location = new System.Drawing.Point(21, 381);
            this.ShowData.Name = "ShowData";
            this.ShowData.RowHeadersWidth = 62;
            this.ShowData.RowTemplate.Height = 28;
            this.ShowData.Size = new System.Drawing.Size(1059, 228);
            this.ShowData.TabIndex = 20;
            this.ShowData.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ShowData_CellMouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(754, 326);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(115, 37);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "ລົບຂໍ້ມູນ";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Wheat;
            this.btnEdit.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(503, 326);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 37);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "ແກ້ໄຂຂໍ້ມູນ";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Lime;
            this.btnAdd.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(204, 326);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 37);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "ເພີ່ມຂໍ້ມູນ";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cust_id
            // 
            this.cust_id.Location = new System.Drawing.Point(202, 151);
            this.cust_id.Multiline = true;
            this.cust_id.Name = "cust_id";
            this.cust_id.Size = new System.Drawing.Size(358, 36);
            this.cust_id.TabIndex = 15;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(102, 216);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(70, 31);
            this.name.TabIndex = 14;
            this.name.Text = "ຊື່ລູກຄ້າ";
            // 
            // sfssf
            // 
            this.sfssf.AutoSize = true;
            this.sfssf.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sfssf.Location = new System.Drawing.Point(66, 156);
            this.sfssf.Name = "sfssf";
            this.sfssf.Size = new System.Drawing.Size(106, 31);
            this.sfssf.TabIndex = 13;
            this.sfssf.Text = "ລະຫັດລູກຄ້າ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "ປ້ອນຂໍ້ມູນ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 31);
            this.label2.TabIndex = 21;
            this.label2.Text = "ທີ່ຢູ່";
            // 
            // cust_Address
            // 
            this.cust_Address.Location = new System.Drawing.Point(202, 274);
            this.cust_Address.Multiline = true;
            this.cust_Address.Name = "cust_Address";
            this.cust_Address.Size = new System.Drawing.Size(838, 36);
            this.cust_Address.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Phetsarath OT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(575, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "ເບີໂທລະສັບ";
            // 
            // telephone
            // 
            this.telephone.Location = new System.Drawing.Point(682, 211);
            this.telephone.Multiline = true;
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(358, 36);
            this.telephone.TabIndex = 24;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // tbCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 621);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cust_Address);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cust_Name);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ShowData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cust_id);
            this.Controls.Add(this.name);
            this.Controls.Add(this.sfssf);
            this.Controls.Add(this.label1);
            this.Name = "tbCustomers";
            this.Text = "frmCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.ShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cust_Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView ShowData;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox cust_id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label sfssf;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cust_Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox telephone;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}