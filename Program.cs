using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArray
{
    internal class Program
    {
        static void Result(int[] arr)
        {

            // displaying the array elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Array Element: " + arr[i]);
            }
        }
        static void Main()
        {
            // declaring an array
            // and initializing it
            int[] arr = { 150, 452, 132, 44, 15 };

            // calling the method
            Result(arr);
            Array.Sort(arr);
            foreach(int i in arr)
            {
                Console.Write(i+" ");
            }
            Console.ReadLine();
        }
    }
}
