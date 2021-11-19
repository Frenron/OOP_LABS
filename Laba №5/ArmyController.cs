using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__5
{
    public static class ArmyController
    {
        public static void SearchByYear(Army arm, int year)
        {
            foreach(var el in arm.arr)
            {
                if(el is Transformer)
                {
                    Transformer tmp = el as Transformer;
                    if(tmp.Year == year)
                    {
                        Console.WriteLine(tmp.Name);
                    }
                }
                else
                {
                    Human tmp = el as Human;
                    if (tmp.Year == year)
                    {
                        Console.WriteLine(tmp.Name);
                    }
                }
            }
        }
        public static void ArmyLength(Army arm)
        {
            Console.WriteLine(arm.arr.Length);
        }

        public static void SearchByPower(Army arm, int power)
        {
            foreach (var el in arm.arr)
            {
                if (el is Transformer)
                {
                    Transformer tmp = el as Transformer;
                    if (tmp.Power == power)
                    {
                        Console.WriteLine(tmp.Name);
                    }
                }
            }
        }
    }
}
