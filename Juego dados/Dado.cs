using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego_dados
{
    internal class Dado
    {
        public int valor;

        public Dado()
        {
            tirar();
            imprimir();
        }

        public void tirar()
        {
            valor = new Random().Next(1, 6);
        }
        public void imprimir()
        {
            Console.WriteLine(RetornarValor());
        }
        public int RetornarValor()
        {
            return valor;
        }
    }
}
