using System;

namespace Ex05.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // fatorial de um número;

            Console.Write("Digite um número: ");
            int a = int.Parse(Console.ReadLine());
            int n = a;
            for (int i = a; i > 1; i--)
            {
                a = a * (i - 1); 
            }

            Console.Write("\n" +n + "! = " + a +"\n");
            Console.ReadKey();

        }
    }
}
