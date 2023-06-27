class Episodio
{
    private List<string> convidados = new();

    public Episodio(int ordem, string titulo, int duracao)
    {
        Titulo = titulo;
        Ordem = ordem;
        Duracao = duracao;
    }
    
    public int Ordem { get; }

    public string Titulo {get; }

    public int Duracao { get; }

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }


    public string Resumo => $"{Ordem}. {Titulo},({Duracao} min) - Convidados do episodio: {string.Join(", ", convidados)}";
       // $"Convidados do Episódio: {Convidados}";
}