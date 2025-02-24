using AplicacaoParaEstudos.Models;

int opcao;

var contato = new Contato
{
    Pessoa = new Pessoa(),
    Endereco = new Endereco()
};

var agenda = new List<Contato>();

//TO DO: validacao de id existente, opcao de deletar contato
Console.WriteLine("Agenda");

do
{
    Console.WriteLine("\nInsira a opção que deseja:");
    Console.WriteLine("1 - Cadastro");
    Console.WriteLine("2 - Buscar");
    Console.WriteLine("0 - Sair");

    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            var contatoPreenchido = CadastrarContato(contato);

            agenda.Add(contatoPreenchido);
            break;

        case 2:
            var contatoEncontrado = BuscarContato(agenda);
            ImprimirContato(contatoEncontrado);
            break;
    }
} while (opcao != 0);

Contato CadastrarContato(Contato contato)
{
    Console.WriteLine("\nDigite os dados do novo CONTATO:");

    Console.Write("Digite o telefone: ");
    contato.NumeroTelefone = Console.ReadLine();

    Console.Write("Digite o ID: ");
    contato.Id = int.Parse(Console.ReadLine());

    Console.Write("Digite o nome: ");
    contato.Pessoa.Nome = Console.ReadLine();

    Console.Write("Digite a idade: ");
    contato.Pessoa.Idade = int.Parse(Console.ReadLine());

    Console.Write("Digite o genero: ");
    contato.Pessoa.Genero = char.Parse(Console.ReadLine());

    Console.Write("Digite a rua: ");
    contato.Endereco.Rua = Console.ReadLine();

    Console.Write("Digite o número da casa: ");
    contato.Endereco.NumeroCasa = int.Parse(Console.ReadLine());

    return contato;
}

Contato BuscarContato(List<Contato> agenda)
{
    Console.Write("\nInforme o ID do contato que seseja buscar: ");
    var id = int.Parse(Console.ReadLine());

    foreach (var contato in agenda)
    {
        if (id == contato.Id)
        {
            return contato;
        }
    }
    return null;
}

void ImprimirContato(Contato contato)
{
    Console.WriteLine("Número: " + contato.NumeroTelefone);
    Console.WriteLine("ID: " + contato.Id);
    Console.WriteLine("Nome: " + contato.Pessoa.Nome);
    Console.WriteLine("Idade: " + contato.Pessoa.Idade);
    Console.WriteLine("Genero: " + contato.Pessoa.Genero);
    Console.WriteLine("Rua: " + contato.Endereco.Rua);
    Console.WriteLine("Número da casa: " + contato.Endereco.NumeroCasa);
}