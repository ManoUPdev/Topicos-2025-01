using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // O que e um array?
            // Um array e uma estrutura de dados que permite armazenar varios valores do mesmo tipo em uma unica variavel(chamada tambem de supervariavel).
            // Em C#, os arrays sao objetos que podem ser manipulados como qualquer outro objeto.
            // Anteriormente, vimos como declarar e inicializar um array de inteiros, mas os arrays podem armazenar qualquer tipo de dado, incluindo strings, objetos e outros tipos de dados primitivos.
            // Aqui esta um exemplo de como declarar e inicializar um array de strings.
            string produto1 = "Arroz";
            string produto2 = "Feijao";
            string produto3 = "Macarrao";
            string produto4 = "Carne";
            string produto5 = "Frango";
            string produto6 = "Peixe";

            string[] produtos = new string[6] {  // Declara um array de strings com 5 elementos
            "Arroz", // 0
            "Feijao", // 1
            "Macarrao", // 2
            "Carne", // 3
            "Frango", // 4
            "Peixe" // 5
        };
            Console.WriteLine(produtos[4]); // Acessa o primeiro elemento do array

        
        Console.ReadLine(); // Espera o usuario pressionar uma tecla antes de fechar o programa
    }
}
}