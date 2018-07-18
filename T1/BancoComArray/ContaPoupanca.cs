using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M009.BancoComArray.Extra;

namespace M009.BancoComArray.Contas
{
    class ContaPoupanca : Conta, ITributavel
    {

        public ContaPoupanca() {

            Titular = new Usuario.Cliente();

        }

        public override void Deposita(double valor)
        {
            if (valor >= 0)
            {
                this.Saldo += valor + 0.1;
            }
        }

        public double CalculaTributo() {

            return this.Saldo * 0.02;
        }
    }
}
