using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace practica_parcial
{
    class clsClima
    {
       public DataSet DS;
        String Tabla = "Localidades";
        public clsClima()
        {
            OleDbConnection conexion = new OleDbConnection();
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Clima.mdb";
            conexion.Open();
            DS = new DataSet();

            // tabla de clima
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.TableDirect;
            cmd.CommandText = Tabla;
            OleDbDataAdapter DA = new OleDbDataAdapter(cmd);
            DA.Fill(DS, Tabla);
            DataColumn[] pk = new DataColumn[1];
            pk[0] = DS.Tables[Tabla].Columns["Localidades"];
            DS.Tables[Tabla].PrimaryKey = pk;
            OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
            conexion.Close();
        }
        public DataTable GetLocalidades()
        {
            if (DS != null && DS.Tables.Count == 1)
            {
                return DS.Tables["Localidades"];
            }
            return null;
        }

    }
}
