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
            // Um array e uma estrutura de dados que permite armazenar varios valores do mesmo tipo
            //  em uma unica variavel(chamada tambem de supervariavel).
            // Em C#, os arrays sao objetos que podem ser manipulados como qualquer outro objeto.
            // Anteriormente, vimos como declarar e inicializar um array de inteiros,
            //  mas os arrays podem armazenar qualquer tipo de dado, incluindo strings, objetos 
            // e outros tipos de dados primitivos.
            // Aqui esta um exemplo de como declarar e inicializar um array de strings.

            // string produto1 = "Arroz";
            // string produto2 = "Feijao";
            // string produto3 = "Macarrao";
            // string produto4 = "Carne";
            // string produto5 = "Frango";
            // string produto6 = "Peixe";

            //     string[] produtos = new string[6] {  // Declara um array de strings com 5 elementos
            //     "Arroz", // 0
            //     "Feijao", // 1
            //     "Macarrao", // 2
            //     "Carne", // 3
            //     "Frango", // 4
            //     "Peixe" // 5
            // };
            //     produtos[1] = "Cebola"; // Se quisermos alterar o valor de um elemento do array,
            //     //  podemos fazer isso usando o indice do elemento
            //     Console.WriteLine(produtos[1]); // Exibe o valor do elemento na posicao 1 do array


            // // outro exemplo de array, desta vez com numeros inteiros
            // int[] numeros = new int[5] { 10, 20, 30, 40, 50 }; // Declara um array de inteiros com 5 elementos
            //                                                    // Exibe os valores do array usando um loop for
            // for (int i = 0; i < numeros.Length; i++)
            // {
            //     Console.WriteLine($"Elemento {i}: {numeros[i]}"); // Exibe o valor do elemento na posicao i do array
            // }

            // Exemplo de array multidimensional
            string[,] produtos = new string[2, 3] // Declara um array multidimensional de strings com 2 linhas e 3 colunas
            {
                { "Arroz", "Feijao", "Macarrao" }, // Linha 0
                { "Carne", "Frango", "Peixe" } // Linha 1
            };
            // Exibe os valores do array multidimensional usando um loop for
            for (int i = 0; i < produtos.GetLength(0); i++) // GetLength(0) retorna o numero de linhas
            {
                for (int j = 0; j < produtos.GetLength(1); j++) // GetLength(1) retorna o numero de colunas
                {
                    Console.WriteLine($"Produto na posicao [{i}, {j}]: {produtos[i, j]}"); // Exibe o valor do elemento na posicao [i, j] do array
                }
            }


        }
    }
}
