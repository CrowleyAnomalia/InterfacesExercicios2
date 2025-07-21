using InterfacesExercicios2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Servicos.Interfaces
{
    internal interface IDesconto
    {
        //criei pois futuramente pode haver outros tipos de desconto, como black friday, semana do consumidor etc...
        public double Descontar(double valor);
    }
}
