using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    // O que é um loop do-while?
    // Um loop do-while é uma estrutura de controle de fluxo que executa um bloco 
    // de código repetidamente enquanto uma condição especificada for verdadeira.
    // A diferença entre um loop while e um loop do-while é que o loop do-while garante 
    // que o bloco de código seja executado pelo menos uma vez,
    //  mesmo que a condição seja falsa na primeira verificação.
    // Sintaxe:
    // do
    // {
    //     // Bloco de código a ser executado
    // } while (condição);

    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;// Inicializa a variável i com o valor 0
                      // O loop do-while executa o bloco de código enquanto a condição for verdadeira.

            int j = 10;// Inicializa a variável j com o valor 10

    
            do // Início do loop do-while
            // O bloco de código dentro do loop será executado pelo menos uma vez
            {
                Console.WriteLine("i = " + i);// Exibe o valor de i
                Console.WriteLine("j = " + j);// Exibe o valor de j
                // Incrementa o valor de i
                i++;// Incrementa o valor de i
                j--;// Decrementa o valor de j
                Console.WriteLine("Incrementando i e decrementando j...");// Mensagem para o usuário
                Console.WriteLine();// Linha em branco para melhor legibilidade

            } while (i < 5);// Continua o loop enquanto i for menor que 5
            // O loop do-while garante que o bloco de código seja executado pelo menos uma vez,

            Console.WriteLine("Pressione qualquer tecla para sair...");// Mensagem para o usuário
            // O loop do-while é útil quando você precisa garantir que
            //  o bloco de código seja executado pelo menos uma vez,
            // mesmo que a condição seja falsa na primeira verificação.
            
          Console.ReadKey();// Aguarda o usuário pressionar uma tecla para sair`
          
           string resposta;
           do
           {
           Console.WriteLine("Executando tarefa...");
           Console.Write("Deseja repetir? (s/n): ");
           resposta = Console.ReadLine().ToLower();
           } while (resposta == "s");
 
      }
      
  }
}
