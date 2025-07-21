using InterfacesExercicios2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Servicos
{
    internal class TaxaRegiao
    {
        public static double CalcTaxaR(Regiao regiao)
        {
            double frete = 0;
            switch (regiao)
            {
                case Regiao.Norte:
                     frete = 30.0;
                    break;
                case Regiao.Nordeste:
                    frete = 0.0;
                    break;
                case Regiao.Sul:
                    frete = 50.0;
                    break;
                case Regiao.Centroeste:
                    frete = 25.0;
                    break;
                case Regiao.Sudeste:
                    frete = 80.0;
                    break;

            }
            return frete;           
                 
            
        }
    }
}
