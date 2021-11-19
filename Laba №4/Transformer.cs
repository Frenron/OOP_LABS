using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__4
{
    class Transformer:Car, Reasonable
    {
        public bool SentientСreature { get; set; }
        private string Name;
        private string Race;
        private readonly int Counter = 0;
        public Transformer(bool sentientCreature, string name, string race, string brand, string color, int releaseYear, bool alien):base(brand, color, releaseYear, alien)
        {
            (SentientСreature, Name, Race) = (sentientCreature, name, race);
            Counter++;
        }

        public void ShowName()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Имя: {Name}\nРаса: {Race}");
            Console.WriteLine("-----------------------");
        }
        void Reasonable.Show()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine($"Разумное существо: {SentientСreature}");
            Console.WriteLine("-----------------------");
        }

        public override string ToString()
        {
            return $"Разумное существо: {SentientСreature}; Имя: {Name}; Раса: {Race}\nВид транспортного средства: Car; Бренд: {Brand}; Цвет: {Color}; Дат выпуска: {ReleaseYear}; Инопланетный: {Alien};\nДвигатель: Название: {Eng.NameEngine} Тип: {Eng.TypeEngine} Год выпуска: {Eng.Year}";
        }
        public override int GetHashCode()
        {
            return Counter;
        }
        public override bool Equals(object obj)
        {
            Transformer temp = obj as Transformer;

            if (temp != null)
            {
                if (temp.SentientСreature == this.SentientСreature && temp.Name == this.Name && temp.Race == this.Race && temp.Brand == this.Brand && temp.Color == this.Color && temp.ReleaseYear == this.ReleaseYear && temp.Alien == this.Alien && temp.Eng.NameEngine == this.Eng.NameEngine && temp.Eng.TypeEngine == this.Eng.TypeEngine && temp.Eng.Year == this.Eng.Year)
                    return true;
                else return false;
            }
            else return false;
        }
    }
}
