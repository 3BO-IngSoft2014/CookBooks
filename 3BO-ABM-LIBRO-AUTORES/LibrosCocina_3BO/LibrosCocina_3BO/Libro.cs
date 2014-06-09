using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace LibrosCocina_3BO
{
    public class Libro
    {
        public int libro_id, autor_id, precio;
        public String nombre, editorial;
        DBManager dbManager = new DBManager();


        public Libro()
        {
            dbManager.inicilizar();
        }

        public void altaLibro(int precio, string nombre, string editorial, int libro_id)
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

