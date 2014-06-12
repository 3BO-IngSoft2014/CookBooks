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
    public partial class ListadoLibros : Form
    {
        public ListadoLibros()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;username=root;password=123456";

                String sQuery = "SELECT * FROM sistema_libros_cocina.libros ;";


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = command;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                dataGrid.DataSource = bSource;
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
