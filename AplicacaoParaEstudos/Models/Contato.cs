namespace AplicacaoParaEstudos.Models;

public class Contato
{
    public Pessoa Pessoa { get; set; }

    public string NumeroTelefone { get; set; }

    public Endereco Endereco { get; set; }
}