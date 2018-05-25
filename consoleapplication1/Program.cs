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
            List<scroll> listproduct = new List<scroll>();
            DismissedProducts product1 = new DismissedProducts(1, "пиво", 10, "нет");
            DismissedProducts product2 = new DismissedProducts(2, "коньяк", 40, "нет");

            //Использование интерфейса
            listproduct.Add(new TemporaryProduct(3, "Водка", 40, "Да",10, Start1, End1));
            listproduct.Add(new TemporaryProduct(4, "Вино", 20, "Да",9, Start2, End2));
            listproduct.Add(product1);
            listproduct.Add(product2);
            foreach (scroll ff in listproduct)
            {
                ff.info();
                Console.WriteLine();
            }

            Console.Write("Введти номер номенклатуры, который хотите убрать из продажи ");            
            int scrollID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int scrollCount = listproduct.Count(b=>b.scrollID==scrollID);
            if (scrollCount == 1)
            {
                IDismiss dScroll = listproduct.SingleOrDefault(b => b.scrollID == scrollID);
                dScroll.Dismiss();
                foreach (scroll ff in listproduct)
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
