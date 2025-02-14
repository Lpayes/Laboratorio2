using System;
class Program
{
    static void Main()
    {
        Console.Write("Bienvenido a la calculadora básica de Lester David Payes Méndez\n");

        Console.Write("\nIngrese el primer número (int): ");
        int int1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el segundo número (int): ");
        int int2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Operaciones con tipo int:");
        Console.WriteLine($"La suma de {int1} y {int2} es: {int1 + int2}");
        Console.WriteLine($"La resta de {int1} y {int2} es: {int1 - int2}");
        Console.WriteLine($"La multiplicación de {int1} y {int2} es: {int1 * int2}");
        Console.WriteLine($"La división de {int1} y {int2} es: {int1 / int2}");

        Console.Write("\n---------------------------------------------------------\n");

        Console.Write("Ingrese el primer número (float): ");
        float float1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Ingrese el segundo número (float): ");
        float float2 = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Operaciones con tipo float:");
        Console.WriteLine($"La suma de {float1} y {float2} es: {float1 + float2}");
        Console.WriteLine($"La resta de {float1} y {float2} es: {float1 - float2}");
        Console.WriteLine($"La multiplicación de {float1} y {float2} es: {float1 * float2}");
        Console.WriteLine($"La división de {float1} y {float2} es: {float1 / float2}");

        Console.Write("\n---------------------------------------------------------\n");

        Console.Write("Ingrese el primer número (double): ");
        double double1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo número (double): ");
        double double2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Operaciones con tipo double:");
        Console.WriteLine($"La suma de {double1} y {double2} es: {double1 + double2}");
        Console.WriteLine($"La resta de {double1} y {double2} es: {double1 - double2}");
        Console.WriteLine($"La multiplicación de {double1} y {double2} es: {double1 * double2}");
        Console.WriteLine($"La división de {double1} y {double2} es: {double1 / double2}");

        Console.Write("\n---------------------------------------------------------\n");

        Console.Write("Ingrese el primer número (Int16): ");
        Int16 int16_1 = Convert.ToInt16(Console.ReadLine());

        Console.Write("Ingrese el segundo número (Int16): ");
        Int16 int16_2 = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Operaciones con tipo Int16:");
        Console.WriteLine($"La suma de {int16_1} y {int16_2} es: {int16_1 + int16_2}");
        Console.WriteLine($"La resta de {int16_1} y {int16_2} es: {int16_1 - int16_2}");
        Console.WriteLine($"La multiplicación de {int16_1} y {int16_2} es: {int16_1 * int16_2}");
        Console.WriteLine($"La división de {int16_1} y {int16_2} es: {int16_1 / int16_2}");

        Console.Write("\n---------------------------------------------------------\n");

        Console.Write("Ingrese el primer número (byte): ");
        byte byte1 = Convert.ToByte(Console.ReadLine());

        Console.Write("Ingrese el segundo número (byte): ");
        byte byte2 = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Operaciones con tipo byte:");
        Console.WriteLine($"La suma de {byte1} y {byte2} es: {byte1 + byte2}");
        Console.WriteLine($"La resta de {byte1} y {byte2} es: {byte1 - byte2}");
        Console.WriteLine($"La multiplicación de {byte1} y {byte2} es: {byte1 * byte2}");
        Console.WriteLine($"La división de {byte1} y {byte2} es: {byte1 / byte2}");
    }
}