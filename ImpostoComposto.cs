
namespace DesignPatterns
{
    /// <summary>
    ///                              DECORATOR PATTERN
    /// </summary>
    public abstract class ImpostoComposto
    {
        public ImpostoComposto OutroImposto { get; set; }

        public ImpostoComposto(ImpostoComposto outroimposto)
        {
            this.OutroImposto = outroimposto;
        }
        public ImpostoComposto()
        {
            this.OutroImposto = null;
        }


        public abstract double Calcular(Orcamento orcamento);
        protected double CalculoOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            return OutroImposto.Calcular(orcamento);
        }


    }
}
