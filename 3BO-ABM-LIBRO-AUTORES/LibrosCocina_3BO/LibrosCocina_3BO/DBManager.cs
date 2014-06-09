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
    class DBManager
    {
        MySqlConnection conexion;
        String servidor = "localhost";
        String basededatos = "sistema_libros_cocina";
        String usuario = "root";
        String contraseña = "123456";
        MySqlDataReader rdr = null;

        public void inicilizar()
        {
            String Conexionstring = "SERVER=" + servidor + ";" + "DATABASE=" + basededatos + ";" + "USER=" + usuario + ";" + "PASSWORD=" + contraseña + ";";
            conexion = new MySqlConnection(Conexionstring);
            try
            {
                //conexion.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error en la conexión" + Convert.ToString(ex));
            }
        }

        public void crearLibro(String nombre_libro)
        {
            String Query = "INSERT INTO `sistema_libros_cocina`.`Libros` (`nombre`) VALUES (" + "'" + nombre_libro + "'" + ")" + ";";
            this.ejecutarQuery(Query);
        }

        public void eliminarLibro(int libroid)
        {
            String Query = "DELETE FROM `sistema_libros_cocina`.`Libros` WHERE libro_id=" + libroid + ";";
            this.ejecutarQuery(Query);
        }

        public void modificarLibro(String nombre_libro, int precio, String editorial, int libroid)
        {
            String Query = "UPDATE `sistema_libros_cocina`.`Libros` SET `nombre` = " + nombre_libro + " SET `precio` = " + precio + " SET `editorial` = " + editorial + " WHERE libro_id=" + libroid + ";";
            this.ejecutarQuery(Query);
        }



        public void crearAutor(String nombre_autor)
        {
            String Query = "INSERT INTO `sistema_libros_cocina`.`Autores` (`nombre`) VALUES (" + "'" + nombre_autor + "'" + ")" + ";";
            this.ejecutarQuery(Query);
        }

        public void eliminarAutor(int autorid)
        {
            String Query = "DELETE FROM `sistema_libros_cocina`.`Libros` WHERE libro_id=" + autorid + ";";
            this.ejecutarQuery(Query);
        }

        public void modificarAutor(String nombre_autor, int autorid)
        {
            String Query = "UPDATE `sistema_libros_cocina`.`Libros` SET `nombre` = " + nombre_autor + " WHERE libro_id=" + autorid + ";";
            this.ejecutarQuery(Query);
        }

        public void crearUsuario(int Usuario_id, String nombre, String apellido, String fecha_nac, String email, int telefono, String direccion)
        {
            if (isRegistrado(Usuario_id) == "N")
            {
                String Query = "INSERT INTO `sistema_libros_cocina`.`Usuario` (`is_Registrado`)(`nombre`) (`apellido`) (`fecha_nac`) (`email`) (`telefono`) (`direccion`) VALUES (" + "'" + "S" + "'" + "  " + "'" + nombre + "'" + " " + "'" + apellido + "'" + " " + "'" + fecha_nac + "'" + " " + "'" + email + "'" + " " + "'" + telefono + "'" + " " + "'" + direccion + "'" + ")" + ";";
                this.ejecutarQuery(Query);

            }else{




           
        }

        public void eliminarUsuario(int autorid)
        {
            String Query = "DELETE FROM `sistema_libros_cocina`.`Libros` WHERE libro_id=" + autorid + ";";
            this.ejecutarQuery(Query);
        }

        public void modificarUsuario(String nombre_autor, int autorid)
        {
            String Query = "UPDATE `sistema_libros_cocina`.`Libros` SET `nombre` = " + nombre_autor + " WHERE libro_id=" + autorid + ";";
            this.ejecutarQuery(Query);
        }

          

        public String isRegistrado(int Usuario_id){

            String Query = "SELECT `is_registrado` FROM `sistema_libros_cocina`.`Usuario` WHERE Usuario_id=" + Usuario_id + ";";
            this.ejecutarQuery(Query);

            return Query;
        
        }






        public void ejecutarQuery(String Query)
        {
            conexion.Open();
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }


    }
}