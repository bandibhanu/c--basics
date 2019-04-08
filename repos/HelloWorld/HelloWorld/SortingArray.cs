using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class SortingArray
    {
        public static void Main(string[] args)
        {
            int[] array = new int[] { 7,3,4,2,1,9};

            Array.Sort(array);

            foreach (int value in array)
            {
                Console.Write(value + " ");
            }
            Console.ReadLine();
        }
    }
}
