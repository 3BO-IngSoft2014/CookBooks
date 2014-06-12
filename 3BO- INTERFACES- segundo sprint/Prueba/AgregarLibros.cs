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
    public partial class AgregarLibros : Form
    {
        public AgregarLibros()
        {
            InitializeComponent();
            
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string myConnection = "datasource = localhost;username=root;password=123456";

                    String sQuery = "INSERT INTO sistema_libros_cocina.libros ( lib_isbn, lib_nombre, lib_stock, lib_editorial, lib_edicion, lib_precio) VALUE(" + this.ISBN_text.Text + ", '" + this.nombre_text.Text + "' , " + this.stock_text.Text + " ,'" + this.editorial_text.Text + "' , '" + this.edicion_text.Text + "'," + this.precio_text.Text + ");";


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
