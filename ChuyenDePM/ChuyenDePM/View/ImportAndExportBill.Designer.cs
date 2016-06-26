namespace ChuyenDePM.View
{
    partial class ImportAndExportBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_empl = new System.Windows.Forms.Label();
            this.lbl_customer = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_storage = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_billID = new System.Windows.Forms.Label();
            this.txt_emplName = new System.Windows.Forms.TextBox();
            this.txt_emplID = new System.Windows.Forms.TextBox();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.txt_billID = new System.Windows.Forms.TextBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.cb_storage = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_OK = new System.Windows.Forms.Button();
            this.TENVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(12, 9);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(372, 39);
            this.lbl_header.TabIndex = 0;
            this.lbl_header.Text = "Phiếu nhập / xuất vật tư";
            // 
            // lbl_empl
            // 
            this.lbl_empl.AutoSize = true;
            this.lbl_empl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_empl.Location = new System.Drawing.Point(15, 75);
            this.lbl_empl.Name = "lbl_empl";
            this.lbl_empl.Size = new System.Drawing.Size(79, 20);
            this.lbl_empl.TabIndex = 1;
            this.lbl_empl.Text = "Nhân viên";
            // 
            // lbl_customer
            // 
            this.lbl_customer.AutoSize = true;
            this.lbl_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_customer.Location = new System.Drawing.Point(16, 130);
            this.lbl_customer.Name = "lbl_customer";
            this.lbl_customer.Size = new System.Drawing.Size(94, 20);
            this.lbl_customer.TabIndex = 2;
            this.lbl_customer.Text = "Khách hàng";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(481, 77);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(82, 20);
            this.lbl_type.TabIndex = 3;
            this.lbl_type.Text = "Loại phiếu";
            // 
            // lbl_storage
            // 
            this.lbl_storage.AutoSize = true;
            this.lbl_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storage.Location = new System.Drawing.Point(481, 128);
            this.lbl_storage.Name = "lbl_storage";
            this.lbl_storage.Size = new System.Drawing.Size(37, 20);
            this.lbl_storage.TabIndex = 4;
            this.lbl_storage.Text = "Kho";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(769, 24);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(45, 20);
            this.lbl_date.TabIndex = 5;
            this.lbl_date.Text = "Ngày";
            // 
            // lbl_billID
            // 
            this.lbl_billID.AutoSize = true;
            this.lbl_billID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_billID.Location = new System.Drawing.Point(481, 24);
            this.lbl_billID.Name = "lbl_billID";
            this.lbl_billID.Size = new System.Drawing.Size(74, 20);
            this.lbl_billID.TabIndex = 6;
            this.lbl_billID.Text = "Mã phiếu";
            this.lbl_billID.Click += new System.EventHandler(this.lbl_billID_Click);
            // 
            // txt_emplName
            // 
            this.txt_emplName.Enabled = false;
            this.txt_emplName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emplName.Location = new System.Drawing.Point(116, 77);
            this.txt_emplName.Name = "txt_emplName";
            this.txt_emplName.ReadOnly = true;
            this.txt_emplName.Size = new System.Drawing.Size(168, 26);
            this.txt_emplName.TabIndex = 7;
            this.txt_emplName.TextChanged += new System.EventHandler(this.txt_emplName_TextChanged);
            // 
            // txt_emplID
            // 
            this.txt_emplID.Enabled = false;
            this.txt_emplID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emplID.Location = new System.Drawing.Point(290, 77);
            this.txt_emplID.Name = "txt_emplID";
            this.txt_emplID.ReadOnly = true;
            this.txt_emplID.Size = new System.Drawing.Size(100, 26);
            this.txt_emplID.TabIndex = 8;
            // 
            // txt_customer
            // 
            this.txt_customer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_customer.Location = new System.Drawing.Point(116, 130);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(274, 26);
            this.txt_customer.TabIndex = 9;
            // 
            // txt_billID
            // 
            this.txt_billID.Enabled = false;
            this.txt_billID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billID.Location = new System.Drawing.Point(569, 26);
            this.txt_billID.Name = "txt_billID";
            this.txt_billID.ReadOnly = true;
            this.txt_billID.Size = new System.Drawing.Size(172, 26);
            this.txt_billID.TabIndex = 12;
            // 
            // datePick
            // 
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Location = new System.Drawing.Point(820, 24);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(200, 26);
            this.datePick.TabIndex = 13;
            // 
            // cb_storage
            // 
            this.cb_storage.DisplayMember = "MAKHO";
            this.cb_storage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_storage.FormattingEnabled = true;
            this.cb_storage.Location = new System.Drawing.Point(569, 132);
            this.cb_storage.Name = "cb_storage";
            this.cb_storage.Size = new System.Drawing.Size(172, 28);
            this.cb_storage.TabIndex = 14;
            this.cb_storage.ValueMember = "MAKHO";
            // 
            // cb_type
            // 
            this.cb_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Nhập",
            "Xuất"});
            this.cb_type.Location = new System.Drawing.Point(569, 76);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(172, 28);
            this.cb_type.TabIndex = 15;
            this.cb_type.Text = "Nhập";
            this.cb_type.SelectedIndexChanged += new System.EventHandler(this.cb_type_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TENVT,
            this.DVT,
            this.SOLUONG,
            this.DONGIA,
            this.THANHTIEN});
            this.dataGridView1.Location = new System.Drawing.Point(20, 209);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1000, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(945, 462);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 18;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_OK
            // 
            this.btn_OK.Location = new System.Drawing.Point(864, 462);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(75, 23);
            this.btn_OK.TabIndex = 19;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            // 
            // TENVT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TENVT.DefaultCellStyle = dataGridViewCellStyle1;
            this.TENVT.HeaderText = "Mặt hàng";
            this.TENVT.Name = "TENVT";
            this.TENVT.Width = 205;
            // 
            // DVT
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DVT.DefaultCellStyle = dataGridViewCellStyle2;
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            this.DVT.ReadOnly = true;
            this.DVT.Width = 190;
            // 
            // SOLUONG
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.SOLUONG.DefaultCellStyle = dataGridViewCellStyle3;
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 180;
            // 
            // DONGIA
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DONGIA.DefaultCellStyle = dataGridViewCellStyle4;
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 180;
            // 
            // THANHTIEN
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.NullValue = null;
            this.THANHTIEN.DefaultCellStyle = dataGridViewCellStyle5;
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            this.THANHTIEN.Width = 200;
            // 
            // ImportAndExportBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 497);
            this.Controls.Add(this.btn_OK);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_storage);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.txt_billID);
            this.Controls.Add(this.txt_customer);
            this.Controls.Add(this.txt_emplID);
            this.Controls.Add(this.txt_emplName);
            this.Controls.Add(this.lbl_billID);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_storage);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_customer);
            this.Controls.Add(this.lbl_empl);
            this.Controls.Add(this.lbl_header);
            this.Name = "ImportAndExportBill";
            this.Text = "ImportAndExportBill";
            this.Load += new System.EventHandler(this.ImportAndExportBill_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_empl;
        private System.Windows.Forms.Label lbl_customer;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.Label lbl_storage;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_billID;
        private System.Windows.Forms.TextBox txt_emplName;
        private System.Windows.Forms.TextBox txt_emplID;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.TextBox txt_billID;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.ComboBox cb_storage;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
    }
}