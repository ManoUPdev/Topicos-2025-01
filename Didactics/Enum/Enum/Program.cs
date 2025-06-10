using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    class Program
    {
        // O que e um enum?
        // Um enum e um tipo de dado que permite definir um conjunto nomeado de constantes.
        // Ele e usado para representar um conjunto fixo de valores, tornando o codigo mais legivel.
        // Aqui esta um exemplo de como usar um enum para representar os dias da semana.

        enum DiaDaSemana 
        {
            Domingo,
            Segunda,
            Terca,
            Quarta,
            Quinta,
            Sexta,
            Sabado
        }

        static void Main(string[] args)
        {
            // Exemplo de uso do enum DiaDaSemana
            DiaDaSemana hoje = DiaDaSemana.Terca; // Declara uma variavel do tipo DiaDaSemana e atribui o valor Quinta
            Console.WriteLine($"Hoje e: {hoje}"); 
            Console.ReadLine();
        }
    }
}