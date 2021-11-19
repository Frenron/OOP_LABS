using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__4
{
    static class Printer
    {
        public static void IAmPrinting(Vehicle obj)
        {
            Console.WriteLine("Тип объекта " + obj.GetType());
            Console.WriteLine(obj.ToString());
        }
    }
}
