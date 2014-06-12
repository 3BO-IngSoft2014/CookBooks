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
    public partial class EliminarAutor : Form
    {
        public EliminarAutor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;username=root;password=123456";

                String sQuery = "DELETE FROM sistema_libros_cocina.autores WHERE aut_nombre = '" + this.Nombre.Text + "' AND aut_apellido = '" + this.Apellido.Text + "';";


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                myConn.Open();


                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("El autor ha sido eliminado !");
                }
                else
                {
                    MessageBox.Show("OPS");
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }﻿

    }
}