/*
 * Crea una lista doble Usando como clases:
 * Domador:
 *  Atributos:
 *      Docil:  Apunta a la primera Jaula
 *      Rebelde:  Apunta al ultima Jaula
 *  Metodos:
 *      Mostrar: muestra las jaulas a partir del Rebelde al Docil
 *      Domesticar: Pide nombre y edad y agrega 1 jaula por el lado Docil
 *      MayoresA: Pide de parametro una edad y muestra los Leones 
 *          a partir de esa edad
 *      MezclaParesInicio: Pide de parametro un segundo domador y 
 *          agrega al final del Domador actual solo los leones con edad par 
 *
 * Jaula
 *  Atributos:
 *      Leon:  Apunta al primer Leon
 *      Sig:  Apunta a la siguiente Jaula
 *      Ant:  Apunta a la anterior Jaula
 *  Metodos:
 *      
 *      
 * Leon
 *  Atributos:
 *      Nombre:  Apunta al primer Leon
 *      Edad:  Apunta al ultimo Leon
 *  Metodos:
 *      ToString: muestra El nombre y Edad del Leon
 *      
 *      
 * Problema: Cree un menu donde se agreguen Jaulas (con sus leones) al 
 * cuidado de un Domador. El menu de opciones sera: 
 * 1-Agrega Domestica Leon: usa metodo Domesticar
 * 2-Muestra Leones: usa metodo Mostrar
 * 3-Muestra Leones mayores a: usa metodo MayoresA
 * 4-Mezcla: pide cuantas jaulas se agregaran a un nuevo domador y 
 *  pedira los datos de los respectivos leones y usar el metodo 
 *  MezclaParesInicio
 * 9-Salir
 */
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;


namespace Domador_Jaula_Leones
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Domador Principal_Domador = new Domador();
            Console.WriteLine("\n    ============================================"
                              + "\n=== Bienvenido al programa Domador_Jaula_Leones ==="
                              +  "\n    ============================================");
            Console.ReadKey();

            int Eleccion;
            do{
                Console.Clear();
                Eleccion = Menu();

                switch (Eleccion)
                {
                    case 1:
                            Principal_Domador.Domesticar();
                        break;
                    case 2:
                            Principal_Domador.Mostrar();
                        break;
                    case 3:
                            Principal_Domador.MostrarMayoresA();
                        break;
                    case 4:
                        Domador Secundario_Domador = new Domador();
                        Console.WriteLine("\nDomador secundario creado.");
                        Console.Write("Indique cuántos Leones creará: " + "\n-> ");
                        if (int.TryParse(Console.ReadLine(), out int numero))
                            Principal_Domador.MezclarParesFinal(Secundario_Domador, numero);
                        else
                            Console.WriteLine("Número de Leones inválido.");
                        break;
                    case 5:
                        Console.WriteLine("\nSaliendo del programa....");
                        break;
                    default:
                        Console.WriteLine("Ingrese una elección válida.");
                        break;
                }
                Console.ReadKey();
            } while (Eleccion != 5) ;

        }
        
        public static int Menu()
        {
            Console.WriteLine("Indique la acción que desea realizar: "
                            + "\n1- Agrega Domestica León."
                            + "\n2- Muestra Leones."
                            + "\n3- Muestra Leones \"Mayores a\"."
                            + "\n4- Mezcla." 
                            + "\n5- Salir.");
            Console.Write("-> ");
            if(int.TryParse(Console.ReadLine(), out int Eleccion))
            {
                return Eleccion;
            }
            else
            {
                Console.WriteLine("Ingrese un dígito numérico.");
                return 0;
            }
        }
    }
}
