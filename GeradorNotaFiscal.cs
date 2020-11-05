using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    /// <summary>
    ///                      BUILDER PATTERN
    /// </summary>
    public class GeradorNotaFiscal
    {
        public string RazaoSocial { get; private set; }
        public string CNPJ { get; private set; }
        public string Observacoes { get; private set; }
        public DateTime Data { get; private set; }
        private double _valorTotal;
        private double _impostos;
        private IList<NotaFiscalItem> _todosItens = new List<NotaFiscalItem>();

        private IList<INotaFiscalAcoes> _acoesAposGerarNF = new List<INotaFiscalAcoes>();

        ///                   OBSERVER PATTERN
        public void AdicionarAcao(INotaFiscalAcoes novaAcao)
        {
            this._acoesAposGerarNF.Add(novaAcao);
        }
        public GeradorNotaFiscal ParaEmpresa(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public GeradorNotaFiscal ComCnpj(string cnpj)
        {
            this.CNPJ = cnpj;
            return this;
        }
        public GeradorNotaFiscal ComObservacoes(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
        public GeradorNotaFiscal NaDataAtual()
        {
            this.Data = DateTime.Now;
            return this;
        }

        public GeradorNotaFiscal comItem(NotaFiscalItem item)
        {
            _todosItens.Add(item);
            _valorTotal += item.Valor;
            _impostos += item.Valor * item.Imposto;
            return this;
        }

        public NotaFiscal Gerar()
        {
            NotaFiscal nf = new NotaFiscal(RazaoSocial, CNPJ, Data, _valorTotal, _impostos, _todosItens, Observacoes);

            ///       OBSERVER PATTERN

            foreach (INotaFiscalAcoes acao in _acoesAposGerarNF)
            {
                acao.Executar(nf);
            }

            return nf; 
        }
    }
}
