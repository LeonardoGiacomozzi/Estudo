    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M009.BancoComArray.Contas;

namespace M009.BancoComArray.Extra

{
    class Banco
    {

        public Conta[] conta = new Conta[10];

        private int cont = 0;
        public void Adciona() {

            

            if (cont < 9)
            {

                this.conta[cont] = new ContaCorrente();


                cont++;

            }
           
           
            
        }


    }
}
