using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__5
{
    partial class Car:Vehicle
    {
        public override void Show()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Вид транспортного средства: Car\nБренд: {Brand}\nЦвет: {Color}\nВыпуск: {ya.releaseYear} лет назад\nИнопланетный: {Alien}\n");
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
