namespace AplicacaoParaEstudos.Models;

public class Contato
{
    public int Id { get; set; }

    public Pessoa Pessoa { get; set; }

    public Endereco Endereco { get; set; }

    public string NumeroTelefone { get; set; }
}