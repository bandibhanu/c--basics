using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class RemoveDuplicates
    {
        public static void Main(string[] args)
        {

            /* Removing the duplicates in array */


            int[] s = new int[10];
            for (int i = 0; i < s.Length; i++)
            {
                s[i] =Convert.ToInt32( Console.ReadLine());
            }
            int[] q = s.Distinct().ToArray();
            foreach (int i in q)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
