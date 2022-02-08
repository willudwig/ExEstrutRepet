using System;

namespace Ex04.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que leia um valor
            //para uma variável N de 1 a 10 e calcule a tabuada de N.

            Console.Write("Digite um número de 1 a 10: ");
            ushort n = ushort.Parse(System.Console.ReadLine());

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("\n" + n + " x " + (i + 1) + " = " + (n * (i + 1)));
            }


            System.Console.ReadKey();
        }
    }
}
