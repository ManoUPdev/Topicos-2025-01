using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aritimeticas
{
     class Program
    {
        static void Main(string[] args)
        {
            // Operadores Aritimeticos em C#
            // Os operadores aritimeticos sao usados para realizar operacoes matematicas basicas,
            //  como adicao, subtracao, multiplicacao e divisao.
            // Vamos ver alguns exemplos de como usar esses operadores em C#.
            int a = 10;
            int b = 5;
            int soma = a + b; // Adicao
            int subtracao = a - b; // Subtracao
            int multiplicacao = a * b; // Multiplicacao
            double divisao = (double)a / b; // Divisao (convertendo para double para evitar truncamento)
            Console.WriteLine($"Soma: {soma}");
            Console.WriteLine($"Subtracao: {subtracao}");
            Console.WriteLine($"Multiplicacao: {multiplicacao}");
            Console.WriteLine($"Divisao: {divisao}");
            Console.ReadLine(); // Espera o usuario pressionar uma tecla antes de fechar o programa

        }
    }
}
