//EXERCÍCIO 3. Crie um programa que preencha uma matriz 3x3 com valores inteiros informados pelo usuário e depois exiba essa matriz na tela.

namespace exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            Console.WriteLine("Vamos montar um matriz 3x3.\nInforme os valores para as colunas: ");
            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Valor para ["+i+","+j+"]: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i,j] +"\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}