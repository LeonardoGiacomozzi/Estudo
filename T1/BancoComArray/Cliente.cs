using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M009.BancoComArray.Usuario
{
   public class Cliente
    {

        public string Nome { get; set; }

        public string Rg { get; set; }

        public string Endereco { get; set; }

        public int Idade { get; set; }

        public bool EhMaiorDeIdade()
        {

            return this.Idade >= 18;

        }

    }
}
