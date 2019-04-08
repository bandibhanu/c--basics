using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class fibo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first");

           //int z= Console.ReadLine();
            int i=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second");

            int j = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.Write(i +" ");
            Console.Write(j + " ");
            for (int m = 0; m < 10; m++)
            {
                c = i + j;
                Console.Write(c + " ");
                i = j;
                j = c;

            }
            Console.Read();


           /*Factorial*/



        }
    }
   

    
}
