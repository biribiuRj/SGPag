using System;
using System.Collections.Generic;
using System.Text;

namespace SGPag.Dominio.Entidades
{
    public class DadosContrato
    {
        public int Id { get; set; }
        public virtual Fornecedor CodeEscAux { get; set; }
        public virtual Contrato ContratoId { get; set; }
        public int ValorFixo { get; set; }
        public int VolumeFixo { get; set; }
        public int QntProcCap { get; set; }
        public int ValProcCap { get; set; }
        public int QntProcInt { get; set; }
        public int ValProcInt { get; set; }
        public int QntAudCap { get; set; }
        public int ValAudCap { get; set; }
        public int QntAudInt { get; set; }
        public int ValAudInt { get; set; }
        public int QntPerCap { get; set; }
        public int ValPerCap { get; set; }
        public int QntPerInt { get; set; }
        public int ValPerInt { get; set; }
        public int Hora1 { get; set; }
        public int Hora2 { get; set; }
        public int Hora3 { get; set; }
        public int Hora4 { get; set; }
        public int Hora5 { get; set; }
        public int Hora6 { get; set; }
        public int Hora7 { get; set; }
        public int Hora8 { get; set; }
        public int Hora9 { get; set; }
        public int Hora10 { get; set; }
        public int Hora11 { get; set; }
        public int Hora12 { get; set; }
        public int PropostaTexto1 { get; set; }
        public int PropostaTexto2 { get; set; }
        public int PropostaTexto3 { get; set; }
        public int PropostaTexto4 { get; set; }
        public int PropostaTexto5 { get; set; }
        public int PropostaTexto6 { get; set; }
        public int PropostaTexto7 { get; set; }
        public int PropostaTexto8 { get; set; }
        public int PropostaValor1 { get; set; }
        public int PropostaValor2 { get; set; }
        public int PropostaValor3 { get; set; }
        public int PropostaValor4 { get; set; }
        public int PropostaValor5 { get; set; }
        public int PropostaValor6 { get; set; }
        public int PropostaValor7 { get; set; }
        public int PropostaValor8 { get; set; }
    }
}