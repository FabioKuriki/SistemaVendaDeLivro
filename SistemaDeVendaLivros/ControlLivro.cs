using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ControlLivro
    {
        int opcao;
        ModelLivro modeloLivro;
        ControlReserva controleReserva;
        public string nomeLogado;
        public string enderecoLogado;
        public int telefoneLogado;
        public int idLogado;
        public ControlLivro()
        {
            opcao = -1;
            modeloLivro = new ModelLivro();
            controleReserva = new ControlReserva();
            

        }

        public void Escolha()
        {
            Console.WriteLine("Escolha um dos livros abaixo: \n" +
                              "0. Introdução ao C# - R$10,00\n" +
                              "1. Introdução ao Python - R$10,50\n" +
                              "2. Introdução ao VisualG - R$11,50\n" +
                              "3. Introdução a Banco de Dados - R$25,00\n" +
                              "4. Sair ");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void SistemaLivro()
        {
            controleReserva.nomeLogado = nomeLogado;
            controleReserva.enderecoLogado = enderecoLogado;
            controleReserva.telefoneLogado = telefoneLogado;
            controleReserva.idLogado = idLogado;
            do
            {
                Escolha();
                Console.Clear();
                switch (opcao)
                {
                    case 0:
                        controleReserva.nomeLivro = modeloLivro.NomeLivro(opcao);
                        if (modeloLivro.livro > 0)
                        {
                            Console.WriteLine("Total: R$" + modeloLivro.Compra(opcao));
                            MaisCompra();
                        }
                        else
                        {
                            controleReserva.SistemaReserva();
                        }
                        break;
                    case 1:
                        controleReserva.nomeLivro = modeloLivro.NomeLivro(opcao);
                        if (modeloLivro.livro2 > 0)
                        {
                            Console.WriteLine("Total: R$" + modeloLivro.Compra(opcao));
                            MaisCompra();
                        }
                        else
                        {
                            controleReserva.SistemaReserva();
                        }
                        break;
                    case 2:
                        controleReserva.nomeLivro = modeloLivro.NomeLivro(opcao);
                        if (modeloLivro.livro3 > 0)
                        {
                            Console.WriteLine("Total: R$" + modeloLivro.Compra(opcao));
                            MaisCompra();
                        }
                        else
                        {
                            controleReserva.SistemaReserva();
                        }
                        break;
                    case 3:
                        controleReserva.nomeLivro = modeloLivro.NomeLivro(opcao);
                        if (modeloLivro.livro4 > 0)
                        {
                            Console.WriteLine("Total: R$" + modeloLivro.Compra(opcao));
                            MaisCompra();
                        }
                        else
                        {
                            controleReserva.SistemaReserva();
                        }
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Escolha uma das opções disponíveis");
                        break;
                }
            }while(opcao != 4);
        }

        //Caso o usuário compre mais de um livro
        public void MaisCompra()
        {
            do
            {
                Console.WriteLine("Gostaria de comprar mais um livro?\n" +
                              "0. Não\n" +
                              "1. Sim");
                opcao = Convert.ToInt32(Console.ReadLine());

            
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Compra realizada");
                        modeloLivro.soma = 0;
                        break;
                    case 1:
                        SistemaLivro();
                        break;
                    default:
                        Console.WriteLine("Informe um opção válida");
                        break;
                }
            }while (opcao != 0);
        }
    }
}
