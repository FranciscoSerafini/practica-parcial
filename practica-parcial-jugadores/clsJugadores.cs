using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace practica_parcial_jugadores
{
    internal class clsJugadores
    {
        private string cadena = "";
        private OleDbConnection conector;
        private OleDbCommand comando;
        private OleDbDataAdapter adaptador;
        private DataTable tabla;

        string urlFoto;

        public clsJugadores()
        {
            cadena = clsConfig.getCadena();
            conector = new OleDbConnection(cadena);
            comando = new OleDbCommand();

            comando.Connection = conector;
            comando.CommandType = CommandType.TableDirect;
            comando.CommandText = "Jugadores";

            adaptador = new OleDbDataAdapter(comando);
            tabla = new DataTable();
            adaptador.Fill(tabla);

            DataColumn[] dc = new DataColumn[8];
            dc[0] = tabla.Columns["Numero"];
            tabla.PrimaryKey = dc;

         
            

        }

        public void llenar(ComboBox combo)
        {
            combo.DisplayMember = "Numero";
            combo.ValueMember = "Nombre";
            combo.DataSource = tabla;
        }

        public void buscar(Int32 numeroFormulario, Label lblNombre, Label lblPosicion, Label lblPierna, Label lblPeso, Label lblAltura, PictureBox PBimagen)
        {
            DataRow fila = tabla.Rows.Find(numeroFormulario);
            if (fila is null)
            {
                MessageBox.Show("Error");
            }
            else
            {
                lblNombre.Text = fila["Nombre"].ToString();
                lblPosicion.Text = fila["Posicion"].ToString();
                lblPierna.Text = fila["Pierna"].ToString();
                lblPeso.Text = fila["Peso"].ToString();
                lblAltura.Text = fila["Altura"].ToString();

                urlFoto = fila["Foto"].ToString();
                PBimagen.ImageLocation = "Imagenes/" + urlFoto;
            }

        }


    }
}
