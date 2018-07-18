using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M009.BancoComArray.Contas;
namespace M009.BancoComArray.Extra
{
    class Totalizador
    {
        public double Total { get; private set; }

        public void Adiciona(Conta conta)
        {

            Total += conta.Saldo;

        }
    }
}
