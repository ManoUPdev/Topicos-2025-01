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
        // Um enum é um tipo especial que permite definir um conjunto fixo de constantes nomeadas. É
        // ótimo para representar valores limitados e claros, tipo dias da semana, estados, cores, etc.

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