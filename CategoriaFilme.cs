using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class CategoriaFilme
    {
         static void Filmes()
        {
            Console.WriteLine("Filmes disponível\n");
            Console.WriteLine("1 - Arranhaverso\n" + "2 - Rei Leão\n" + "3 - Vingadores\n" + "4 - Invasão Zumbi\n");
        }

        public static void Main(string[] args)
        {
            Filmes();
            Console.WriteLine("Digite o número correspondente ao filme que deseja assistir: ");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nFilme escolhido: Aranhaverso. Classificacao indicativa: G (Livre)");
                    break;
                case 2:
                    Console.WriteLine("\nFilme escolhido: Rei Leão. Classificacao indicativa: PG (Maior de 10 anos) ");
                    break;
                case 3:
                    Console.WriteLine("\nFilme escolhido: Vingadores. Classificacao indicativa: PG-13 (Maior de 13 anos)");
                    break;
                case 4:
                    Console.WriteLine("\nFilme escolhido: Invasão Zumbi. Classificacao indicativa: R (Maior de 18 anos) ");
                    break;

            }
        }
    }
}
