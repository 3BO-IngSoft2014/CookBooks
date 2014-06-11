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
    public partial class BorrarLibro : Form
    {
        public BorrarLibro()
        {
            InitializeComponent();
        }

        private void Activar_Borrado_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;port= 3307;username=root;password=42878880";

                String sQuery = "DELETE FROM sistema_libros_cocina.libros_autores WHERE isbn = '" + this.bl_text.Text + "';"; 


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                myConn.Open();


                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("EL LIBRO CON EL ISBN INGRESADO HA SIDO BORRADO !");
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
            }﻿
        }
    }
}
