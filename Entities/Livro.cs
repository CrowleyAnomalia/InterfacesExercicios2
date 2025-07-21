using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Entities
{
    internal class Livro
    {
        public string Nome { get; set; }
        public double Preco { get; private set; }
        public double Peso { get; private set; }

        public Livro(string nome, double preco, double peso)
        {
            Nome = nome;
            Preco = preco;
            Peso = peso;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Nome} - R${Preco.ToString("F2")}");
            return sb.ToString();
        }
    }
}
