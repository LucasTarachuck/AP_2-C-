
public class Destino 
{
    public string NomeLocal { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }

    public Destino(string nomelocal, string pais, string codigo, string descricao)
    {
        NomeLocal = nomelocal;
        Pais = pais;
        Codigo = codigo;
        Descricao = descricao;
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Local: {NomeLocal}");
        Console.WriteLine($"Pais: {Pais}");
        Console.WriteLine($"Código: {Codigo}");
        Console.WriteLine($"Descrição: {Descricao}");
    }
    public void PesquisarPorCodigo(string codigo)
    {
        if(codigo == Codigo)
        {
            Console.WriteLine($"Destino: {NomeLocal}");
            Console.WriteLine($"Pais: {Pais}");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine($"Descricao: {Descricao}");
        }
        else
        {
            Console.WriteLine("Código não encontrado");
        }
    }
    public void PesquisarPorNome(string nome)
    {
        if(nome == NomeLocal)
        {
            Console.WriteLine($"Destino: {NomeLocal}");
            Console.WriteLine($"Pais: {Pais}");
            Console.WriteLine($"Codigo: {Codigo}");
            Console.WriteLine($"Descricao: {Descricao}");
        }
    }

    internal static bool Contains(Destino destino)
    {
        throw new NotImplementedException();
    }
}