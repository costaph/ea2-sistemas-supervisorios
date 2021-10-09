using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacaoInvestimentos
{
    class Investimento : IMonetario
    {
        protected float Montante;
        protected float J_ano;
        protected int Periodo_ano;
        public Investimento (float montante, float j_ano, int periodo_ano)
            {
                Montante = montante;
                J_ano = j_ano/100;
                Periodo_ano = periodo_ano;
            }

        public float setMontante(float montante)
        {
            return this.Montante = montante;
        }

        public float setTaxaAno(float j_ano)
        {
            return this.J_ano = j_ano/100;
        }
        public int setPeriodoAno(int periodo_ano)
        {
            return this.Periodo_ano = periodo_ano;
        }

        float IMonetario.GetMontante()
        {
            return Montante;
        }
        float IMonetario.GetTaxaAno()
        {
            return J_ano;
        }
        float IMonetario.GetPeriodo()
        {
            return Periodo_ano;
        }

        //Obtendo a taxa de juros ao mês
        public double getTaxaMes()
        {
            double j_mes = (Math.Pow(1 - J_ano, 1/12)) - 1;

            return j_mes;
        }

        //Calculo Juros Simples
        public double getResultadoSimples()
        {
            double mj_simples = Montante + (Montante * J_ano * Periodo_ano);

            return mj_simples;
        }

        //Calculo Juros Compostos
        public double getResultadoCompostos()
        {
            double mj_compostos = Montante + Math.Pow((1 + J_ano), Periodo_ano);

            return mj_compostos;
        }

        //Calculo do Maior Retorno por Investimento
        public double maiorRetorno(double mj_simples, double mj_compostos)
        {
            if (mj_simples > mj_compostos)
            {
                Console.WriteLine("Os Juros Simples deram maior retorno. Sendo seu valor: ");
                return mj_simples;
            } else
            {
                Console.WriteLine("Os Juros Compostos deram maior retorno. Sendo seu valor: ");
                return mj_compostos;
            }
        }
    }
}
