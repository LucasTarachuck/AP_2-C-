public class PacoteTuristico : ServicoViagem, IReservavel, IPesquisavel
{
    public string Destino { get; set; }
    public DateTime DataInicio { get; set; }
    public DateTime DataFim { get; set; }
    public decimal Preco { get; set; }
    public int VagasDisponiveis { get; set; }

    public PacoteTuristico(string destino, DateTime datainicio, DateTime datafim, decimal preco, int vagasdisponiveis, string codigo, string descricao):base(codigo, descricao)
    {
        Destino = destino;
        DataInicio = datainicio;
        DataFim = datafim;
        Preco = preco;
        VagasDisponiveis = vagasdisponiveis;
    }

    public override void Reservar()
    {
        if (VagasDisponiveis <= 0)
        {
            Console.WriteLine("Não há mais vagas disponíveis");
        }
        else if (VagasDisponiveis < 0)
        {
            Console.WriteLine("Não há como exisitir número de vagas negativas");
        }
        else
        {
            Console.WriteLine($"Existe um número de {VagasDisponiveis} vagas disponíveis.");
            Console.WriteLine("Deseja confrimar a reserva?");
            string sim_ou_nao = Console.ReadLine();
            if(sim_ou_nao == "não")
            {  
                Console.WriteLine("Viagem não reservada");
            }
            else if(sim_ou_nao ==  null && sim_ou_nao != "sim" && sim_ou_nao != "não")
            {
                 Console.WriteLine("Digite Sim para confirmar a reserva ou Não para não confrimar");
            }
            else
            {
                Console.WriteLine("Reserva confirmada");
                VagasDisponiveis = VagasDisponiveis - 1;
            }
        }
    }
    public override void Cancelar()
    {
        Console.WriteLine("Viagem cancelada");
        VagasDisponiveis = VagasDisponiveis + 1;
    }

    public void PesquisarPorCodigo(string codigo)
    {
        if(codigo == Codigo)
        {
            Console.WriteLine($"Destino: {Destino}");
            Console.WriteLine($"Data de início: {DataInicio}");
            Console.WriteLine($"Data finalização: {DataFim}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Vagas Disponíveis: {VagasDisponiveis}");
            Console.WriteLine($"Descricao: {Descricao}");
        }
        else
        {
            Console.WriteLine("Código não encontrado");
        }
    }
    public void PesquisarPorNome(string nome)
    {
        if(nome == Destino)
        {
            Console.WriteLine($"Codigo: {Codigo}");
            Console.WriteLine($"Data de início: {DataInicio}");
            Console.WriteLine($"Data finalização: {DataFim}");
            Console.WriteLine($"Preço: {Preco}");
            Console.WriteLine($"Vagas Disponíveis: {VagasDisponiveis}");
            Console.WriteLine($"Descricao: {Descricao}");
        }
    }
}