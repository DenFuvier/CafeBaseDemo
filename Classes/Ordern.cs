using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBase.Classes
{
    class Ordern
    {
        public int OrderID { get; set; }
        public int WaiterID { get; set; }
        public string ReadyOrNot { get; set; }
        public int CookID { get; set; }
        public int TableNumber { get; set; }
        public int Quantity { get; set; }
        public string DishNames { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
