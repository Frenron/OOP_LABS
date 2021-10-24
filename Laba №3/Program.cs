using System;

namespace Laba__3
{
    class Program
    {
        static void Main(string[] args)
        {
            Set<int> set = new Set<int>() { 1, 2, 3, 4 };
            Console.WriteLine($"{set.Me.Id} {set.Me.Name} {set.Me.Company} {((Set<int>.Owner.Date)set).DateOfSeptember}");
            Set<int> set2 = new Set<int>() { 4, 5, 6, 7 };
            Set<int> set3 = new Set<int>() { 3, 4, 5, 6 };
            Console.Write("Добавление элемента: ");
            var NewEl = set + 5;
            foreach (var elem in NewEl)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
            Console.Write("Объединение: ");
            var Union = set + set2;
            foreach (var elem in Union)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
            Console.Write("Пересечение: ");
            var crossed = set * set3;
            foreach (var elem in crossed)
            {
                Console.Write($"{elem} ");
            }
            Console.WriteLine();
            Console.Write($"False: ");
            if (set)
            {
                Console.WriteLine("Размер больше 3, но меньше 10");
            }
            Console.WriteLine($"Count: {StaticOperation.Count(set)}\nSum: {StaticOperation.Sum(set)}\nRange: {StaticOperation.Range(set)}");
            Set<string> set4 = new Set<string>() { "Ren4L", "Dantey", "MSTkrut2"};
            var str = StaticOperation.Str(set4);
            Console.Write("Str: ");
            foreach (var elem in str)
            {
                Console.Write($"{elem} ");
            }
        }
    }
}
