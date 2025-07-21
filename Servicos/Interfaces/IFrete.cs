using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesExercicios2.Enum;

namespace InterfacesExercicios2.Servicos.Interfaces
{
    internal interface IFrete
    {
        public double CalcularFrete(double peso, Regiao regiao);
    }
}
