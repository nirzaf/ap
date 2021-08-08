using System;

namespace learningProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
           Console.Write("If you want to exit Type Exit. \nInput 1 : ");

           string input = Console.ReadLine();
           if(input == "exit" || input == "Exit")
           {
               return;
           } 
           double input1 =  Convert.ToDouble(input);

           Console.Write("Please Enter The Operator +, -. *, / : ");
           char symbol = Convert.ToChar(Console.ReadLine());
           Console.Write("Input 2 : ");
           double input2 = Convert.ToDouble(Console.ReadLine());
           if (symbol == '+')
           {
             double answer = input1 + input2;
             Console.WriteLine(input1 +" "+ symbol+" "+ input2 + " = "+ answer);  
           }
           else if (symbol == '-')
           {
               Console.WriteLine(input1 - input2);
           }
           else if (symbol == '*')
           {
               Console.WriteLine(input1 * input2);
           }
           else if (symbol == '/')
           {
               Console.WriteLine(input1 / input2);
           }
          
           else 
           {
               Console.WriteLine("Invalid Output");
           }

        }       
    }
}