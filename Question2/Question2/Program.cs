using System;

namespace ValoresFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o Valor Fibonacci");
            int n = int.Parse(Console.ReadLine());

            bool pertence = VerificaFibonacci(n);

            if (pertence)
                Console.WriteLine(n + " pertence à sequência de Fibonacci");
            else
                Console.WriteLine(n + " não pertence à sequência de Fibonacci");
        }

        static bool VerificaFibonacci(int n)
        {
            int a = 0;
            int b = 1;

            while (b < n)
            {
                int c = a + b;
                a = b;
                b = c;
            }

            if (b == n)
                return true;
            else
                return false;
        }
    }
}