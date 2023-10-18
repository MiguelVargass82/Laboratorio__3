using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Amigo_Secreto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OpcionJugad_SelectedItemChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //foreach (String[] Jugador in Jugador )
            {
                //OpcionJugad.Items.Add(Jugador.nombre);
            }
            if (numEndu.Value != 0 && frecEndul.Value != 0)
            {
                int tiempoDias = Convert.ToInt32(numEndu.Text) * Convert.ToInt32(frecEndul.Text);
                DateTime fechaSeleccionada = fechaIni.Value;
                DateTime fechaFinal = fechaSeleccionada.AddDays(tiempoDias);
                lblFecha.Text = "El juego terminará el dia: " + fechaFinal.ToString();
                lblFechaIn.Visible = false;
                lblFecha.Visible = true;
                lblNum.Visible = false;
                lblFrec.Visible = false;
                numEndu.Visible = false;
                frecEndul.Visible = false;
                fechaIni.Visible = false;
                btnGuardar.Visible = false;
                numeroJugadores.Visible = false;
                lblJugador.Visible = false;
            }
            else
            {
                MessageBox.Show("Papi sea serio y de todos los valores pedidos");
            }
        }

        private void consultCorreo_Click(object sender, EventArgs e)
        {

        }
    }
}
