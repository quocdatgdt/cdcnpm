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
    public partial class ListStaff : Form
    {

        private ConnectServer conn;

        List<StaffModel> listStaff = new List<StaffModel>() { };
        StaffModel staff = new StaffModel();
        StaffController staffController;
        AccountModel account = new AccountModel();

        public ListStaff()
        {
            InitializeComponent();
            
            staffController = new StaffController();
            initCommon();
            conn = new ConnectServer(Constants.server, Constants.user, Constants.password);
            initListStaff();
        }

        public void initCommon()
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            // init value for combobox in search
            searchCategory.Items.Add("Mã nhân viên");
            searchCategory.Items.Add("Họ tên");
            searchCategory.SelectedIndex = 0;
        }

        private void initListStaff()
        {
            //staffController.showDataListStaff(tableListStaff);
            tableListStaff.DataSource = null;
            listStaff = staffController.getListStaff();
            tableListStaff.DataSource = listStaff;
        }

        private void panelListStaff_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableListStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            showInfoStaff(e.RowIndex);
            btnCreate.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            //btnCreate.Visible = false;
        }

        public void showInfoStaff(int index)
        {
            idStaff.Text = tableListStaff.Rows[index].Cells[0].Value.ToString();
            txtFirstName.Text = tableListStaff.Rows[index].Cells[1].Value.ToString();
            txtLastName.Text = tableListStaff.Rows[index].Cells[2].Value.ToString();
            txtAddress.Text = tableListStaff.Rows[index].Cells[3].Value.ToString();
            txtBirthDay.Text = tableListStaff.Rows[index].Cells[4].Value.ToString();
            txtSalary.Text = tableListStaff.Rows[index].Cells[5].Value.ToString();
            txtDesc.Text = tableListStaff.Rows[index].Cells[6].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idStaff.Text);
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Address = txtAddress.Text;
            DateTime birthday = DateTime.Parse(txtBirthDay.Text);
            float Salary = float.Parse(txtSalary.Text);
            string Desc = txtDesc.Text;
            StaffModel staff = new StaffModel();
            staff.manv = id;
            staff.ho = FirstName;
            staff.ten = LastName;
            staff.diachi = Address;
            staff.ngaysinh = birthday;
            staff.luong = Salary;
            staff.ghichu = Desc;
            account = Constants.TryLogin();
            if (account.accsess == true)
            {
                if (validateForm())
                {
                    Boolean result = staffController.updateStaff(staff);
                    if (result == true)
                    {
                        try
                        {
                            initListStaff();
                            ResetForm();
                            lbNotification.ForeColor = ForeColor = System.Drawing.Color.Green;
                            lbNotification.Text = "Cập nhật nhân viên mới thành công!!!";
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show(E.ToString());
                        }

                    }
                    else
                    {
                        lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                        lbNotification.Text = "Cập nhật nhân viên mới thất bại!!!";
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Bạn không còn quyền thực hiện lệnh này!!!");
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            int modeSearch = searchCategory.SelectedIndex;
            if (modeSearch == 0)
            {
                Boolean check = false;
                tableListStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in tableListStaff.Rows)
                    {
                        if (row.Cells[0].Value.ToString().Equals(searchValue))
                        {
                            row.Selected = true;
                            check = true;
                            showInfoStaff(row.Index);
                            break;
                        }
                    }
                    if (check == false)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!!");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            else if (modeSearch == 1)
            {
                Boolean check = false;
                tableListStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                try
                {
                    foreach (DataGridViewRow row in tableListStaff.Rows)
                    {
                        string fullName = row.Cells[1].Value.ToString() + " " + row.Cells[2].Value.ToString();
                        if (fullName.Equals(searchValue))
                        {
                            row.Selected = true;
                            check = true;
                            showInfoStaff(row.Index);
                            break;
                        }
                    }
                    if (check == false)
                    {
                        MessageBox.Show("Không tìm thấy nhân viên!!");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(idStaff.Text);
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Address = txtAddress.Text;
            DateTime birthday = DateTime.Parse(txtBirthDay.Text);
            float Salary = float.Parse(txtSalary.Text);
            string Desc = txtDesc.Text;
            StaffModel staff = new StaffModel();
            staff.manv = id;
            staff.ho = FirstName;
            staff.ten = LastName;
            staff.diachi = Address;
            staff.ngaysinh = birthday;
            staff.luong = Salary;
            staff.ghichu = Desc;

            if (Constants.userID == id)
            {
                MessageBox.Show("Không thể xóa tài khoản đang login hiện tại!!!");
            }
            else
            {
                if (account.accsess == true)
                {
                    account = Constants.TryLogin();
                    if (account.accsess == true)
                    {
                        Boolean result = staffController.deleteStaff(staff);
                        if (result == true)
                        {
                            ResetForm();
                            lbNotification.ForeColor = ForeColor = System.Drawing.Color.Green;
                            lbNotification.Text = "Xóa nhân viên mới thành công!!!";
                            initListStaff();

                        }
                        else
                        {
                            lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                            lbNotification.Text = "Xóa nhân viên mới thất bại!!!";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không còn quyền thực hiện lệnh này!!!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn đã không còn trong hệ thống!!!");
                }
            }
        }

        public void ResetForm()
        {
            idStaff.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtAddress.Text = "";
            //txtBirthDay.Text = DateTime.MinValue.ToString();
            txtSalary.Text = "";
            txtDesc.Text = "";
            btnCreate.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            lbNotification.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        public Boolean validateForm()
        {
            string FirstName = txtFirstName.Text;
            string LastName = txtLastName.Text;
            string Address = txtAddress.Text;
            DateTime birthday = DateTime.Parse(txtBirthDay.Text);
            string getSalary = txtSalary.Text;

            if (getSalary.Equals(""))
            {
                txtSalary.Focus();
                lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                lbNotification.Text = "Lương nhân viên không được bỏ trống!";
                return false;
            }
            else
            {
                float Salary = float.Parse(getSalary);
            }
            
            string Desc = txtDesc.Text;

            if (FirstName.Equals(""))
            {
                txtFirstName.Focus();
                lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                lbNotification.Text = "Họ nhân viên không được bỏ trống!";
                return false;
            }
            if (LastName.Equals(""))
            {
                txtLastName.Focus();
                lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                lbNotification.Text = "Tên nhân viên không được bỏ trống!";
                return false;
            }
            if (Address.Equals(""))
            {
                txtAddress.Focus();
                lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                lbNotification.Text = "Địa chỉ nhân viên không được bỏ trống!";
                return false;
            }

            return true;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                string FirstName = txtFirstName.Text;
                string LastName = txtLastName.Text;
                string Address = txtAddress.Text;
                DateTime birthday = DateTime.Parse(txtBirthDay.Text);
                float Salary = float.Parse(txtSalary.Text);
                string Desc = txtDesc.Text;
                StaffModel staff = new StaffModel();

                staff.ho = FirstName;
                staff.ten = LastName;
                staff.diachi = Address;
                staff.ngaysinh = birthday;
                staff.luong = Salary;
                staff.ghichu = Desc;

                account = Constants.TryLogin();
                if (account.accsess == true)
                {

                    Boolean result = staffController.createStaff(staff);
                    if (result == true)
                    {
                        initListStaff();
                        ResetForm();
                        lbNotification.ForeColor = ForeColor = System.Drawing.Color.Green;
                        lbNotification.Text = "Tạo nhân viên mới thành công!!!";
                    }
                    else
                    {
                        lbNotification.ForeColor = ForeColor = System.Drawing.Color.Red;
                        lbNotification.Text = "Tạo nhân viên mới thất bại!!!";
                    }

                }
                else
                {
                    MessageBox.Show("Bạn không còn quyền thực hiện lệnh này!!!");
                }
            }
        }
    }
}
