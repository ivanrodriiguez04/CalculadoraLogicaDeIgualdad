using CalculadoraLogicaDeIgualdad.Servicios;

namespace CalculadoraLogicaDeIgualdad 
{
    /// <summary>
    /// Clase principal de la aplicacion
    /// 10102023 -> irm
    /// </summary>

    class Program 
    {
        /// <summary>
        /// Metodo principal de la aplicacion
        /// 10102023 -> irm
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) 
        {
            //Creamos los objetos necesarios
            MenuInterfaz menuInt = new MenuImplementacion();
            CalculadoraInterfaz calcInt = new CalculadoraImplementacion();

            //Variables
            bool cerrarMenu = false;
            int opcionSeleccinada;

            //iniciamos el bucle
            while (!cerrarMenu) 
            {
                opcionSeleccinada = menuInt.mostrarMenu();
                switch (opcionSeleccinada) 
                { 
                    case 0:
                        Console.WriteLine("Cerrando la calculadora");
                        cerrarMenu = true;
                        break;
                    case 1:
                        calcInt.igualdad();
                        break; 
                    case 2:
                        calcInt.desigualdad();
                        break;
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }
    }
}