using InterfacesExercicios2.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercicios2.Entities
{
    internal class Cliente
    {
        public int Id { get; private set; }
        public string Nome {  get; private set; }
        public bool Premium { get; private set; }
        public Regiao Localizacao { get; private set; }
        public List<Livro> livros { get; private set; }

        public Cliente(int id, string nome, Regiao localizacao)
        {
            Id = id;
            Nome = nome;
            Premium = false;//redundancia
            Localizacao = localizacao;
        }
        public void ContratarPremium() 
        { Premium = true; }
        public void AdicionarLvros(Livro livro)
        {
            livros.Add(livro);
        }
        public double GetPeso()
        {
            double pesoTotal = 0;
            foreach (var l in livros)
            {
                pesoTotal += l.Peso;
            }
            return pesoTotal;
        }

    }
}
