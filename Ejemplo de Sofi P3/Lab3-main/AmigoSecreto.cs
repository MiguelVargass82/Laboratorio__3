using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
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

        public Jugador[] llenarDatos()
        {
            int cont = 0;

            while (cont < numJugadores)         //Llenamos el vector de tal manera que cada jugador seria una posicion
            {
                Console.WriteLine("Ingrese el nombre del jugador "+ (cont + 1));
                string nombre= Console.ReadLine();
                Console.WriteLine("Ingrese el correo del jugador "+ (cont + 1));
                string correo = Console.ReadLine();
                Console.WriteLine("Ingrese la endulzada ideal del jugador "+( cont + 1));
                string endulzada= Console.ReadLine();
                Console.WriteLine("Ingrese el regalo deseado nombre del jugador " + (cont + 1));
                string regalo = Console.ReadLine();

                jugadores[cont] = new Jugador(nombre, correo, endulzada, regalo);
                cont = cont + 1;
            }

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
            for ( int ii = 0;  ii < numJugadores; ii++)
            {
                auxiliar[ii] = jugadores[ii];
            }                                                              
            bool ban = true;
            Jugador[] auxiliar2 = new Jugador[numJugadores];


            while (ban)
            {
                bool ban2 = true;
                int i = 0;

                auxiliar2 = DesorganizarVector(auxiliar);

                while (i<jugadores.Length-1 && ban2)          // Aca comprobamos que ninguna posicion del vector desorganizado sea igual a la del vector original
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

            string[] nombre1 = SacarNombres(jugadores);
            string[] nombre2 = SacarNombres(auxiliar2);
            Console.WriteLine(nombre1[1]);
                Console.WriteLine(nombre2[1]);      



           



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



    }



}
