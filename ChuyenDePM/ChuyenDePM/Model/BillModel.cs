using ChuyenDePM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM.Model
{
    class BillModel
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public string type { get; set; }
        public string customer { get; set; }
        public float totalPrice { get; set; }
        public int emplID { get; set; }
        public string storageID { get; set; }
        public BillModel()
        {

        }
    }
}
