using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_dados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dado dado1 = new Dado();
            Dado dado2 = new Dado();
            Dado dado3 = new Dado();

            JuegoDados juego1 = new JuegoDados(dado1,dado2,dado3);
            
            Console.ReadKey();
        }
    }
}
