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
            clsClima clima = new clsClima();
            cmbLocalidad.DisplayMember = "nombre";
            cmbLocalidad.ValueMember = "localidad";
            cmbLocalidad.DataSource = clima.GetLocalidades();

            clsTemperatura temperatura = new clsTemperatura();
            


            DateTime fecha = dtPFecha.Value.Date;
            // la hora se guarda en formato hora:minutos,
            // con la hora en formato 24 horas
            


        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            int localidades = Convert.ToInt32(cmbLocalidad.SelectedValue);
            
        }
    }

}
