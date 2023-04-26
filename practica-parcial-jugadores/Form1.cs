using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_parcial_jugadores
{
    
    public partial class frmPrincipal : Form
    {
        Int32 numeroFormulario;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

           clsJugadores objJugadores = new clsJugadores();
            objJugadores.llenar(comboBox1);

        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            DataRowView filaSeleccionada = (DataRowView)comboBox1.SelectedItem;

            Int32 valorSeleccionado = Convert.ToInt32(filaSeleccionada["Numero"]);
           
            numeroFormulario = valorSeleccionado;


            clsJugadores jugadores = new clsJugadores();
            jugadores.buscar(numeroFormulario, lblNombre, lblPosicion, lblPierna, lblAltura, lblpeso, PBimagen);
        }
    }
}
