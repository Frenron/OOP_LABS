using System;

namespace Laba__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Ren4L = new Human(true, "Влад", 18);
            Ren4L.Show();
            Console.WriteLine(Ren4L.ToString());

            Car Tay = new Car("Tayota", "Red", 2012, false);
            Tay.Show();
            Tay.ShowN();

            Transformer Optimus = new Transformer(true, "Optimus", "Autobot","Peugeot", "Blue", 2003, true);
            Optimus.ShowName();
            Optimus.Show();
            ((Reasonable)Optimus).Show();
            Console.WriteLine(Optimus.GetHashCode());
            if (Optimus is Car)
            {
                Console.WriteLine("Объект принадлежит классу Машина");
            }
            else
            {
                Console.WriteLine("Объект не принадлежит классу Машина");
            }

            Vehicle[] arr = new Vehicle[2];
            arr[0] = Optimus;
            arr[1] = Tay;
            Console.WriteLine($"\n==============================\n");
            foreach (var el in arr)
            {
                Printer.IAmPrinting(el);
                Console.WriteLine();
            }
            Console.WriteLine($"==============================");
        }
    }
}
