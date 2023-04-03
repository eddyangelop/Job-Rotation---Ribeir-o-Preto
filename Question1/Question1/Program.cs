using System;
using System.Globalization;

namespace somaDeValores
{
    class program
    {
        static void Main(string[] args)
        {

            int Indice = 13;
            int Soma = 0;
            int K = 0;

            while (K < Indice)
            {
                K = K + 1;
                Soma = Soma + K;

            }

            Console.WriteLine(Soma);
            Console.ReadLine();
            // Resposta 91
        }
    }
};
