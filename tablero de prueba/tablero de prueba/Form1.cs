using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3;

namespace tablero_de_prueba
{
    public partial class Form1 : Form
    {

        private Jugador[] jugadores;
        public Form1()
        {
            InitializeComponent();

          
            string num = "10";
            int numm = int.Parse(num);

            AmigoSecreto ejemplo = new AmigoSecreto(numm);

         //   jugadores = ejemplo.llenarDatos();


           

            ejemplo.Todo(jugadores);
            


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numEndu.Text != "" && frecEndul.Text != "")
            {
                int tiempoDias = Convert.ToInt32(numEndu.Text) * Convert.ToInt32(frecEndul.Text);
                DateTime fechaSeleccionada = dateTimePicker1.Value;
                DateTime fechaFinal = fechaSeleccionada.AddDays(tiempoDias);
                lblFecha.Text = "El juego terminará el dia: " + fechaFinal.ToString();
                lblFecha.Visible = true;
                lblNum.Visible = false;
                lblFrec.Visible = false;
                numEndu.Visible = false;
                frecEndul.Visible = false;
                label2.Visible = false;
                dateTimePicker1.Visible = false;
                btn_fecha.Visible = false;

                correo miforma = new correo();

                miforma.Show();

            }
            else
            {
                MessageBox.Show("Papi sea serio y de todos los valores pedidos");
            }


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void btnJugad_Click(object sender, EventArgs e)
        {
            int veces = Convert.ToInt32(contJugad.Value);
            int jugador = 1;
            while (veces != 0 && jugador <= contJugad.Value)
            {


            }
            txtDato1.Visible = true;
            txtDato2.Visible = true;
            txtDato3.Visible = true;
            Nombre.Visible = true;
            correo.Visible = true;
            endulzada.Visible = true;
            btnSubir.Visible = true;
            
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (jugadores != null)
            {
                AmigoSecreto amigoSecreto = new AmigoSecreto(jugadores.Length);
                string[] nombresJugadores = jugadores.Select(jugador => jugador.getNombre()).ToArray();
                amigoSecreto.NombreComboBox(nombresJugadores); // Usar jugadores en este contexto
            }
            else
            {
                // Manejo de error si jugadores no ha sido inicializado.
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {
            int contador = 0;
            for(int i = 0; i < contJugad.Value; i++)
            {

                Nombre.Clear();
                correo.Clear();
                endulzada.Clear();
                regalo.Clear();
                contador++;
            }
            

            string textoIngresado = Nombre.Text;
        }
    }
}