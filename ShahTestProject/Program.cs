using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShahTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shahrukh");
            //int x = 5, y = 6, z = 40;
            //Console.WriteLine(x + y - z);
            Calculator Calc = new Calculator();
            var Sum = Calc.AdditionMethod(45, 60);
            Console.WriteLine(Sum);
            var SumResult = Console.ReadLine();
            var arg_Array = SumResult.Split(' ');
        
            string op = arg_Array[1];
            var arg_1 = Int32.Parse(arg_Array[0]);
            var arg_2 = Int32.Parse(arg_Array[2]);

            int Result = 0;

            if(op == "+")
            {
               Result = Calc.AdditionMethod(arg_1, arg_2);
            }

            Console.WriteLine(Result);

            
            var Sub = Calc.Substraction(90, 65);
            Console.WriteLine(Sub);
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}

