using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class StrongNumber
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the value");
            int givenvalue = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int duplicate = givenvalue;
            Console.WriteLine($"givenvalue  {givenvalue} ");
            while (givenvalue > 0)
            {
                int factorial = 1;

                int j = givenvalue % 10;
                Console.WriteLine($"j= {j}");
                for (int i = j; i > 1; i--)
                {

                    factorial = factorial * i;
                   // Console.WriteLine(factorial + "\n");//givenvalue+"*******" + i+"=======" + (givenvalue * i));

                }
                Console.WriteLine(factorial);
                sum = sum + factorial;
                Console.WriteLine(sum);
               // factorial = 0;
                givenvalue = givenvalue / 10;
                
            }
            if (sum == duplicate)
            {
                Console.WriteLine("Strong number");
            }
            else
            {
                Console.WriteLine("not Strong");
            }
            Console.ReadLine();
        }
    }
}