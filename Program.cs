// See https://aka.ms/new-console-template for more information
using System.ComponentModel;

Console.WriteLine("Hello, World!");

int a;

int b;

a = 10;

b = a;

Console.WriteLine("valor de a:" + a);

Console.WriteLine("valor de b:" + b);



Console.WriteLine("Escriba un numero mayor a 0:");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int inversion) && inversion > 0)
{
    int invertido = 0;
    int temp = inversion;

    while (temp != 0)
    {
        int digito = temp % 10;
        invertido = invertido * 10 + digito;
        temp /= 10;
    }

    Console.WriteLine("El numero invertido de " + inversion + " es " + invertido);
}
else
{
    Console.WriteLine("El valor ingresado no es un numero valido mayor a 0.");
}
Console.ReadKey();

char continuar = 'S';

do
{
    Console.WriteLine("Calculadora Básica");
    Console.WriteLine("=================");
    Console.WriteLine("Seleccione la operación que desea realizar:");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");
    Console.Write("Opción: ");
    string opcionTexto = Console.ReadLine();
    int opcion;

    if (!int.TryParse(opcionTexto, out opcion) || opcion < 1 || opcion > 4)
    {
        Console.WriteLine("Opción invalida.");
        Console.ReadKey();
        continue;
    }

    Console.Write("Ingrese el primer numero: ");
    string num1Texto = Console.ReadLine();
    double num1;
    if (!double.TryParse(num1Texto, out num1))
    {
        Console.WriteLine("El primer número ingresado no es valido.");
        Console.ReadKey();
        continue;
    }

    Console.Write("Ingrese el segundo número: ");
    string num2Texto = Console.ReadLine();
    double num2;
    if (!double.TryParse(num2Texto, out num2))
    {
        Console.WriteLine("El segundo número ingresado no es válido. Presione cualquier tecla para reiniciar.");
        Console.ReadKey();
        continue;
    }

    double resultado = 0;
    bool operacionValida = true;

    switch (opcion)
    {
        case 1:
            resultado = num1 + num2;
            break;
        case 2:
            resultado = num1 - num2;
            break;
        case 3:
            resultado = num1 * num2;
            break;
        case 4:
            
            if (num2 == 0)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                operacionValida = false;
            }
            else
            {
                resultado = num1 / num2;
            }
            break;
        default:
            
            Console.WriteLine("Opción desconocida.");
            operacionValida = false;
            break;
    }

    if (operacionValida)
    {
        Console.WriteLine("El resultado de la operación es: " + resultado);
    }


    Console.Write("¿Desea realizar otro calculo? (S/N): ");
    string resp = Console.ReadLine();
    
    continuar = (!string.IsNullOrEmpty(resp)) ? resp[0] : 'N';

} while (continuar == 'S' || continuar == 's');

Console.WriteLine("Gracias por usar la calculadora. Presione cualquier tecla para salir.");
Console.ReadKey();