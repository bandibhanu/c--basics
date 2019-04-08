using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Calculator
    {
       public static void calculationMethod(int enteroption, int firstvalue,int secondvalue)
        {
            switch (enteroption)
            {
                case 1: 
                      Console.WriteLine(firstvalue+ secondvalue);
                    break;

                case 2:
                    Console.WriteLine(firstvalue * secondvalue);
                    break;
                case 3:
                    Console.WriteLine(firstvalue/secondvalue);
                    break;
                case 4:
                    Console.WriteLine(firstvalue-secondvalue);
                    break;
             }

        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the options \n" +
                "1.Addition\n" +
                "2.Multiplication\n" +
                "3.division\n" +
                "4.Substituion");
            int enteroption=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstvalue");
            int firstvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the firstvalue");
            int secondvalue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Final Result");

            calculationMethod(enteroption, firstvalue, secondvalue);
            Console.ReadLine();
        }
    }
}
