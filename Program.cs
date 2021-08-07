using System;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           /* Console.WriteLine("Enter your input here :");

            int input = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<=input;i++)
            {
                if(i%3 ==0)
                {
                    Console.WriteLine('*');
                }
                else
                {
                    Console.WriteLine(i);
                }
            } */

                Console.WriteLine("Input : ");
                int input = Convert.ToInt32(Console.ReadLine());
                for (int x = 1; x >= input; x++)
                Console.WriteLine(x);
        }
        
    }
}