using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosCocina_3BO
{
    public class UsuarioAnonimo : TipoUsuario
    {



        public UsuarioAnonimo(GestorDeUsuario unGestorDeUsuario)
        {
            this.setGestorDeUsuario(unGestorDeUsuario);
        }
        public void registrarse(string unNombreUsuario, string password, string nombre, string apellido, string dir, string email, int telefono)
        {
            this.getGestorDeUsuario().registrarUsuario(unNombreUsuario, password, nombre, apellido, dir, email, telefono);
        }

        public override void agregarACarrito(Libro unLibro)
        {
            throw new NotImplementedException();
        }

        public override void comprar()
        {
            throw new NotImplementedException();
        }

        public Carrito verCarrito()
        {
            throw new NotImplementedException();
        }

        public override void verLibro(Libro unLibro)
        {
            // una vista para ver el libro que tiene restricciones
        }

        public override void loguearUsuario(string nombreUsuario, string pass)
        {
            throw new NotImplementedException();
        }

        public override string getNombreUsuario()
        {
            throw new NotImplementedException();
        }


    }
}
