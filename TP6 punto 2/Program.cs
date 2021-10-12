using System.IO;
using System;
// Desarrollar un programa que
// permita registrar información de película
// s: nombre, director, año estreno y genero.
// La información se debe almacenar en un archivo de texto.
// Mediante un menú de usuario se debe permitir grabar nuevas películas y
// cceder al listado completo de películas grabadas.


namespace TP6_punto_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al sistema de peliculITES , señale la accion a realizar :\n" +
          "\n1.- Guardar Película" +
              "\n2.- Ver peliculas almacenadas"
              );

            string s1 = null;

            s1 = Console.ReadLine();

            switch (s1)
            {
                case "1":
                    Console.WriteLine("Indique los datos a almacenar\n");
                    int numero = 2;
                    numero = numero + 1;
                    string año = "";
                    string nombre = "";
                    string director = "";
                    string genero = "";
                    string ruta = @"D:\peliculasTP.txt";

                    System.Console.WriteLine("Ingrese el  nombre de la pelicula");
                   nombre = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el director de la pelicula");
                    director = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el año de la pelicula");
                    año = Console.ReadLine();
                    System.Console.WriteLine("Ingrese el/los generos (seguidos por coma) de la pelicula");
                    genero = Console.ReadLine();
                    StreamWriter writer = File.AppendText(ruta);

                    // agragamos contenido
                    writer.WriteLine("\n#{0}", numero);
                    writer.WriteLine("Nombre:"); writer.WriteLine(nombre);
                    writer.WriteLine("Director:"); writer.WriteLine(director);
                    writer.WriteLine("Año:"); writer.WriteLine(año);
                    writer.WriteLine("Género"); writer.WriteLine(genero);
                    writer.Close();

                    


                    break;
                case "2":
                    Console.WriteLine("Las peliculas listadas son:\n"); {


                        string rutaCompleta = @"D:\peliculasTP.txt";

                        string line = "";
                        using (StreamReader file = new StreamReader(rutaCompleta))
                        {
                            while ((line = file.ReadLine()) != null)                //Leer linea por linea
                            {
                                Console.WriteLine(line);
                            }

                        }
                        break;
                                           


                    }
            }
        }
    }
}