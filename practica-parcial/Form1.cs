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
        Int32 minima;
        Int32 maxima;
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
            cmbLocalidad.DataSource = objClima.GetAllClima();
            Tabla = objClima.GetAllClima();


        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            Int32 LocSelecciona = Convert.ToInt32(cmbLocalidad.SelectedValue);
            String FechaFormulario = dtPFecha.Value.ToString("dd/MM/yyyy");

            clsTemperatura Localidad = new clsTemperatura();
            DataTable tabla =  Localidad.GetAllTemperatura();

            foreach (DataRow fila in tabla.Rows) //tipo de dato, variable,
            {
                if (Convert.ToInt32(fila["localidad"]) == LocSelecciona)
                {
                    DateTime fechaBase = Convert.ToDateTime(fila["fecha"]); //fecha de base de datos
                    string fechaFormBase = fechaBase.ToString("dd/MM/yyyy");
                    if (FechaFormulario == fechaFormBase)
                    {
                        minima = Convert.ToInt32(fila["minima"]);
                        maxima = Convert.ToInt32(fila["maxima"]);


                    }


                }

                txtMinimo.Text = Convert.ToString(minima);
                txtMaximo.Text = Convert.ToString(maxima);

            }
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }

}
