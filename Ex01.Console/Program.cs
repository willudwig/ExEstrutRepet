using System;

namespace Ex01.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um algoritmo que leia a altura de 15 pessoas.
            //Este programa deverá calcular e mostrar:
            //a. A menor altura do grupo;
            //b. A maior altura do grupo;

            double[] pessoas = new double[15];

            //ler pessoas
            for (int i = 0; i < pessoas.Length; i++)
            {
                System.Console.Write("Digite a altura da pessoa " + (i+1) + ": ");
                pessoas[i] = Convert.ToDouble(System.Console.ReadLine());
            }
            
            //ordenar pessoas - do maior para o menor
            double t;
            for (int j = 0; j < pessoas.Length; j++)
            {
                for (int k = j+1; k < pessoas.Length; k++)
                {
                    if (pessoas[j] < pessoas[k])
                    {
                        t = pessoas[j];
                        pessoas[j] = pessoas[k];
                        pessoas[k] = t;
                    }
                }
            }

            System.Console.WriteLine(" ");

            //exibir pessoas ordenadas
            for (int i = 0; i < pessoas.Length; i++)
            {
                System.Console.Write(pessoas[i] + " ");  
            }

            System.Console.WriteLine("\n\nA maior pessoa tem " + pessoas[0] + " de altura");
            System.Console.WriteLine("A menor pessoa tem " + pessoas[14] + " de altura");

            System.Console.ReadKey();   
        }
    }
}
