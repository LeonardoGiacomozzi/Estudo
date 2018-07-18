using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using M009.BancoComArray.Usuario;

namespace M009.BancoComArray.Contas
{
    public abstract class Conta
    {
        public double Saldo { get; protected set; }

        public int Numero { get; set; }

        public Cliente Titular { get; set; }

        public virtual void Deposita(double valor)
        {
            if (valor >= 0)
            {
                this.Saldo += valor;
            }
        }

        public bool VerificaSaque(double valor)
        {
            bool valid = false;
            if (this.Saldo >= valor && valor >= 0)
            {
                if (Titular.EhMaiorDeIdade())
                {

                    Saque(valor);
                    valid = true;
                }
                else if (!Titular.EhMaiorDeIdade() && valor <= 200)
                {

                    Saque(valor);
                    valid = true;
                }
                else
                {

                    valid = false;
                }
            }


            return valid;
        }

        public virtual void Saque(double valor)
        {

            if (valor <= this.Saldo && valor > 0)
            {

                this.Saldo -= valor;

            }
        }

        public void Transfere(double valor, Conta destino)
        {
            Saque(valor);
            destino.Deposita(valor);
        }

        public Conta()
        {
            Titular = new Cliente();
        }
    }
}

