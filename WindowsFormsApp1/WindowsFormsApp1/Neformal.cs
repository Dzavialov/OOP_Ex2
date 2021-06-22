using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Neformal : Person
    {
        public Neformal(string name, int age) : base(name, age) { }

        public override string Hello(Person person)
        {
            string hello = "Привіт " + person.Name;
            return hello;
        }

        public override string Information()
        {
            string info = "Мене звуть " + name + ", Мій вік: " + age + " рік, Я неформал";
            return info;
        }
    }
}
