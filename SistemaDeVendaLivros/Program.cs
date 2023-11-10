using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlPessoa controle = new ControlPessoa();
            controle.Acesso();
            Console.ReadLine();//Manter aberto
        }
    }
}
