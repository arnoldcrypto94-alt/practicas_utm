using System.Collections.Generic;
using MercaditoUTM.SRC.Core.Entities;

namespace MercaditoUTM.SRC.Core.Usecases
{
    public interface ICrearProductoUseCase
    {
        IEnumerable<Articulo> Execute(Articulo newArticle);
    }
}
