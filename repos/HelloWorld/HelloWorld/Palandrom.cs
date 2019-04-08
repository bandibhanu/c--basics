using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Palandrom
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter the number");
        int givenInteger=Convert.ToInt32(Console.ReadLine());
            int temp = givenInteger;
            int sum = 0;
            while(givenInteger > 0)
            {
                int i= givenInteger % 10;
                 sum = (sum * 10) + i;
                givenInteger = givenInteger / 10;
            
            }
    
       
            if(sum == temp)
            {
                Console.WriteLine("palendrome");
            }
            else
            {
                Console.WriteLine("not a palendrome");
            }
              
            Console.ReadLine();
            
        }
    }
}
