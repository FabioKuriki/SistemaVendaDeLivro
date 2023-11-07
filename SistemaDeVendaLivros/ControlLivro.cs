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
        public ControlLivro()
        {
            opcao = -1;
            livro = 2;
            livro2 = 2;
            livro3 = 2;
            livro4 = 2;
        }

        public void Escolha()
        {
            Console.WriteLine("Escolha um dos livros abaixo: \n" +
                              "0. Introdução ao C# - R$10,00\n" +
                              "1. Introdução ao Python - R$10,00\n" +
                              "2. Introdução ao VisualG - R$10,00\n" +
                              "3. Introdução a Banco de Dados - R$10,00");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void Reserva()
        {
            Console.WriteLine("Gostaria de realizar a reserva?\n" +
                              "0. Sim\n" +
                              "1. Não");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void MenuLivro()
        {
            Escolha();
            switch(opcao)
            {
                case 0:
                    livro = livro - 1;
                    if(livro == 0)
                    {
                        Console.WriteLine("Livro Esgotado");
                        
                    }
                    break;
                case 1:
                    livro2 = livro2 - 1;
                    break;
                case 2:
                    livro3 = livro3 - 1;
                    break;
                case 3:
                    livro4 = livro4 - 1;
                    break;
                default:
                    Console.WriteLine("Escolha uma das opções disponíveis");
                    break;
            }
        }
    }
}
