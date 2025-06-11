using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While
{
    // O que é um loop while?
    // Um loop while é uma estrutura de controle de fluxo que executa um bloco 
    // de código repetidamente enquanto uma condição especificada for verdadeira.
    //diferenca do while para if else é que o while executa 
    // o bloco de código enquanto a condição for verdadeira,
    // enquanto o if else executa o bloco de código apenas uma vez, dependendo da condição.
    // Sintaxe:
    // while (condição)
    // {
    //     // Bloco de código a ser executado
    // }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0; // Inicializa a variável i com o valor 0

            while (i < 5) // O loop while executa o bloco de código enquanto a condição for verdadeira
            {
                Console.WriteLine("i = " + i); // Exibe o valor de i
                i++; // Incrementa o valor de i
            }

            Console.WriteLine("Pressione qualquer tecla para sair..."); // Mensagem para o usuário
            Console.ReadKey(); // Aguarda a entrada do usuário antes de fechar o console
        }
    }
}
