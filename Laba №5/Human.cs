using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__5
{
    class Human:Reasonable
    {
        public bool SentientСreature { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }

        public Human (bool sentientСreature, string name, int year)
        {
            (SentientСreature, Name, Year) = (sentientСreature, name, year);
        }

        public void Show()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Разумное существо: {SentientСreature}\nИмя: {Name}\nВозраст: {Year}");
            Console.WriteLine("-----------------------");
        }
        public override string ToString()
        {
            return $"Разумное существо: {SentientСreature}; Имя: {Name}; Возраст: {Year};";
        }
    }
}
