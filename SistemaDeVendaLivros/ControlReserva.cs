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
        public string nomeLogado;
        public string enderecoLogado;
        public int telefoneLogado;
        public int idLogado;
        public string nomeLivro;
        Boolean parar;

        public ControlReserva()
        {
            modeloReserva = new ModelReserva();
        }

        public void MenuReserva()
        {
            Console.WriteLine("Livro indisponível para compra, gostaria de realizar a reserva?\n" +
                              "0. Não\n" +
                              "1. Sim");
            opcao = Convert.ToInt32(Console.ReadLine());
        }

        public void SistemaReserva()
        {
            if (parar == false)
            {
                modeloReserva.ZerarReserva();
                parar = true;
            }
            MenuReserva();
            switch (opcao)
            {
                case 0:
                    break;
                case 1:
                    modeloReserva.PreenchimentoReserva(idLogado, nomeLogado, enderecoLogado, telefoneLogado, nomeLivro);
                    Console.WriteLine("Reserva realizada em sistema");
                    break;
                case 2:
                    modeloReserva.MostrarVetor(); //Para consultar se os dados foram inseridos
                    break;
                default:
                    Console.WriteLine("Informe um opção válida");
                    break;
            }
        }
    }
}
