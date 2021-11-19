using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__5
{
    partial class Car:Vehicle
    {
        public Engine Eng = new Engine("EA111", "Бензиновый", 1985);
        protected string Brand;
        protected string Color;
        protected int ReleaseYear;
        public YearsAgo ya;

        public struct YearsAgo
        {
            public readonly int releaseYear;
            public YearsAgo(int releaseYear = 0)
            {
                this.releaseYear = 2021 - releaseYear;
            }
        }
        public Car(string brand, string color, int releaseYear, bool alien)
        {
            ( Brand, Color, ReleaseYear, Alien) = (brand, color, releaseYear, alien);
            this.ya = new YearsAgo(releaseYear);
        }
    }
}
