using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class ConversionFromDecimalToBinary
    {
        public static void Main(string []args)
        { int i = 0;
            int[] array = new int[100];
            Console.WriteLine("give a decimal number ");
            int givenNumber = int.Parse(Console.ReadLine());
            while(givenNumber>0)
            {
                array[i++] = givenNumber % 2;
                givenNumber = givenNumber / 2;
            }
           array.Reverse();
            Console.WriteLine(array);
            Console.ReadLine();

        }
    }
}
