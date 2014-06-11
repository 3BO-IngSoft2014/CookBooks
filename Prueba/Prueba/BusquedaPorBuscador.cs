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
    public partial class BusquedaPorBuscador : Form
    {
        public BusquedaPorBuscador()
        {
            InitializeComponent();
        }

        private void BUSCAR_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;port= 3307;username=root;password=42878880";
                string myString = this.busq_text.Text;
                String sQuery = "SELECT * FROM sistema_libros_cocina.libros_autores WHERE nombreA LIKE '%" + myString + "%' or nombreL LIKE '%" + myString + "%';"; // + myString + "';"; // + " %'); "; // +this.busq_text.Text + " ' ;"; // " %';" ;//=' " + this.busq_text.Text + "  ' or c.nombreL = '" + this.busq_text.Text + " ' ;";


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                this.dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);

                //myConn.Open();




                //myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
        }
    }
}
