using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class order
    {
        public int orderID { get; set; }
        public customer customer { get; set; }
        public string orderList { get; set; }
        public check check { get; set; }

        public order(int orderID, customer customer, string orderList, check check)
        {
            this.orderID = orderID;
            this.customer = customer;
            this.orderList = orderList;
            this.check = check;
        }
    }
}
