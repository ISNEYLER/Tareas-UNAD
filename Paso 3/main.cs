/* Isneyler Mosquera Preciado
 Grupo: 93
 Ingeniería Electrónica
 Código Fuente: Autoría propia */

//En este array se guardaran todos los numeros ingresados
int[] numeros = new int[8];


//En esta variable se almacena temporalmente el numero ingresado por teclado
int numero;

//En estas variables se guardará el conteo de los numeros que se repiten
double rep3 = 0;
double rep4 = 0;
double rep5 = 0;
double rep6 = 0;

//En estas vaariables se guardará las potencias correspondientes las repeticiones de los numeros
double potencia3 = 0;
double potencia4 = 0;
double potencia5 = 0;
double potencia6 = 0;

//Este ciclo es el encargado de recorrer y llenar el arreglo
for (int i = 0; i < 8; i++)
{
    Console.WriteLine("Ingresa un número entre 3 y 6");
    numero = int.Parse(Console.ReadLine());
    //Aqui se verifica que mientras que el numero ingresado sea menor que 3 o mayor que 6  no se guardara y advertira que es un numero invalido y pedira que se ingrese otro
    while (numero < 3 || numero > 6)
    {
        Console.WriteLine("Numero inválido debe estar entre 3 y 6");
        numero = int.Parse(Console.ReadLine());
    }

    //Aqui se almacena el numero ingreso una vez superada la verificacion
    numeros[i] = numero;

    //Si numero es igual a x (3, 4, 5, ...) se incrementa en 1 el contador
    if (numero == 3)
    {
        rep3++;
    }
    else if (numero == 4)
    {
        rep4++;
    }
    else if (numero == 5)
    {
        rep5++;
    }
    else if (numero == 6) {
        rep6++;
    }
}

//Aqui se calcula lans potencias de las repeticiones de cada numero
potencia3 = Math.Pow(3, rep3);
potencia4 = Math.Pow(4, rep4);
potencia5 = Math.Pow(5, rep5);
potencia6 = Math.Pow(6, rep6);

//Aqui se recorre el array de los numeros ingresados y se imprime su valor correspondiente
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine("Los numeros ingresados fueron: " + numeros[i]);
}

//Aqui se imprimen los valores resultantes segun la cantidad de veces que se repitan los numeros
Console.WriteLine("\n");
Console.WriteLine("El número 3 se repite " + rep3 + " veces, su potencia es de " + potencia3);
Console.WriteLine("El número 4 se repite " + rep4 + " veces, su potencia es de " + potencia4);
Console.WriteLine("El número 5 se repite " + rep5 + " veces, su potencia es de " + potencia5);
Console.WriteLine("El número 6 se repite " + rep6 + " veces, su potencia es de " + potencia6);

