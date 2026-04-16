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
