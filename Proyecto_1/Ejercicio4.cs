using System;

class Ejercicio4
{
    static void Main()
    {
        // 1) Pido al usuario que ingrese una cadena
        Console.Write("Ingrese una cadena de texto: ");
        string cadena1 = Console.ReadLine() ?? "";

        // 2) Muestro la longitud de la cadena
        Console.WriteLine($"La longitud de la cadena es: {cadena1.Length}");

        // 3) Pido una segunda cadena 
        Console.Write("Ingrese una segunda cadena de texto: ");
        string cadena2 = Console.ReadLine() ?? "";

        // 4) Concateno y muestro ambas cadenas
        string concatenada = cadena1 + cadena2;
        Console.WriteLine($"Las cadenas concatenadas son: {concatenada}");

        // 5) Extraigo una subcadena de los primeros 5 caracteres
        int largoSubcadena = 5;
        if (cadena1.Length >= largoSubcadena)
        {
            string subcadena = cadena1.Substring(0, largoSubcadena);
            Console.WriteLine($"La subcadena (primeros {largoSubcadena} caracteres) es: {subcadena}");
        }
        else
        {
            Console.WriteLine("La cadena es demasiado corta para extraer la subcadena.");
        }

        // 6) Calculadora: operaciones con dos números
        Console.Write("Ingrese el primer número: ");
        string num1Str = Console.ReadLine() ?? "";
        bool valido1 = double.TryParse(num1Str, out double num1);

        if (!valido1)
        {
            Console.WriteLine("Número 1 inválido.");
            return;
        }

        Console.Write("Ingrese el segundo número: ");
        string num2Str = Console.ReadLine() ?? "";
        bool valido2 = double.TryParse(num2Str, out double num2);

        if (!valido2)
        {
            Console.WriteLine("Número 2 inválido.");
            return;
        }

        Console.Write("Ingrese la operación (+, -, *, /): ");
        string op = Console.ReadLine() ?? "";

        double resultado = 0;
        bool operacionValida = true;

        switch (op)
        {
            case "+":
                resultado = num1 + num2;
                Console.WriteLine($"La suma de {num1} y {num2} es igual a: {resultado}");
                break;
            case "-":
                resultado = num1 - num2;
                Console.WriteLine($"La resta de {num1} y {num2} es igual a: {resultado}");
                break;
            case "*":
                resultado = num1 * num2;
                Console.WriteLine($"La multiplicación de {num1} y {num2} es igual a: {resultado}");
                break;
            case "/":
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"La división de {num1} y {num2} es igual a: {resultado}");
                }
                else
                {
                    Console.WriteLine("No se puede dividir por cero.");
                    operacionValida = false;
                }
                break;
            default:
                Console.WriteLine("Operación inválida.");
                operacionValida = false;
                break;
        }

        if (!operacionValida) return;

        // 7) Recorrer la cadena1 con foreach y mostrar cada carácter
        Console.WriteLine("\nMostrando cada carácter de la primera cadena:");
        foreach (char c in cadena1)
        {
            Console.WriteLine(c);
        }

        // 8) Buscar una palabra en la cadena1
        Console.Write("\nIngrese una palabra para buscar en la primera cadena: ");
        string palabraBuscada = Console.ReadLine() ?? "";

        if (cadena1.IndexOf(palabraBuscada) >= 0)
        {
            Console.WriteLine($"La palabra '{palabraBuscada}' se encontró en la cadena.");
        }
        else
        {
            Console.WriteLine($"La palabra '{palabraBuscada}' NO se encontró en la cadena.");
        }

        // 9) Convertir la cadena1 a mayúsculas y minúsculas
        Console.WriteLine($"Cadena en mayúsculas: {cadena1.ToUpper()}");
        Console.WriteLine($"Cadena en minúsculas: {cadena1.ToLower()}");

        // 10) Separar una cadena ingresada por comas y mostrar cada parte
        Console.Write("\nIngrese una cadena separada por comas (ejemplo: manzana,pera,naranja): ");
        string cadenaSeparada = Console.ReadLine() ?? "";
        string[] partes = cadenaSeparada.Split(',');

        Console.WriteLine("Elementos separados:");
        foreach (string parte in partes)
        {
            Console.WriteLine(parte.Trim());
        }

        // 11) Resolver ecuación simple tipo "582+2"
        Console.Write("\nIngrese una ecuación simple (ejemplo: 582+2): ");
        string ecuacion = Console.ReadLine() ?? "";

        int posMas = ecuacion.IndexOf('+');
        if (posMas >= 0)
        {
            string numA = ecuacion.Substring(0, posMas);
            string numB = ecuacion.Substring(posMas + 1);

            bool valA = double.TryParse(numA.Trim(), out double valNumA);
            bool valB = double.TryParse(numB.Trim(), out double valNumB);

            if (valA && valB)
            {
                double res = valNumA + valNumB;
                Console.WriteLine($"La suma de {valNumA} y {valNumB} es: {res}");
            }
            else
            {
                Console.WriteLine("Error al interpretar los números.");
            }
        }
        else
        {
            Console.WriteLine("Solo se soporta suma con '+' en este ejemplo.");
        }
    }
}
