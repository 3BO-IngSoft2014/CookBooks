using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prueba
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AgregarLibros());
            //Application.Run(new LibrosMasVendidos());
            //Application.Run(new AgregarPreguntasMasFrecuentes());
            //Application.Run(new BusquedaPorBuscador());
            //Application.Run(new BorrarLibro());
            Application.Run(new ListadoLibros());
        }
    }
}
