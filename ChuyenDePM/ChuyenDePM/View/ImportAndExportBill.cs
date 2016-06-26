using ChuyenDePM.Controller;
using ChuyenDePM.Model;
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

namespace ChuyenDePM.View
{
    public partial class ImportAndExportBill : Form
    {
        private AccountModel account;
        private StorageController storageCtrl;
        private BillController billCtrl;
        private MaterialController materialCtrl;
        private List<Material> listMaterial;
        private List<string> listNameMaterial;

        public ImportAndExportBill()
        {
            storageCtrl = new StorageController();
            billCtrl = new BillController();
            materialCtrl = new MaterialController();
            listMaterial = materialCtrl.getListMaterial();
            listNameMaterial = new List<string>();
            foreach (Material model in listMaterial)
            {
                listNameMaterial.Add(model.name);
            }
            account = Constants.TryLogin();
            if (!account.accsess)
            {
                this.Close();
            }
            InitializeComponent();
        }
        private void txt_emplName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_billID_Click(object sender, EventArgs e)
        {

        }


        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ImportAndExportBill_Load(object sender, EventArgs e)
        {
            List<StorageModel> listStorage = storageCtrl.getListStorage();
            List<string> listNameStorage = new List<string>();
            foreach (StorageModel model in listStorage)
            {
                listNameStorage.Add(model.name);
            }
            this.cb_storage.DataSource = listNameStorage;
            string lastBillID = billCtrl.getLastBillID(this.cb_type.Text);
            string[] split = lastBillID.Split('_');
            int IDNumber = int.Parse(split[1]);
            IDNumber++;
            lastBillID = split[0] + "_" + IDNumber;
            this.txt_billID.Text = lastBillID;
            this.txt_emplName.Text = Constants.userName;
            this.txt_emplID.Text = Constants.userID.ToString();
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            string lastBillID = billCtrl.getLastBillID(this.cb_type.Text);
            string[] split = lastBillID.Split('_');
            int IDNumber = int.Parse(split[1]);
            IDNumber++;
            lastBillID = split[0] + "_" + IDNumber;
            this.txt_billID.Text = lastBillID;
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 0)
            {
                TextBox prodCode = e.Control as TextBox;
                if (prodCode != null)
                {
                    prodCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    prodCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    var autoComplete = new AutoCompleteStringCollection();
                    autoComplete.AddRange(listNameMaterial.ToArray());
                    prodCode.AutoCompleteCustomSource = autoComplete;

                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("TENVT"))
            {
                foreach (Material model in listMaterial)
                {
                    if (model.name.Equals(dataGridView1[e.ColumnIndex, e.RowIndex].Value))
                    {
                        dataGridView1[e.ColumnIndex + 1, e.RowIndex].Value = model.unit;
                        break;
                    }
                }
            }
        }

    }
}
