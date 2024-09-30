/* Isneyler Mosquera Preciado
 Grupo: 93
 Ingeniería Electrónica
 Código Fuente: Autoría propia */

using System.ComponentModel.Design;

namespace Paso2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const double TasaMortalidad = 0.2;
            const int MesesAño = 12;

            //Variable que identifica lo que se escribe por teclado, si es un numero entonces es igual a true, si no es numero entonces es igual a false
            bool EsNumero;
            //Variable que guarda el posible numero escrito por teclado
            int PosibleNumero;

            do
            {
                Console.WriteLine("Por favor introduzca la cantidad de nacimientos mensuales");
                //Variable que almacena lo que se escribe por teclado
                String EntradaTeclado = Console.ReadLine();
                
                //Aqui se determina si lo que se escribe en el teclado es un numero o no//
                EsNumero = int.TryParse(EntradaTeclado,out PosibleNumero);
                
                //Si es un numero y es mayor que 0 hacer lo siguiente
                if(EsNumero == true && PosibleNumero > 0)
                {   
                    //Limpiar consola
                    Console.Clear();
                    //Despues de validar la entrada por teclado se asigna el valor a la cantidad de nacimientos
                    int NacimientosMensuales = PosibleNumero;
                    //Calculo de muertes mensuales
                    double MuertesMensuales = NacimientosMensuales * TasaMortalidad;
                    //Calculo de vivos mensuales
                    double VivosMensuales = NacimientosMensuales - MuertesMensuales;

                    //Calculo de Nacimientos Anuales
                    int NacimientosAnuales = NacimientosMensuales * MesesAño;
                    //Calculo de Muertes Anuales
                    double MuertesAnuales = NacimientosAnuales * TasaMortalidad;
                    //Calculo de vivos anuales
                    double VivosAnuales = NacimientosAnuales - MuertesAnuales;

                    //Se imprimen en consola los valores mensuales de Nacimientos, Muertes y Vivos
                    Console.WriteLine("Nacimientos mensuales: " + NacimientosMensuales + "\n" + "Muertes mensuales: " + MuertesMensuales + "\n" + "Vivos mensuales: " + VivosMensuales + "\n");

                    //Si hay mas de 100 Muertes anuales hacer lo siguiente
                    if (MuertesAnuales > 100)
                    {
                        //Se imprime alerta en consola debido a que la cantidad de muertes anuales superó la cantidad de 100 y los valores mensuales de Nacimientos, Muertes y Vivos
                        Console.WriteLine("Estado de Alerta" + "\n" + "Nacimientos Anuales: " + NacimientosAnuales + "\n" + "Muertes anuales: " + MuertesAnuales + "\n" + "Vivos anuales: " + VivosAnuales + "\n");
                    }
                    //En caso contrario hacer lo siguiente//
                    else
                    {
                        Console.WriteLine("Nacimientos Anuales: " + NacimientosAnuales + "\n" + "Muertes anuales: " + MuertesAnuales + "\n" + "Vivos anuales: " + VivosAnuales + "\n");
                    }
                }
                //Si lo ingresado por teclado es un numero y es menor o igual que 0 hacer lo siguiente
                else if (EsNumero == true && PosibleNumero <= 0)
                {
                    //Se le avisa al usuario que no es posible calcular con valores iguales o menores que 0
                    Console.WriteLine("Error: " + EntradaTeclado + " , no es posible calcular con valores iguales o menores que 0");
                }
                //Si es algo diferente a un numero hacer lo siguiente
                else
                {
                    //Se le avisa al usuario que lo ingresado no es un numero
                    Console.WriteLine("Error: " + EntradaTeclado + " no es un número");
                }


            }
            //Mientras que lo se este ingresando por teclado no sea un numero y sea igual o menor a 0 este bucle nunca acabara
            while (EsNumero == false || PosibleNumero <= 0);

        }
    }
}


