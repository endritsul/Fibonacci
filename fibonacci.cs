using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int fibo1 = 1;
            int fibo2 = 0;
            int fibo_result;

            Console.WriteLine("Fibonacci Sequence");
            Console.WriteLine(fibo2);
            Console.WriteLine(fibo1);

            for (int x = 1; x < 20; x++)
            {
                fibo_result = fibo1 + fibo2;
                fibo2 = fibo1;
                fibo1 = fibo_result;
                Console.WriteLine(fibo_result);
            }
        }
    }
}
