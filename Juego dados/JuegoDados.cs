using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_dados
{
    internal class JuegoDados
    {
        Dado dado1;
        Dado dado2;
        Dado dado3;

        public JuegoDados(Dado _dado1, Dado _dado2, Dado _dado3)
        {
            this.dado1 = _dado1;

            this.dado2 = _dado2;

            this.dado3 = _dado3;
            
            jugar();
        }

        public void jugar()
        {

            if (dado1.valor == dado2.valor && dado2.valor == dado3.valor)
            {
                Console.WriteLine("Gano!!");
            }
            else
            {
                Console.WriteLine("Perdio");
            }
        }
    }
}
