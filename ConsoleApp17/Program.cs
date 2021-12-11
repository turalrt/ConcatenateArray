using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program /*task3*/
    {
        static void Main(string[] args)
        {
            int [] arr1 = { 2, 1, 3 };
            int [] arr2 = { 6, 4, 5 };
            int [] arr3 = arr1.Concat(arr2).ToArray();
            Array.Sort(arr3);
            Array.Reverse(arr3);
            Console.WriteLine("arr3:");
            foreach (int value in arr3)
            {
                Console.Write(value + " ");
            }
        }
    }
}
