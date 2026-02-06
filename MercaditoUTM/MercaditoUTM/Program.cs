using System;
using System.Collections.Generic;
using MercaditoUTM.SRC.Application;
using MercaditoUTM.SRC.Core.Usecases;
using MercaditoUTM.SRC.Core.Entities; // Needed for Articulo

Console.WriteLine("Creando y mostrando 25 artículos nuevos:");

ICrearProductoUseCase crearProducto = new CrearProductoUseCase();
Random random = new Random();

for (int i = 0; i < 25; i++)
{
    Articulo newArticulo = new Articulo
    {
        Nombre = $"Nuevo Producto {i + 1} - {Guid.NewGuid().ToString().Substring(0, 4)}",
        Precio = Math.Round((decimal)(random.NextDouble() * 1000) + 1, 2),
        SKU = $"NEW-SKU-{random.Next(1000, 9999)}",
        Stock = random.Next(1, 100),
        Marca = $"Nueva Marca {random.Next(1, 6)}"
    };

    // Execute the use case to add the new article.
    // The returned list contains all articles, but we only print the one we just created.
    crearProducto.Execute(newArticulo); 
    
    Console.WriteLine($"Creado - Nombre: {newArticulo.Nombre}, Precio: {newArticulo.Precio:C}, SKU: {newArticulo.SKU}, Stock: {newArticulo.Stock}, Marca: {newArticulo.Marca}");
}

Console.WriteLine("\nCreación de 25 artículos nuevos completada.");

// Optionally, you could also call ConsultarProductosUseCase here to see the full list (initial 25 + new 25)
// IConsultarProductosUseCase consultarProductos = new ConsultarProductosUseCase();
// Console.WriteLine("\nLista completa de artículos después de la creación:");
// foreach (var articulo in consultarProductos.Execute())
// {
//     Console.WriteLine($"Nombre: {articulo.Nombre}, Precio: {articulo.Precio:C}, SKU: {articulo.SKU}, Stock: {articulo.Stock}, Marca: {articulo.Marca}");
// }
