using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM.Controller
{
    class StorageController
    {
        private ConnectServer conn;
        private SqlDataReader reader;
        public StorageController()
        {
            conn = new ConnectServer(Constants.server, Constants.user, Constants.password);
        }
        public List<StorageModel> getListStorage()
        {
            List<StorageModel> storages = new List<StorageModel>();
            conn.cmd.CommandText = "select * from myV_getListStorage";
            conn.openConnection();
            reader = conn.cmd.ExecuteReader();
            // Data is accessible through the DataReader object here.
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    StorageModel storage = new StorageModel();
                    storage.id = reader.GetString(0);
                    storage.name = reader.GetString(1);
                    storage.address = reader.GetString(2);                  

                    storages.Add(storage);
                }
            }
            conn.closeConnection();
            return storages;
        }
    }
}
