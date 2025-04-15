using System;

class Program
{
    static void Main() // svm
    {
        Console.WriteLine("Qual seu nome?"); // cw
        string nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}!");

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Contando: {i}");
        }
    }
}