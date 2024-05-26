using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAgenda
{
    internal class Agenda
    {
        public string Nome  { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public List<Agenda> dados = new();

        public Agenda() { }
        public Agenda(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        public void AddContato()
        {
            Console.WriteLine("Você escolheu adicionar contato.");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Telefone: ");
            string telefone = Console.ReadLine();
            Console.Write("E-mail: ");
            string email = Console.ReadLine();

            dados.Add(new Agenda(nome, telefone, email));

        }

        public void EditarContato()
        {
            Console.WriteLine("Você escolheu editar contato.");
            Console.WriteLine();
            Console.Write("Digite o nome do contato que deseja editar: ");

            int index = GetIndex();

            if (index == -1)
            {
                Console.WriteLine("Deseja tentar novamente? Sim ou Não");
                string opcao = Console.ReadLine();
                if (opcao == "Sim")
                {
                    EditarContato();
                }
                return;
            }

            Console.Write("Nome: ");
            dados[index].Nome = Console.ReadLine();
            Console.Write("Telefone: ");
            dados[index].Telefone = Console.ReadLine();
            Console.Write("E-mail: ");
            dados[index].Email = Console.ReadLine();

        }

        public void ExcluirContato()
        {
            Console.WriteLine("Você escolheu excluir contato.");
            Console.WriteLine();
            Console.Write("Digite o nome do contato que deseja remover: ");

            int index = GetIndex();

            if (index == -1)
            {
                Console.WriteLine("Deseja tentar novamente? Sim ou Não");
                string opcao = Console.ReadLine();
                if (opcao == "Sim")
                {
                    ExcluirContato();
                }
                return;
            }

            dados.RemoveAt(index);

        }

        public void ExibirContato()
        {
            Console.WriteLine("Você escolheu ver lista de contatos.");
            Console.WriteLine();
            if (dados.Count == 0)
            {
                Console.WriteLine("Lista vazia!");
                return;
            }
            int cont = 1;
            foreach (Agenda obj in dados)
            {
                Console.WriteLine($"{cont} - {obj}");
                cont++;
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Telefone: {Telefone}, E-mail: {Email}";
        }

        private int GetIndex()
        {
            var contato = Console.ReadLine();
            var item = dados.FirstOrDefault(x => x.Nome == contato);

            if (item == null)
            {
                Console.WriteLine("Opção invalida!");
                return -1;
            }

            return dados.IndexOf(item);
        }
    }
}
