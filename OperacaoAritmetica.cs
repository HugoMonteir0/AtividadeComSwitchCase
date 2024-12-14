using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class OperacaoAritmetica
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            double numero01 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite outro número: ");
            double numero02 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Digite uma operacao matemática(+, -, *, /): ");
            string? operacao = Console.ReadLine();

            double resultado;

            switch (operacao)
            {
                case "+":
                    {
                        resultado = numero01 + numero02;
                        Console.WriteLine("A operação escolhida foi: " + operacao + ". O resutado da soma dos números: " + numero01 + " e " + numero02 + " é = " + resultado);
                        break;
                    }
                case "-":
                    {
                        resultado = numero01 - numero02;
                        Console.WriteLine("A operação escolhida foi: " + operacao + ". O resutado da subtração dos números: " + numero01 + " e " + numero02 + " é = " + resultado);
                        break;
                    }
                case "*":
                    {
                        resultado = numero01 * numero02;
                        Console.WriteLine("A operação escolhida foi: " + operacao + ". O resutado da multiplicação dos números: " + numero01 + " e " + numero02 + " é = " + resultado);
                        break;
                    }
                case "/":
                    resultado = numero01 / numero02;
                    Console.WriteLine("A operação escolhida foi: " + operacao + ". O resutado da divisão dos números: " + numero01 + " e " + numero02 + " é = " + resultado);
                    break;
                default:
                    Console.WriteLine("Erro: operador não existente, tente novamente!");
                    break;
            }

        }
    }
}
