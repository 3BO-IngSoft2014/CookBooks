using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrosCocina_3BO
{
    public class Autor
    {
        public int autor_id, libro_id;
        public String nombre;
        DBManager dbManager = new DBManager();


        public Autor()
        {
            dbManager.inicilizar();
        }

        public void altaAutor(int autor_id, string nombre, int libro_id)
        {
            this.autor_id = autor_id;
            this.nombre = nombre;
            this.libro_id = libro_id;
            dbManager.inicilizar();
            dbManager.crearLibro(nombre);
        }

        public void modificarAutor(int autor_id, string nombre, int libro_id)
        {
            this.autor_id = autor_id;
            this.nombre = nombre;
            this.libro_id = libro_id;
            dbManager.inicilizar();
            dbManager.modificarAutor(nombre, autor_id);
        }

        public void bajaAutor(int autor_id)
        {
            this.autor_id = autor_id;
            dbManager.inicilizar();
            dbManager.eliminarAutor(autor_id);
        }

    }
}
