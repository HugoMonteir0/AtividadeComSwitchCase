using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeComSwitchCase
{
    internal class ConvertorDeTemperatura
    {
        public static double CalculadoraCelsius(double celsius)
        {
            return celsius * 9 / 5 +32;
        }

        public static double CalculadoraFahrenheit(double fahrenheit)
        {
            return fahrenheit - 32 *5 / 9;
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Conversor de temperatura\n");
            Console.WriteLine("Escolha uma opção:\n");
            Console.WriteLine("1 - Converter de Celcius para Fahrenheit");
            Console.WriteLine("2 - Converter de Fahrenheit para Celcius\n");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Digite a temperatura Celsius: ");
                    double celsius = Convert.ToDouble(Console.ReadLine());
                    CalculadoraCelsius(celsius);
                    Console.WriteLine($"A temperatura convertida de Celsius para Fahrenheit é: {celsius:F2}°C");
                    break;
                    
                case 2:
                    Console.WriteLine("Digite a temperatura em Fahrenheit: ");
                    double fahrenheit = Convert.ToDouble(Console.ReadLine());
                    CalculadoraFahrenheit(fahrenheit);
                    Console.WriteLine($"A temperatura em Fahrenheit é: {fahrenheit:F2} °F");
                    break;

            }
            

        }
    }
}
