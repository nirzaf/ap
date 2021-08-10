using System;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Input 1 : ");
            string input = Console.ReadLine();
            double input1;
            if (input == "Exit" || input == "exit")
            {
                return;
            }
            else
            {
                input1 = Convert.ToDouble(input);
            }
            Console.Write("Enter the Operator +, -, * , / : ");
            char symbol = Convert.ToChar(Console.ReadLine());
            Console.Write("Input 2 : ");
            double input2 = Convert.ToDouble(Console.ReadLine());
        }       
    }
}