using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__5
{
    abstract class Vehicle
    {
        public string TypeVehicle { get; set; }
        public bool Alien { get; set; }
        public virtual void Show() { Console.WriteLine("Vehicle"); }
        public abstract void ShowN();

    }
}
