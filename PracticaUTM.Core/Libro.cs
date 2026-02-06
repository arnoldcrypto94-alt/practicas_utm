using System.Collections.Generic;

namespace PracticaUTM.Core
{
    public class Libro
    {
        public required string Nombre { get; set; }
        public required string ISBN { get; set; }
        public required string Editorial { get; set; }
        public int AnoPublicacion { get; set; }
        public decimal Precio { get; set; }
        public List<Autor> Autores { get; set; } = new List<Autor>();
        public required string Genero { get; set; }
    }
}
