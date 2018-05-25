using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    abstract class scroll: IDismiss
    {
        public int scrollID { get; set; }
        public string scrollName { get; set; }
        public double scrollStrength { get; set; }
        public string Dismissed    { get; set; }

        public scroll (int scrollID, string scrollName, double scrollStrength, string Dismissed)
        {
            this.scrollID = scrollID;
            this.scrollName = scrollName;
            this.scrollStrength = scrollStrength;
            this.Dismissed = Dismissed;
        }

        public virtual void info()
        {
            Console.WriteLine("Код номенклатуры: {0}\nНазвание номенклатуры: {1}\nГрадус: {2}\nВ продаже: {3}", 
                scrollID, scrollName, scrollStrength, Dismissed);
        }

        /*public override string ToString()
        {
            return scrollID.ToString() + ": " + scrollName;
        }*/

        public abstract void Dismiss();
    }
}
