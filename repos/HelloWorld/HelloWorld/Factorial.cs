using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Factorial
    {
        public static void Main(string [] args) {
            Console.WriteLine("enter the value");
            int givenvalue = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"givenvalue  {givenvalue} ");
            int factorial = 1;
            for(int i = givenvalue; i > 1; i--)
            {
                factorial = factorial * i;
                Console.WriteLine(factorial + "\n");//givenvalue+"*******" + i+"=======" + (givenvalue * i));
            }
            Console.Read();

            }
        
    }
}
