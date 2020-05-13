using SGPag.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class Fornecedor
    {
        public string NomeSap { get; set; }
        public string NomeCnpj { get; set; }
        public string Identidade { get; set; }
        public string Email { get; set; }
        public string TipoPessoa { get; set; }
        public string CpfCnpj { get; set; }
        public int CodSap { get; set; }
        public string InscMunicipal { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public virtual Estado EstadoId { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public virtual Usuario UsuarioId { get; set; }
        public string Terouraria { get; set; }
        public string Ativo { get; set; }
        public string NomeSocio1 { get; set; }
        public string TelefoneSocio1 { get; set; }
        public string EmailSocio1 { get; set; }
        public string NomeSocio2 { get; set; }
        public string TelefoneSocio2 { get; set; }
        public string EmailSocio2 { get; set; }
        public string NomeFinanceiro1 { get; set; }
        public string TelefoneFinanceiro1 { get; set; }
        public string EmailFinanceiro1 { get; set; }
        public string NomeFinanceiro2 { get; set; }
        public string TelefoneFinanceiro2 { get; set; }
        public string EmailFinanceiro2 { get; set; }
        public virtual ICollection<Contrato>Contratos { get; set; }

    }
}
