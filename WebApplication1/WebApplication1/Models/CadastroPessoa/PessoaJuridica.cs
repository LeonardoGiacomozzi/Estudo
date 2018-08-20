using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models.Pessoas
{
    public class PessoaJuridica:Pessoa
    {
        public ETipoPessoa eTipo { get; private set; }
        public string NomeEmpresa { get; set; }
        public string Nacionalidade { get; set; }
        public string NomeResponsavel { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string InscricaoEstadual { get; set; }
        public string Cnpj { get; set; }
        public string EmailPrincipal { get; set; }
        public string EmailSecundario { get; set; }
        public string WebSite { get; set; }
        public string Observacao { get; set; }
        public Endereco Endereco{ get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string Operadora { get; set; }
    }
}