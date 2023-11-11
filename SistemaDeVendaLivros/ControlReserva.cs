using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ControlReserva
    {
        int opcao;
        ModelReserva modeloReserva;

        public ControlReserva()
        {
            modeloReserva = new ModelReserva();  
            opcao = -1;
        }

        public void MenuReserva()
        {
            Console.WriteLine("Livro indisponível para compra, gostaria de realizar a reserva?\n" +
                              "0. Não\n" +
                              "1. Sim");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("Reserva realizada em sistema");
                    break;
                default:
                    Console.WriteLine("Informe um opção válida");
                    break;
            }
        }
    }
}
