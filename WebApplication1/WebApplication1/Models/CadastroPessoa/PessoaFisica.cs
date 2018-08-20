using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Models.Pessoas
{
    public class PessoaFisica:Pessoa
    {
        public ETipoPessoa eTipo { get; private set; }
        public string Nome { get; set; }
        public string Apelido { get; set; }
        public string Atividade { get; set; }
        public string Proficao { get; set; }
        public EEstadoCivil EEstadoCivil { get; set; }
        public string Nacionalidade { get; set; }
        public string NomePai { get; set; }
        public string NomeMae { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cpf { get; set; }
        public string Rg{ get; set; }
        public string Local { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EmailPrincipal { get; set; }
        public string EmailSecundario { get; set; }
        public string WebSite { get; set; }
        public string Observacao { get; set; }
        public Endereco Endereco{ get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string Operadora { get; set; }


        public PessoaFisica()
        {
        }
    }
}
