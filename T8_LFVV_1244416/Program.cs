using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T8_LFVV_1244416
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string op1, op2,n1, seguir="";
            int suma, n=0,contador, multiplicacion;
            do
            {
                Console.WriteLine("LABORATORIO 8");
                Console.Write("\n\tMenú\na) Sumatoria\nb) Mostrar tablas de multiplicar\nc) Número Perfecto\nIngrese opción: ");
                op1 = Console.ReadLine();
                op2 = op1.ToLower();
                switch (op2)
                {
                    case "a":
                        Console.Write("\nIngrese un número: ");
                        n = int.Parse(Console.ReadLine());
                        suma = 0;
                        contador = 0;
                        do
                        {
                            contador = contador + 1;
                            suma = suma + contador;
                        } while (contador < n);
                        Console.WriteLine("La suma de los números desde 1 hasta " + n + " es igual a: " + suma);
                        break;

                    case "b":
                        Console.Write("\nIngrese un número: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        multiplicacion = 0;
                        for (int i = 0; i <= 10; i++)
                        {
                            multiplicacion = i * n;
                            Console.WriteLine(n + " x " + i + " = " + multiplicacion);
                        }
                        break;

                    case "c":
                        Console.Write("\nIngrese un número: ");
                        n1 = Console.ReadLine();
                        bool oop = int.TryParse(n1, out n);
                        suma = 0;
                        if (oop == true)
                        {
                            n = Convert.ToInt32(n1);
                            if (n > 0)
                            {
                                for (int i = 1; i < n; i++)
                                {
                                    if (n % i == 0)
                                    {
                                        suma = suma + i;
                                    }
                                }
                                if (suma == n)
                                {
                                    Console.WriteLine(n + " es un número perfecto");
                                }
                                if (suma != n)
                                {
                                    Console.WriteLine(n + " no es un número perfecto");
                                }
                                break;
                            }
                            else if (n <= 0)
                            {
                                Console.WriteLine("\nError: Usted ha ingresado un valor menor o igual a 0");
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nError: Usted ha ingresado una letra");
                            break;
                        }

                        break;
                    default:
                        Console.WriteLine("\nOpción no válida");
                        break;

                }
                Console.Write("\nDesea repetir el menú (s/n): ");
                seguir = Console.ReadLine();
                Console.Clear();
            } while (seguir == "s"); 
        }
    }
}
