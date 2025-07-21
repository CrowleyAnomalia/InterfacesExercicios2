using InterfacesExercicios2.Servicos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Servicos
{
    internal class ServicoImpostoRN : I_Imposto
    {
        private double taxa = 0.2;//20%
        public double CalcularImposto(double valor)
        {
            return taxa * valor;
        }
    }
}
