using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operadores
{
    class Program
    {
        static void Main(string[] args)
        {


          // Operadores de Atribuicao, ou seja, operadores que atribuem valores a variaveis  
          // Operadores condicioanais, ou seja, operadores que comparam valores e retornam verdadeiro ou falso
          //usando if, else if e else (exemplo)

          int a = 10;
          int b = 20;
          int c = 2;

         
          if (a > b) //SE 
          {
            Console.WriteLine("E VERDADE!");
          }

           else if (a > c) //SENAO SE
           {
            Console.WriteLine("E MENOR QUE 20 E MAIOR QUE 2!");
           }

          else //SENAO
          {
           Console.WriteLine("E FALSO!");
          }

          Console.ReadLine();

          //Pelo que vimos quando o if, else if e else, o programa executa a primeira condicao verdadeira 
          // que encontrar e ignora as demais.
          // Se nenhuma condicao for verdadeira, o programa executa o bloco de codigo dentro do else.
          // else if e else sao usados para criar estruturas de controle de fluxo, que permitem que 
          // o programa tome decisoes com base em condicoes.
          //diferenca entre else if e else, e que o else if permite que voce teste varias condicoes, 
          // enquanto o else so executa se nenhuma das condicoes anteriores for verdadeira.
          // Podemos usar operadores de comparacao, como <, >, <=, >=, == e != para comparar valores.
          // Operadores logicos sao usados para combinar ou inverter condicoes.
          // Os operadores logicos mais comuns sao: && (E), || (OU) e ! (NAO).
          // Vamos ver alguns exemplos de como usar esses operadores em C#.

          //           Console.WriteLine("Digite sua idade: ");

           //           int idade = int.Parse(Console.ReadLine());


            //           if (idade >= 0 && idade <= 12)
            //           {
            //             Console.WriteLine("Voce e uma crianca!");
            //           }
            //           else if (idade >= 13 && idade <= 17)
            //           {
            //             Console.WriteLine("Voce e um adolescente!");
            //           }
            //           else if (idade >= 18 && idade <= 59)
            //           {
            //             Console.WriteLine("Voce e um adulto!");
            //           }
            //           else if (idade >= 60)
            //           {
            //             Console.WriteLine("Voce e um idoso!");
            //           }
            //           else
            //           {
            //            Console.WriteLine("Idade invalida!");
            //           }
            //            Console.ReadLine();

        }
    }
}
