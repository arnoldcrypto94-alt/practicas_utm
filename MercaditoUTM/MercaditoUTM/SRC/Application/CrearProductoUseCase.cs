using System.Collections.Generic;
using MercaditoUTM.SRC.Core.Entities;
using MercaditoUTM.SRC.Core.Usecases;

namespace MercaditoUTM.SRC.Application
{
    public class CrearProductoUseCase : ICrearProductoUseCase
    {
        public IEnumerable<Articulo> Execute(Articulo newArticle)
        {
            ArticleDataSource.AddArticle(newArticle);
            return ArticleDataSource.GetArticles();
        }
    }
}
