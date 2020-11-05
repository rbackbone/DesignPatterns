using System;

namespace DesignPatterns
{
    /// <summary>
    ///                       STATE PATTERN
    /// </summary>

    public class EstadoAprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Desconta(0.02);
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em Aprovação!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoFinalizado();
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está em Aprovação!");
        }
    }
}
