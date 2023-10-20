using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public Jugador[] participantes; //Participantes no esta haciendo nada
         public Form1()
        {
            InitializeComponent();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dateTimePicker1.Value;

        }
        public void btnJugad_Click(object sender, EventArgs e)  //BOTON GUARDAR (1)
        {

            if (numEndu.Text != "" && frecEndul.Text != "" && valorEndu.Text != "" && valorRega.Text != "")
            {
                int numEnduF;
                int frecEndulF;
                int valorRegaF;
                int valorEnduF;
                if (int.TryParse(numEndu.Text, out numEnduF) && int.TryParse(frecEndul.Text, out frecEndulF) && int.TryParse(valorEndu.Text, out valorEnduF) && int.TryParse(valorRega.Text, out valorRegaF))
                {
                    int tiempoDias = Convert.ToInt32(numEndu.Text) * Convert.ToInt32(frecEndul.Text);
                    DateTime fechaSeleccionada = dateTimePicker1.Value;
                    DateTime fechaFinal = fechaSeleccionada.AddDays(tiempoDias);
                    lblFecha.Text = " El juego terminará el dia: " + fechaFinal.ToString() + "\n Proxima endulzada: " + fechaSeleccionada.AddDays(Convert.ToInt32(frecEndul.Text));
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
                    saltar.Visible = true;

                   Ocasion = new AmigoSecreto(numJug);   //Definimso un objeto de la clase amigo secreto 
                                                          //Mediante ocasion podremos acceder a los datos que necesitemos
                    //Osea que numJug si funciona
                }
                else
                {
                    MessageBox.Show("Por favor, no ingreses letras >:)");
                }
                

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

        int cont = 0;   //Definimos un contador que interara en las posiciones                         
        public void btnSubir_Click(object sender, EventArgs e)  //BOTON SUBIR
        {

            if (cont < numJug)
            {


                string nombrev = Nombre.Text;           //Extraemos los datos de los textbox cada vez que presionemos el boton
                string correov = correo.Text;
                string endulzadav = endulzada.Text;
                string regalov = regalo.Text;

                Ocasion.llenarDatos(cont, nombrev, correov, endulzadav, regalov);   //Aplicamos la funcion llenar datos para el objeto jugador

                Nombre.Clear();
                correo.Clear();
                endulzada.Clear();
                regalo.Clear();

                cont++;
            }
            else
            {
                MessageBox.Show("Estas definiendo mas jugadores de los que estableciste anteriormente");
            }
        }//Fin del evento boton subir
       


        private void saltar_Click(object sender, EventArgs e)   //BOTON CORREOS
        {
            Jugador[] amigos = Ocasion.DesorganizadoAcertado(Ocasion.jugadores);
            //Amigos sera el vector que contiene los amigos secretos

            //Ya funciona el almacenamiento de los botones

            // La idea es que aca comienze a mostrar los correos 

         //   MessageBox.Show(Ocasion.SacarNombres(Ocasion.jugadores)[0]);
           // MessageBox.Show(Ocasion.SacarNombres(amigos)[0]);


           string[] nombresAmi = Ocasion.SacarNombres(amigos); //Lista de amigos secretos

            string[]listCorre = Ocasion.SacarCorreos(Ocasion.jugadores); //lista de correos personales

            string[]listendulza = Ocasion.SacarEndulzadas(amigos); //lista de eldulzadas

            string[] listrega = Ocasion.SacarRegalos(amigos);        //Lista de regalos


            correo miforma = new correo();

            miforma.nombresAmigos = nombresAmi;

            miforma.listCorreos = listCorre;        //Asignamos a las variables de el otro formularios los valores que necesitamos de este

            miforma.listendulzadas = listendulza;

            miforma.listregalo = listrega;


            miforma.amigolbl.Text = nombresAmi[0];
            miforma.amigolbl2.Text = nombresAmi[0];     //Necesitamos que esto aparezca de primeras
            miforma.amigolbl1.Text = nombresAmi[0];

            miforma.correolbl.Text = listCorre[0];
            miforma.endulzadalbl.Text = listendulza[0];
            miforma.regalolbl.Text = listrega[0];




            miforma.Ocasionn = Ocasion;
            miforma.amigos = amigos;
            miforma.Show();

        }

   






        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   //Un boton que simplemente cierra
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {
        } //NADA LABEL DOBLE CLIC
    }
}