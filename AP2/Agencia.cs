using System.Net.WebSockets;

public class Agencia 
{
    public List<Destino> Destinos { get; set; }
    public List<Cliente> Clientes {get; set; }
    public List<PacoteTuristico> PacoteTuristicos { get; set; }

    public Agencia()
    {
        Destinos = new List<Destino>();
        Clientes = new List<Cliente>();
        PacoteTuristicos = new List<PacoteTuristico>();
    }
    
    public void CadastrarDestino(Destino destino)
    {
        Destinos.Add(destino);
        Console.WriteLine("Destino cadastrado");
    }
    public void ConsultarDestinoPorCodigo(string codigo)
    {
        if (codigo == null)
        {
            Console.WriteLine("Código não encontrado");
        }
        else
        {
            foreach(var destino in Destinos)
            {
                Console.WriteLine($"Nome do local: {destino.NomeLocal}");
                Console.WriteLine($"Pais: {destino.Pais}");
                Console.WriteLine($"Código: {destino.Codigo}");
                Console.WriteLine($"Descrição: {destino.Descricao}");
            }
        }
    }
    public void ListarDestinos()
    {
        foreach (var destino in Destinos)
        {
            Console.WriteLine($"Nome do local: {destino.NomeLocal}");
            Console.WriteLine($"Pais: {destino.Pais}");
            Console.WriteLine($"Código: {destino.Codigo}");
            Console.WriteLine($"Descrição: {destino.Descricao}");
        }
    }
    public void CadastrarCliente(Cliente cliente)
    {
        Clientes.Add(cliente);
        Console.WriteLine("Cliente cadastrado com sucesso");
    }
    public void ConsultarClientePorID(string numeroidentificaco)
    {
        if (numeroidentificaco == null)
        {
            Console.WriteLine("Código não encontrado");
        }
        else
        {
            foreach(var cliente in Clientes)
            {
                Console.WriteLine($"Nome Completo: {cliente.Nome}");
                Console.WriteLine($"Identificador: {cliente.NumeroIdentificacao}");
                Console.WriteLine($"Contato: {cliente.Contato}");
            }
        }
    }
    public void ListarClientes()
    {
        foreach(var cliente in Clientes)
        {
            Console.WriteLine($"Nome Completo: {cliente.Nome}");
            Console.WriteLine($"Identificador: {cliente.NumeroIdentificacao}");
            Console.WriteLine($"Contato: {cliente.Contato}");
            
        }
    }
    public void CadastrarPacoteTuristico(PacoteTuristico pacote)
    {
        PacoteTuristicos.Add(pacote);
        Console.WriteLine("Pacote cadastrado com sucesso");
    }
    public void ConsultarPacotePorCodigo(string codigo)
    {
        if (codigo == null)
        {
            Console.WriteLine("Código não encontrado");
        }
        else
        {
            foreach(var pacote in PacoteTuristicos)
            {
                Console.WriteLine($"Destino: {pacote.Destino}");
                Console.WriteLine($"Data de início: {pacote.DataInicio}");
                Console.WriteLine($"Data final: {pacote.DataFim}");
                Console.WriteLine($"Preoço: {pacote.Preco}");
                Console.WriteLine($"Vagas Disponíveis:{pacote.VagasDisponiveis}");
            }
        }
    }
    public void ListarPacotes()
    {
        foreach(var pacote in PacoteTuristicos)
        {
            Console.WriteLine($"Destino: {pacote.Destino}");
            Console.WriteLine($"Data de início: {pacote.DataInicio}");
            Console.WriteLine($"Data final: {pacote.DataFim}");
            Console.WriteLine($"Preoço: {pacote.Preco}");
            Console.WriteLine($"Vagas Disponíveis:{pacote.VagasDisponiveis}");
        }
            
     }
}