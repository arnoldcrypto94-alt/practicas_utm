using System.Collections.Generic;
using MercaditoUTM.SRC.Core.Entities;
using MercaditoUTM.SRC.Core.Usecases;

namespace MercaditoUTM.SRC.Application
{
    public class ConsultarProductosUseCase : IConsultarProductosUseCase
    {
        public IEnumerable<Articulo> Execute()
        {
            return ArticleDataSource.GetArticles();
        }
    }
}
