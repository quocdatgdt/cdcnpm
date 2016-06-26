using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM.Model
{
    class AccountModel
    {
        public bool accsess { get; set; }
        public string user { get; set; } //ten login
        public string password { get; set; }
        public string role { get; set; }
        public string userName { get; set; } //ten nhan vien
        public int userID { get; set; } //ma nhan vien
        public AccountModel()
        {

        }
    }
}
