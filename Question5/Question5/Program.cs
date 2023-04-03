using System;

namespace inverterCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {

            //string a ser invertida
            Console.WriteLine("Escreva uma palavra:");
            string input = (Console.ReadLine());

            //string para armazenar a string invertida
            string output = "";


            for (int i = input.Length - 1; i >= 0; i--)
            {
                output += input[i];
            }

            Console.WriteLine("Palavra Invertida: " + output);

        }

    }
}