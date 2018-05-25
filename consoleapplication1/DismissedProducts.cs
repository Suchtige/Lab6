using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DismissedProducts: scroll
    {

        
        public DismissedProducts(int scrollID, string scrollName, double scrollStrength, string Dismissed) : 
            base (scrollID, scrollName, scrollStrength, Dismissed)
        {

        }

        

        public override void Dismiss()
        {
            base.Dismissed = "Нет";
        }
    }
}
