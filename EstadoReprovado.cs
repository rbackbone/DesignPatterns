using System;

namespace DesignPatterns
{
    /// <summary>
    ///                       STATE PATTERN
    /// </summary>

    public class EstadoReprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orçamento reprovado!");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Reprovado!");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Reprovado!");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orçamento já está Reprovado!");
        }
    }
}
