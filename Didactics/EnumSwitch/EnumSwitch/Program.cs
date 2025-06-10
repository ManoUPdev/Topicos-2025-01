using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumSwitch
{
    class Program
    {
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
                case DiaSemana.Domingo:
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
                    // O switch verifica o valor da variavel 'dia' e executa o bloco de codigo correspondente.
                    // Se o valor nao corresponder a nenhum dos casos, o bloco 'default' e executado.
                    // Isso torna o codigo mais claro e facil de entender, especialmente quando ha muitos casos a serem verificados.
                    //Enquanto o enum e usado para definir um conjunto nomeado de constantes, o switch e usado para controlar o fluxo do programa com base no valor de uma variavel.
                    // os dois podem ser usados juntos para tornar o codigo mais legivel e facil de manter.
                    
            }
        }
    }
}
