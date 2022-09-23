using MyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customer = new MyLibrary.Customer();
            customer.UpdateName("Name");

            
            MyLibrary.ICalculate function = new MyLibrary.AddCalculate();

            var resul = function.PerformeCal(10, 10);
            Console.WriteLine(resul);

            MyObject myObject = new MyObject(); 
            MyObject myObject2 = new MyObject(10, 10);

            


            //Console.WriteLine("object 1 property is " + myObject.Number3);
            //Console.WriteLine("object 2 property is " + myObject2.Number3);

            Console.ReadLine();
        }
    }
}
