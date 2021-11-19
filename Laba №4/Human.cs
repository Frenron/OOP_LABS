using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__4
{
    class Human:Reasonable
    {
        public bool SentientСreature { get; set; }
        private string Name { get; set; }
        private int Age { get; set; }

        public Human (bool sentientСreature, string name, int age)
        {
            (SentientСreature, Name, Age) = (sentientСreature, name, age);
        }

        public void Show()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Разумное существо: {SentientСreature}\nИмя: {Name}\nВозраст: {Age}");
            Console.WriteLine("-----------------------");
        }
        public override string ToString()
        {
            return $"Разумное существо: {SentientСreature}; Имя: {Name}; Возраст: {Age};";
        }
    }
}
