
namespace DesignPatterns
{
    public class IKCV : TemplateImposto
    {
        protected override bool DeveUsarMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor > 500;
        }

        protected override double MaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        protected override double MinimaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
