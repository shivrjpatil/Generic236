using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class NonGeneric
    {
            public void ToPrintArray<T>(T[] intArr)
            {
                foreach (T data in intArr)
                {
                    Console.WriteLine(data);
                }
            }
        }
}
