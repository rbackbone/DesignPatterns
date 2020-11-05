using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    ///                      BUILDER PATTERN
    /// </summary>
    public class NotaFiscalItem
    {
        public NotaFiscalItem(string descricao, double valor, double imposto)
        {
            Valor = valor;
            Imposto = imposto;
            Descricao = descricao;
        }

        public double Valor { get; set; }
        public double Imposto { get; set; }
        public string Descricao { get; set; }


    }
}
