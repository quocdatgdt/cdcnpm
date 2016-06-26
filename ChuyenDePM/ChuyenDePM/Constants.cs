using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM
{
    class Constants
    {
        public static string user { get; set; }
        public static int userID { get; set; }
        public static string password { get; set; }
        public static string userName { get; set; }
        public static string server { get; set; }
        public static string roleUser { get; set; }
        public static AccountModel TryLogin()
        {
            AccountModel account = new AccountModel();
            account.user = Constants.user;
            account.password = Constants.password;
            ConnectServer conn = new ConnectServer(server, user, password);
            try
            {
                SqlParameter parameter = new SqlParameter("@LGNAME", user);
                conn.cmdSP.CommandText = "mySP_getInfoUser";
                conn.cmdSP.Parameters.Add(parameter);
                conn.openConnection();

                SqlDataReader dr = conn.cmdSP.ExecuteReader();
                if (dr.Read())
                {
                    account.role = dr["ROLES"].ToString();
                    account.userName = "" + dr["HOTEN"].ToString();
                    account.userID = (int)dr["MANV"];
                    account.accsess = true;
                    Constants.userID = account.userID;
                    Constants.userName = account.userName;
                    Constants.user = account.user;
                    Constants.password = account.password;
                    Constants.roleUser = account.role;
                }
                else
                {
                    account.accsess = false;
                }
                conn.closeConnection();
            }
            catch (Exception e)
            {
                account.accsess = false;
            }
            return account;
        }
    }
}
