using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // declaring variables
            int numbers = 20;
            int fibo1 = 1;
            int fibo2 = 0;
            int fibo_result;
            
            // writeline for the first two numbers of the fibonacci sequence
            Console.WriteLine("Fibonacci Sequence");
            Console.WriteLine(fibo2);
            Console.WriteLine(fibo1);
            
            // for-loop to get the first 20 numbers of the fibonacci seq.
            for (int i = 1; i < numbers; i++)
            {
                fibo_result = fibo1 + fibo2;
                fibo2 = fibo1;
                fibo1 = fibo_result;
                Console.WriteLine(fibo_result);
            }
        }
    }
}
