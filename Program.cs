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

