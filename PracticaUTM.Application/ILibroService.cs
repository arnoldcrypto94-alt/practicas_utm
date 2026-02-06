using System.Collections.Generic;
using PracticaUTM.Core;

namespace PracticaUTM.Application
{
    public interface ILibroService
    {
        IEnumerable<Libro> GetAllLibros();
        IEnumerable<Libro> GetLibrosByGenero(string genero);
        IEnumerable<Libro> GetLibrosByNombreContains(string searchTerm);
        IEnumerable<Libro> GetLibrosByAutorPais(string pais);
        IEnumerable<Autor> GetAutoresByLibroGenero(string genero);
    }
}
