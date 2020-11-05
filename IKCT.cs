
namespace DesignPatterns
{
    public class IKCT : TemplateImposto
    {
        protected override bool DeveUsarMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor > 750;
        }

        protected override double MaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.3;
        }

        protected override double MinimaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.08;
        }
    }
}
