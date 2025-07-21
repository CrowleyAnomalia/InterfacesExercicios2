using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Servicos.Interfaces
{
    internal interface I_Imposto
    {
        //criei uma interface imposto pois impostos não são fixos em todos os lugares,
        //imposto do RN é diferente do imposto de SC por exemplo
        public double CalcularImposto(double valor);
    }
}
