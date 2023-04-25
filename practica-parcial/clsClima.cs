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
        //declaramos las cadenas de conexion 

        private string Cadena = "";
        //
        private OleDbConnection conexion;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable Tabla;

        //creamos el constructor:
        public clsClima()
        {
            Cadena = "provider=microsoft.jet.oledb.4.0;data source=CLIMA.mdb";
            conexion = new OleDbConnection(Cadena);
            comando = new OleDbCommand();
            

            comando.Connection = conexion;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Localidades";

            adaptador = new OleDbDataAdapter(comando);
            Tabla = new DataTable();
            adaptador.Fill(Tabla);


        }
       public DataTable GetAllClima()
       {
            return Tabla;
       }

    }
}
