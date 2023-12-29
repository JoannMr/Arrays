// Codifica un programa que demani 6 números a l’usuari i després els imprimeixi de
// manera inversa.

using System;

class Program
{
    static void Main()
    {
        int[] numeros = new int[6];

        for (int i = 0; i < 6; i++)
        {
            Console.Write("Ingresa el número {0}: ", i + 1);
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nNúmeros en orden inverso:");

        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(numeros[i]);
        }

        Console.ReadKey();
    }
}

// Codifica un programa que prepari espai per desar un màxim de 100 noms. L'usuari
// haurà d'anar introduint un nom cada cop, fins que es teclegi stop, moment en què
// deixaran de demanar-se més noms i es mostrarà a la pantalla la llista dels noms que
// s'han introduït.

using System;

class Program
{
    static void Main()
    {
        string[] nombres = new string[100];

        int cantidadNombres = 0;

        Console.WriteLine("Introduce nombres. Escribe 'stop' para finalizar.");

        while (true)
        {
            Console.Write("Ingresa un nombre: ");
            string nombre = Console.ReadLine();

            if (nombre.ToLower() == "stop")
            {
                break;
            }
            nombres[cantidadNombres] = nombre;
            cantidadNombres++;
        }

        Console.WriteLine("\nLista de nombres introducidos:");

        for (int i = 0; i < cantidadNombres; i++)
        {
            Console.WriteLine(nombres[i]);
        }

        Console.ReadKey();
    }
}


// Codifica un programa que emmagatzemi en una taula el nombre de dies que té cada
// mes, demaneu a l'usuari que us indiqui un mes (1=gener, 12=desembre) i mostri a la
// pantalla el nombre de dies que té aquest mes.

using System;

class Program
{
    static void Main()
    {
        int[] diasPorMes = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        Console.Write("Ingresa un número de mes (1=enero, 12=diciembre): ");
        int numeroMes = Convert.ToInt32(Console.ReadLine());

        if (numeroMes >= 1 && numeroMes <= 12)
        {
            int numeroDias = diasPorMes[numeroMes - 1];

            Console.WriteLine($"El mes {numeroMes} tiene {numeroDias} días.");
        }
        else
        {
            Console.WriteLine("Número de mes no válido. Ingresa un número entre 1 y 12.");
        }

        Console.ReadKey();
    }
}

// Codifica un programa que permita al usuario ingresar 7 valores decimales y luego
// muestre esos valores ordenados de mayor a menor.

using System;

class Program
{
    static void Main()
    {
        int cantidadValores = 7;
        double[] valores = new double[cantidadValores];

        for (int i = 0; i < cantidadValores; i++)
        {
            Console.Write($"Ingresa el valor {i + 1}: ");
            valores[i] = Convert.ToDouble(Console.ReadLine());
        }

        Array.Sort(valores);
        Array.Reverse(valores);

        Console.WriteLine("\nValores ordenados de mayor a menor:");

        foreach (double valor in valores)
        {
            Console.WriteLine(valor);
        }

        Console.ReadKey();
    }
}

// Codifica un programa que solicite al usuario el ingreso de 10 números y determine
// cuántos de ellos son pares.

using System;

class Program
{
    static void Main()
    {
        int cantidadNumeros = 10;
        int numerosPares = 0;

        Console.WriteLine($"Ingresa {cantidadNumeros} números:");

        for (int i = 0; i < cantidadNumeros; i++)
        {
            Console.Write($"Número {i + 1}: ");
            int numero = Convert.ToInt32(Console.ReadLine());


            if (EsPar(numero))
            {
                numerosPares++;
            }
        }

        Console.WriteLine($"De los {cantidadNumeros} números ingresados, {numerosPares} son pares.");

        Console.ReadKey();
    }

    static bool EsPar(int numero)
    {
        return numero % 2 == 0;
    }
}