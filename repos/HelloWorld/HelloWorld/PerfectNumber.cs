using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PerfectNumber
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("enter number to know perfect numbe or not ");
            int givenNumber = Convert.ToInt32(Console.ReadLine());
            int duplicate = givenNumber;
            int sum = 0;
            while (givenNumber > 0)
            {
               // int i = givenNumber % 10;
                for(int j=1;j<givenNumber;j++)
                {
                    if (givenNumber % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == duplicate)
                {
                    Console.WriteLine("perfect number");
                }
                else
                {
                    Console.WriteLine("not a perfect Number");
                }
                Console.ReadLine();
            }

            Console.ReadLine();

        }
    }
}
