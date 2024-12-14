using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class NotaAluno
    {
        static void Mensagem()
        {
            Console.WriteLine("Digite sua nota pra determinar a sua classificação!\n");
        }

        public static void Main(string[] args)
        {
            Mensagem();
            Console.WriteLine("Digite sua nota: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            switch(numero)
            {
                case int classificacao when (classificacao >= 9 && classificacao <=10):
                    Console.WriteLine("Classificacao: A");
                    break;
                case int classificacao when (classificacao >= 7 && classificacao <= 8):
                    Console.WriteLine("Classificacao: B");
                    break;
                case int classificacao when (classificacao >= 5 && classificacao <= 6):
                    Console.WriteLine("Classificacao: C");
                    break;
                case int classificacao when (classificacao >= 3 && classificacao <= 4):
                    Console.WriteLine("Classificacao: D");
                    break;
                case int classificacao when (classificacao >= 0 && classificacao <= 2):
                    Console.WriteLine("Classificacao: F");
                    break;
                default:
                    Console.WriteLine("Erro: Digite o valor de 0 a 10");
                    break;
            }
        }
    }
}
