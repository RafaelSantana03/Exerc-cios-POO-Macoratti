using Exercicio02;
using System.Runtime.CompilerServices;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n## Exercicio 2 ##\n");
Console.ResetColor();


//Criando um álbum padrão e exibindo o número de páginas
LivroFotos albumFotosPadrao = new();
Console.WriteLine($"Álbum padrão: { albumFotosPadrao.GetNumeroPaginas()} Paginas");

//Criando um álbum de fotos com 24 paginas e exibindo o número de páginas
LivroFotos albumPaginas = new(24);
Console.WriteLine($"\nÁlbum de fotos com { albumPaginas.GetNumeroPaginas()} paginas");

//Criando um álbum de fotos grande e exibindo o número de páginas
SuperLivroFotos superAlbum = new();
Console.WriteLine($"\nÁlbum grande: {superAlbum.GetNumeroPaginas()} Páginas");
Console.ReadKey();
