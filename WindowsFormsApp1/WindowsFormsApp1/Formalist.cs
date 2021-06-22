using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Formalist : Person
    {
        public Formalist(string name, int age) : base(name, age) { }

        public override string Hello(Person person)
        {
            string hello = "Добрий день " + person.Name;
            return hello;
        }

        public override string Information()
        {
            string info = "Мене звуть " + name + ", Мій вік: " + age + " рік, Я формаліст";
            return info;
        }
    }
}
