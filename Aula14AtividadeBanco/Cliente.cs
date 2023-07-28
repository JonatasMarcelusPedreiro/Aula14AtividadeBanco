using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula14AtividadeBanco
{
    internal class Cliente
    {

        //ATRIBUTOS//


        //private = para deixar claro que é privado//
        public string nome;
        public string email;
        public string senha;
        public ContaBancaria contaBancaria;

        //MÉTODO CONSTRUTOR//

        public Cliente(string nome, string email, string senha, double saldo, bool credito, bool debito)
        {
            this.nome = nome;
            this.email = email;
            this.senha = senha;
            this.contaBancaria = new ContaBancaria(saldo, credito, debito );




        }


        //MÉTODOS//
        public void mostra()
        {


            Console.WriteLine($"Olá {nome}\n {email}");


        }

    }
}
