using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_parcial
{
    public partial class Form1 : Form
    {
        clsClima localidades;
        clsTemperatura temperatura;
        DataTable Tabla;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsClima objClima = new clsClima();
            //llenado de combo box
            cmbLocalidad.DisplayMember = "nombre";
            cmbLocalidad.ValueMember = "localidad";
            cmbLocalidad.DataSource = objClima.GetAll();
            Tabla = objClima.GetAll();


        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 localidad = Convert.ToInt32(cmbLocalidad.SelectedValue);
            string Varfecha = dtPFecha.Text;

            temperatura = new clsTemperatura();
            Tabla = temperatura.GetAll();

            foreach (DataRow fila in Tabla.Rows)
            {
                DateTime fechahora = Convert.ToDateTime(fila["fecha"]);
                string fecha = fechahora.ToString("dd/MM/yyyy");

                if (Varfecha == fecha)
                {
                    txtMaximo.Text = fila[2].ToString();
                    txtMinimo.Text = fila[3].ToString();
                }
            }
            
        }
    }

}
