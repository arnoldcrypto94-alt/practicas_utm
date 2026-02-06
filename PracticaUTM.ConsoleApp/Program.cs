using System;
using PracticaUTM.Application;
using PracticaUTM.Core;
using System.Linq;

namespace PracticaUTM.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ILibroService libroService = new LibroService();

            Console.WriteLine("--- Consultar todos los libros ---");
            var allLibros = libroService.GetAllLibros();
            PrintLibros(allLibros);

            Console.WriteLine("\n--- Consultar libros de género Ci-Fi ---");
            var ciFiLibros = libroService.GetLibrosByGenero("Ci-Fi");
            PrintLibros(ciFiLibros);

            Console.WriteLine("\n--- Consultar libros que contienen 'Algebra' en su nombre ---");
            var algebraLibros = libroService.GetLibrosByNombreContains("Algebra");
            PrintLibros(algebraLibros);

            Console.WriteLine("\n--- Consultar libros escritos por autores franceses ---");
            var francesLibros = libroService.GetLibrosByAutorPais("Francia");
            PrintLibros(francesLibros);

            Console.WriteLine("\n--- Consultar autores que han escrito libros de romance ---");
            var autoresRomance = libroService.GetAutoresByLibroGenero("Romance");
            PrintAutores(autoresRomance);

            Console.WriteLine("\nPresione cualquier tecla para salir.");
            Console.ReadKey();
        }

        static void PrintLibros(IEnumerable<Libro> libros)
        {
            if (!libros.Any())
            {
                Console.WriteLine("  No se encontraron libros.");
                return;
            }
            foreach (var libro in libros)
            {
                Console.WriteLine($"  Nombre: {libro.Nombre}, Género: {libro.Genero}, Editorial: {libro.Editorial}, Año: {libro.AnoPublicacion}, Precio: {libro.Precio:C}");
                if (libro.Autores.Any())
                {
                    Console.WriteLine("    Autores: " + string.Join(", ", libro.Autores.Select(a => $"{a.Nombre} ({a.Pais})")));
                }
            }
        }

        static void PrintAutores(IEnumerable<Autor> autores)
        {
            if (!autores.Any())
            {
                Console.WriteLine("  No se encontraron autores.");
                return;
            }
            foreach (var autor in autores)
            {
                Console.WriteLine($"  Nombre: {autor.Nombre}, País: {autor.Pais}, Año Nacimiento: {autor.AnoNacimiento}");
            }
        }
    }
}