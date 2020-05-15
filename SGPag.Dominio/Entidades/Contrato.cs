using System;

namespace SGPag.Dominio.Entidades
{
    public class Contrato
    {
        public int Id { get; set; }
        public int FornecedorId { get; set; }
        public virtual Fornecedor Fornecedor { get; set; }
        public int CodeEscAuxId { get; set; }
        public string Aditivo { get; set; }
        public string Controle_aditivos { get; set; }
        public string Sgpag_ant { get; set; }
        public int Assinatura { get; set; }
        public int VigIndeterminada { get; set; }
        public DateTime VigInicial { get; set; }
        public DateTime VigFinal { get; set; }
        public int Objeto { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
