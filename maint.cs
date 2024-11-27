/* Isneyler Mosquera Preciado
 Grupo: 93
 Ingeniería Electrónica
 Código Fuente: Autoría propia */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la cantidad de estudiantes a valorar:");
        int cantidad = int.Parse(Console.ReadLine());

        string[] nombres = new string[cantidad];
        int[] calificaciones = new int[cantidad];

        // Captura de datos
        CapturarDatos(cantidad, nombres, calificaciones);

        // Calcular y mostrar los resultados
        double promedio = CalcularPromedio(calificaciones);
        int calificacionMaxima = CalcularMaxima(calificaciones);
        int calificacionMinima = CalcularMinima(calificaciones);

        Console.WriteLine($"\nResultados:");
        Console.WriteLine($"- Calificación promedio: {promedio:F2}");
        Console.WriteLine($"- Calificación máxima: {calificacionMaxima}");
        Console.WriteLine($"- Calificación mínima: {calificacionMinima}");
    }

    // Función para obtener datos de los estudiantes
    static void CapturarDatos(int cantidad, string[] nombres, int[] calificaciones)
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nEstudiante #{i + 1}:");

            Console.Write("Ingrese el nombre: ");
            nombres[i] = Console.ReadLine();

            int calificacion;
            do
            {
                Console.Write("Ingrese la calificación (entre 1 y 10): ");
                calificacion = int.Parse(Console.ReadLine());
                if (calificacion < 1 || calificacion > 10)
                {
                    Console.WriteLine("La calificación debe estar entre 1 y 10. Intente nuevamente.");
                }
            } while (calificacion < 1 || calificacion > 10);

            calificaciones[i] = calificacion;
        }
    }

    // Funcion para calcular el promedio de las calificaciones
    static double CalcularPromedio(int[] calificaciones)
    {
        int suma = 0;
        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }
        return (double)suma / calificaciones.Length;
    }

    // Funcion para calcular la calificación máxima
    static int CalcularMaxima(int[] calificaciones)
    {
        int maxima = calificaciones[0];
        foreach (int calificacion in calificaciones)
        {
            if (calificacion > maxima)
            {
                maxima = calificacion;
            }
        }
        return maxima;
    }

    // Funcion para calcular la calificación mínima
    static int CalcularMinima(int[] calificaciones)
    {
        int minima = calificaciones[0];
        foreach (int calificacion in calificaciones)
        {
            if (calificacion < minima)
            {
                minima = calificacion;
            }
        }
        return minima;
    }
}
