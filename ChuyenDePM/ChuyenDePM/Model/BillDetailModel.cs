using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuyenDePM.Model
{
    class BillDetailModel
    {
        public string materialID { get; set; }
        public string billID { get; set; }
        public int quantity { get; set; }
        public float unitPrice { get; set; }
        public BillDetailModel()
        {

        }
    }
}
