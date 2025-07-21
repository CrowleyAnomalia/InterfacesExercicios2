using InterfacesExercicios2.Entities;
using InterfacesExercicios2.Enum;
using InterfacesExercicios2.Servicos;
using InterfacesExercicios2.Servicos.Interfaces;
try {
    Console.WriteLine("Bem vindo ao sistema");
    Console.WriteLine("");
    Console.WriteLine("Para começar entre com os seus dados:");
    Console.Write("Nome: "); string nome = Console.ReadLine();
    Console.Write("ID: "); int id = int.Parse(Console.ReadLine());
    Console.Write("Localização:(Sul/Norte/Nordeste/Centroeste/Sudeste) ");
    string localizacao = Console.ReadLine();
    Enum.TryParse<Regiao>(localizacao, ignoreCase: true, out var regiao);//muito importante

    Cliente cliente = new(id, nome, regiao);
    Console.Write("Deseja se tornar Premium e ganhar um desconto de 5% em todos os pedidos? S/N");
    string escolha = Console.ReadLine();
    char sn = char.ToUpper(escolha[0]);

    switch (sn)
    {
        case 'S':
            Console.WriteLine("Perfeito! Agora você é cliente premium");
            cliente.ContratarPremium();
            break;
        case 'N':
            break;
    }
    Console.Write("Quantos livros deseja comprar? ");
    int qnt = int.Parse(Console.ReadLine());
    for (int i = 0; i < qnt; i++)
    {
        Console.WriteLine($"Dados do Livro{i + 1}");
        Console.Write("Nome: "); string livronome = Console.ReadLine();
        Console.Write("Preço: "); double preco = double.Parse(Console.ReadLine());
        Console.Write("Peso: "); double peso = double.Parse(Console.ReadLine());
        Livro livro = new(livronome, preco, peso);
        cliente.AdicionarLivros(livro);
    }
    Console.WriteLine("Subtotal:");
    foreach (var l in cliente.livros)
    {
        Console.WriteLine(l);
    }

    ClienteService clienteService = new(new ServicoImpostoRN(), new FreteBrasil(), new DescontoPremium());
    Console.WriteLine($"Total: {clienteService.ProcessarPedido(cliente)}");
}
catch (Exception ex) { Console.WriteLine(ex.Message); }









