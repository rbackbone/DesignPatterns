using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----- Curso Design Patterns -----");

            IImposto iss = new ISS();
            IImposto icms = new ICMS();

            Orcamento orcamento = new Orcamento(500);

            CalculadorImposto calculador = new CalculadorImposto();
            var resultado = calculador.Calcular(orcamento, iss);

            Console.WriteLine($"Orçamento ISS: {orcamento.Valor} , Imposto: {resultado}");

            IImposto ickv = new IKCV();
            resultado = calculador.Calcular(orcamento, ickv);

            Console.WriteLine($"Orçamento IKCV: {orcamento.Valor} , Imposto: {resultado}");

            ImpostoComposto insdc = new INSDC(new INSPT());

            Console.WriteLine($"Orçamento INSDC: {orcamento.Valor} , Imposto: {insdc.Calcular(orcamento)}");


            Orcamento marketing = new Orcamento(1200);
            marketing.AplicaDescontoExtra();
            Console.WriteLine($"Orçamento Marketing: {marketing.Valor} , Estado: {marketing.EstadoAtual}");

            marketing.Aprova();
            marketing.AplicaDescontoExtra();
            Console.WriteLine($"Orçamento Marketing: {marketing.Valor} , Estado: {marketing.EstadoAtual}");

            marketing.Finaliza();
            Console.WriteLine($"Orçamento Marketing: {marketing.Valor} , Estado: {marketing.EstadoAtual}");
           // marketing.AplicaDescontoExtra();


            ///        BUILDER PATTERN / FLUENT INTERFACE

            GeradorNotaFiscal geradorNF = new GeradorNotaFiscal();
            geradorNF
                     .ParaEmpresa("RMac Hambone Sys compliance")
                     .ComCnpj("923.321.001/0001-12")
                     .comItem(new NotaFiscalItem("item 1", 10.2, 0.1))
                     .comItem(new NotaFiscalItem("item 2", 13.7, 0.1))
                     .comItem(new NotaFiscalItem("item 3", 20.2, 0.1))
                     .comItem(new NotaFiscalItem("item 4", 110.2, 0.1))
                     .NaDataAtual()
                     .ComObservacoes("Entregar no bar da esquina");

            ///       OBSERVER PATTERN

            geradorNF.AdicionarAcao(new NotaDao());
            geradorNF.AdicionarAcao(new NotaEnvio());
            geradorNF.AdicionarAcao(new NotaSMS());

            NotaFiscal NF001 = geradorNF.Gerar();

            Console.WriteLine($"Notafiscal: Valor {NF001.ValorBruto} - Impostos: {NF001.Impostos}");





            Console.ReadKey();
        }
    }
}
