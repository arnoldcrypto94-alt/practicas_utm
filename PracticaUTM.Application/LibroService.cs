using System.Collections.Generic;
using System.Linq;
using PracticaUTM.Core;

namespace PracticaUTM.Application
{
    public class LibroService : ILibroService
    {
        private List<Libro> _libros;

        public LibroService()
        {
            // Sample Data
            var autor1 = new Autor { Nombre = "Isaac Asimov", Pais = "Rusia", AnoNacimiento = 1920 };
            var autor2 = new Autor { Nombre = "Frank Herbert", Pais = "Estados Unidos", AnoNacimiento = 1920 };
            var autor3 = new Autor { Nombre = "George Orwell", Pais = "Reino Unido", AnoNacimiento = 1903 };
            var autor4 = new Autor { Nombre = "Jane Austen", Pais = "Reino Unido", AnoNacimiento = 1775 };
            var autor5 = new Autor { Nombre = "Victor Hugo", Pais = "Francia", AnoNacimiento = 1802 };
            var autor6 = new Autor { Nombre = "Julio Verne", Pais = "Francia", AnoNacimiento = 1828 };
            var autor7 = new Autor { Nombre = "Suzanne Collins", Pais = "Estados Unidos", AnoNacimiento = 1962 };

            _libros = new List<Libro>
            {
                new Libro
                {
                    Nombre = "Yo, Robot", ISBN = "978-84-450-7162-4", Editorial = "Edhasa",
                    AnoPublicacion = 1950, Precio = 15.99m, Autores = new List<Autor> { autor1 }, Genero = "Ci-Fi"
                },
                new Libro
                {
                    Nombre = "Dune", ISBN = "978-84-450-7053-5", Editorial = "Acervo",
                    AnoPublicacion = 1965, Precio = 22.50m, Autores = new List<Autor> { autor2 }, Genero = "Ci-Fi"
                },
                new Libro
                {
                    Nombre = "1984", ISBN = "978-84-9989-094-1", Editorial = "Debolsillo",
                    AnoPublicacion = 1949, Precio = 10.00m, Autores = new List<Autor> { autor3 }, Genero = "Distopía"
                },
                new Libro
                {
                    Nombre = "Orgullo y Prejuicio", ISBN = "978-84-206-7452-4", Editorial = "Cátedra",
                    AnoPublicacion = 1813, Precio = 9.50m, Autores = new List<Autor> { autor4 }, Genero = "Romance"
                },
                 new Libro
                {
                    Nombre = "Los Miserables", ISBN = "978-84-233-5240-6", Editorial = "Austral",
                    AnoPublicacion = 1862, Precio = 18.75m, Autores = new List<Autor> { autor5 }, Genero = "Novela Clásica"
                },
                 new Libro
                {
                    Nombre = "Viaje al Centro de la Tierra", ISBN = "978-84-9105-021-0", Editorial = "Alianza Editorial",
                    AnoPublicacion = 1864, Precio = 12.00m, Autores = new List<Autor> { autor6 }, Genero = "Aventura"
                },
                 new Libro
                {
                    Nombre = "Algebra de Baldor", ISBN = "978-970-817-000-0", Editorial = "Grupo Editorial Patria",
                    AnoPublicacion = 1941, Precio = 25.00m, Autores = new List<Autor>(), Genero = "Educativo"
                },
                new Libro
                {
                    Nombre = "Los Juegos del Hambre", ISBN = "978-84-272-0212-0", Editorial = "RBA Molino",
                    AnoPublicacion = 2008, Precio = 14.00m, Autores = new List<Autor> { autor7 }, Genero = "Ci-Fi"
                },
            };
        }

        public IEnumerable<Libro> GetAllLibros()
        {
            return _libros;
        }

        public IEnumerable<Libro> GetLibrosByGenero(string genero)
        {
            return _libros.Where(l => l.Genero.Equals(genero, System.StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Libro> GetLibrosByNombreContains(string searchTerm)
        {
            return _libros.Where(l => l.Nombre.Contains(searchTerm, System.StringComparison.OrdinalIgnoreCase));
        }

        public IEnumerable<Libro> GetLibrosByAutorPais(string pais)
        {
            return _libros.Where(l => l.Autores.Any(a => a.Pais.Equals(pais, System.StringComparison.OrdinalIgnoreCase)));
        }

        public IEnumerable<Autor> GetAutoresByLibroGenero(string genero)
        {
            return _libros.Where(l => l.Genero.Equals(genero, System.StringComparison.OrdinalIgnoreCase))
                          .SelectMany(l => l.Autores)
                          .Distinct()
                          .OrderBy(a => a.Nombre);
        }
    }
}
