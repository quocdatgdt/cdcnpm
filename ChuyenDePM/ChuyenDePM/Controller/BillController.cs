using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM.Controller
{
    class BillController
    {
        private ConnectServer conn;
        private SqlDataReader reader;
        private SqlParameter parameter;

        public BillController()
        {
            conn = new ConnectServer(Constants.server, Constants.user, Constants.password);
        }

        public List<BillModel> getListBill()
        {
            List<BillModel> bills = new List<BillModel>() { };
            conn.cmd.CommandText = "myV_getListStorage";
            conn.openConnection();
            reader = conn.cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    BillModel bill = new BillModel();
                    bill.id = reader.GetString(0);
                    bill.date = reader.GetDateTime(1);
                    bill.type = reader.GetString(2);
                    bill.customer = reader.GetString(3);
                    bill.totalPrice = reader.GetFloat(4);
                    bill.emplID = reader.GetInt32(5);
                    bill.storageID = reader.GetString(6);

                    bills.Add(bill);
                }
            }

            conn.closeConnection();
            return bills;
        }

        public string getLastBillID(string loai)
        {
            string id = "";
            parameter = new SqlParameter("@LOAI", loai);
            conn.cmdSP.CommandText = "mySP_getLastPhieu";
            conn.cmdSP.Parameters.Add(parameter);
            conn.openConnection();
            reader = conn.cmdSP.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    id = reader.GetString(0);
                }
            }
            conn.closeConnection();
            return id;
        }

    }
}
