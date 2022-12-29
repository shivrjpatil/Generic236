using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 1, 2, 3, 4, 5 };
            double[] doubleArr = { 1.1, 2.2, 3.3, 4.4, 5.5 };
            char[] charArr = { 'a', 'b', 'c', 'd', 'e' };
            NonGeneric genericOperation = new NonGeneric();
            genericOperation.ToPrintArray(intArr);
            genericOperation.ToPrintArray(doubleArr);
            genericOperation.ToPrintArray(charArr);
            Console.ReadLine();
        }
    }
}
