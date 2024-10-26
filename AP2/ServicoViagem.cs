public abstract class ServicoViagem
{
    protected string Codigo { get; set; }
    protected string Descricao { get; set; }

    public ServicoViagem(string codigo, string descricao)
    {
        Codigo = codigo;
        Descricao = descricao;
    }

    public abstract void Reservar();
    public abstract void Cancelar();
}