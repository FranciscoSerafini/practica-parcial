using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace practica_parcial
{
    class clsTemperatura
    {
        public DataSet DS;
        String Tabla = "Temperaturas";
        private string Cadena = "";
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataAdapter Adaptador;
        private DataTable Tabla;
        public clsTemperatura()
        {
            
       
        }
        public DataTable GetTemperaturas()
        {
            if (DS != null && DS.Tables.Count == 1)
            {
                return DS.Tables["Temperaturas"];

            }
            return null;
        }
    
    }

}
