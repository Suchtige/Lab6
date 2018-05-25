using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class product
    {
        public int productID { get; set; }
        public string productName { get; set; }
        public scroll scrollID { get; set; }
        public double productVolume { get; set; }
        public string productProducer { get; set; }
        public int productPrice { get; set; }

        public product(int productID, string productName, scroll scrollID, double productVolume, int productPrice, string productProducer)
        {
            this.productID = productID;
            this.productName = productName;
            this.scrollID = scrollID;
            this.productVolume = productVolume;
            this.productPrice = productPrice;
            this.productProducer = productProducer;
        }

        /*public virtual void info()
        {
            Console.WriteLine("Код товара: {0}\nНазвание товара: {1}\nНоменклатура: {2}\nОбъем: {3}\nПроизводитель: {4}\n" +
                "Цена: {5}\n", productID, productName, scrollID, productVolume, productProducer, productPrice);
        }*/
    }
}
