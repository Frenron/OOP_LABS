using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__4
{
    sealed class Engine
    {
        public string TypeEngine;
        public int Year;
        public string NameEngine;

        public Engine(string nameEngine, string typeEngine, int year)
        {
            (NameEngine, TypeEngine, Year) = (nameEngine, typeEngine, year);
        }

        public override string ToString()
        {
            return $"Название: {NameEngine}; Вид: {TypeEngine}; Год выпуска: {Year}";
        }
    }
}
