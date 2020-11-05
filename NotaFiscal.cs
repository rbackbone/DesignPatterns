
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    /// <summary>
    ///                      BUILDER PATTERN
    /// </summary>
    public class NotaFiscal
    {
        public NotaFiscal(string razaoSocial, string cNPJ, DateTime data, double valorTotal, double impostos, IList<NotaFiscalItem> todosItens, string observacoes)
        {
            RazaoSocial = razaoSocial;
            CNPJ = cNPJ;
            Data = data;
            ValorBruto = valorTotal;
            Impostos = impostos;
            TodosItens = todosItens;
            Observacoes = observacoes;
        }

        public string RazaoSocial { get; }
        public string CNPJ { get; }
        public DateTime Data { get; }
        public double ValorBruto { get; }
        public double Impostos { get; }
        public IList<NotaFiscalItem> TodosItens { get; }
        public string Observacoes { get; }
    }
}
