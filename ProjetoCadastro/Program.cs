
using ProjetoCadastro.Telas;
using System;

namespace ProjetoCadastro {
    public class Program {
        static void Main(string[] args) {

            ManterCliente cliente = new ManterCliente();
            ManterFuncionario func = new ManterFuncionario();
            int opcoes = 0;

            while (opcoes != 5) {

                Console.WriteLine("O que deseja fazer ? \n 1 = Cadastrar Cliente, \n 2 = Listar Clientes, \n 3 = Cadastrar Funcionário, \n 4 = Listar Funcionários, \n 5 = Fechar Programa");
                opcoes = int.Parse(Console.ReadLine());

                switch (opcoes) {
                    case 1:
                        cliente.CadastrarCliente();
                        break;
                    case 2:
                        cliente.ListarClientes();
                        break;
                    case 3:
                        func.CadastrarFuncionario();
                        break;
                    case 4:
                        func.ListarFuncionarios();
                        break;
                    default:
                        Console.WriteLine("Comando Não Encontrado !");
                        break;

                }


            }

        }
    }
}