using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace Laba__3
{
    static class StaticOperation
    {
        public static int Sum(Set<int> set)
        {
            var sum = 0;
            foreach (var elem in set)
            {
                sum += elem;
            }
            return sum;
        }

        public static int Range(Set<int> set)
        {
            return set.Max() - set.Min();
        }

        public static int Count(Set<int> set)
        {
            return set.Count();
        }

        public static string Str(this string str)
        {
            var NewSet = str.Replace(' ',',');
            
            return NewSet;
        }

    }
    class Set<T> : IEnumerable<T>
    {
        public Owner Me = new Owner(1, "Ren4L", "BSTU");
        public Date date = new Date();
        private readonly List<T> _list = new List<T>();
        public static int Ow = 123;
        public int Count => _list.Count;
        public int Size() => _list.Count;
        public bool Has(T item) => _list.Contains(item);
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item));
            }
            if (!_list.Contains(item))
            {
                _list.Add(item);
            }
        }

        public static Set<T> operator +(Set<T> set1, T elem)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (elem == null)
            {
                throw new ArgumentNullException(nameof(elem));
            }
            var NewSet = new Set<T>();
            foreach (var elem2 in set1)
            {
                NewSet.Add(elem2);
            }
            NewSet.Add(elem);
            return NewSet;
        }

        public static Set<T> operator +(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }
            var NewSet = new Set<T>();
            foreach (var elem in set1)
            {
                if (!set2.Has(elem))
                {
                    NewSet.Add(elem);
                }
            }
            foreach (var elem2 in set2)
            {
                NewSet.Add(elem2);
            }
            return NewSet;
        }


        public static Set<T> operator *(Set<T> set1, Set<T> set2)
        {
            if (set1 == null)
            {
                throw new ArgumentNullException(nameof(set1));
            }

            if (set2 == null)
            {
                throw new ArgumentNullException(nameof(set2));
            }

            var resultSet = new Set<T>();

            if (set1.Count < set2.Count)
            {
                foreach (var item in set1._list)
                {
                    if (set2._list.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }
            else
            {
                foreach (var item in set2._list)
                {
                    if (set1._list.Contains(item))
                    {
                        resultSet.Add(item);
                    }
                }
            }

            return resultSet;
        }

        public static bool operator true(Set<T> set1)
        {
            if (set1.Size() > 3 && set1.Size() < 10) { return true; }
            else return false;
        }
        public static bool operator false(Set<T> set1)
        {
            if (set1.Size() > 3 && set1.Size() < 10) { return false; }
            else return true;
        }



        public class Owner
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Company { get; set; }

            public Owner(int id, string name, string company)
            {
                Id = id;
                Name = name;
                Company = company;
            }
            public static void getList(Set<T> set)
            {
                Console.WriteLine(set.Count());
            }
        }

        public class Date
        {
            public DateTime DateOfCreate = DateTime.Now;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return _list.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }


    }
}
