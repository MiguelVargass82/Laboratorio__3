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
    public partial class correo : Form
    {
        public object jugadores;
        public AmigoSecreto Ocasionn;
        public Jugador[] amigos;

        public correo()
        {
        
            InitializeComponent();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {           
        } //NADA

        private void button1_Click(object sender, EventArgs e) //BOTON SIGUIENTE  de correos
        {
            //Se encargara de que cada vez que le demos siguiente nos va a mostrar el siguiente correo y el siguiente amigo secreto

            string[] nombresAmigos = Ocasionn.SacarNombres(amigos); //Lista de amigos secretos

            string[] listCorreos = Ocasionn.SacarCorreos(Ocasionn.jugadores); //lista de correos personales

            string[] listendulzadas = Ocasionn.SacarCorreos(Ocasionn.jugadores); //lista de correos personales

         //   amigolbl.Text= 
            MessageBox.Show((Ocasionn.SacarNombres(Ocasionn.jugadores)[0]));

        }

        private void button2_Click(object sender, EventArgs e) //Boton iniciar
        {
            
            


        }
    }






}
