using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaDeIgualdad.Servicios
{
    /// <summary>
    /// Clase que implementa la interfaz de la calculadora
    /// 10102023 -> irm
    /// </summary>
    internal class CalculadoraImplementacion : CalculadoraInterfaz
    {
        public void igualdad()
        {
            String texto1=PedirTexto();
            String texto2=PedirTexto();
            if (texto1 == texto2)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            }

        }

        public void desigualdad()
        {
            String texto1 = PedirTexto();
            String texto2 = PedirTexto();
            if (texto1 != texto2)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");

            }
        }
        private String PedirTexto()
        {
            String texto;
            Console.WriteLine("Indique el texto");
            texto = Console.ReadLine();

            return texto;
        }
    }
}
