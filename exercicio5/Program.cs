//EXERCÍCIO 5. Crie uma matriz 4x4 de números inteiros aleatórios e encontre o maior valor presente nela.

namespace exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[,] matriz = new int[4,4];

            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(1, 101);
                }
            }

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            int maior = matriz[0,0];

            for(int i = 0; i < 4; i++)
            {
                maior = matriz[i,i] > maior ? maior = matriz[i,i] : maior;
            }

            Console.WriteLine("\nO maior valor da matriz é: "+maior);

            Console.ReadKey();
        }
    }
}