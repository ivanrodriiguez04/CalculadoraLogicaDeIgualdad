using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogicaDeIgualdad.Servicios
{
    /// <summary>
    /// Clase que implementa a la interfaz del menu
    /// 10102023 -> irm
    /// </summary>
    internal class MenuImplementacion:MenuInterfaz
    {
        public int mostrarMenu()
        {
            int opcionIntroducida;

            Console.WriteLine("0. Cerrar Calculadora");
            Console.WriteLine("1. Igualdad");
            Console.WriteLine("2. Desigualdad");
            Console.WriteLine("¿Qué opcion desea utilizar?");

            opcionIntroducida = Console.ReadKey(true).KeyChar - ('0');

            return opcionIntroducida;
        }
    }
}
