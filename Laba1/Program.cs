using System;
using System.Text;

namespace Laba1
{
    class Program
    {
        static void Main(string[] args)
        {
        //1)
            
            //a)
            
            bool flag = true;//хранит значение true или false (логические литералы)
            byte bit = 255; // хранит целое число от 0 до 255 и занимает 1 байт
            sbyte sbit = -127; // хранит целое число от -128 до 127 и занимает 1 байт.
            short n = -21234; //хранит целое число от -32768 до 32767 и занимает 2 байта
            ushort un = 53423; // хранит целое число от 0 до 65535 и занимает 2 байта
            int i = -23432423; //хранит целое число от -2147483648 до 2147483647 и занимает 4 байта
            uint ui = 632432423;//хранит целое число от 0 до 4294967295 и занимает 4 байта
            long l = -3267476422342342;// хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт
            ulong ul = 9828993765435234323;//хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт
            float f = -5.3e-10f;//хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта
            double d = 7.3e+3;//хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта
            decimal dl = -1432.32432m;//хранит десятичное дробное число. Если употребляется без десятичной запятой, имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт
            char c = 'R';// хранит одиночный символ в кодировке Unicode и занимает 2 байта
            string s = "Ren4L";//хранит набор символов Unicode
            
            //b)
            
            //явное

            float nf = (float)d;
            int ni = (int)d;
            double nd = Double.Parse("1,543");
            short nn = System.Convert.ToInt16(ni);
            bool nflag = bool.Parse("true");

            //неявное

            long nl = ni;
            d = n;
            d = i;
            ul = ui;
            d = f;

            //c)

            float fl = 23.53434f;
            Object obj = fl;
            float nfl = (float)obj;

            //d)

            var a = 123;
            var b = "Ren4L";
            Console.WriteLine($"{a.GetType()} {b.GetType()}");

            //e)

            int? num = null;
            num = 10;

        //2)

            //a)

            string word1 = "hello", word2 = "world";
            string colab = word1 == word2 ? "true" : "false";
            Console.WriteLine($"{colab}");

            //b)

            string s1 = "Hello World", s2 = " Welcom Back", s3 = "Back to the future";
            string res = String.Concat(s1, s2); // сцепление
            Console.WriteLine(res);

            Console.WriteLine($"{res.Substring(0, 6)}"); //выделение

            foreach (string word in res.Split(" ")) //разделение 
            {
                Console.Write($"{word}, ");
            }

            Console.WriteLine($"\n{res.Insert(5, $" {s3}")}"); //вставка

            Console.WriteLine($"{res.Remove(0,6)}"); //удаление

            char[] arr = { 'R', 'e', 'n', '4', 'L', ' ', 
                'R', 'e', 'n', '4', 'L', ' ', 
                'R', 'e', 'n', '4', 'L', ' ', 
                'R', 'e', 'n', '4', 'L', ' ', 
                'R', 'e', 'n', '4', 'L', ' ', 
                'R', 'e', 'n', '4', 'L', };
            s3.CopyTo(0, arr, 5,s3.Length);
            Console.WriteLine(arr);

            string test = "", test2 = null;
            if(test == test2)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            //d)

            StringBuilder SB = new StringBuilder("Ren4L", 20);
            SB.Remove(3, 2);
            SB.Append("cheL");
            SB.Insert(0, "Name: ");
            Console.WriteLine(SB);

        //3)

            //a)
            int[,] array = new int[3, 3]
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };
            for(int o = 0; o < 3; o++)
            {
                for (int j = 0; j < 3; j++) Console.Write(String.Format("{0,3}", array[o, j]));
                Console.WriteLine();
            }

            //b)

            string[] st = new string[3]
            {
                "One",
                "Two",
                "Three"
            };

            foreach(string word in st)
            {
                Console.Write($"{word} ");
            }
            Console.Write($": {st.Length}");

            Console.Write($"\nEnter position: ");
            int pos = Int32.Parse(Console.ReadLine()) - 1;
            Console.Write($"\nEnter new value: ");
            string Val = Console.ReadLine();

            if (pos < st.Length && pos > -1) st[pos] = Val;
            foreach (string word in st)
            {
                Console.Write($"{word} ");
            }

            //c)

            double[][] jag = new double[3][];
            jag[0] = new double[2];
            jag[1] = new double[3];
            jag[2] = new double[4];

            for (int o = 0; o < jag.Length; o++)
            {
                for (int j = 0; j < jag[o].Length; j++)
                {
                    Console.Write($"Enter element [{o}][{j}]: ");
                    jag[o][j] = Double.Parse(Console.ReadLine());
                }
            }


            for (int o = 0; o < jag.Length; o++)
            {
                for (int j = 0; j < jag[o].Length; j++) Console.Write($"{jag[o][j]} ");
                Console.WriteLine();
            }

            //d)

            var st1 = "hello world!";
            var st2 = jag[1];

            //4)

            //abc)

            (int num, string str, char chaR, ulong ul) k = (420, "NetConnect", 'R', 4324324);

            Console.Write(k);
            Console.WriteLine($" ({k.Item1}, {k.Item3}, {k.Item4})");

            //d)

            (var z, var x, var v, var m) = k;
            Console.WriteLine($"{z}, {x}, {v}, {m}");

            //e)

            (int num, string str, char chaR, ulong ul) k2 = (420, "NetConnect", 'R', 4324324);
            Console.WriteLine(k.Equals(k2) ? "true" : "false");

            //5)

            (int, int, int, char) func(int[] mas, string st2)
            {
                int max = 0, min = 10, sum = 0;
                foreach(int num in mas)
                {
                    if (num > max) max = num;
                    if (num < min) min = num;
                    sum += num;
                }
                char first = char.Parse(st2.Remove(1, st2.Length -1));
                return (max, min, sum, first);
            }

            int[] mass = { 2, 2, 8, 4, 2 };
            Console.WriteLine(func(mass, "Ren4L"));
        }
    }
}