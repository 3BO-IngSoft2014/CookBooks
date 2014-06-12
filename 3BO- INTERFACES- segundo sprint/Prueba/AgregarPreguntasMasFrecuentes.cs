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
    public partial class AgregarPreguntasMasFrecuentes : Form
    {
        public AgregarPreguntasMasFrecuentes()
        {
            InitializeComponent();
        }


        private void AgregarPreguntaYRespuesta_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;port= 3307;username=root;password=123456";

                String sQuery = "INSERT INTO sistema_libros_cocina.PreguntasYRespuestas (preg,resp) VALUE('" + this.preg_text.Text + "', '" + this.resp_text.Text + "');";


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
