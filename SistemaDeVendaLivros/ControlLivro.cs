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
        int livro;
        int livro2;
        int livro3;
        int livro4;
        double ValorLivro;
        double ValorLivro2;
        double ValorLivro3;
        double ValorLivro4;
        ModelLivro modeloLivro;
        ModelReserva modeloReserva;
        ModelPessoa modeloPessoa;
        public ControlLivro()
        {
            opcao = -1;
            livro = 2;
            livro2 = 0;
            livro3 = 2;
            livro4 = 2;
            ValorLivro = 10;
            ValorLivro2 = 10.50;
            ValorLivro3 = 11.50;
            ValorLivro4 = 25;
            modeloLivro = new ModelLivro();
            modeloReserva = new ModelReserva();
            modeloPessoa = new ModelPessoa();
        }

        public void Escolha()
        {
            Console.WriteLine("Escolha um dos livros abaixo: \n" +
                              "0. Introdução ao C# - R$10,00\n" +
                              "1. Introdução ao Python - R$10,50\n" +
                              "2. Introdução ao VisualG - R$11,50\n" +
                              "3. Introdução a Banco de Dados - R$25,00");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void Reserva()
        {
            Console.WriteLine("Livro indisponível para compra, gostaria de realizar a reserva?\n" +
                              "0. Sim\n" +
                              "1. Não");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch(opcao)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Tenha um ótimo dia");
                    break;
                default:
                    Console.WriteLine("Informe um opção válida");
                    break;
            }
        }

        public void MaisCompra()
        {
            Console.WriteLine("Gostaria de comprar mais um livro?\n" +
                              "0. Sim\n" +
                              "1. Não");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    MenuLivro();
                    break;
                case 1:
                    Console.WriteLine("Compra realizada");
                    break;
                default:
                    Console.WriteLine("Informe um opção válida");
                    break;
            }
        }

        public void MenuLivro()
        {
            Escolha();
            Console.Clear();
            switch(opcao)
            {
                case 0:
                    if(livro > 0)
                    {
                        Console.WriteLine("Total: R$" + modeloLivro.Compra(ValorLivro));
                        livro = livro - 1;
                        MaisCompra();

                    }
                    else
                    {
                        Reserva();
                    }
                    break;
                case 1:
                    if (livro2 > 0)
                    {
                        Console.WriteLine("Total: R$" + modeloLivro.Compra(ValorLivro2));
                        livro2 = livro2 - 1;
                        MaisCompra();
                    }
                    else
                    {
                        Reserva();
                    }
                    break;
                case 2:
                    if (livro3 > 0)
                    {
                        Console.WriteLine("Total: R$" + modeloLivro.Compra(ValorLivro3));
                        livro3 = livro3 - 1;
                        MaisCompra();

                    }
                    else
                    {
                        Reserva();
                    }
                    break;
                case 3:
                    if (livro4 > 0)
                    {
                        Console.WriteLine("Total: R$" + modeloLivro.Compra(ValorLivro4));
                        livro4 = livro4 - 1;
                        MaisCompra();

                    }
                    else
                    {
                        Reserva();
                    }
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções disponíveis");
                    break;
            }
        }
    }
}
