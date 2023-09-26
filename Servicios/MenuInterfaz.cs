using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroMenuC.Servicios
{
    /// <summary>
    /// Interfaz con la relación de métodos de la funcionalidad menú
    /// </summary>
    internal interface MenuInterfaz
    {
        /// <summary>
        /// Método que muestra mensaje de bienvenida al cajero
        /// 250923 - dmp
        /// </summary>
        void mostrarMensajeBienvenida();
        /// <summary>
        /// Método que muestra el menu y recoge la selección del ususario
        /// 260923 - dmp
        /// </summary>
        /// <returns></returns>
        public int mostrarMenuYSeleccion();
    }
}
