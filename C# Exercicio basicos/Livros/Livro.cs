using System;

public class Livro
{
    public  string? Titulo { get; set; }
    public  string? Autor { get; set; }
    public int NumeroPaginas { get; set; }


    public void ExibirDetalhes()
    {
        Console.WriteLine($"Titulo:{Titulo}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"NumeroPaginas: {NumeroPaginas}");
    }
}