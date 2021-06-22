using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Realist : Person
    {
        public Realist(string name, int age) : base(name, age) { }

        public override string Hello(Person person)
        {
            string hello;
            if (person.Age - age > 5)
            {
                hello = "Добрий день " + person.Name;
            }
            else
            {
                hello = "Привіт " + person.Name;
            }

            return hello;
        }

        public override string Information()
        {
            string info = "Мене звуть " + name + ", Мій вік: " + age + " рік, Я реаліст";
            return info;
        }
    }
}
