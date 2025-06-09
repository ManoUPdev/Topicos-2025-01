using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcoes
{
    // Funcoes sao blocos de codigo que podem ser chamados em diferentes partes do programa.
    // Elas permitem que voce escreva codigo reutilizavel e modular, facilitando a manutencao e a extensibilidade do programa.
    // As funcoes podem receber parametros de entrada e retornar valores de saida.
    // Para criar uma funcao em C#, voce deve definir o tipo de retorno, o nome da funcao e os parametros de entrada (se houver).
    // Aqui esta um exemplo de funcao que recebe uma string como parametro e exibe uma mensagem na tela.
    class Program
    {

        static void Main(string[] args)
        {
            
            // ExibirMsg();// Chama a funcao ExibirMsg, que exibe uma mensagem na tela.
            //             // A funcao ExibirMsg nao recebe nenhum parametro, entao nao precisamos passar nada entre os parenteses.
            //             // E assim que voce pode criar funcoes em C#.
            //             // Voce pode criar funcoes que recebem parametros, como por exemplo uma funcao que recebe um numero inteiro e retorna o dobro desse numero.

            // Console.ReadLine(); // Espera o usuario pressionar uma tecla antes de fechar o programa

            GerarPreco(60); // Chama a funcao GerarPreco, passando o valor 60 como parametro.
            // A funcao GerarPreco recebe um inteiro como parametro e exibe o preco na tela.
            Console.WriteLine();
        }

        // Aqui esta a definicao da funcao ExibirMsg.
        // Ela nao recebe nenhum parametro, e nao retorna nenhum valor, entao o tipo de retorno e void.

        static void ExibirMsg()
        {
            // Esta funcao recebe uma string como parametro e exibe a mensagem na tela.
            Console.WriteLine("Esse sistema e muito legal!");
            Console.WriteLine("Estou usando C# para aprender sobre funcoes.");
            Console.WriteLine("Bem-vindo!");
        }

        static void GerarPreco(int preco) // se der erro, verifique se o tipo de dado esta correto
        {
            // Esta funcao recebe um inteiro como parametro e exibe o preco na tela.
            // Voce pode chamar essa funcao passando um valor inteiro, e ela exibira o preco formatado.
            // Por exemplo, se voce passar o valor 60, ela exibira "60".
            // Se voce quiser formatar o preco com duas casas decimais, voce pode usar o metodo ToString("F2").
            // Aqui esta um exemplo de como fazer isso:

            {
                Console.WriteLine(preco);
            }


        } 

    }
    
}