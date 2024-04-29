
//Busca de Dados em uma Matriz de Animais Suponha que você tenha uma matriz que representa uma lista de animais, onde cada linha contém as seguintes propriedades de um animal: Nome Espécie Idade Peso Escreva um programa em C# que permita ao usuário buscar animais por uma determinada propriedade (nome, espécie, idade ou peso) e exibir os animais que correspondem à busca. // Matriz de animais [Nome, Espécie, Idade, Peso] string[,] animais = { { "Fido", "Cachorro", "5", "10kg" }, { "Whiskers", "Gato", "5", "5kg" }, { "Buddy", "Cachorro", "3", "8kg" }, { "Fluffy", "Gato", "2", "4kg" }, { "Spot", "Cachorro", "4", "12kg" } };

namespace exercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] animais = {
            { "Fido", "Cachorro", "5", "10kg" },
            { "Whiskers", "Gato", "5", "5kg" },
            { "Buddy", "Cachorro", "3", "8kg" },
            { "Fluffy", "Gato", "2", "4kg" },
            { "Spot", "Cachorro", "4", "12kg" }
        };

            Console.WriteLine("Escolha a categoria da pesquisa (nome, espécie, idade, peso):");
            string categoria = Console.ReadLine();

            string mensagemErro = categoria != "nome" && categoria != "espécie" && categoria != "idade" && categoria != "peso" ? "\nCategoria de pesquisa inválida." : "";

            Console.WriteLine(mensagemErro);

            if (mensagemErro == "")
            {
                Console.WriteLine("\nAgora, informe " + categoria + " do animal:");
                string valor = Console.ReadLine();

                bool encontrado = false;

                for (int i = 0; i < animais.GetLength(0); i++)
                {
                    encontrado = categoria == "nome" && animais[i, 0] == valor ||
                                categoria == "espécie" && animais[i, 1] == valor ||
                                categoria == "idade" && animais[i, 2] == valor ||
                                categoria == "peso" && animais[i, 3] == valor;

                    if (encontrado)
                    {
                        Console.WriteLine("\nNome: " + animais[i, 0] + "\nEspécie: " + animais[i, 1] + "\nIdade: " + animais[i, 2] + "\nPeso: " + animais[i, 3]);
                        break;
                    }
                }

                if (!encontrado)
                {
                    Console.WriteLine("\nAnimal não encontrado.");
                }
            }

            Console.ReadKey();
        }
    }
}