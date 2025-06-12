using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch
            // É uma forma prática de substituir vários ifs/else if
            // quando você precisa comparar uma variável com muitos valores possíveis.
            

         // switch (variavel) {
         //case valor1:
         // código para quando variavel == valor1
         //break;
        //case valor2:
        // código para quando variavel == valor2
       // break;
       //outros casos...
       //default:
       //  código se nenhum case acima for igual
       // }


            // Console.WriteLine("Digite um numero de 1 a 7 para o dia da semana:");
            // int dia = int.Parse(Console.ReadLine());

            // switch (dia)//         // O switch verifica o valor da variavel 'dia' e executa o bloco de codigo correspondente.
            // {
            //     case 1://         // O bloco 'case' define um caso especifico que sera verificado.
            //         Console.WriteLine("Domingo");
            //         break;//         // O 'break' encerra o bloco do case, evitando que o codigo continue executando os outros casos.
            //     case 2:
            //         Console.WriteLine("Segunda-feira");
            //         break;
            //     case 3:
            //         Console.WriteLine("Terca-feira");
            //         break;
            //     case 4:
            //         Console.WriteLine("Quarta-feira");
            //         break;
            //     case 5:
            //         Console.WriteLine("Quinta-feira");
            //         break;
            //     case 6:
            //         Console.WriteLine("Sexta-feira");
            //         break;
            //     case 7:
            //         Console.WriteLine("Sabado");
            //         break;
            //     default: //         // O bloco default e executado se nenhum dos casos acima for atendido.
            //         Console.WriteLine("Numero invalido. Digite um numero de 1 a 7.");
            //         break;
            // }
            // O switch verifica o valor da variavel 'dia' e executa o bloco de codigo correspondente.
            // Se o valor nao corresponder a nenhum dos casos, o bloco 'default' e executado.
            // Isso torna o codigo mais claro e facil de entender, especialmente quando ha muitos casos a serem verificados.
            // Agora, vamos ver um exemplo de switch com uma variavel string.
            Console.WriteLine("Digite o nome de um dia da semana:");
            string diaSemana = Console.ReadLine().ToLower();
            switch (diaSemana)
            {
                case "domingo":
                    Console.WriteLine("Domingo");
                    break;
                case "segunda-feira":
                    Console.WriteLine("Segunda-feira");
                    break;
                case "terca-feira":
                    Console.WriteLine("Terca-feira");
                    break;
                case "quarta-feira":
                    Console.WriteLine("Quarta-feira");
                    break;
                case "quinta-feira":
                    Console.WriteLine("Quinta-feira");
                    break;
                case "sexta-feira":
                    Console.WriteLine("Sexta-feira");
                    break;
                case "sabado":
                    Console.WriteLine("Sabado");
                    break;
                default:
                    Console.WriteLine("Dia da semana invalido.");
                    break;
            }
        }
    }
}