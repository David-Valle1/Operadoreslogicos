
using System;

class Calculador
{
    static void Main()
    {
        Console.WriteLine("Ingrese un operador lógico ( Suma, Resta, Multiplicación o Divición. )");
        string Operador = Console.ReadLine();

        if (Operador == "+")
        {
            Console.WriteLine("Ingrese el primer numero a sumar");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a sumar");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Resultado = num1 + num2;
            Console.WriteLine($"El resultado de la suma es: {Resultado}");
            Console.ReadKey();
        }
        else if (Operador == "-")
        {
            Console.WriteLine("Ingrese el primer numero a restar");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a restar");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Resultado = num1 - num2;
            Console.WriteLine($"El resultado de la resta es: {Resultado}");
            Console.ReadKey();
        }

        else if (Operador == "*")
        {
            Console.WriteLine("Ingrese el primer numero a multiplicar");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a multiplicar");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Resultado = num1 * num2;
            Console.WriteLine($"El resultado de la multiplicación es: {Resultado}");
            Console.ReadKey();
        }

        else if (Operador == "/")
        {
            Console.WriteLine("Ingrese el primer numero a dividir");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero a dividir");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int Resultado = num1 / num2;
            Console.WriteLine($"El resultado de la divición  es: {Resultado}");
            Console.ReadKey();
        }



    }
}
