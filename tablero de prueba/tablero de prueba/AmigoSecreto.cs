﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab3;
using Microsoft.SqlServer.Server;

namespace tablero_de_prueba
{
    public class AmigoSecreto
    {
        int numJugadores;
        public Jugador[] jugadores;


        public AmigoSecreto(int numJugadores)
        {
            this.jugadores = new Jugador[numJugadores];
            this.numJugadores = numJugadores;


          
        }

        public void llenarDatos(int num, string nombre, string correo, string endulzada, string regalo)
        {
            //Llenamos el vector de tal manera que cada jugador seria una posicion
            Jugador aux = new Jugador(nombre, correo, endulzada, regalo);
           
            //La funcion:
              //Se encargara de crear un objeto en una posicion dada del vector del objeto

            this.jugadores[num] = aux;       //La unica que nos interesa en cuestion de codigo de aca   
         
        }

        public string[] SacarNombres(Jugador[] ejemplo)
        {
            string[] nombres = new string[numJugadores];

            for (int i = 0; i < numJugadores; i++)
            {
           
             //   MessageBox.Show(i.ToString());        //Extraemos los nombre usando los metodos de la clase Jugador
                nombres[i] = ejemplo[i].getNombre();
            }
            return nombres;                 //Me retorna un vector con los nombres en el orden en que estan ingresados
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


        public string[] SacarEndulzadas(Jugador[] ejemplo)
        {
            String[] endulzadas = new string[numJugadores];

            for (int i = 0; i < numJugadores; i++)
            {                                                   //Extraemos las endulzadas usando los metodos de la clase Jugador
                endulzadas[i] = ejemplo[i].getEndulzadaIdeal();
            }
            return endulzadas;     //Me retorna un vector con los correos en el orden en que estan ingresados
        }

        public string[] SacarRegalos(Jugador[] ejemplo)
        {
            String[] regalos = new string[numJugadores];

            for (int i = 0; i < numJugadores; i++)
            {                                                   //Extraemos las endulzadas usando los metodos de la clase Jugador
                regalos[i] = ejemplo[i].getRegaloIdeal();
            }
            return regalos;     //Me retorna un vector con los correos en el orden en que estan ingresados
        }


        public Jugador[] DesorganizarVector(Jugador[] vectorOriginal)
        {
            Random random = new Random();
            Jugador[] clon = (Jugador[])vectorOriginal.Clone(); // Clonamos el vector original para no modificarlo directamente

            for (int i = clon.Length - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1); // Generar un índice aleatorio
                                               // Intercambiar los elementos en las posiciones i y j
                Jugador temp = clon[i];
                clon[i] = clon[j];
                clon[j] = temp;
            }

            return clon;
        }



        public string NombreComboBox(string[] nombre1)      // ?? ni idea eso lo hizo Santiago
        {

            for (int j = 0; j < numJugadores; j++)
            {
                return nombre1[j];

            }
            return ("error ni idea");
        }


        public Jugador[] DesorganizadoAcertado(Jugador[] jugadoress) //Nos retornara el vector idealmente desorganizado
        {

            Jugador[] auxiliar = new Jugador[numJugadores]; //En este punto auxiliar es el mismo vector jugadores pero es una clonacion
            for (int ii = 0; ii < numJugadores; ii++)
            {
                auxiliar[ii] = jugadoress[ii];       //clonacion de vectores
            }
            bool ban = true;
            Jugador[] auxiliar2 = new Jugador[numJugadores];


            while (ban)
            {
                bool ban2 = true;
                int i = 0;

                auxiliar2 = DesorganizarVector(auxiliar);

                while (i < jugadores.Length  && ban2)          // Aca comprobamos que ninguna posicion del vector desorganizado sea igual a la del vector original
                {                                          //Osea nadie sea su propio amigo secreto

                    if (auxiliar2[i] == jugadoress[i])
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
            return auxiliar2;

        } //Fin funcion Desorganizacion ideal     
    }
}
