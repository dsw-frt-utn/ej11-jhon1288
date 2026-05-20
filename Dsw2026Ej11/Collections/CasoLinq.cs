using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    private List<Libro> libros;

    public CasoLinq()
    {
        libros = Libro.CrearLista();
    }

    // 1. Primer libro
    public Libro GetPrimero()
    {
        return libros.FirstOrDefault();
    }

    // 2. Último libro
    public Libro GetUltimo()
    {
        return libros.LastOrDefault();
    }

    // 3. Suma de precios
    public decimal GetTotalPrecios()
    {
        return libros.Sum(l => l.Precio);
    }

    // 4. Promedio de precios
    public decimal GetPromedioPrecios()
    {
        return libros.Average(l => l.Precio);
    }

    // 5. Libros con Id > 15
    public List<Libro> GetListById()
    {
        return libros.Where(l => l.Id > 15).ToList();
    }

    // 6. Lista formateada
    public List<string> GetLibros()
    {
        return libros
            .Select(l => $"{l.Titulo} - {l.Precio:C}")
            .ToList();
    }

    // 7. Mayor precio
    public Libro GetMayorPrecio()
    {
        return libros.OrderByDescending(l => l.Precio).FirstOrDefault();
    }

    // 8. Menor precio
    public Libro GetMenorPrecio()
    {
        return libros.OrderBy(l => l.Precio).FirstOrDefault();
    }

    // 9. Mayores al promedio
    public List<Libro> GetMayorPromedio()
    {
        var promedio = libros.Average(l => l.Precio);
        return libros.Where(l => l.Precio > promedio).ToList();
    }

    // 10. Ordenados por título descendente
    public List<Libro> GetOrdenadosDesc()
    {
        return libros.OrderByDescending(l => l.Titulo).ToList();
    }
}
