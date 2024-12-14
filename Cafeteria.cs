using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class Cafeteria
    {
        static void Menu()
        {
            Console.WriteLine("Bem vindo a cafeteria do Palestra\n");
            Console.WriteLine("Escolha uma bebida do menu:\n");
            Console.WriteLine("1 - Café\n" + "2 - Chá\n" + "3 - Suco\n" + "4 - Refrigerante\n");

        }

        public static void Main(string[] args)
        {
            Menu();
            Console.WriteLine("Digite o número da bebida que deseja escolher: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Bebida escolhida: Café");
                    break;
                case 2:
                    Console.WriteLine("Bebida escolhida: Chá");
                    break;
                case 3:
                    Console.WriteLine("Bebida escolhida: Suco");
                    break;
                case 4:
                    Console.WriteLine("Bebida escolhida: Refrigerante");
                    break;
                default:
                    Console.WriteLine("Erro: Digite uma opção correspondente ao menu!");
                    break;
                    
            }
        }
    }
}
