using System;

namespace DesignPatterns
{
    /// <summary>
    ///                       STATE PATTERN
    /// </summary>

    public class EstadoFinalizado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento já finalizado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Finalizado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Finalizado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Finalizado!");
        }
    }
}
