
using System;

namespace DesignPatterns
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IEstadoOrcamento EstadoAtual { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            EstadoAtual = new EstadoEmAprovacao();
        }

        internal void Desconta(double desconto)
        {
            Valor = Valor - desconto;
        }
        public void AplicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }
        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }
        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }
    }
}
