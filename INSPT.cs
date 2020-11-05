
namespace DesignPatterns
{
    public class INSPT : ImpostoComposto
    {
        public INSPT(ImpostoComposto outroimposto): base(outroimposto) { }

        public INSPT() : base () { }

        public override double Calcular(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.06) + CalculoOutroImposto(orcamento);
        }

    }
}
