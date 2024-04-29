//EXERCÍCIO 1. Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, exiba esses elementos na tela.

namespace exercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] elementos = new int[5];

            Console.WriteLine("Informe 5 números inteiros: ");
            for (int i = 0; i < elementos.Length; i++)
            {
                elementos[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < elementos.Length; i++)
            {
                Console.WriteLine(elementos[i]);
            }
       
            Console.ReadKey();
        }
    }
}