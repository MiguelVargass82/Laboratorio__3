using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Lab3;
using Microsoft.SqlServer.Server;

namespace tablero_de_prueba
{
    internal class AmigoSecreto
    {
        int numJugadores;
        Jugador[] jugadores;


        public AmigoSecreto(int numJugadores)
        {
            this.jugadores = new Jugador[numJugadores];
            this.numJugadores = numJugadores;
        }

        public Jugador[] llenarDatos(int num, Jugador[] jugadores, string nombre, string correo, string endulzada, string regalo)
        {          
                  //Llenamos el vector de tal manera que cada jugador seria una posicion           
            jugadores[num] = new Jugador(nombre, correo, endulzada, regalo);
             
            return jugadores;
        }

        public string[] SacarNombres(Jugador[] ejemplo)
        {
            string[] nombres = new string[numJugadores];

            for (int i = 0; i < numJugadores; i++)
            {                                                   //Extraemos los nombre usando los metodos de la clase Jugador
                nombres[i] = ejemplo[i].getNombre();
            }
            return nombres;                 //Me retorna un vector con los nombres en el orden en que estan ingresados
        }

        public String[] InicilizarVector(Jugador[] jugadoress)
        {
            int tamaño = jugadores.Length;
            int cont = 0;
            while (cont < tamaño)
            {
                jugadores[cont] = new Jugador("0", "0","0","0") ;
                cont = cont + 1;
            }
            return jugadoress;
        }

        public string[] SacarCorreos(Jugador[] ejemplo)
        {
            String[] correos = new string[numJugadores];

            for (int i = 0; i < numJugadores; i++)
            {                                                   //Extraemos los correos usando los metodos de la clase Jugador
                correos[i] = ejemplo[i].getCorreo();
            }
            return correos;     //Me retorna un vector con los correos en el orden en que estan ingresados
        }


        public void Todo(Jugador[] jugadores)
        {

            Jugador[] auxiliar = new Jugador[numJugadores]; //En este punto auxiliar es el mismo vector jugadores pero es una clonacion
            for (int ii = 0; ii < numJugadores; ii++)
            {
                auxiliar[ii] = jugadores[ii];
            }
            bool ban = true;
            Jugador[] auxiliar2 = new Jugador[numJugadores];


            while (ban)
            {
                bool ban2 = true;
                int i = 10;

                auxiliar2 = DesorganizarVector(auxiliar);

                while (i < jugadores.Length - 1 && ban2)          // Aca comprobamos que ninguna posicion del vector desorganizado sea igual a la del vector original
                {                                          //Osea nadie sea su propio amigo secreto

                    if (auxiliar2[i] == jugadores[i])
                    {                                    //En el momento en que alguna posicion coincide el ciclo pequeño se cierra y quedan las condiciones ...
                        ban2 = false;
                        //...para que el ciclo grande se vuelva a ejecutar
                    }
                    i++;

                }

                if (ban2)
                {
                    ban = false;

                }


            }


        } //Fin funcion


        public static Jugador[] DesorganizarVector(Jugador[] vector)
        {
            Random random = new Random();

            for (int i = vector.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1); // Generar un índice aleatorio

                // Intercambiar los elementos en las posiciones i y j
                Jugador temp = vector[i];
                vector[i] = vector[j];
                vector[j] = temp;
            }
            return vector;
        }
        public string NombreComboBox(string[] nombre1)
        {

            for (int j = 0; j < numJugadores; j++)
            {
                return nombre1[j];

            }
            return ("error ni idea");
        }

    }
}
