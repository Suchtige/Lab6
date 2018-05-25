using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class pass
    {
        public int passID { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public string patronymic { get; set; }
        public int age { get; set; }

        public pass(int passID, string surname,string name, string patronymic, int age)
        {
            this.passID = passID;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.age = age;

        }
    }
}
