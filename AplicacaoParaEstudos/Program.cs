using AplicacaoParaEstudos.Models;

int opcao;

var contato = new Contato
{
    Pessoa = new Pessoa(),
    Endereco = new Endereco()
};

Console.WriteLine("Agenda");

Console.Write("Insira a opção que deseja: ");

opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 0:
        CadastrarContato(contato);//implementar validacoes.
        break;

    case 1:
        //buscar contato
        break;
}

void CadastrarContato(Contato contato)
{
    Console.WriteLine("\nDigite os dados do novo CONTATO:");

    Console.Write("Digite o telefone: ");
    contato.NumeroTelefone = Console.ReadLine();

    Console.Write("Digite o ID: ");
    contato.Pessoa.Id = int.Parse(Console.ReadLine());

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
}