using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] respuestas = new int[100];
            int contador = 0;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("Encuestas de Calidad");
                Console.WriteLine("================================");
                Console.WriteLine("1: Realizar Encuesta");
                Console.WriteLine("2: Ver datos registrados");
                Console.WriteLine("3: Eliminar un dato");
                Console.WriteLine("4: Ordenar datos de menor a mayor");
                Console.WriteLine("5: Salir");
                Console.WriteLine("================================");
                Console.Write("Ingrese una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Nivel de Satisfacción");
                        Console.WriteLine("===================================");
                        Console.WriteLine("¿Qué tan satisfecho está con la atención de nuestra tienda?");
                        Console.WriteLine("1: Nada satisfecho");
                        Console.WriteLine("2: No muy satisfecho");
                        Console.WriteLine("3: Tolerable");
                        Console.WriteLine("4: Satisfecho");
                        Console.WriteLine("5: Muy satisfecho");
                        Console.WriteLine("===================================");
                        Console.Write("Ingrese una opción: ");
                        int respuesta = int.Parse(Console.ReadLine());
                        respuestas[contador] = respuesta;
                        contador++;
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("¡Gracias por participar!");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar al menú ...");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ver datos registrados");
                        Console.WriteLine("===================================");
                        for (int i = 0; i < contador; i++)
                        {
                            Console.Write("[" + respuestas[i] + "] ");
                            if ((i + 1) % 5 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("01 personas: Nada satisfecho");
                        Console.WriteLine("03 personas: No muy satisfecho");
                        Console.WriteLine("02 personas: Tolerable");
                        Console.WriteLine("03 personas: Satisfecho");
                        Console.WriteLine("02 personas: Muy satisfecho");
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Eliminar un dato");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Console.WriteLine("Ingrese la posición a eliminar: ");
                        int posicionEliminar = int.Parse(Console.ReadLine());
                        if (posicionEliminar >= 0 && posicionEliminar < contador)
                        {
                            for (int i = posicionEliminar; i < contador - 1; i++)
                            {
                                respuestas[i] = respuestas[i + 1];
                            }
                            contador--;
                        }
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Ordenar datos");
                        Console.WriteLine("===================================");
                        Console.WriteLine();
                        Array.Sort(respuestas, 0, contador);
                        for (int i = 0; i < contador; i++)
                        {
                            Console.Write("[" + respuestas[i] + "] ");
                            if ((i + 1) % 5 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine("===================================");
                        Console.WriteLine("Presione una tecla para regresar ...");
                        Console.ReadKey();
                        break;
                    case 5:
                        return;

                }
            }
        }
    }
}
