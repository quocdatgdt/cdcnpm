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
    public partial class Home : Form
    {
        public static SqlConnection con;
        public Home()
        {
            InitializeComponent();
            Constants.server = "QUOCDAT";
        }

        private void btn_DN_Click(object sender, EventArgs e)
        {
           
            if (input_MK.Text == "")
            {
                lbRole.Text = "Nhập Mật Khẩu";
            }
            if (input_TK.Text == "")
            {
                lbRole.Text = "Nhập Tài Khoản.";
            }
            if (input_MK.Text != "" && input_TK.Text != "")
            {
                AccountModel account = new AccountModel();
                Constants.user = input_TK.Text;
                Constants.password = input_MK.Text;
                account = Constants.TryLogin();
                if (account.accsess == true)
                {
                    lbRole.ForeColor = System.Drawing.ColorTranslator.FromHtml("#2196F3"); ;
                    lbRole.Text = account.userName + " : " + account.role;
                    input_TK.Text = "";
                    input_MK.Text = "";
                    Login.Visible = false;
                    panelMain.Visible = true;
                    menu.Visible = true;
                    //Console.WriteLine(account.role);
                    if (account.role.Equals("Nhanvien"))
                    {
                        nhanVientoolStripMenuItem.Enabled = false;
                        nhapKhoToolStripMenuItem.Enabled = false;
                        taoTaiKhoanToolStripMenuItem.Enabled = false;
                        duLieuToolStripMenuItem.Enabled = false;
                    }
                    else
                    {
                        nhanVientoolStripMenuItem.Enabled = true;
                        nhapKhoToolStripMenuItem.Enabled = true;
                        taoTaiKhoanToolStripMenuItem.Enabled = true;
                        duLieuToolStripMenuItem.Enabled = true;
                    }

                }
                else
                {
                    lbRole.Text = "Tài Khoản Hoặc Mật Khẩu Không Đúng.";
                }
            }
        }

        private void ThoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login.Visible = true;
            panelMain.Visible = false;
            menu.Visible = false;
            lbRole.Text = "";
        }

        private void NhapVatTuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            MaterialList materialList = new MaterialList(Constants.user, Constants.password);
            materialList.TopLevel = false;
            materialList.Visible = true;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(materialList.MaterialListPanel);
        }

        private void nhapNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            InputListStaff inputListStaff = new InputListStaff();
            inputListStaff.TopLevel = false;
            inputListStaff.Visible = true;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(inputListStaff.panelThemNhanVien);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void taoTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            CreateAccount createAccount = new CreateAccount();
            createAccount.TopLevel = false;
            createAccount.Visible = true;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(createAccount.panelCreateAcount);
        }

        private void phiếuXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ImportAndExportBill bill = new ImportAndExportBill();
            bill.ShowDialog();
        }

        private void danhSachNhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelMain.Visible = true;
            ListStaff listStaff = new ListStaff();
            listStaff.TopLevel = false;
            listStaff.Visible = true;
            panelMain.Controls.Clear();
            panelMain.Controls.Add(listStaff.panelListStaff);
        }

    }
}
