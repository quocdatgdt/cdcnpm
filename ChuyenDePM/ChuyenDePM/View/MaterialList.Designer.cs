namespace ChuyenDePM
{
    partial class MaterialList
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
            this.MaterialListPanel = new System.Windows.Forms.Panel();
            this.dgvwList = new System.Windows.Forms.DataGridView();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtcode = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.MaterialListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwList)).BeginInit();
            this.SuspendLayout();
            // 
            // MaterialListPanel
            // 
            this.MaterialListPanel.Controls.Add(this.dgvwList);
            this.MaterialListPanel.Controls.Add(this.btnUndo);
            this.MaterialListPanel.Controls.Add(this.btnExit);
            this.MaterialListPanel.Controls.Add(this.btnDelete);
            this.MaterialListPanel.Controls.Add(this.btnAdd);
            this.MaterialListPanel.Controls.Add(this.btnSave);
            this.MaterialListPanel.Controls.Add(this.btnSearch);
            this.MaterialListPanel.Controls.Add(this.txtcode);
            this.MaterialListPanel.Controls.Add(this.lblSearch);
            this.MaterialListPanel.Location = new System.Drawing.Point(17, 16);
            this.MaterialListPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaterialListPanel.Name = "MaterialListPanel";
            this.MaterialListPanel.Size = new System.Drawing.Size(688, 436);
            this.MaterialListPanel.TabIndex = 0;
            // 
            // dgvwList
            // 
            this.dgvwList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvwList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvwList.Location = new System.Drawing.Point(31, 52);
            this.dgvwList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvwList.Name = "dgvwList";
            this.dgvwList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvwList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvwList.Size = new System.Drawing.Size(624, 305);
            this.dgvwList.TabIndex = 9;
            this.dgvwList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvwList_CellContentClick);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(509, 4);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(100, 28);
            this.btnUndo.TabIndex = 8;
            this.btnUndo.Text = "Hoàn tác";
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(555, 384);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 28);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(379, 384);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(205, 384);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(31, 384);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Ghi lại";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 4);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(55, 28);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(157, 4);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(132, 22);
            this.txtcode.TabIndex = 1;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(27, 10);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 17);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Tìm vật tư có mã: ";
            // 
            // MaterialList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 466);
            this.Controls.Add(this.MaterialListPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MaterialList";
            this.Text = "Danh mục vật tư";
            this.MaterialListPanel.ResumeLayout(false);
            this.MaterialListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvwList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel MaterialListPanel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtcode;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvwList;
    }
}