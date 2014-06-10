using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace LibrosCocina_3BO
{
     public class DBManager
    {
        MySqlConnection conexion;
        String servidor = "localhost";
        String basededatos = "sistema_libros_cocina";
        String usuario = "root";
        String contraseña = "123456";
        //MySqlDataReader rdr = null;
        //MySqlCommand command;

        public void inicilizar()
        {
            String Conexionstring = "SERVER=" + servidor + ";" + "DATABASE=" + basededatos + ";" + "USER=" + usuario + ";" + "PASSWORD=" + contraseña + ";";
            conexion = new MySqlConnection(Conexionstring);
            try
            {
               conexion.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la conexión" + Convert.ToString(ex));
            }
        }

            
        public void crearLibro(int isbn, String nombre_libro,int stock, String editorial, int precio)
        {
            String Query = "INSERT INTO " + basededatos +".Libros (lib_isbn,lib_nombre,lib_stock,lib_ventas,lib_editorial, lib_edicion,lib_precio VALUES( " + "'" + isbn  + "'" + nombre_libro  + "'" + stock  + "'" + editorial  + "'" + precio + "');"; 
            this.ejecutarQuery(Query);            
        }

        public void crearLibro(int isbn, String nombre_libro,int stock, String editorial) 
        {
            this.crearLibro(isbn, nombre_libro, stock, editorial, 0);
        }

        public void eliminarLibro(int isbn)
        {
            String Query = "DELETE FROM `sistema_libros_cocina`.`Libros` WHERE lib_isbn ==" + isbn + ";";
            this.ejecutarQuery(Query);
        }

        public void modificarLibro(int isbn, string nombre, int stock, string editorial, int edicion, int precio)
        {
            String Query = "UPDATE `sistema_libros_cocina`.`Libros` SET `lib_nombre` = " + nombre + " SET `lib_stock` = " + stock + " SET `lib_editorial` = " + editorial + " SET `lib_edicion` = " + edicion +" SET `precio` = " + precio + " WHERE lib_isbn=" + isbn + ";";
            this.ejecutarQuery(Query);
        }

        public void buscarLibrosMasVendidos()
        {
            // LIBROS MAS VENDIDOS (TAREA DE Luciano)
         
        }

        public void buscarLibroPorNombre(String unNombre)
        {
            
            //     SIN REALIZAR AUN
        }

        public void crearAutor(string nombre, string apellido)
        {
            String Query = "INSERT INTO " + basededatos + ".`Autores` (`nombre`) VALUES (" + "'" + nombre + "'" + "'" + apellido + "' );";
            this.ejecutarQuery(Query);
        }

        public void eliminarAutor(int id)
        {
            String Query = "DELETE FROM `sistema_libros_cocina`.`Autores` WHERE aut_id=" + id + ";";
            this.ejecutarQuery(Query);
        }

        public void modificarAutor(int id, String nombre, String apellido )
        {
            String Query = "UPDATE `sistema_libros_cocina`.`Autores` SET `aut_nombre` = " + nombre + " SET `aut_apellido` = " + apellido + " WHERE aut_id ==" + id + ";";
            this.ejecutarQuery(Query);
        }

        public void mapearAutoresYLibros()
        {
         //      SIN REALIZAR AUN
          
        }

        public void ejecutarQuery(String Query)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

        public void quitarDelStockDelLibro()
        {
            // (tarea de leonardo)
        }

        
        public void crearCliente(string unNombreUsuario, string password, string nombre, string apellido, string direccion, string email, int telefono)
        {
                        
            String columnas = "(`cli_nu`,`cli_pass``cli_nombre`,`cli_apellido`,`cli_email`)";
            String valores = unNombreUsuario + "," + password + "," + nombre + "," + apellido + "," +  email;
            String tabla = "`clientes`";
            String QueryEnTabla = "INSERT INTO `sistema_libros_cocina`." + tabla + columnas + " VALUES (" + valores + ");";
            this.ejecutarQuery(QueryEnTabla);
            tabla = "`dir_clientes`"; 
            columnas = "(`dir_nu`,`dir_calle`)";
            valores = unNombreUsuario + "," + direccion;
            this.ejecutarQuery(QueryEnTabla);
            tabla = "`tel_clientes`";
            columnas = "(`tel_nu`,`tel_particular`)";
            valores = unNombreUsuario + "," + telefono;
            this.ejecutarQuery(QueryEnTabla);

        }

        public void eliminarCliente(string nombreUsuario)
        {
            // falta el drop cascade para eliminarlo de otras tablas
            String Query = "DELETE FROM `sistema_libros_cocina`.`clientes` WHERE `cli_nu` = " + nombreUsuario + ";";
            this.ejecutarQuery(Query);
        }

        public void agregarLibroAHistorialDeVentas()
        {
            //     TAREA SIN REALIZAR AUN
        }

        public void agregarTelefono()
        {
        //     SIN REALIZAR AUN
        }

        public void agregarDireccion()
        {
              //      SIN REALIZAR AUN
        }

        

        
    }