public class Cliente
{
    public string Nome { get; set; }
    public string NumeroIdentificacao { get; set; }
    public string Contato { get; set; }

    public Cliente(string nome, string numeroidentificaco, string contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroidentificaco;
        Contato = contato;
    }
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Número de identificação: {Nome}");
        Console.WriteLine($"Contato: {Contato}");
    }
}