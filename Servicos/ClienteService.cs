using InterfacesExercicios2.Servicos.Interfaces;
using InterfacesExercicios2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Servicos
{
    internal class ClienteService
    {
        private I_Imposto _Imposto; IFrete _Frete; IDesconto _Desconto;
        public ClienteService(I_Imposto imposto, IFrete frete)
        {
            _Imposto = imposto;
            _Frete = frete;            
        }

        public ClienteService(I_Imposto imposto, IFrete frete, IDesconto desconto)
        {
            _Imposto = imposto;
            _Frete = frete;
            _Desconto = desconto;
        }
        //aplicando a inversão de controle por injeção de dependencia por construtor

        public double ProcessarPedido(Cliente cliente)
        {
            
            double subtotal = 0;

            foreach (var item in cliente.livros)
            {
                subtotal += item.Preco;

            }
            subtotal += _Imposto.CalcularImposto(subtotal) + _Frete.CalcularFrete(cliente.GetPeso(), cliente.Localizacao);
            double total = (cliente.Premium) ? subtotal -= _Desconto.Descontar(subtotal) : subtotal;
            return total;
        }
        
        
        
    }
}
