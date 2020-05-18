using System;

namespace SGPag.Dominio.Entidades
{
    public class Contrato : Entidade
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public int CodeEscAuxId { get; set; }
        public string Aditivo { get; set; }
        public string ControleAditivos { get; set; }
        public string SgpagAnt { get; set; }
        public DateTime Assinatura { get; set; }
        public int VigIndeterminada { get; set; }
        public DateTime VigInicial { get; set; }
        public DateTime VigFinal { get; set; }
        public int Objeto { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
