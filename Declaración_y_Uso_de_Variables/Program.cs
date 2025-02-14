using System;
class Program
{
    static void Main()
    {
        int numeroEntero;
        double numeroDecimal;
        string texto;
        bool valorBooleano;
        Console.Write("Ingrese un número entero: ");
        numeroEntero = int.Parse(Console.ReadLine() ?? "0");

        Console.Write("Ingrese un número decimal: ");
        numeroDecimal = double.Parse(Console.ReadLine() ?? "0.0");

        Console.Write("Ingrese un texto: ");
        texto = Console.ReadLine() ?? string.Empty;

        Console.Write("Ingrese un valor verdadero o falso (true/false): ");
        valorBooleano = bool.Parse(Console.ReadLine() ?? "false");

        Console.WriteLine("\nValores ingresados:");
        Console.WriteLine("Número entero: " + numeroEntero);
        Console.WriteLine("Número decimal: " + numeroDecimal);
        Console.WriteLine("Texto: " + texto);
        Console.WriteLine("Valor booleano: " + valorBooleano);
    }
}
