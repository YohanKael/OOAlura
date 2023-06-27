// Musica musica1 = new Musica();
// musica1.Nome = "Roxane";
// musica1.Artista = "The Police";
// musica1.Duracao = 273;
// musica1.Disponivel = true;
// Console.WriteLine(musica1.DescricaoResumida);
// 
// Musica musica2 = new Musica();
// musica2.Nome = "Vertigo";
// musica2.Artista = "U2";
// musica2.Duracao = 367;
// musica2.Disponivel = true;
// 
// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();

// Banda queen = new Banda("Queen");
// 
// Album albumDoQueen = new Album("A night at the opera");
// 
// 
// Musica musica1 = new Musica(queen, "Love of my life")
// {
//     Duracao = 213,
//     Disponivel = true,
// };
// 
// Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
// {
//     Duracao = 354,
//     Disponivel = false,
// };
// 
// 
// 
// albumDoQueen.AdicionarMusica(musica1);
// albumDoQueen.AdicionarMusica(musica2);
// queen.AdicionarAlbum(albumDoQueen);
// 
// musica1.ExibirFichaTecnica();
// musica2.ExibirFichaTecnica();
// albumDoQueen.ExibirMusicasDoAlbum();
// queen.ExibirDiscografia();



Episodio ep1 = new (1, "Tecnicas de facilitaçao", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");

Episodio ep2 = new(2, "Tecnicas de Aprendizado", 67);
ep2.AdicionarConvidados("Ana");
ep2.AdicionarConvidados("Marcos");


Episodio ep3 = new(3, "Tecnicas de facilitaçao", 45);
ep3.AdicionarConvidados("Joao");
ep3.AdicionarConvidados("Fernando");


Podcast podcast = new("Podcast especial", "daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);
podcast.ExibirDetalhes();
