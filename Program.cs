using System;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           string i = string.Empty;
           int x = 5; 
           while(x > 0)
           {
               x--;
               i += "*";
               Console.WriteLine(i);
           }
           while(i.Length > 1)
           {
               i = i.Substring(0, i.Length - 1);
               Console.WriteLine(i);
           } 
        }      
    }
}