﻿using System;
using System.Collections.Generic;

namespace SGPag.Dominio.Entidades
{
    public class Fornecedor : Entidade
    {
        public int Id { get; set; }
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
        public int EstadoId { get; set; }
        public virtual Estado Estado { get; set; }
        public string Cidade { get; set; }
        public string CEP { get; set; }
        public string Pais { get; set; }
        public string Telefone { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
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
        public virtual ICollection<Contrato> Contratos { get; set; }

        public override void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
