using System;

class CalculadoraV2
{
    static void Main()
    {
        Console.Write("Ingrese un número real: ");
        string entrada = Console.ReadLine() ?? "";

        float numero;  // Declaración antes del TryParse
        bool esNumero = float.TryParse(entrada, out numero);

        if (!esNumero)
        {
            Console.WriteLine("Error: No ingresó un número válido.");
            return;
        }

        Console.WriteLine("\nResultados:\n");

        // 1. Valor absoluto
        Console.WriteLine("Valor absoluto: " + Math.Abs(numero));

        // 2. Cuadrado
        Console.WriteLine("Cuadrado: " + (numero * numero));

        // 3. Raíz cuadrada (sólo si el número es >= 0)
        if (numero >= 0)
        {
            Console.WriteLine("Raíz cuadrada: " + Math.Sqrt(numero));
        }
        else
        {
            Console.WriteLine("Raíz cuadrada: No se puede calcular (número negativo).");
        }

        // 4. Seno
        Console.WriteLine("Seno: " + Math.Sin(numero));

        // 5. Coseno
        Console.WriteLine("Coseno: " + Math.Cos(numero));

        // 6. Parte entera (por conversión a entero)
        int parteEntera = (int)numero;
        Console.WriteLine("Parte entera: " + parteEntera);
    }
}
