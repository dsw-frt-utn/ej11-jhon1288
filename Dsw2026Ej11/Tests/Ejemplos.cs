using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        var caso = new CasoList();

        var a1 = new Alumno(1, "Juan", 8.5);
        var a2 = new Alumno(2, "Ana", 9.0);
        var a3 = new Alumno(3, "Luis", 7.8);

        caso.AgregarAlumno(a1);
        caso.AgregarAlumno(a2);
        caso.AgregarAlumno(a3);

        Console.WriteLine("LISTA:");
        foreach (var a in caso.ObtenerAlumnos())
            Console.WriteLine(a.Nombre);

        var encontrado = caso.BuscarPorNombre("Ana");
        Console.WriteLine(encontrado != null ? encontrado.Nombre : "No existe");

        var noExiste = caso.BuscarPorNombre("Pedro");
        Console.WriteLine(noExiste != null ? noExiste.Nombre : "No existe");

        caso.EliminarAlumno(a1);

        Console.WriteLine("Después de eliminar uno:");
        foreach (var a in caso.ObtenerAlumnos())
            Console.WriteLine(a.Nombre);

        caso.EliminarPorPosicion(0);

        Console.WriteLine("Después de eliminar el primero:");
        foreach (var a in caso.ObtenerAlumnos())
            Console.WriteLine(a.Nombre);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        var caso = new CasoDictionary();

        // Crear alumnos (constructor correcto)
        var a1 = new Alumno(1, "Juan", 8.5);
        var a2 = new Alumno(2, "Ana", 9.0);
        var a3 = new Alumno(3, "Luis", 7.8);

        // Asignar legajo (igual que la clave)
        a1.Legajo = 1;
        a2.Legajo = 2;
        a3.Legajo = 3;

        // Agregar
        caso.AgregarAlumno(a1.Legajo, a1);
        caso.AgregarAlumno(a2.Legajo, a2);
        caso.AgregarAlumno(a3.Legajo, a3);

        //  Listar
        Console.WriteLine("DICCIONARIO:");
        foreach (var item in caso.ObtenerDiccionario())
        {
            Console.WriteLine(item.Value);
        }

        // Buscar existente
        var alumno = caso.BuscarAlumno(2);
        Console.WriteLine(alumno != null ? alumno.ToString() : "No existe");

        // Buscar inexistente
        var noExiste = caso.BuscarAlumno(99);
        Console.WriteLine(noExiste != null ? noExiste.ToString() : "No existe");

        //  Eliminar
        caso.EliminarAlumno(1);

        //  Listar nuevamente
        Console.WriteLine("Después de eliminar:");
        foreach (var item in caso.ObtenerDiccionario())
        {
            Console.WriteLine(item.Value);
        }

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        var caso = new CasoLinq();

        Console.WriteLine("Primero: " + caso.GetPrimero()?.Titulo);
        Console.WriteLine("Último: " + caso.GetUltimo()?.Titulo);

        Console.WriteLine("Total precios: " + caso.GetTotalPrecios());
        Console.WriteLine("Promedio precios: " + caso.GetPromedioPrecios());

        Console.WriteLine("\nLibros formateados:");
        foreach (var l in caso.GetLibros())
        {
            Console.WriteLine(l);
        }

        Console.WriteLine("\nMayor precio: " + caso.GetMayorPrecio()?.Titulo);
        Console.WriteLine("Menor precio: " + caso.GetMenorPrecio()?.Titulo);

        Console.WriteLine("\nLibros con precio mayor al promedio:");
        foreach (var l in caso.GetMayorPromedio())
        {
            Console.WriteLine(l.Titulo);
        }

        Console.WriteLine("\nLibros ordenados desc:");
        foreach (var l in caso.GetOrdenadosDesc())
        {
            Console.WriteLine(l.Titulo);
        }

    }
}
