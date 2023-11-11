using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ModelLivro
    {
        public int livro;
        public int livro2;
        public int livro3;
        public int livro4;
        double ValorLivro;
        double ValorLivro2;
        double ValorLivro3;
        double ValorLivro4;
        public double soma;
        public ModelLivro()
        {
            livro = 1;
            livro2 = 0;
            livro3 = 2;
            livro4 = 2;
            ValorLivro = 10;
            ValorLivro2 = 10.50;
            ValorLivro3 = 11.50;
            ValorLivro4 = 25;
            soma = 0;
        }

        //Controle das quantidades de livros + o calculo da soma / valor total da compra
        public double Compra(int opcao)
        {
            do
            {
                if (opcao == 0)
                {
                    if (livro > 0)
                    {
                        livro = livro - 1;
                        soma = soma + ValorLivro;
                    }
                    return soma;
                }
                else
                {
                    if (opcao == 1)
                    {
                        if (livro2 > 0)
                        {
                            livro = livro - 1;
                            soma = soma + ValorLivro2;
                        }
                        return soma;
                    }
                    else
                    {
                        if (opcao == 2)
                        {
                            if (livro3 > 0)
                            {
                                livro = livro - 1;
                                soma = soma + ValorLivro3;
                            }
                            return soma;
                        }
                        else
                        {
                            if (opcao == 3)
                            {
                                if (livro4 > 0)
                                {
                                    livro = livro - 1;
                                    soma = soma + ValorLivro4;
                                }
                                return soma;
                            }
                            else
                            {
                                return soma;
                            }
                        }
                    }
                }
            }while(opcao != 0);
        }
    }
}
