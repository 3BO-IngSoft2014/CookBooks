using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosCocina_3BO
{
    public abstract class TipoUsuario
    {
          // falta crear GESTOR USUARIO (TAREA DE LEONARDO)
        private GestorDeUsuario unGestorDeUsuario;

        public abstract void agregarACarrito(Libro unLibro);
        public abstract void comprar();
        public abstract void verLibro(Libro unLibro);
        public abstract void loguearUsuario(string nombreUsuario, string pass);
        public void buscarLibroPorNombre(Libro unLibro)
        {
            this.unGestorDeUsuario.buscarLibroPorNombre(unLibro);
        }
        public void setGestorDeUsuario(GestorDeUsuario unGestorDeUsuario)
        {
            this.unGestorDeUsuario = unGestorDeUsuario;
        }

        public GestorDeUsuario getGestorDeUsuario()
        {
            return this.unGestorDeUsuario;
        }

        public abstract string getNombreUsuario();
    }
}
