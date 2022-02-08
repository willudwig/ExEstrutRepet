using System;

namespace Ex03.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um algoritmo que efetue a soma de todos
            //os números ímpares que são múltiplos de três e que se
            //encontram no conjunto dos números de 1 até 500.
            //num % 3 == 0

            int[] numeros = new int[500];
            int[] multiplos = new int[500];
            int soma = 0;
                

            numeros[0] = 1;

            //ler numeros
            for (int i = 1; i < numeros.Length; i++)
            {
                numeros[i] = numeros[0] + i;
            }

            //verificar ímpares
            for (int i = 0; i < numeros.Length; i++)
            {

                if ((numeros[i] % 2) != 0 &&  numeros[i] % 3 == 0)
                {
                    multiplos[i] = numeros[i];
                }
            }

            //somar multiplos
            for (int j = 0; j < multiplos.Length -1; j++)
            {
                soma += multiplos[j];
            }
            

            //exibir soma
            System.Console.WriteLine("A soma entre os impares é: " + soma);
            
     
            System.Console.ReadKey();


        }
    }
}
