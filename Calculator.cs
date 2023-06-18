using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Xunit_And_Acceptans
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public List<int> Results = new List<int>();

        public int Addition(int num1, int num2)
        {
            int result = num1 + num2;
            Console.WriteLine($"{num1} + {num2} = {result}");
            Results.Add(result);
            return result;
        }

        public int Subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            Console.WriteLine($"{num1} - {num2} = {result}");
            Results.Add(result);
            return result;
        }

        public int Division(int num1, int num2)
        {
            int result = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {result}");
            Results.Add(result);
            return result;
        }
        public int Multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            Console.WriteLine($"{num1} * {num2} = {result}");
            Results.Add(result);
            return result;
        }
    }
}
