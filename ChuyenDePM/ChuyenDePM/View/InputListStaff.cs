using ChuyenDePM.Controller;
using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDePM
{

    public partial class InputListStaff : Form
    {

        StaffModel staff = new StaffModel();
        StaffController staffController;
        AccountModel account = new AccountModel();

        public InputListStaff()
        {
            staffController = new StaffController();
            InitializeComponent();
            this.Text = "Thêm nhân viên";
        }

        private void input_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            String ho = input_ho.Text;
            String ten = input_ten.Text;
            String diachi = input_diachi.Text;
            DateTime ngaysinh = input_ngaysinh.Value;
            float luong = float.Parse(input_luong.Text);
            String ghichu = input_ghichu.Text;
            staff = new StaffModel();
            staff.ho = ho;
            staff.ten = ten;
            staff.diachi = diachi;
            staff.ngaysinh = ngaysinh;
            staff.luong = luong;
            staff.ghichu = ghichu;

                Boolean result = staffController.createStaff(staff);
                if (result == true)
                {
                    MessageBox.Show("Tạo nhân viên thành công!!");
                    input_ho.Text = "";
                    input_ten.Text = "";
                    input_diachi.Text = "";
                    input_luong.Text = "";
                    input_ghichu.Text = "";
                }
                else
                {
                    MessageBox.Show("Tạo nhân viên thất bại!!");
                }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
