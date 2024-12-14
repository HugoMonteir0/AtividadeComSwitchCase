namespace
    AtividadeComSwitchCase
{
    internal class Menu
    {
        static void Opcoes()
        {
            Console.WriteLine("- Menu de Opcoes -\n");
            Console.WriteLine("1 - Óla, Mundo!");
            Console.WriteLine("2 - Bem-vindo ao C#!");
            Console.WriteLine("3 - Sair do prgrama!\n");
        }

        public static void Main(string[] args)
        {
            Opcoes();
            Console.WriteLine("Escolha uma das opcoes: \n");
            int numero = Convert.ToInt16(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Opcao selecionada: " + numero + "\nÓla, Mundo!");
                    break;
                case 2:
                    Console.WriteLine("Opcao selecionada: " + numero + "\nBem-vindo ao C#!");
                    break;
                case 3:
                    Console.WriteLine("Opcao selecionada: " + numero + "\nSair do programa!");
                    break;
                default:
                    Console.WriteLine("Opcao selecionada: " + numero + "\nErro: Digite uma opcao válida!");
                    break;
            }

        }
    }
}
