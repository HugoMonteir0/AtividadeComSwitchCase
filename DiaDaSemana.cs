using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class DiaDaSemana
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt16(Console.ReadLine());
 
            switch (numero) {
                case 1:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Segunda-feira!");
                    break;
                case 2:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Terça-feira!");
                    break;
                case 3:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Quarta-feira!");
                    break;
                case 4:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Quinta-feira!");
                    break;
                case 5:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Sexta-feira!");
                    break;
                case 6:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Sábado!");
                    break;
                case 7:
                    Console.WriteLine("O número digitado foi: " + numero + ". Que corresponde a " + "Domingo!");
                    break;
                default:
                    Console.WriteLine("O número digitado não corresponde a nenhum dia da semana!");
                    break;
            }
        }
    }
}
