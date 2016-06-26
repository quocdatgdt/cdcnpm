using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuyenDePM.Controller
{
    class StaffController
    {
        private ConnectServer conn;
        SqlDataReader reader;
        string roleUser;

        public StaffController()
        {
            conn = new ConnectServer(Constants.server, Constants.user, Constants.password);
        }

        public Boolean createStaff(StaffModel staff)
        {
            Boolean result = true;
            conn.cmdSP.CommandText = "mySP_createStaff";
            SqlParameter parameterHo = new SqlParameter("@HO", staff.ho);
            SqlParameter parameterTen = new SqlParameter("@TEN", staff.ten);
            SqlParameter parameterDiachi = new SqlParameter("@DIACHI", staff.diachi);
            SqlParameter parameterNgaysinh = new SqlParameter("@NGAYSINH", staff.ngaysinh);
            SqlParameter parameterLuong = new SqlParameter("@LUONG", staff.luong);
            SqlParameter parameterGhichu = new SqlParameter("@GHICHU", staff.ghichu);

            conn.cmdSP.Parameters.Add(parameterHo);
            conn.cmdSP.Parameters.Add(parameterTen);
            conn.cmdSP.Parameters.Add(parameterDiachi);
            conn.cmdSP.Parameters.Add(parameterNgaysinh);
            conn.cmdSP.Parameters.Add(parameterLuong);
            conn.cmdSP.Parameters.Add(parameterGhichu);
            conn.cmdSP.CommandType = CommandType.StoredProcedure;

            conn.openConnection();
            int a = conn.cmdSP.ExecuteNonQuery();
            //reader = conn.cmdSP.ExecuteReader();
            if (a == 0)
            {
                result = false;
            }
            else
            {
                result = true;
            }

            conn.closeConnection();
            return result;
        }

        public List<StaffModel> getListStaff()
        {
            List<StaffModel> staffs = new List<StaffModel>() { };
            conn.cmdSP.CommandText = "mySP_getListStaff";
            conn.cmdSP.CommandType = CommandType.StoredProcedure;

            conn.openConnection();
            reader = conn.cmdSP.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                DateTime ngaysinh = new DateTime();
                float luong = 0;
                while (reader.Read())
                {
                    StaffModel staff = new StaffModel();
                    staff.manv = reader.GetInt32(0);
                    staff.ho = reader.GetString(1);
                    staff.ten = reader.GetString(2);
                    staff.diachi = reader.GetString(3);

                    ngaysinh = reader.GetDateTime(4);
                    staff.ngaysinh = ngaysinh;
                    luong = (float)(double)reader["LUONG"];
                    staff.luong = luong;
                    if (reader.IsDBNull(6))
                    {
                        staff.ghichu = "";
                    }
                    else
                    {
                        staff.ghichu = reader.GetString(6);
                    }

                    staffs.Add(staff);
                }
            }

            conn.closeConnection();
            return staffs;
        }

        public List<StaffModel> getListStaffNoAccount()
        {
            List<StaffModel> staffs = new List<StaffModel>() { };
            conn.cmdSP.CommandText = "mySP_getListStaffNoAccount";
            conn.cmdSP.CommandType = CommandType.StoredProcedure;
            conn.openConnection();
            reader = conn.cmdSP.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                DateTime ngaysinh = new DateTime();
                float luong = 0;
                while (reader.Read())
                {
                    StaffModel staff = new StaffModel();
                    staff.manv = reader.GetInt32(0);
                    staff.ho = reader.GetString(1);
                    staff.ten = reader.GetString(2);
                    staff.diachi = reader.GetString(3);

                    ngaysinh = reader.GetDateTime(4);
                    staff.ngaysinh = ngaysinh;
                    luong = (float)(double)reader["LUONG"];
                    staff.luong = luong;
                    staff.ghichu = reader.GetString(6);
                    staffs.Add(staff);
                }
            }

            conn.closeConnection();
            return staffs;
        }

        public Boolean createAccountForStaff(string loginName, string password, string user, string role)
        {
            conn.openConnection();
            conn.cmdSP.CommandText = "[dbo].[mySP_createLogin]";
            SqlParameter parameterLoginName = new SqlParameter("@LGNAME", loginName);
            SqlParameter parameterPassWord = new SqlParameter("@PASS", password);
            SqlParameter parameterUser = new SqlParameter("@USRNAME", user);
            SqlParameter parameterRole = new SqlParameter("@ROLE", role);
            conn.cmdSP.Parameters.Add(parameterLoginName);
            conn.cmdSP.Parameters.Add(parameterPassWord);
            conn.cmdSP.Parameters.Add(parameterUser);
            conn.cmdSP.Parameters.Add(parameterRole);
            conn.cmdSP.CommandType = CommandType.StoredProcedure;
            int a = conn.cmdSP.ExecuteNonQuery();
            conn.closeConnection();
            //reader = conn.cmdSP.ExecuteReader();
            if (a == 0)
            {
                return false;
            }
            return true;
        }

        public Boolean updateStaff(StaffModel staff)
        {
            Boolean result = true;
            conn.cmdSP.CommandText = "mySP_updateStaff";
            SqlParameter parameterManv = new SqlParameter("@MANV", staff.manv);
            SqlParameter parameterHo = new SqlParameter("@HO", staff.ho);
            SqlParameter parameterTen = new SqlParameter("@TEN", staff.ten);
            SqlParameter parameterDiachi = new SqlParameter("@DIACHI", staff.diachi);
            SqlParameter parameterNgaysinh = new SqlParameter("@NGAYSINH", staff.ngaysinh);
            SqlParameter parameterLuong = new SqlParameter("@LUONG", staff.luong);
            SqlParameter parameterGhichu = new SqlParameter("@GHICHU", staff.ghichu);

            conn.cmdSP.Parameters.Add(parameterManv);
            conn.cmdSP.Parameters.Add(parameterHo);
            conn.cmdSP.Parameters.Add(parameterTen);
            conn.cmdSP.Parameters.Add(parameterDiachi);
            conn.cmdSP.Parameters.Add(parameterNgaysinh);
            conn.cmdSP.Parameters.Add(parameterLuong);
            conn.cmdSP.Parameters.Add(parameterGhichu);
            conn.cmdSP.CommandType = CommandType.StoredProcedure;

            conn.openConnection();
            roleUser = Constants.roleUser;
            if (roleUser == "Admin")
            {
                int a = conn.cmdSP.ExecuteNonQuery();
                //reader = conn.cmdSP.ExecuteReader();
                if (a == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền thực hiện lệnh này!!");
            }
            conn.closeConnection();
            return result;
        }

        public bool deleteStaff(StaffModel staff)
        {

            Boolean result = true;
            conn.cmdSP.CommandText = "mySP_deleteStaff";
            SqlParameter parameterManv = new SqlParameter("@MANV", staff.manv);

            conn.cmdSP.Parameters.Add(parameterManv);
            conn.cmdSP.CommandType = CommandType.StoredProcedure;

            conn.openConnection();
            roleUser = Constants.roleUser;
            if (roleUser == "Admin")
            {
                int a = conn.cmdSP.ExecuteNonQuery();
                //reader = conn.cmdSP.ExecuteReader();
                if (a == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }

            conn.closeConnection();
            return result;
        }

    }
}
