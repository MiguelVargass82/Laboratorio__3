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

       
        public int numJug;
        public AmigoSecreto Ocasion;
        public Jugador[] participantes;
         public Form1()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

        }
        public void btnJugad_Click(object sender, EventArgs e)
        {
            
            if (numEndu.Text != "" && frecEndul.Text != "")
            {
                int tiempoDias = Convert.ToInt32(numEndu.Text) * Convert.ToInt32(frecEndul.Text);
                DateTime fechaSeleccionada = dateTimePicker1.Value;
                DateTime fechaFinal = fechaSeleccionada.AddDays(tiempoDias);
                lblFecha.Text = " El juego terminará el dia: " + fechaFinal.ToString()   + "\n Proxima endulzada: " + fechaSeleccionada.AddDays(Convert.ToInt32(frecEndul.Text));
                lblFecha.Visible = true;
                lblNum.Visible = false;
                lblFrec.Visible = false;
                numEndu.Visible = false;
                frecEndul.Visible = false;
                label2.Visible = false;
                dateTimePicker1.Visible = false;
                valorEndu.Visible = false;
                valorRega.Visible = false;
                lblValorEndu.Visible = false;
                lblValorRega.Visible = false;

                this.numJug = Convert.ToInt32(contJugad.Value);

                txtDato1.Visible = true;
                txtDato2.Visible = true;
                txtDato3.Visible = true;
                lblRegalo.Visible = true;
                Nombre.Visible = true;
                correo.Visible = true;
                endulzada.Visible = true;
                regalo.Visible = true;
                btnSubir.Visible = true;

                Ocasion = new AmigoSecreto(numJug);

            }
            else
            {
                MessageBox.Show("Papi sea serio y de todos los valores pedidos");
            }

            Jugador[] participantes = new Jugador[numJug];  //creacion del vector


            btnJugad.Enabled = false;
        }

       
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }


        //En el evento del boton subir realizaremos la asignacion al vector del cada jugador en cada posicion

        int cont = 0;
        static int nummm = 8;           //Le puse static y UY QUIETO!!
        
        

       
        public void btnSubir_Click(object sender, EventArgs e)
        {
             
            

            // Variable que cambiara por el valor de las personas que definio santiago
            string nombrev = Nombre.Text;
            string correov = correo.Text;
            string endulzadav = endulzada.Text;
            string regalov = regalo.Text;      //Se supone que ya debe funcionar la asignacion de datos (necesitamos el numero de jugadores)

            Ocasion.llenarDatos(cont, nombrev, correov, endulzadav, regalov);





            //participantes = Ocasion.llenarDatos(cont, participantes, nombrev, correov, endulzadav, regalov);

            Nombre.Clear();
            correo.Clear();
            endulzada.Clear();
            regalo.Clear();
          
            cont++;
       
        }
        //NECESITO SACAR DE ESTE AMBITO LA VARIABLE PARTICIPANTES


        private void saltar_Click(object sender, EventArgs e)
        {


            Jugador[] amigos = Ocasion.DesorganizadoAcertado(participantes);

            // La idea es que aca comienze a mostrar los correos 


            MessageBox.Show((Ocasion.SacarNombres(participantes)[1]));
            // Me esta lanzando un error que creemos que puede ser que no se esta usando la misma variable 
            //participantes que definimos anteriormente
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            correo miforma = new correo();

            miforma.Show();

        }
    }
}