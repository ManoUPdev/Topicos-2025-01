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

        //  GerarPreco(60); // Chama a funcao GerarPreco, passando o valor 60 como parametro.
        //  GerarPreco(24); // A funcao GerarPreco recebe um inteiro como parametro e exibe o preco na tela.
        //  GerarPreco(-3);
        //  GerarPreco(37);

        //Como vimos anteriormente, as funcoes podem receber parametros de entrada e retornar valores de saida.
        // foram mostrados exemplos de funcoes que recebem quatro parametros e exibem mensagens na tela.

        // string valor = Console.ReadLine(); // Lê uma linha de texto digitada pelo usuário
        // Console.WriteLine(valor); // Exibe o valor lido na tela
        // Console.ReadLine(); // Espera o usuário pressionar uma tecla antes de fechar o programa

        //  Aqui esta um exemplo de retorno de uma funcao.
        // Console.WriteLine(Math.Abs(-7)); // Exibe o valor absoluto de -3, que e 3.
        // Console.ReadLine(); // Espera o usuario pressionar uma tecla antes de fechar o programa
        // A funcao Math.Abs recebe um numero inteiro como parametro e retorna o valor absoluto desse numero.
        // Voce pode usar essa funcao para obter o valor absoluto de qualquer numero inteiro, positivo ou negativo.

        int soma1 = Somar(1, 2, 3); // A funcao Somar recebe tres inteiros como parametros e retorna a soma deles.
        int soma2 = Somar(10, 20, 30); // Voce pode chamar essa funcao passando qualquer valor inteiro, e ela retornara a soma deles.
        int soma3 = Somar(100, 200, 300); // Por exemplo, se voce passar os valores 1, 2 e 3, ela retornara 6.

        Console.WriteLine(soma1); // Exibe o resultado da funcao Somar na tela.
        Console.WriteLine(soma2); // Exibe o resultado da funcao Somar na tela.
        Console.WriteLine(soma3); // Exibe o resultado da funcao Somar na tela. 
        }

        // Aqui esta a definicao da funcao ExibirMsg.
        // Ela nao recebe nenhum parametro, e nao retorna nenhum valor, entao o tipo de retorno e void.

        // static void ExibirMsg()
        // {
        //     // Esta funcao recebe uma string como parametro e exibe a mensagem na tela.
        //     Console.WriteLine("Esse sistema e muito legal!");
        //     Console.WriteLine("Estou usando C# para aprender sobre funcoes.");
        //     Console.WriteLine("Bem-vindo!");
        // }

        // static void GerarPreco(int preco) // se der erro, verifique se o tipo de dado esta correto
        // {
        //     int precoAbs = Math.Abs(preco); // Calcula o valor absoluto do preco
        //     int valorFormatado = precoAbs; // Formata o preco para exibir na tela
        //     Console.WriteLine($"O preco formatado e: {valorFormatado}"); // Exibe o preco formatado na tela


        // Esta funcao recebe um inteiro como parametro e exibe o preco na tela.
        // Voce pode chamar essa funcao passando um valor inteiro, e ela exibira o preco formatado.
        // Por exemplo, se voce passar o valor 60, ela exibira "60".
        // Se voce quiser formatar o preco com duas casas decimais, voce pode usar o metodo ToString("F2").
        // Aqui esta um exemplo de como fazer isso:
        // } 

        // antes de prosseguir, void significa que a funcao nao retorna nenhum valor, ou seja, ela apenas executa uma acao.
        //porem se voce quiser que a funcao retorne um valor, voce deve especificar o tipo de retorno na definicao da funcao.
        // Por exemplo, se voce quiser que a funcao retorne um inteiro, voce deve escrever "int"
        //  antes do nome da funcao, se for bool e bool, string string e assim por diante.
        // Esta funcao recebe tres inteiros como parametros e retorna a soma deles.
        // Voce pode chamar essa funcao passando tres valores inteiros, e ela retornara a soma deles.
        // Por exemplo, se voce passar os valores 1, 2 e 3, ela retornara 6.

        static int Somar(int a, int b, int c) //calcula a soma dos tres numeros
        {
            int resultadoFinal = a + b + c; // Armazena o resultado da soma em uma variavel
            return resultadoFinal;// Retorna o resultado da soma
        }    //Como vimos nada apareceu na tela, porque a funcao Somar nao exibe nada na tela.
             // Para exibir o resultado da soma na tela, voce pode chamar a funcao Somar e armazenar o resultado em uma variavel, e depois exibir essa variavel na tela.

    }
    // De forma geral, as funcoes sao uma parte importante da programacao em C#, pois permitem que voce escreva codigo reutilizavel e modular.
    // Elas podem receber parametros de entrada e retornar valores de saida, e podem ser chamadas em diferentes partes do programa.
    // Voce pode criar funcoes que realizam diferentes tarefas, como calcular a soma de numeros, exibir mensagens na tela, formatar valores, entre outras.       
    }
    
