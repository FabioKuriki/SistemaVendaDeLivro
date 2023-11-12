﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaLivros
{
    public class ModelPessoa
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
        string nomeLogado;
        string enderecoLogado;
        int telefoneLogado;
        int idlogado;
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

        public void EsvaziarVetor()//Todos os IDs ficam com -1 até serem preenchidos
        {
            for(i = 0; i < 2; i++)
            {
                id[i] = -1;
            }
        }

        //Preenchimento para banco de dados do cadastro
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

        //Validação para que não haja a criação de logins iguais
        public Boolean ValidacaoLoginExistente(string login2)
        {
            for(i = 0; i < 2; i++)
            {
                if(login2 == login[i])
                {
                    return true;
                }
            }
            return false;
        }

        //Validação de login para acesso aos livros
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

        //Teste para ver como os vetores estão preenchidos
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

        public string ProcuraNome(string login2)
        {
            for(i = 0; i < 2; i++)
            {
                if(login2 == login[i])
                {
                    nomeLogado = nome[i];
                }
            }
            return nomeLogado;
        }

        public string ProcuraEndereco(string login2)
        {
            for (i = 0; i < 2; i++)
            {
                if (login2 == login[i])
                {
                    enderecoLogado = endereco[i];
                }
            }
            return enderecoLogado;
        }
        public int ProcuraTelefone(string login2)
        {
            for (i = 0; i < 2; i++)
            {
                if (login2 == login[i])
                {
                    telefoneLogado = telefone[i];
                }
            }
            return telefoneLogado;
        }
        public int ProcuraId(string login2)
        {
            for (i = 0; i < 2; i++)
            {
                if (login2 == login[i])
                {
                    idlogado = id[i];
                }
            }
            return idlogado;
        }
    }
}
