using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class ClassificacaoIdade
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());

            switch (idade)
            {
                case int classificacao when (classificacao >= 0 && classificacao <= 12):
                    Console.WriteLine("Você tem " + idade + " anos, você é uma criança!");
                    break;
                case int classificacao when (classificacao >= 13 && classificacao <= 17):
                    Console.WriteLine("Você tem " + idade + " anos, você é um adolescente!");
                    break;
                case int classificacao when (classificacao >= 18 && classificacao <= 59):
                    Console.WriteLine("Você tem " + idade + " anos, você é um adulto!");
                    break;
                case int classificacao when (classificacao >= 60):
                    Console.WriteLine("Você tem " + idade + " anos, você é um idoso!");
                    break;
                default:
                    Console.WriteLine("Erro: digite um número positivo.");
                    break;


            }
        }
    }
}
