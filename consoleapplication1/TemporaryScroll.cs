using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class TemporaryScroll : scroll
    {

        public int TimeSelling { get; set; }
        public DateTime StartSelling
        { get; set; }
        public DateTime EndSelling
        { get; set; }
        public TemporaryScroll(int scrollID,string scrollName, double scrollStrength, string Deleted, int TimeSelling,
            DateTime StartSelling, DateTime EndSelling) : 
            base (scrollID, scrollName, scrollStrength,Deleted)
        {
            this.scrollID=scrollID;
            this.scrollName = scrollName;
            this.scrollStrength = scrollStrength;
            this.StartSelling = StartSelling;
            this.EndSelling = EndSelling;
            this.TimeSelling = TimeSelling;
        }     

        public override void info()
        {
            base.info();
            Console.WriteLine("Время в продаже: " + TimeSelling);
            Console.WriteLine("Дата поступления в продажу: {0}", StartSelling);
            Console.WriteLine("Дата конца продажи: {0}", EndSelling);
        }

        public override void Delete()
        {
            base.Deleted = "нет";
        }
        
    }
}
