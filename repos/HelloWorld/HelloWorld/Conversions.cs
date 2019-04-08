using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Conversions
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("givenNumber");

            int givenNumber = int.Parse(Console.ReadLine());           
            double sum= 0;
           double j = 2;
            int i = 0;
            while(givenNumber>0)
            {
                int duplicate = givenNumber % 10;
                              
              sum = sum + (duplicate * (Math.Pow(j, i)));
                              
                givenNumber = givenNumber / 10;
                i++;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

    }
}
