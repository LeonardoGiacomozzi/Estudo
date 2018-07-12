using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usando_class_e_obj
{
    class Class1
    {
        public int numero;

        public string titular;

        public double saldo;

        public int agencia;

        public string cpf;

        public void saca(double valor) {

            this.saldo -= valor;

        }

        public void deposito(double valor) {

            this.saldo += valor;


        }

        public void tranfere(double valor, Class1 destino) {

            this.saca(valor);
            destino.deposito(valor);

        }

    }
}
