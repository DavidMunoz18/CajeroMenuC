﻿using CajeroMenuC.Servicios;

namespace CajeroMenuC.Controladores
{
    /// <summary>
    /// Clase principal de la aplicación
    /// 250923 - dmp
    /// </summary>
    class program
    {
        /// <summary>
        /// Método de entrada de la aplicación
        /// 250923 - dmp
        /// </summary>
        /// <param name="args"></param>
        static void Main(String[] args)
        {
            MenuInterfaz mi = new MenuImplementacion();
            mi.mostrarMensajeBienvenida();

            //variable que controla la entrada y salida del bucle
            bool cerrarMenu = false;
            //contener la opción del usuario
            int opcionSeleccionada;

            //desde la primera iteración debe cumplirse la condición
            while(!cerrarMenu)
            {

                opcionSeleccionada = mi.mostrarMenuYSeleccion();

                switch(opcionSeleccionada)
                {
                    case 0:
                        Console.WriteLine("[INFO] - Se ejecuta caso 0 ");
                        cerrarMenu = true;
                        break;
                    case 1:
                        Console.WriteLine("[INFO] - Se ejecuta caso 1 ");
                        break;
                    case 2:
                        Console.WriteLine("[INFO] - Se ejecuta caso 2 ");
                        break;
                    case 3:
                        Console.WriteLine("[INFO] - Se ejecuta caso 3 ");
                        break;
                    case 4:
                        Console.WriteLine("[INFO] - Se ejecuta caso 4 ");
                        break;
                    case 5:
                        Console.WriteLine("[INFO] - Se ejecuta caso 5 ");
                        break;
                    default:
                        
                        //escribe lo que le pidamos
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }
            }
        }

    }
}