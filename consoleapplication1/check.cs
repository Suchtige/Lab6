using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class check
    {
        public int checkID { get; set; }
        public DateTime checkDate {get;set;}
        public double checkSumm { get; set; }
        public order orderList { get; set; }

        public check(int checkID, DateTime checkDate, double checkSumm, order orderList)
        {
            this.checkDate = checkDate;
            this.checkID = checkID;
            this.checkSumm = checkSumm;
            this.orderList = orderList;
        }
    }
}
