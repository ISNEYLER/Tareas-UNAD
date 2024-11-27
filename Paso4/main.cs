/* Isneyler Mosquera Preciado
 Grupo: 93
 Ingeniería Electrónica
 Código Fuente: Autoría propia */
class Program
{
    // Función principal
    static void Main(string[] args)
    {
        Console.WriteLine("Ingresa la cantidad de empleados:");
        int cantidad = int.Parse(Console.ReadLine());

        string[] nombres = new string[cantidad];
        int[] edades = new int[cantidad];

        // Captura de datos
        CapturarDatos(cantidad, nombres, edades);

        // Calcular y mostrar la edad promedio
        double promedio = CalcularPromedio(edades);
        Console.WriteLine($"\nLa edad promedio de los empleados es: {promedio:F2} años.");
    }

    // Función para obtener los datos de los empleados
    static void CapturarDatos(int cantidad, string[] nombres, int[] edades)
    {
        for (int i = 0; i < cantidad; i++)
        {
            Console.WriteLine($"\nEmpleado #{i + 1}:");

            Console.Write("Ingrese el nombre: ");
            nombres[i] = Console.ReadLine();

            Console.Write("Ingrese la edad: ");
            edades[i] = int.Parse(Console.ReadLine());
        }
    }

    // Función que calcula el promedio de las edades
    static double CalcularPromedio(int[] edades)
    {
        int suma = 0;
        foreach (int edad in edades)
        {
            suma += edad;
        }
        return (double)suma / edades.Length;
    }
}
