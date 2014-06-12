using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prueba
{
    public partial class AgregarAutor : Form
    {
        public AgregarAutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string myConnection = "datasource = localhost;username=root;password=123456";

                String sQuery = "INSERT INTO sistema_libros_cocina.autores ( aut_nombre, aut_apellido, lib_isbn_ID) VALUE( '" + this.NOMBRE.Text + "' , '" + this.APELLIDO.Text + "' ," + this.Libro_isbn.Text + ");";


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                myConn.Open();


                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("ALMACENADO !");
                }
                else
                {
                    MessageBox.Show("OPS, ALGO PASO CON TU CONEXION");
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
        
        }
    }
}