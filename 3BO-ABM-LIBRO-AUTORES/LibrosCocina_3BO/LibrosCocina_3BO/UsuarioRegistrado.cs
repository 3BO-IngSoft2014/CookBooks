using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosCocina_3BO
{
    public class UsuarioRegistrado : TipoUsuario
    {

        private string nombre;
        private string apellido;
        private string direccion;
        private string email;
        private int telefono;
        private string password;

        private string unNombreUsuario;
        DBManager dbManager = new DBManager();


        public UsuarioRegistrado(GestorDeUsuario unGestorDeUsuario, string unNombreUsuario, string password, string nombre, string apellido, string direccion, string email, int telefono)
        {
            this.setGestorDeUsuario(unGestorDeUsuario);
            this.password = password;
            this.nombre = nombre;
            this.apellido = apellido;
            this.direccion = direccion;
            this.email = email;
            this.telefono = telefono;
            this.unNombreUsuario = unNombreUsuario;
        }

        public override string getNombreUsuario()
        {
            return this.unNombreUsuario;
        }

        public override void agregarACarrito(Libro unLibro)
        {
            getGestorDeUsuario().agregar(unLibro);
        }


        public override void comprar()
        {
            getGestorDeUsuario().concretaCompra();
        }


        public override void verLibro(Libro unLibro)
        {
            // veo el libro
        }

        public override void loguearUsuario(string nombreUsuario, string pass)
        {    // TAREA DE LEONARDO
            //comprobar que lo de abajo sea verdad, ES MAS COMPLEJO QUE ESO
            // VA EN UN TRY CATCH
            if (this.unNombreUsuario == nombreUsuario && this.password == pass)
            {
                // algo
            }
        }



    }
}