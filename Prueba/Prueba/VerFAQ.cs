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
    public partial class VerFAQ : Form
    {
        public VerFAQ()
        {
            InitializeComponent();
            Fill();
        }

        void Fill()
        {
            try
            {
                string myConnection = "datasource = localhost;port= 3307;username=root;password=42878880";

                String sQuery = "SELECT * FROM sistema_libros_cocina.preguntasyrespuestas; ";// WHERE preg = '" + myString + "' ;";


                MySqlConnection myConn = new MySqlConnection(myConnection);

                MySqlCommand command = new MySqlCommand(sQuery, myConn);

                //MySqlDataAdapter sda = new MySqlDataAdapter();
                MySqlDataReader myReader;
                myConn.Open();
                //sda.SelectCommand = command;
                myReader = command.ExecuteReader();

                while (myReader.Read())
                {
                    String sName = myReader.GetString("preg");
                    this.pregBox.Items.Add(sName);

                }﻿
                


                myConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }﻿
        }


        private void Elegir_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource = localhost;port= 3307;username=root;password=42878880";
                string myString = this.pregBox.Text;
                String sQuery = "SELECT resp FROM sistema_libros_cocina.preguntasyrespuestas WHERE preg = '" + myString + "' ;";


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
