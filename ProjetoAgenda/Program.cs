using System;

namespace ProjetoAgenda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            bool exibirMenu = true;

            while (exibirMenu)
            {
                Console.WriteLine("--- MENU ---");
                Console.WriteLine("1 - Adicionar contato");
                Console.WriteLine("2 - Editar contato");
                Console.WriteLine("3 - Excluir contato");
                Console.WriteLine("4 - Ver lista de contatos");
                Console.WriteLine("5 - Sair do menu");

                Console.Write("O que deseja fazer? ");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        agenda.AddContato();
                        Console.WriteLine();
                        break;

                    case 2:
                        agenda.EditarContato();
                        Console.WriteLine();
                        break;

                    case 3:
                        agenda.ExcluirContato();
                        Console.WriteLine();
                        break;

                    case 4:
                        agenda.ExibirContato();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.WriteLine("Você escolheu sair do menu. Até breve!");
                        Console.WriteLine();
                        return;

                    default:
                        Console.WriteLine("Opção invalida. Por favor, escolha novamente");
                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}