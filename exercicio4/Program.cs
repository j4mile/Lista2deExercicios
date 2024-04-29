//EXERCÍCIO 4. Escreva um programa que declare dois vetores de mesmo tamanho e calcule a soma dos elementos correspondentes de ambos os
//vetores, armazenando o resultado em um terceiro vetor. Em seguida, exiba o vetor resultante.

namespace exercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vamos somar os valores de dois vetores. Primeiro, informe o tamanho deles: ");
            int tamVetor = int.Parse(Console.ReadLine());

            int[] vetorUm = new int[tamVetor];
            int[] vetorDois = new int[tamVetor];

            Console.WriteLine("\nAgora, informe os "+tamVetor+" valores do primeiro vetor: ");
            for(int i = 0; i < vetorUm.Length; i++)
            {
                vetorUm[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nPor fim, informe os "+tamVetor+" valores do segundo vetor: ");
            for (int i = 0; i < vetorUm.Length; i++)
            {
                vetorDois[i] = int.Parse(Console.ReadLine());
            }

            int[] vetorSoma = new int[tamVetor];

            for(int  i = 0; i < tamVetor; i++)
            {
                vetorSoma[i] = vetorUm[i] + vetorDois[i];
                
            }

            Console.WriteLine("A soma dos vetores é de: ");
            for (int i = 0; i < vetorSoma.Length; i++)
            {
                Console.WriteLine(vetorSoma[i]);
            }

            Console.ReadKey();
        }
    }
}