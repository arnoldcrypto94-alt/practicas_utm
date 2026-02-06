using System;
using System.Collections.Generic;
using MercaditoUTM.SRC.Core.Entities;

namespace MercaditoUTM.SRC.Application
{
    public static class ArticleDataSource
    {
        private static List<Articulo> _articles;
        private static readonly Random _random = new Random();

        static ArticleDataSource()
        {
            _articles = new List<Articulo>();
            GenerateInitialArticles(25);
        }

        private static void GenerateInitialArticles(int count)
        {
            for (int i = 0; i < count; i++)
            {
                _articles.Add(new Articulo
                {
                    Nombre = $"Producto {i + 1} - {Guid.NewGuid().ToString().Substring(0, 4)}",
                    Precio = Math.Round((decimal)(_random.NextDouble() * 1000) + 1, 2), // Price between 1 and 1000
                    SKU = $"SKU-{_random.Next(1000, 9999)}",
                    Stock = _random.Next(0, 200), // Stock between 0 and 199
                    Marca = $"Marca {_random.Next(1, 5)}" // 4 different brands
                });
            }
        }

        public static IEnumerable<Articulo> GetArticles()
        {
            return _articles;
        }

        public static void AddArticle(Articulo article)
        {
            _articles.Add(article);
        }
    }
}
