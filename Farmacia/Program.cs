namespace Farmacia
{
    internal class Program
    {
        private static ConsoleKeyInfo cki;
        static void Main(string[] args)
        {
            int opcao;

            while (true)
            {
                Console.Write("Entre com a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Criar produto: ");

                        KeyPress();
                        break;
                    case 2:
                        Console.Write("Listar todos os produtos: ");

                        KeyPress();
                        break;
                    case 3:
                        Console.Write("Consultar produto por id: ");

                        KeyPress();
                        break;
                    case 4:
                        Console.Write("atualizar produto: ");

                        KeyPress();
                        break;
                    case 5:
                        Console.Write("Deletar produto: ");

                        KeyPress();
                        break;
                    case 6:
                        Console.Write("Saindo... ");

                        KeyPress();
                        break;
                    default:
                        Console.Write("Opção inválida");
                        
                        KeyPress();
                        break;
                }
            }
        }

        static void KeyPress()
        {
            do
            {
                Console.WriteLine("Pressione enter para continuar...");
                cki = Console.ReadKey();
            } while (cki.Key != ConsoleKey.Enter);
        }
    }
}