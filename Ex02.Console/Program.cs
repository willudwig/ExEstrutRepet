using System;

namespace Ex02.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escrever um algoritmo que gera e escreve os números ímpares entre 100 e 200.

            int[] numeros = new int[100];
            int[] impares = new int[100];


            numeros[0] = 100;
            
            //ler numeros
            for (int i = 1; i < numeros.Length; i++)
            {
                    numeros[i] = numeros[0] + i;
            }

            //verificar ímpares
            for (int i = 0; i < numeros.Length; i++)
            {
                
                if ((numeros[i] % 2) != 0)
                {
                    impares[i] = numeros[i]; 
                }
            }

            //exibir ímpares
            for (int i = 0; i < numeros.Length; i++)
            {
                if ( impares[i] != 0 )
                {
                    System.Console.WriteLine(impares[i]);
                }
               
            }

            System.Console.ReadKey();
        }
    }
}
