using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1 {
    class Program {
        static void Main(string[] args) {
            DateTime Start1 = new DateTime(2018, 1, 20);
            DateTime End1 = new DateTime(2018, 2, 20);
            DateTime Start2 = new DateTime(2018, 1, 10);
            DateTime End2 = new DateTime(2018, 4, 30);            
            List<scroll> lstScroll = new List<scroll>();
            DeletedScroll product1 = new DeletedScroll(1, "пиво", 10, "нет");
            DeletedScroll product2 = new DeletedScroll(2, "коньяк", 40, "нет");

            //Использование интерфейса
            lstScroll.Add(new TemporaryScroll(3, "Водка", 40, "Да",10, Start1, End1));
            lstScroll.Add(new TemporaryScroll(4, "Вино", 20, "Да",9, Start2, End2));
            lstScroll.Add(product1);
            lstScroll.Add(product2);
            lstScroll.OrderBy(b=>b.scrollID);
            foreach (scroll ff in lstScroll)
            {
                ff.info();
                Console.WriteLine();
            }

            Console.Write("Введите номер номенклатуры, которую хотите убрать из продажи ");            
            int scrollID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int scrollCount = lstScroll.Count(b=>b.scrollID==scrollID);
            if (scrollCount == 1)
            {
                SDelete dScroll = lstScroll.SingleOrDefault(b => b.scrollID == scrollID);
                dScroll.Delete();
                foreach (scroll ff in lstScroll)
                {
                    ff.info();
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("Неверное значение");
                                                         
            Console.ReadLine();
            
        }
        
    }
}
