using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido al progrma de comparación de números de Lester Payes\n");

        Console.Write("Ingrese el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2)
        {
            Console.WriteLine($"Número 1 ({num1}) es mayor que Número 2 ({num2})");
        }
        else if (num1 < num2)
        {
            Console.WriteLine($"Número 1 ({num1}) es menor que Número 2 ({num2})");
        }
        else
        {
            Console.WriteLine($"Número 1 ({num1}) es igual a Número 2 ({num2})");
        }

        if (num1 > 0 && num2 > 0)
        {
            Console.WriteLine($"Número 1 ({num1}) y Número 2 ({num2}) son positivos");
        }
        else if (num1 < 0 && num2 < 0)
        {
            Console.WriteLine($"Número 1 ({num1}) y Número 2 ({num2}) son negativos");
        }
        else if (num1 > 0 && num2 < 0)
        {
            Console.WriteLine($"Número 1 ({num1}) es positivo y Número 2 ({num2}) es negativo");
        }
        else if (num1 < 0 && num2 > 0)
        {
            Console.WriteLine($"Número 1 ({num1}) es negativo y Número 2 ({num2}) es positivo");
        }
        else if (num1 == 0 && num2 == 0)
        {
            Console.WriteLine("Ambos números son cero");
        }
        else
        {
            Console.WriteLine($"Uno de los números es cero: Número 1 ({num1}), Número 2 ({num2})");
        }
    }
}