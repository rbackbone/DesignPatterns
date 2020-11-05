
namespace DesignPatterns
{
    /// <summary>
    ///                    TEMPLATE METHOD PATTERN
    /// </summary>
    public abstract class TemplateImposto : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxa(orcamento))
            {
                return MaximaTaxa(orcamento);
            }
            return MinimaTaxa(orcamento);
        }

        protected abstract bool DeveUsarMaximaTaxa(Orcamento orcamento);
        protected abstract double MaximaTaxa(Orcamento orcamento);
        protected abstract double MinimaTaxa(Orcamento orcamento);

    }
}
