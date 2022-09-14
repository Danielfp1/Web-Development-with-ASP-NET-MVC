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
            MyObject myObject = new MyObject(); 
            MyObject myObject2 = new MyObject(10, 10);

            


            Console.WriteLine("object 1 property is " + myObject.Number3);
            Console.WriteLine("object 2 property is " + myObject2.Number3);

            Console.ReadLine();
        }
        class MyObject
        {
            int _number1 = 5;
            int _number2 = 5;

            public MyObject()
            {
                Number1 = 5;
                Number2 = 5;
            }
            public MyObject(int number1, int number2)
            {
                Number1 = number1;
                Number2 = number2;
            }

            public int Number1 { get => _number1; set => _number1 = value; }
            public int Number2 { get => _number2; set => _number2 = value; }
            public int Number3 { get { return _number1 + _number2; } }

            public int Calculate(int number1, int number2)
            {
                return number1 + number2;
            }
            public int Calculate()
            {
                return _number1 + _number2;
            }

            public string MyMethod()
            {
                return "some value";
            }
        }
    }
}
