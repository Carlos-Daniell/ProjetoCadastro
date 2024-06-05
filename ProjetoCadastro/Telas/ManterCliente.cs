using Biblioteca.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.Telas {
    internal class ManterCliente {
        Cliente cliente = new Cliente();
        public void CadastrarCliente() {

            Console.Clear();
            Console.WriteLine("CADASTRAR CLIENTE");

            Console.WriteLine("Nome: ");
            cliente.Nome = Console.ReadLine();

            Console.WriteLine("Data de Nascimento: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Telefone: ");
            cliente.Telefone = Console.ReadLine();

            Console.WriteLine("CPF: ");
            cliente.CPF = Console.ReadLine();

            Console.WriteLine("RG: ");
            cliente.RG = Console.ReadLine();

            Console.WriteLine("CEP(digite apenas números: ");
            cliente.CEP = int.Parse(Console.ReadLine());

            Console.WriteLine("Estado: ");
            cliente.Estado = Console.ReadLine();

            Console.WriteLine("Cidade: ");
            cliente.Cidade = Console.ReadLine();

            Console.WriteLine("Endereco: ");
            cliente.Endereco = Console.ReadLine();

            SalvarCliente(cliente);

        }

        public void ListarClientes() { }
        public void SalvarCliente(Cliente cliente) { }


    }
}
