using System;
using System.Collections.Generic;
using System.Text;

namespace Domador_Jaula_Leones
{
    internal class Domador
    {
        private Jaula Docil;
        private Jaula Rebelde;


        public void Domesticar()
        {

            Console.WriteLine("\nIngrese el nombre del León");
            Console.Write("-> ");
            string nombre = Console.ReadLine();
            if (string.IsNullOrEmpty(nombre))
            {
                Console.WriteLine("Ingrese un nombre válido.");
                return;
            }
            Console.WriteLine();
            Console.WriteLine("Ingrese la edad del León");
            Console.Write("-> ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Jaula nuevajaula = new Jaula();
                Leon nuevoleon = new Leon();
                nuevoleon.Nombre = nombre;
                nuevoleon.Edad = edad;
                nuevajaula.Leon1 = nuevoleon;

                if (this.Docil == null)
                {
                    this.Docil = nuevajaula;
                    this.Rebelde = nuevajaula;
                }
                else
                {
                    nuevajaula.Siguiente = this.Docil;
                    this.Docil.Anterior = nuevajaula;
                    this.Docil = nuevajaula;
                }
            }
            else
            {
                Console.WriteLine("Ingrese una edad válida.");
                return;
            }
                
        }
        public void Mostrar()
        {
            if(this.Docil == null)
                Console.WriteLine("Primero ingrese un León");
            else
            {
                Jaula jaulactual = this.Rebelde;
                int cont = 1;

                Console.WriteLine("\nLos Leones pertenecientes al Domador del más rebelde al más dócil son: ");
                while (jaulactual != null)
                {
                    Console.WriteLine($"- Jaula {cont}: {jaulactual.Leon1.ToString()}");
                    cont++;
                    jaulactual = jaulactual.Anterior;
                }
            }
        }

        public void MostrarMayoresA()
        {
            if(this.Docil == null)
                Console.WriteLine("Primero ingrese un León");
            else
            {
                Console.Write("\nIngrese la edad desde la que quiere ver a los Leones: ");
                if (int.TryParse(Console.ReadLine(), out int edadA))
                {
                    Jaula jaulactual = this.Docil;
                    Leon leonactual;
                    bool encontrado = Buscar(edadA);

                    if (encontrado)
                    {
                        Console.WriteLine("\nLos Leones con edad mayor o igual a {0} son: ", edadA);

                        while (jaulactual != null)
                        {
                            leonactual = jaulactual.Leon1;
                            if (leonactual.Edad >= edadA)
                                Console.WriteLine("- " + leonactual.ToString());
                            jaulactual = jaulactual.Siguiente;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No se ha encontrado ningún León de esa edad.");
                    }
                }
                else
                    Console.WriteLine("Ingrese un valor numérico.");
            }
        }

        public bool Buscar(int edad)
        {
            Jaula jaulactual = this.Docil;
            Leon leonactual;
            while (jaulactual != null)
            {
                leonactual = jaulactual.Leon1;
                if (leonactual.Edad >= edad)
                    return true;
                jaulactual = jaulactual.Siguiente;
            }
            return false;
        }

        public void MezclarParesFinal(Domador Secundario_Domador, int cantleones)
        {
           if(Secundario_Domador == null || cantleones == 0)
            {
                Console.WriteLine("El domador recién creado no tiene leones para realizar la mezcla.");
            }
            else
            {
                int cont = cantleones;
                Jaula jaulactual = null;
                do
                {
                    Secundario_Domador.Domesticar();

                    if (jaulactual == null)
                    {
                        jaulactual = Secundario_Domador.Docil;
                        if (jaulactual == null)
                            Console.WriteLine("\n León inválido");
                        else
                        {
                            Console.WriteLine("Leon creado");
                            cont--;
                        }
                    }
                    else
                    {
                        jaulactual = jaulactual.Anterior;
                        cont--;
                    }
                } while (cont > 0);
                Secundario_Domador.Mostrar();

                Console.WriteLine("Presione un tecla para mezclar la lista con el Domador Principal,"
                    + " según las edades pares");
                Console.ReadKey();

                jaulactual = Secundario_Domador.Docil;

                while(jaulactual != null)
                {
                    if(jaulactual.Leon1.Edad % 2 == 0)
                    {
                        Jaula jaultemp = new Jaula();
                        jaultemp.Leon1 = jaulactual.Leon1;

                        Rebelde.Siguiente = jaultemp;
                        jaultemp.Anterior = Rebelde;
                        Rebelde = jaultemp;    
                    }
                    jaulactual = jaulactual.Siguiente;
                }
            }
        }
    }
}
