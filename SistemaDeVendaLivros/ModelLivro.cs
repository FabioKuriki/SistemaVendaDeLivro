using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ModelLivro
    {
        double soma;
        public ModelLivro()
        {
            soma = 0;
        }

        public double Compra(double ValorLivro)
        {
            soma = soma + ValorLivro;
            return soma;
        }
    }
}
