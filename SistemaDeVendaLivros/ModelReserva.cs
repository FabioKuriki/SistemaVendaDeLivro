using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ModelReserva
    {
        int[] id;
        string[] nome;
        string[] endereco;
        int[] telefone;
        int i;
        string[] nomeLivro;
        
        public ModelReserva()
        {
            i = 0;
            id = new int[2];
            nome = new string[2];
            endereco = new string[2];
            telefone = new int[2];
            nomeLivro = new string[2];
            
        }

        public void ZerarReserva()
        {
            for(i = 0; i < 2; i++)
            {
                id[i] = -1;
            }
        }
        public void PreenchimentoReserva(int id2, string nome2, string endereco2, int telefone2, string nomeLivro2)
        {
            for(i = 0; i < 2; i++)
            {
                if (id[i] == -1)
                {
                    id[i] = id2;
                    nome[i] = nome2;
                    endereco[i] = endereco2;
                    telefone[i] = telefone2;
                    nomeLivro[i] = nomeLivro2;
                    break;
                }
            }
        }

        public void MostrarVetor()
        {
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("\nID: " + id[i]);
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Endereco: " + endereco[i]);
                Console.WriteLine("Telefone: " + telefone[i]);
                Console.WriteLine("Nome do Livro: " + nomeLivro[i]);
            }
        }
    }
}
