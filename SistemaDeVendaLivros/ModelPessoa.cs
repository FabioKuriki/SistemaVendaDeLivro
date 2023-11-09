using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    class ModelPessoa
    {
        int[] id;
        string[] login;
        string[] senha;
        string[] nome;
        string[] endereco;
        int[] telefone;
        int[] dia;
        int[] mes;
        int[] ano;
        int i;
        //Método Construtor
        public ModelPessoa()
        {
            id = new int[2];
            nome = new string[2];
            endereco = new string[2];
            telefone = new int[2];
            dia = new int[2];
            mes = new int[2];
            ano = new int[2];
            login = new string[2];
            senha = new string[2];
            i = 0;
            
        }
        //Fim do Construtor

        public void Preenchimento(string login2, string senha2, string nome2, string endereco2, int telefone2, int dia2, int mes2, int ano2)
        {
            for (i = 0; i < 2; i++)
            {
                if (login[i] == null && senha[i] == null)
                {
                    id[i] = i;
                    nome[i] = nome2;
                    endereco[i] = endereco2;
                    telefone[i] = telefone2;
                    dia[i] = dia2;
                    mes[i] = mes2;
                    ano[i] = ano2;
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
                Console.WriteLine("\nID: " + id[i]);
                Console.WriteLine("Nome: " + nome[i]);
                Console.WriteLine("Endereco: " + endereco[i]);
                Console.WriteLine("Telefone: " + telefone[i]);
                Console.WriteLine("Dia: " + dia[i]);
                Console.WriteLine("Mês: " + mes[i]);
                Console.WriteLine("Ano: " + ano[i]);
                Console.WriteLine("Login: " + login[i]);
                Console.WriteLine("Senha: " + senha[i]);
            }
        }
    }
}
