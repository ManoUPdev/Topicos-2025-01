using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Didatics
{
 class Program
   {
     static void Main(string[] args)
     {
        // Antes de comecarmos a estudar C#, é importante entender alguns conceitos fundamentais.
        // Claro tambem e importante entender a estrutura de um programa em C#.
        // na parte de cima do arquivo, temos o namespace Didatics, que e um contenedor de classes.
        // O namespace e usado para organizar o codigo, e evitar conflitos de nomes entre classes.
        // Acima do namespace, temos as diretivas using, que sao chamadas de modulos ou pacotes.
        // Elas sao usadas para importar funcionalidades de outras bibliotecas, como System, que contem classes basicas do C#.
        //ja que o C# e uma linguagem muito rica, com muitas funcionalidades, e importante entender como organizar o codigo.
        // Primeiro, vamos falar o que e uma solucao,dps um projeto e por fim, o que e um arquivo.
        // Uma solucao e um contenedor de projetos, que por sua vez, contem arquivos.
        // Cada projeto pode conter varios arquivos, e cada arquivo pode conter varias classes.
        // Vamos criar um exemplo simples para ilustrar isso.
        // Vamos criar uma solucao chamada "Didatics", que contem um projeto chamado "Program.cs".
        // Dentro do projeto, vamos criar uma classe chamada "Program", que contem um metodo chamado "Main".
        // O metodo Main e o ponto de entrada do programa, ou seja, e o primeiro metodo que sera executado quando o programa for iniciado.
        // Vamos escrever um codigo simples dentro do metodo Main, que imprime uma mensagem na tela.

        // Console.WriteLine("Hello, World!");
        // Console.WriteLine("Meu nome e Joaquin, e estou aprendendo C#.");


        //Console.ReadLine(); // Espera o usuario pressionar uma tecla antes de fechar o programa

        // Agora que entendemos a estrutura basica de um programa em C#, vamos falar sobre variaveis e tipos de dados.
        // Variaveis sao usadas para armazenar valores, e cada variavel tem um tipo de dado associado a ela.
        // Os tipos de dados mais comuns em C# sao: int (inteiro), double (numero com ponto flutuante ou decimal), string (texto) e bool (verdadeiro ou falso).
        // Vamos criar algumas variaveis e imprimir seus valores na tela.

        // int idade = 30; // Variavel do tipo inteiro
        // double altura = 1.75; // Variavel do tipo double
        // string nome = "Joaquin"; // Variavel do tipo string
        // Console.WriteLine($"Meu nome e {nome}, tenho {idade} anos e minha altura e {altura} metros.");

        // Mais um exemplo de variavel, agora do tipo bool.

        //int anoNascimento = 1993; // Variavel do tipo inteiro
        //string nomeCompleto = "Joaquin"; // Variavel do tipo string
        //double salario = 2500.50; // Variavel do tipo double
        //bool estaAprendendo = true; // Variavel do tipo bool
        //Console.WriteLine($"Meu nome completo e {nomeCompleto}, nasci em {anoNascimento}, meu salario e {salario} e estou aprendendo C#? {estaAprendendo}");
            
        // Outras formas de declarar variaveis
            
        //var idade = 32; // Variavel do tipo inteiro, inferida pelo compilador
        //var altura = 1.77; // Variavel do tipo double, inferida pelo compilador
        //Console.WriteLine($"Minha idade e {idade} anos e minha altura e {altura} metros.");

        //mesmo que voce declare uma variavel com var, voce ainda precisa especificar o tipo de dado quando for usar a variavel.
        //por exemplo um numero inteiro, voce pode usar a variavel idade, que foi declarada como var, mas o compilador sabe que ela e do tipo inteiro.

        // Agora vamos falar sobre as constantes.
        // Constantes sao variaveis cujo valor nao pode ser alterado depois de definido.

        // const double PI = 3.14159; // Constante do tipo double
        // Console.WriteLine($"O valor de PI e {PI}.");

        // Agora para finalizar, vamos colocar uma entrada do usuario.
        // Vamos pedir para o usuario digitar seu nome e idade, e depois imprimir uma mensagem na tela com essas informacoes.

        string nome = " ";
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine(); // Lendo a entrada do usuario
        Console.WriteLine("Seu nome e: ");
        Console.WriteLine(nome); // Imprimindo o nome do usuario


        // Console.ReadLine(); // Espera o usuario pressionar uma tecla antes de fechar o programa
      }
   }
}