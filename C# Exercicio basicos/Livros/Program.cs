using System;
class Program
{
    static void Main(String[] args)
    {
        Livro meuLivro = new Livro();
        meuLivro.Titulo = "O Senhor do Aneis";
        meuLivro.Autor = "J.R.R. Tolkien";
        meuLivro.NumeroPaginas = 1216;


        meuLivro.ExibirDetalhes();
    }
}