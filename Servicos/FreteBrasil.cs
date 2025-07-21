using InterfacesExercicios2.Enum;
using InterfacesExercicios2.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Servicos
{
    internal class FreteBrasil : IFrete
    {
        private double ValorFixo = 5.0;
        

        public double CalcularFrete(double peso, Regiao regiao)
        {
            double valorPorPeso = (peso > 10) ? 5.0 : 2.0;

            double calculo = (valorPorPeso * peso) + ValorFixo + TaxaRegiao.CalcTaxaR(regiao);
            return calculo;


        }

    }
}
