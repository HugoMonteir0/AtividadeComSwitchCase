using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class CalculadoraDeImpostos
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o seu sálario atual: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            double salarioFinal = 0;

            switch (salario)
            {
                case double imposto when (imposto <= 1500):
                    salarioFinal = salario * 0.05;
                    Console.WriteLine("O seu salário atual é: "+ salario + "\nO seu sálario novo com os impostos inclusos, são: "  + salarioFinal + salario);
                    break;

                case double imposto when (imposto >= 1501 && imposto <=3000):
                     salarioFinal = salario * 0.10;
                    Console.WriteLine("O seu salário atual é: " + salario + "\nO seu sálario novo com os impostos inclusos, são: " + salarioFinal + salario);
                    break;

                case double imposto when (imposto > 3000):
                     salarioFinal = salario * 0.15;
                    Console.WriteLine("O seu salário atual é: " + salario + "\nO seu sálario novo com os impostos inclusos, são: " + salarioFinal + salario);
                    break;
            }
        }
    }
}
