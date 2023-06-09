﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace practica_parcial
{
    class clsTemperatura
    {
        private string Cadena = "";
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable Tabla;

        public clsTemperatura()
        {
            Cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            conexion = new OleDbConnection(Cadena);
            comando = new OleDbCommand();

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Temperaturas";

            adaptador = new OleDbDataAdapter(comando);
            Tabla = new DataTable();
            adaptador.Fill(Tabla);
        }
        public DataTable GetAllTemperatura()
        {
            return Tabla;
        }



    }

}
