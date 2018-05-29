using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class DeletedScroll: scroll
    {

        
        public DeletedScroll(int scrollID, string scrollName, double scrollStrength, string Deleted) : 
            base (scrollID, scrollName, scrollStrength, Deleted)
        {

        }

        

        public override void Delete()
        {
            base.Deleted = "Нет";
        }
    }
}
