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
        public object jugadores;        //Definimos las variables necesarias que necesitamos de el otro form
        public AmigoSecreto Ocasionn;
        public Jugador[] amigos;

       public  string[] nombresAmigos;

        public string[] listCorreos;

        public string[] listendulzadas;

        public string[] listregalo;




        public correo()
        {
        
            InitializeComponent();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {           
        } //NADA

        int cont = 0;
        private void button1_Click(object sender, EventArgs e) //BOTON SIGUIENTE  de correos
        {
            //Se encargara de que cada vez que le demos siguiente nos va a mostrar el siguiente correo y el siguiente amigo secreto
            if (cont < nombresAmigos.Length)
            {

                amigolbl.Text = nombresAmigos[cont];
                amigolbl2.Text = nombresAmigos[cont];     //Necesitamos que esto aparezca de primeras
                amigolbl1.Text = nombresAmigos[cont];

                correolbl.Text = listCorreos[cont];
                endulzadalbl.Text = listendulzadas[cont];
                regalolbl.Text = listregalo[cont];
                cont++;
            }
            else
            {
                MessageBox.Show("Por favor presione SALIR");
            }


         
            MessageBox.Show((Ocasionn.SacarNombres(Ocasionn.jugadores)[0]));

        }

        private void salirbtn_Click(object sender, EventArgs e)
        {
            this.Close();   //Un boton que simplemente cierra
        }
    }






}
