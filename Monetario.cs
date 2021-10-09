using System;
using System.Collections.Generic;
using System.Text;

namespace AplicacaoInvestimentos
{
    public interface IMonetario
    {
        float GetMontante();
        float GetPeriodo();
        float GetTaxaAno();
    }
}
