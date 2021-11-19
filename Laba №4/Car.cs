using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__4
{
    class Car:Vehicle
    {
        public Engine Eng = new Engine("EA111", "Бензиновый", 1985);
        protected string Brand;
        protected string Color;
        protected int ReleaseYear;


        public Car(string brand, string color, int releaseYear, bool alien)
        {
            ( Brand, Color, ReleaseYear, Alien) = (brand, color, releaseYear, alien);
        }

        public override void Show()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Вид транспортного средства: Car\nБренд: {Brand}\nЦвет: {Color}\nГод выпуска: {ReleaseYear}\nИнопланетный: {Alien}\n");
            Console.WriteLine($"Двигатель:\n   Название: {Eng.NameEngine}\n   Тип: {Eng.TypeEngine}\n   Год выпуска: {Eng.Year}");
            Console.WriteLine("-----------------------");
        }

        public override void ShowN()
        {
            Console.WriteLine($"Бренд: {Brand}");
        }

        public override string ToString()
        {
            return $"Вид транспортного средства: Car; Бренд: {Brand}; Цвет: {Color}; Дат выпуска: {ReleaseYear}; Инопланетный: {Alien};\nДвигатель: Название: {Eng.NameEngine} Тип: {Eng.TypeEngine} Год выпуска: {Eng.Year}";
        }
    }
}
