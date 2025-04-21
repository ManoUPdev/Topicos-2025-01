using System;

public class Livro
{
    // Propriedades
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int NumeroPaginas { get; set; }

    // Construtor
    public Livro(string titulo, string autor, int numeroPaginas)
    {
        Titulo = titulo;
        Autor = autor;
        NumeroPaginas = numeroPaginas;
    }

    // Método para exibir os detalhes do livro
    public void ExibirDetalhes()
    {
        Console.WriteLine("Título: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        Console.WriteLine("Número de Páginas: " + NumeroPaginas);
    }
}

// Classe com o Main para testar
public class Program
{
    public static void Main()
    {
        Livro livro = new Livro("Dom Casmurro", "Machado de Assis", 244);
        livro.ExibirDetalhes();
    }
}
