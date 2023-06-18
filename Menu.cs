using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb7_Xunit_And_Acceptans
{
    public class Menu : Calculator
    {
        public int Choice { get; set; }
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }


        public void PrintResults()
        {
            Console.WriteLine("Previous results:");
            foreach (var item in Results)
            {
                Console.WriteLine(item);
            }
        }

        public int GetChoiceNumber(int choice)
        {
            choice = 0;
            do
            {
                try
                {
                    choice = int.Parse(Console.ReadLine());
                    return choice;
                }
                catch
                {

                }
                return choice;
            } while (choice == 0);

        }

        public int GetFirstNumberInput(int firstNumber)
        {
            try
            {
                Console.WriteLine("Please enter a single digit number: ");
                firstNumber = int.Parse(Console.ReadLine());
                return firstNumber;
            }
            catch
            {
                Console.WriteLine("Error: Not a valid input..");
            }
            return firstNumber;
        }
        public int GetSecondNumberInput(int secondNumber)
        {
            try
            {
                Console.WriteLine("Please enter a single digit number: ");
                secondNumber = int.Parse(Console.ReadLine());
                return secondNumber;
            }
            catch
            {
                Console.WriteLine("Error: Not a valid input..");
                Console.ReadKey();
            }
            return secondNumber;
        }

        public void MenuChoice(int choice)
        {
            int num1;
            int num2;
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    num1 = GetFirstNumberInput(FirstNumber);
                    num2 = GetSecondNumberInput(SecondNumber);
                    Addition(num1, num2);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    num1 = GetFirstNumberInput(FirstNumber);
                    num2 = GetSecondNumberInput(SecondNumber);
                    Subtraction(num1, num2);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    num1 = GetFirstNumberInput(FirstNumber);
                    num2 = GetSecondNumberInput(SecondNumber);
                    Multiplication(num1, num2);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.Clear();
                    num1 = GetFirstNumberInput(FirstNumber);
                    num2 = GetSecondNumberInput(SecondNumber);
                    Division(num1, num2);
                    Console.ReadKey();
                    break;
                case 5:
                    Console.Clear();
                    PrintResults();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Error: Not a valid input..");
                    Console.ReadKey();
                    break;
            }
        }

        public void Start()
        {
            int loop = 0;
            do
            {
                Console.WriteLine("Welcome\n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. See previous results\n");

                int choice = GetChoiceNumber(Choice);
                MenuChoice(choice);
                Console.Clear();
            } while (loop != 1);
        }
    }
}
