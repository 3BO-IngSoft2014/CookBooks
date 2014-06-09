using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosCocina_3BO
{
    class Usuario
    {
   {
        
        public int Usuario_id, telefono, ;
        public String nombre, apellido, email, fecha_nac, direccion;

        DBManager dbManager = new DBManager();


        public Usuario()
        {
            dbManager.inicilizar();
        }

        public void altaUsuario(int precio, string nombre, string editorial, int libro_id)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.editorial = editorial;
            this.libro_id = libro_id;
            dbManager.inicilizar();
            dbManager.crearLibro(nombre);
        }

        public void modificarLibro(int precio, string nombre, string editorial, int libro_id)
        {
            this.precio = precio;
            this.nombre = nombre;
            this.editorial = editorial;
            this.libro_id = libro_id;
            dbManager.inicilizar();
            dbManager.modificarLibro(nombre, precio, editorial, libro_id);
        }

        public void bajaLibro(int libro_id)
        {
            this.libro_id = libro_id;
            dbManager.inicilizar();
            dbManager.eliminarLibro(libro_id);
        }

    }
}