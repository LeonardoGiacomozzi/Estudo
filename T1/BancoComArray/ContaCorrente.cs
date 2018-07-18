using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009.BancoComArray.Contas
{
    class ContaCorrente : Conta
    {
        public ContaCorrente()
        {

            Titular = new Usuario.Cliente();

        }
        public override void Saque(double valor)
        {
            
            if (valor <= this.Saldo && valor > 0)
             {

                this.Saldo -= valor + 0.05;

             }
            
        }
    }
}
