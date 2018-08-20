using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models.Pessoas;
using WebApplication1.Models.CadastroImovel.ListaDocumentos;
using WebApplication1.Models.CadastroImovel.ListaDetalhes;

namespace WebApplication1.Models.CadastroImovel
{
    public class Imovel
    {
        private string Codigo { get; set; }
        public string DescricaoBreve { get; set; }
        public string DescricaoCompleta { get; set; }
        public ETipoNegocio TipoNegocio { get; set; }
        public EtipoDeImovel TipoDeImovel { get; set; }
        public EFinalidadeImovel Finalidade { get; set; }
        public Endereco Endereco { get; set; }
        public Pessoa Responsavel { get; set; }
        public CodigoIntegracao CdgIntegracao { get; set; }
        public double MetragemUtil { get; set; }
        public double MetragemTotal{ get; set; }
        public IList<Caracteristica> CaracteristicasPrincipais { get; set; }
        public IList<Caracteristica> CaracteristicasGerais { get; set; }
        public Valor ValorTotal { get; set; }
        public Detalhes Detalhes { get; set; }
        public IList<Anexo> Anexos { get; set; }
        public Crm Crm { get; set; }
        public IList<Documentos> Documentos { get; set; }
    }
}