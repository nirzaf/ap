using System;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int x = 1;
            int number = 1;
            int multiple = 1;
            while (x <= 10)
            {
                Console.Write(number * multiple + " ");
                x++;
                number++;
            }
           
        }       
    }
}