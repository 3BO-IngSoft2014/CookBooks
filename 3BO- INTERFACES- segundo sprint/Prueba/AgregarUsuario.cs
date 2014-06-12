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
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string myConnection = "datasource = localhost;username=root;password=123456";

                String sQuery = "INSERT INTO sistema_libros_cocina.usuario (nombreUsuario, pass, nombre, apellido, direccion, email, telefono) VALUE('" + this.nombreUsuario.Text + "', " + this.password.Text + " ,'" + this.nombre.Text + "', '" + this.apellido.Text + "' , '" + this.email.Text + "' , '" + this.direccion.Text + "' , " + this.telefono.Text + ");";


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                myConn.Open();


                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("USUARIO CREADO !");
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

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}