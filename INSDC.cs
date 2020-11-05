
namespace DesignPatterns
{
    class INSDC : ImpostoComposto
    {
        public INSDC(ImpostoComposto outroimposto) : base(outroimposto) { }
        public INSDC() : base() { }

        public override double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.16) + CalculoOutroImposto(orcamento);
        }

    }
}
