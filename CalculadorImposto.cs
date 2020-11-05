
namespace DesignPatterns
{
    public class CalculadorImposto
    {

        public double Calcular (Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);
        }

    }
}
