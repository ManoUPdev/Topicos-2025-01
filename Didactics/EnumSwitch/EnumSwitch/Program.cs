using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSwitch
{
    class Program
    {
        // EnumSwitch é um exemplo que combina o uso de enums e switch para
        //O switch é uma estrutura de decisão que verifica o valor de uma variável 
        // e executa o bloco correspondente ao caso (case) correspondente. 
        // Fica muito legal com enums porque você pode tratar cada valor enum de forma clara.


    // enum DiaSemana { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };

    // enum DiaSemana hoje = Quarta;

    // switch (hoje) {
    // case Domingo:
    //printf("Descanso!\n");
    // break;
    //case Quarta:
    // printf("Dia de reunião.\n");
    //break;
    //default:
   //printf("Dia normal.\n");
   //break;
}

        enum DiaSemana
        {
            Domingo = 1,
            Segunda = 2,
            Terca = 3,
            Quarta = 4,
            Quinta = 5,
            Sexta = 6,
            Sabado = 7
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero de 1 a 7 para o dia da semana:");
            int dia = int.Parse(Console.ReadLine());

            switch ((DiaSemana)dia)
            {
                case DiaSemana.Domingo:// O switch e usado para controlar o fluxo do programa com base no valor de uma variavel.
                    // O enum e usado para definir um conjunto nomeado de constantes que representam os dias da semana.
                    Console.WriteLine("Domingo");
                    break;
                case DiaSemana.Segunda:
                    Console.WriteLine("Segunda-feira");
                    break;
                case DiaSemana.Terca:
                    Console.WriteLine("Terca-feira");
                    break;
                case DiaSemana.Quarta:
                    Console.WriteLine("Quarta-feira");
                    break;
                case DiaSemana.Quinta:
                    Console.WriteLine("Quinta-feira");
                    break;
                case DiaSemana.Sexta:
                    Console.WriteLine("Sexta-feira");
                    break;
                case DiaSemana.Sabado:
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Numero invalido. Digite um numero de 1 a 7.");
                    break;
                  
                    
            }
        }
    }

