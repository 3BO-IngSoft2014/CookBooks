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

        DBManager dbManager = new DBManager();
        int isbn;
        string nombre;
        int stock;
        string editorial;
        int edicion;
        int precio;


        public Libro(int isbn, string nombre, int stock, string editorial, int edicion, int precio)
        {
            this.isbn = isbn;
            this.nombre = nombre;
            this.stock = stock;
            this.editorial = editorial;
            this.edicion = edicion;
            this.precio = precio;
            dbManager.inicilizar();
        }

        public int getIsbn()
        {
            return this.isbn;
        }

        public void altaLibro()
        {
            dbManager.inicilizar();
            dbManager.crearLibro(this.isbn, nombre, stock, editorial, precio);
        }

        public void modificarLibro(int isbn, string nombre, int stock, string editorial, int edicion, int precio)
        {
            // tanto para alta como para modificacion tengo que meter mas columnas en la bd
            dbManager.inicilizar();
            dbManager.modificarLibro(this.isbn, nombre, stock, editorial, edicion, precio);
        }

        public void bajaLibro(int isbn)
        {

            dbManager.inicilizar();
            dbManager.eliminarLibro(isbn);
        }

        public void buscarLibrosMasVendidos()
        {

            //      tarea realizar por luciano
        }


        public string getNombre()
        {
            return this.nombre;
        }

    }
}

