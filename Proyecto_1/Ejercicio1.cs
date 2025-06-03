using System;
class Ejercicio1
{
    static void Main()
    {
        //pido un numero al usuario
        Console.Write("Ingrese un número: ");
        string entrada = Console.ReadLine() ?? ""; //entrada como texto

        //verifico si el texto ingresado es valido
        bool esNumero = int.TryParse(entrada, out int numero);
        if (!esNumero)
        {
            Console.WriteLine("No ingreso un numero valido.");
            return;
        }

        //verifico que el numero sea mayor que 0
        if (numero <= 0)
        {
            Console.WriteLine("El numero debe ser mayor a 0 para poder invertirlo");
            return;
        }

        //invierto el numero
        int invertido = 0;
        int original = numero;

        while (numero > 0)
        {
            int digito = numero % 10; //para tomar el ultimo digito
            invertido = invertido * 10 + digito; //voy armando el numero invertido
            numero = numero / 10;//elimino el ultimo digito 
        }

        //muestro el resultado 
        Console.WriteLine($"El numero original era: {original}");
        Console.WriteLine($"El numero invertido es: {invertido}");
        
    }
}
