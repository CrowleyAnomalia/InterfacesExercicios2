using InterfacesExercicios2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfacesExercicios2.Servicos.Interfaces;

namespace InterfacesExercicios2.Servicos
{
    internal class DescontoPremium : IDesconto
    {
        private double desconto = 0.05;
        public double Descontar(double valor)
        {
            
            return valor * desconto;

        }
    }
}
