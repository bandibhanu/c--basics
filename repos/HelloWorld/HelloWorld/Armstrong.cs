using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Armstrong
    {
        /* sum of the length with power length*/

        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number ");

            int givenNumber = Convert.ToInt32(Console.ReadLine());
            int duplicate = givenNumber;
            Console.WriteLine("given number");
            Console.WriteLine(givenNumber);
            String s = givenNumber.ToString();
            Console.WriteLine("length");
            Console.WriteLine(s.Length);
            double length = s.Length;
            double sum = 0;
            while (givenNumber > 0)
            {
                double i=givenNumber % 10;
                sum = sum + (Math.Pow(i, length));
              //  Console.WriteLine(sum);
                givenNumber = givenNumber / 10;
            }
            Console.WriteLine(sum);
            if (duplicate == sum)
            {
                Console.WriteLine("armstring ");
            }
            else
            {
                Console.WriteLine("not an armstroing");
            }
            
            Console.ReadLine();
        }
    }
}
