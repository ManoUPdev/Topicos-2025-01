using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    // O que é um loop foreach?
    // Um loop foreach é uma estrutura de controle de fluxo que itera sobre uma coleção de elementos, como um array ou uma lista.
    // Ele executa um bloco de código para cada elemento da coleção, permitindo acessar cada item sem precisar usar um índice.
    // Sintaxe:
    // foreach (tipo elemento in coleção)
    // {
    //     // Bloco de código a ser executado para cada elemento
    // }

    class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = { "Maçã", "Banana", "Laranja", "Uva" }; // Cria um array de frutas

            foreach (string fruta in frutas) // Itera sobre cada fruta no array
            {
                Console.WriteLine(fruta); // Exibe o nome da fruta
            }

            Console.WriteLine("Pressione qualquer tecla para sair..."); // Mensagem para o usuário
            Console.ReadKey(); // Aguarda a entrada do usuário antes de fechar o console
        }
    }
}