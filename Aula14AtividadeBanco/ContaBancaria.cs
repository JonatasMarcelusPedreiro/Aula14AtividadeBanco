using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula14AtividadeBanco
{
    internal class ContaBancaria
    {
        //ATRIBUTOS//


        //private = para deixar claro que é privado//
        public double saldo;
        public bool credito;
        public bool debito;


        //MÉTODO CONSTRUTOR//

        public ContaBancaria(double saldo, bool credito, bool debito )
        {
            this.saldo = saldo;
            this.credito = true;
            this.debito = false;






        }


        //MÉTODOS//
        public void mostra()
        {


            Console.WriteLine($"seu saldo é de {saldo} \n cartão de débito{debito} \n cartão de crédito {credito}");


        }



    }
}
