using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public interface SumInterface
    {
        double sum(double num1,double num2);
    }
    public class SumClass: SumInterface
    {
        //double value1=num1;
        //double value2=7;
         double SumInterface.sum(double value1,double value2)
        {
            return value1 + value2;
            //Console.WriteLine("sum=" + (value1 + value2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SumClass obj = new SumClass();

        //   double total= obj.sum(3,4);

            Console.WriteLine("total=" + obj.sum(3, 4));
            SumInterface i = obj;
          // double j= i.sum(4, 1);
            Console.WriteLine("total=" + i.sum(4, 1));


            Console.Read();
        }
    }
}
