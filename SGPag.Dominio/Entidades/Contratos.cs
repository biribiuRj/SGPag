using SGPag.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Contratos
    {
        public int Id { get; set; }
        public Fornecedores FornecedorId { get; set; }
        public Fornecedores CodeEscAux { get; set; }
        public string Aditivo { get; set; }
        public string Controle_aditivos { get; set; }
        public string Sgpag_ant { get; set; }
        public int Assinatura { get; set; }
        public int VigIndeterminada { get; set; }
        public DateTime VigInicial { get; set; }
        public DateTime VigFinal { get; set; }
        public int Objeto { get; set; }
        public string Enviado { get; set; }
        public DateTime Validado_em { get; set; }
        public Usuarios User_validado { get; set; }
        public string Anexo_contrato { get; set; }
        public string Num_aditivo { get; set; }
        public string Fixo { get; set; }
        public string Variavel { get; set; }
        public string Proposta { get; set; }
        public string Ativo { get; set; }
        public Empresas Empre { get; set; }
        public string Are { get; set; }
        public Estados Estad { get; set; }
        public string Cid { get; set; }
        public string Obs { get; set; }
        public string Just { get; set; }
        public Usuarios User_cadastro { get; set; }
        public Usuarios User_alteracao { get; set; }
        public DateTime Updated_at { get; set; }
        public DateTime Dt_protocolo { get; set; }
        public DateTime Dt_validacao { get; set; }
        public string Validar { get; set; }
        public string Protocolo { get; set; }
    }
}
