class Podcast
{
    private List<Episodio> episodios = new();

    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }

    public int TotalEpisodios => episodios.Count;

    public string Host { get; }

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"{Nome} apresentado por {Host}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem)) 
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"Esse Podcast Possui um Total de: {TotalEpisodios} episódios");
    }
}