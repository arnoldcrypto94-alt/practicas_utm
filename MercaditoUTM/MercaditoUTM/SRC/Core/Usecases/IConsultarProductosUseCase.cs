using System.Collections.Generic;
using MercaditoUTM.SRC.Core.Entities;

namespace MercaditoUTM.SRC.Core.Usecases
{
    public interface IConsultarProductosUseCase
    {
        IEnumerable<Articulo> Execute();
    }
}
