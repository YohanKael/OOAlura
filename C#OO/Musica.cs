class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }

    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    
    public string DescricaoResumida =>  // lambda
        $"A música {Nome} pertence à banda {Artista}";
    


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        Console.WriteLine($"Disponivel: {Disponivel}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel no plano.");
        } else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }}