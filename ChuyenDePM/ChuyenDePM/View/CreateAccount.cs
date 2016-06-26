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
    public partial class CreateAccount : Form
    {
        private StaffController staffController;

        public CreateAccount()
        {
            staffController = new StaffController();
            InitializeComponent();
            initListStaff();
            initListRole();
            
            
        }

        private void initListRole()
        {
            cbBoxRole.Items.Add("Admin");
            cbBoxRole.Items.Add("Nhân viên");
            cbBoxRole.SelectedIndex = 0;
        }

        private void initListStaff()
        {
            cbBoxUsername.Items.Clear();
            List<StaffModel> staffs = staffController.getListStaffNoAccount();
            for (int i = 0; i < staffs.Count; i++)
            {
                StaffModel staff = new StaffModel();
                string firstName = staffs[i].ho;
                string lastName = staffs[i].ten;
                cbBoxUsername.Items.Add(firstName + " " + lastName);
            }
            if (staffs.Count != 0)
            {
                cbBoxUsername.SelectedIndex = 0;
            }
            else
            {
                lbNotification.ForeColor = ForeColor = System.Drawing.Color.Green;
                lbNotification.Text = "Tất cả các nhân viên đều đã có tài khoản!!!";
                
            }
            //CcbBoxUsername.SelectedIndex = 0;
        }

        private void username_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string LoginName = txtLoginName.Text;
            string Password = txtPassword.Text;
            string Username = cbBoxUsername.Text;
            string Role = cbBoxRole.Text;
            MessageBox.Show(Username);

            // set value of Role
            string roleValue = "";
            int id = 0;
            string User = "";

            List<StaffModel> staffs = staffController.getListStaffNoAccount();
            for (int i = 0; i < staffs.Count; i++)
            {
                StaffModel staff = new StaffModel();
                string firstName = staffs[i].ho;
                string lastName = staffs[i].ten;
                string fullName = firstName + " " + lastName;
                if (fullName.Equals(Username))
                {
                    id = staffs[i].manv;
                }
                cbBoxUsername.Items.Add(firstName + " " + lastName);
            }
            User = id.ToString();

            if (cbBoxRole.SelectedIndex == 0)
            {
                roleValue = "Admin";
            }
            else
            {
                roleValue = "Nhanvien";
            }
            try
            {
                Boolean result = staffController.createAccountForStaff(LoginName, Password, User, roleValue);
                if (result==true)
                {
                    initListStaff();
                    txtLoginName.Text = "";
                    txtPassword.Text = "";
                    lbNotification.ForeColor = ForeColor = System.Drawing.Color.Green;
                    lbNotification.Text = "Tạo tài khoản thành công!!!";
                }
                else
                {
                    MessageBox.Show("Tạo tài khoản thất bại!");
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }

        }

        private void panelCreateAcount_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtLoginName_TextClick(object sender, EventArgs e)
        {
            lbNotification.Text = "";
        }

    }
}
