using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_parcial_jugadores
{
    internal class clsConfig
    {
        public static string getCadena()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=RiverBaseDatos.mdb";
            return cadena;
        }



    }
}
