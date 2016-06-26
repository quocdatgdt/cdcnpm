using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM
{
    class ConnectServer
    {
        private string server { get; set; }
        private string userID { get; set; }
        private string password { get; set; }
        private string connectionString { get; set; }
        private SqlConnection con { get; set; }
        public SqlCommand cmdSP { get; set; }
        public SqlCommand cmd { get; set; }
        public ConnectServer(string server, string userID, string password)
        {
            this.server = server;
            this.userID = userID;
            this.password = password;
            this.connectionString = "Server=" + server + ";Integrated security=false;database=QLVT_dat;User ID = " + userID + "; password=" + password;
            this.con = new SqlConnection(this.connectionString);
            this.cmd = con.CreateCommand();
            this.cmdSP = con.CreateCommand();
            this.cmdSP.CommandType = CommandType.StoredProcedure;
        }
        public void openConnection()
        {
            con.Open();
        }
        public void closeConnection()
        {
            this.cmd = con.CreateCommand();
            this.cmdSP = con.CreateCommand();
            this.cmdSP.CommandType = CommandType.StoredProcedure;
            this.con.Close();
            this.cmd.Dispose();
            this.cmdSP.Dispose();
            this.connectionString = "";
            this.server = "";
            this.userID = "";
            this.password = "";  
         
        }
    }
}
