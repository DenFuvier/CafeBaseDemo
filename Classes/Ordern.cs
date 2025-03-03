using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeBase.Classes
{
    class Ordern
    {
        public int id { get; set; }
        public int WaiterID { get; set; }
        public int ChefID { get; set; }
        public int OrderStatus { get; set; }
        public int TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
