using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ControlPessoa
    {
        ModelPessoa modelo;
        ControlLivro controleLivro;
        int opcao;
        //Método Construtor
        public ControlPessoa()
        {
            modelo = new ModelPessoa();
            controleLivro = new ControlLivro();
            opcao = -1;
        }
        //Fim do Construtor


        public void Menu()
        {
            Console.WriteLine("\nEscolha uma das opções abaixo: \n" +
                              "0. Sair\n" +
                              "1. Login\n" +
                              "2. Cadastro");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void Acesso()
        {
            do
            {
                Menu();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado!");
                        break;
                    case 1:
                        Console.Write("Login: ");
                        string login = Console.ReadLine();
                        Console.Write("Senha: ");
                        string senha = Console.ReadLine();
                        if (modelo.Validacao(login, senha) == true)
                        {
                            Console.Clear();
                            controleLivro.MenuLivro();
                        }
                        else
                            Console.WriteLine("Login inválido ou inexistente");
                        break;
                    case 2:
                        int dia;
                        int mes;
                        int ano;
                        Console.Write("Nome:");
                        string nome = Console.ReadLine();
                        Console.Write("Endereço:");
                        string endereco = Console.ReadLine();
                        Console.Write("Telefone:");
                        int telefone = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Data de Nascimento: ");
                        do
                        {
                            Console.Write("Dia: ");
                            dia = Convert.ToInt32(Console.ReadLine());
                            if (dia < 1 || dia > 31)
                            {
                                Console.WriteLine("Informa um dia válido");
                            }
                        } while (dia < 1 || dia > 31);
                        do
                        {
                            Console.Write("Mês: ");
                            mes = Convert.ToInt32(Console.ReadLine());
                            if (mes < 1 || mes > 12)
                            {
                                Console.WriteLine("Informa um mês válido");
                            }
                        } while (mes < 1 || mes > 12);
                        do
                        {
                            Console.Write("Ano: ");
                            ano = Convert.ToInt32(Console.ReadLine());
                            if (ano < 0)
                            {
                                Console.WriteLine("Informa um ano válido");
                            }
                        } while (ano < 0);
                        Console.Write("Login:");
                        login = Console.ReadLine();
                        Console.Write("Senha:");
                        senha = Console.ReadLine();
                        modelo.Preenchimento(login, senha, nome, endereco, telefone, dia, mes, ano);
                        break;
                    case 3:
                        modelo.MostrarVetor();
                        break;
                    default:
                        Console.WriteLine("Opção selecionada não é válida");
                        break;
                }
            }while(opcao != 0);
        }
    }
}
