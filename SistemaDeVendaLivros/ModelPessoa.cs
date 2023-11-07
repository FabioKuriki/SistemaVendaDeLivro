using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ModelPessoa
    {
        string[] login;
        string[] senha;
        int i;
        //Método Construtor
        public ModelPessoa()
        {
            login = new string[2];
            senha = new string[2];
            i = 0;
            
        }
        //Fim do Construtor

        public void Preenchimento(string login2, string senha2)
        {
            for (i = 0; i < 2; i++)
            {
                if (login[i] == null && senha[i] == null)
                {
                    login[i] = login2;
                    senha[i] = senha2;
                    break;
                }
            }
        }

        public Boolean Validacao(string login2,string senha2)
        {
            for (i = 0; i < 2; i++)
            {
                if (login2 == login[i] && senha2 == senha[i])
                {
                    return true;
                }
                
            }
            return false;
        }

        public void MostrarVetor()
        {
            for (i = 0; i < 2; i++)
            {
                Console.WriteLine("Login: " + login[i]);
                Console.WriteLine("Senha: " + senha[i]);
            }
        }
    }
}
