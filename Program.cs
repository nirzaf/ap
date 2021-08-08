using System;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
  
                Console.WriteLine("Input : ");
                int input = Convert.ToInt32(Console.ReadLine());
                for (int x = 1; x >= input; x++)
                Console.WriteLine(x);
        }       
    }
}