/* Isneyler Mosquera Preciado
 Grupo: 93
 Ingeniería Electrónica
 Código Fuente: Autoría propia */

// Aqui se declara un arreglo de 3 filas y 4 columnas
int[,] matriz = new int[3, 4];

// Aqui se declara un arreglo para almacenar la suma de cada fila
int[] sumasFilas = new int[3];

// Aqui se declara un arreglo para almacenar el promedio de cada columna
double[] promediosColumnas = new double[4];

// Aqui se declara un arreglo para almacenar la suma de cada columna
int[] totalColumnas = new int[4]; 

// Este ciclo se usa para capturar números pares entre 20 y 50 para llenar la matriz
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        int numero;
        do
        {
            Console.Write($"Ingresa un número par entre 20 y 50 para la posición [{i + 1}, {j + 1}]: ");
            numero = int.Parse(Console.ReadLine());

            //Aqui se verifica que no sean numeros menores a 20 o 50 o que el residuo del numero entre no sea igual a 0
            //Es decir que se verifica que NO se ingresen numeros menores a 20 y 50 y que no sean pares, si se cumple la condicion alerta al usuario y vuelve a pedir otro numero
            if (numero < 20 || numero > 50 || numero % 2 != 0)
            {
                Console.WriteLine("El número es inválido, debe ser par y estar entre 20 y 50.");
            }
        } while (numero < 20 || numero > 50 || numero % 2 != 0);

        matriz[i, j] = numero;
        totalColumnas[j] += numero;
    }
}

// Calcular suma de cada fila
for (int i = 0; i < 3; i++)
{
    int sumaFila = 0;
    for (int j = 0; j < 4; j++)
    {
        sumaFila += matriz[i, j];
    }
    sumasFilas[i] = sumaFila;
}

// Calcular el promedio de cada columna
for (int j = 0; j < 4; j++)
{
    promediosColumnas[j] = totalColumnas[j] / 3.0;
}

// Mostrar resultados
Console.WriteLine("\nMatriz generada:");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("\nSuma de cada fila:");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Fila {i + 1}: {sumasFilas[i]}");
}

Console.WriteLine("\nPromedio de cada columna:");
for (int j = 0; j < 4; j++)
{
    Console.WriteLine($"Columna {j + 1}: {promediosColumnas[j]:F2}");
}