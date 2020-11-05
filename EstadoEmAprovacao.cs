using System;

namespace DesignPatterns
{
    /// <summary>
    ///                       STATE PATTERN
    /// </summary>

    public class EstadoEmAprovacao : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Desconta(0.6);
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoAprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento em Aprovação - não pode ser diretamente finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new EstadoReprovado();
        }
    }
}
