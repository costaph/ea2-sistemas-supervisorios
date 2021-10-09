using System;

namespace AplicacaoInvestimentos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitando dados do Usuario
            Console.WriteLine("Informe seu montante inicial: ");
            var grana = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Informe a taxa de juros ao ano (percentual): ");
            var j_ano = float.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Informe seu periodo de aplicacao: ");
            var ano = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--------------------------------------------------------------\n");

            Investimento capital = new Investimento(grana, j_ano, ano);

            IMonetario aplicacao = capital;

            //Selecionando os Valores
            capital.setMontante(grana);
            capital.setTaxaAno(j_ano);
            capital.setPeriodoAno(ano);

            //Confirmando os valores
            Console.WriteLine("Os valores inseridos são:");
            Console.WriteLine("Montante: " + aplicacao.GetMontante());
            Console.WriteLine("Taxa de Juros Anual: " + aplicacao.GetTaxaAno());
            Console.WriteLine("Periodo de Aplicacao: " + aplicacao.GetPeriodo());

            Console.WriteLine("\n--------------------------------------------------------------\n");

            //Reposta
            Console.WriteLine("Taxa de Juros ao mes: " + capital.getTaxaMes() + "\n");
            Console.WriteLine("Resultado do montante aplicado a juros simples: " + capital.getResultadoSimples() + "\n");
            Console.WriteLine("Resultado do montante aplicado a juros compostos: " + capital.getResultadoCompostos() + "\n");
            Console.WriteLine(capital.maiorRetorno(capital.getResultadoSimples(), capital.getResultadoCompostos()));
        }
    }
}
