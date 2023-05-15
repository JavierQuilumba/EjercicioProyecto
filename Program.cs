using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Elije una opción\n" +
                "\n1.- Calcular Serie Fibonacci" +
                "\n2.- Calcular Triangulo de Pascal" +
                "\n3.- Salir\n");

            String s1 = null;
            s1 = Console.ReadLine();
            switch (s1)
            {
                case "1":

                    int cantidad;
                    int a, b, c;
                    Console.WriteLine("Ingrese el número: ");
                    cantidad = int.Parse(Console.ReadLine());
                    a = 0; b = 1;
                    Console.Write(a + " " + b + " ");
                    for (int k = 3; k <= cantidad; k++)
                    {
                        c = a + b;
                        Console.Write(c + " ");
                        a = b;
                        b = c;

                    }

                    break;

                case "2":
                    int i = 0;
                    int Count = 0;
                    int Cantidad = 0;
                    int Columna = 0;
                    int Fila = 0;

                    Console.Clear();
                    Console.Write("Ingrese el número de filas que desee: ");
                    Cantidad = int.Parse(Console.ReadLine());

                    int[,] MAT = new int[Cantidad + 1, Cantidad + 1];


                    for (i = 1; i <= Cantidad; i++)
                    {
                        for (Count = 1; Count <= Cantidad; Count++)
                        {
                            if ((Count == 1) | (i == Count))
                            {
                                MAT[i, Count] = 1;
                            }
                            else
                            {
                                MAT[i, Count] = MAT[i - 1, Count] + MAT[i - 1, Count - 1];
                            }
                        }
                    }

                    Fila = 2;
                    for (i = 1; i <= Cantidad; i++)
                    {
                        Columna = 40 - (i * 2);
                        for (Count = 1; Count <= Cantidad; Count++)
                        {
                            if (MAT[i, Count] != 0)
                            {
                                Console.SetCursorPosition(Columna, Fila);
                                Console.Write(MAT[i, Count]);
                                Columna = Columna + 4;
                            }
                        }
                        Fila = Fila + 1;
                        Console.WriteLine();
                    }

                    break;

                case "3":
                    Console.WriteLine("OPCION SALIR");
                    break;

                default:
                    Console.WriteLine("No se selecciono un opción");
                    break;

            }
            Console.ReadKey();
        }
    }
}
