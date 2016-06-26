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

namespace ChuyenDePM
{
    public partial class MaterialList : Form
    {
        List<Material> listMaterial = new List<Material>() { };
        MaterialController mc;
        Material material;
        AccountModel account = new AccountModel();
        string user;
        string passWord;
        public MaterialList(string user, string passWord)
        {
            this.user = user;
            this.passWord = passWord;
            mc = new MaterialController();
            InitializeComponent();
            init();
            
        }
        public void init()
        {
            dgvwList.DataSource = null;
            listMaterial = mc.getListMaterial();
            dgvwList.DataSource = listMaterial;
        }
        private void dgvwList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            material = new Material();
            material.id = dgvwList.Rows[e.RowIndex].Cells[0].Value.ToString();
            material.name = dgvwList.Rows[e.RowIndex].Cells[1].Value.ToString();
            material.unit = dgvwList.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            account = Constants.TryLogin();
            if (account.accsess == true)
            {
                if (mc.deleteMaterial(material)){
                    Console.Write("Delete successfully!\n");
                    init();
                }
                    
                else
                    Console.Write("Delete failed!\n");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            account = Constants.TryLogin();
            string code = txtcode.Text;
            material = new Material();
            if (account.accsess == true)
            {
                
                dgvwList.DataSource = null;
                dgvwList.DataSource = mc.searchMaterial(code);
            }
        }
    }
}
