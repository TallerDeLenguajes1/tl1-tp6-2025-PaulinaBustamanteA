using System;

class CalculadoraV2
{
    static void Main()
    {
        Console.Write("Ingrese un número real: ");
        string entrada = Console.ReadLine();

        bool esNumero = float.TryParse(entrada, out float numero);

        if (!esNumero)
        {
            Console.WriteLine("Error: No ingresó un número válido.");
            return;
        }

        Console.WriteLine("\nResultados:\n");

        // Valor absoluto
        Console.WriteLine("Valor absoluto: " + Math.Abs(numero));

        // Cuadrado
        Console.WriteLine("Cuadrado: " + (numero * numero));

        // Raíz cuadrada (sólo si el número es >= 0)
        if (numero >= 0)
        {
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero));
        }
        else
        {
            Console.WriteLine("Raíz cuadrada: No se puede calcular (número negativo).");
        }

        // Seno
        Console.WriteLine("Seno: " + Math.Sin(numero));

        // Coseno
        Console.WriteLine("Coseno: " + Math.Cos(numero));

        // Parte entera (por conversión)
        int parteEntera = (int)numero;
        Console.WriteLine("Parte entera: " + parteEntera);
    }
}
