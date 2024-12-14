using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class CalculadoraDeFatorial
    {
        static long CalcularFatorial(int n)
        {
            long fatorial = 1;
            for (int contadora = 1; contadora <= n; contadora++)
            {
                fatorial *= contadora;
            }
            return fatorial;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro para calcular o fatorial: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            switch(numero)
            {
                case < 0:
                    Console.WriteLine("Fatorial não é definido para números negativos.");
                    break;

                case 0:
                    Console.WriteLine("O fatorial de 0 é 1.");
                    break;

                default:
                    Console.WriteLine($"O fatorial de {numero} é {CalcularFatorial(numero)}.");
                    break;
            }
        }
    }
}
