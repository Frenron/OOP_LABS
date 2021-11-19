using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba__5
{
    public sealed class Army
    {
        public object[] arr;
        public Army(params object[] ar)
        {
            this.arr = ar;
        }

        public object this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                if (value is Transformer || value is Human) arr.Append(value);
            }
        }

        public void getElement()
        {
            foreach(var el in arr)
            {
                Console.WriteLine(el);
            }
        }

        public void Add(object el)
        {
            this.arr = arr.Append(el).ToArray();
        }

        public void Delete(int index)
        {
            this.arr = this.arr.Where((el, i) => i != index).ToArray();
        }

    }
}
