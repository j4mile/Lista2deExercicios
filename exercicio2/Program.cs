//EXERCÍCIO 2. Escreva um programa que declare e inicialize um vetor com 5 elementos inteiros e, em seguida, mostre o maior e menor valor.

namespace exercicio2
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

            int maior = elementos[0];
            int menor = elementos[0];

            for (int i = 0; i < elementos.Length; i++)
            {

                maior = elementos[i] > maior ? maior = elementos[i] : maior;
                menor = elementos[i] < menor ? menor = elementos[i] : menor;

            }
            Console.WriteLine("Maior número: "+maior+"\nMenor número: "+menor);

            Console.ReadKey();

        }
    }
}