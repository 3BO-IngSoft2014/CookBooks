/*
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
    public partial class ModificarLibro : Form
    {
        public ModificarLibro()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
 {
            
                try
                {
                    string myConnection = "datasource = localhost;username=root;password=123456";

                    String sQuery = "UPDATE `sistema_libros_cocina`.`Libros`  SET `lib_nombre` = " + this.textBox1.Text + " SET `lib_stock` = " + this.textBox2.Text + " SET `lib_editorial` = " + this.textBox3.Text + " SET `lib_edicion` = " + this.textBox4.Text +" SET `precio` = " + this.textBox5.Text + " WHERE lib_isbn=" + this.textBox6.Text + ";";

                    MySqlConnection myConn = new MySqlConnection(myConnection);

                    MySqlCommand command = new MySqlCommand(sQuery, myConn);

                    myConn.Open();


                    if (command.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Guardado !");
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


*/