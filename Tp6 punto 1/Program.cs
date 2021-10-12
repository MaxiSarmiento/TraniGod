using System;
//Elaborar un programa que permita registrar las temperaturas para un periodo dado (quincenal o mensual) y al finalizar informe la temperatura promedio, máxima y mínima. Se requiere utilizar un arreglo (vector) para almacenar las temperaturas.


namespace Tp6_punto_1
{
    class Program
    {
        static void Main(string[] args)
        {
        int n = 0;
            int dia = 1;
        int maxima;
        int minima;
        string valor = "";
        float minimo = 15.0f;
        float maximo = 30.0f;
        float suma = 0.0f;
        float promedio = 0.0f;
           
        
            Console.WriteLine("Bienvenido al sistema, elija que tipo de registro quiere realizar:\n" +
            "\n1.- Quincenal" +
                "\n2.- Mensual"  
                );

           string s1 = null;

            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("usted eligió quincenal");
                    float[] quincenal = new float[15];
                    for (n = 0; n < 15; n++)
                    {
                        Console.WriteLine("ingrese la temperatura del dia: {0}\n",dia);
                        dia = dia + 1;
                        valor = Console.ReadLine();
                        quincenal[n] = Convert.ToSingle(valor);

                    }
                    for (n = 0; n < 15; n++)
                    {
                       suma = suma + quincenal[n];
                    }
                     promedio = suma / 15;
                    for (n = 0; n < 15; n++)
                    {
                        if (quincenal[n] > maximo)
                        {
                            maximo = quincenal[n];
                        }
                    }
                    for (n = 0; n < 15; n++)
                    {
                        if (quincenal[n] < minimo)
                        {
                            minimo = quincenal[n];
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("El promedio de temperatura es {0}", Math.Round(promedio, 2));
                    Console.WriteLine("La temperatura máxima es {0}", maximo);
                    Console.WriteLine("La temperatura mínima es {0}", minimo);

                    Console.WriteLine("Presione una tecla para finalizar...");
                    Console.ReadKey();
            
            break;
                case "2":
                    Console.WriteLine("Usted elgió Mensual");
                    float[] mensual = new float[31];
                    for (n = 0; n < 31; n++)
                    {
                        Console.WriteLine("ingrese la temperatura del dia: {0}\n",dia);
                        dia = dia + 1;
                        valor = Console.ReadLine();
                        mensual[n] = Convert.ToSingle(valor);
                    }
                    for (n = 0; n < 31; n++)
                    {
                        suma = suma + mensual[n];
                    }
                    promedio = suma / 31;
                    for (n = 0; n < 31; n++)
                    {
                        if (mensual[n] > maximo)
                        {
                            maximo = mensual[n];
                        }
                    }
                    for (n = 0; n < 31; n++)
                    {
                        if (mensual[n] < minimo)
                        {
                            minimo = mensual[n];
                        }
                    }
                    Console.Clear();
                    Console.WriteLine("El promedio de temperatura es: {0}", Math.Round(promedio, 2));
                    Console.WriteLine("La temperatura máxima es {0}", maximo);
                    Console.WriteLine("La temperatura mínima es {0}", minimo);

                    Console.WriteLine("Presione una tecla para finalizar...");
                    Console.ReadKey();

                    break;
                default:
                    Console.WriteLine("opcion no válida, seleccione una opcion");
                    break;
            }
            Console.ReadLine();
        }
    }
}
