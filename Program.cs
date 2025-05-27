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
           
            Console.WriteLine("Calculadora Mejorada");
            Console.WriteLine("====================");
            Console.WriteLine("Seleccione la operación a realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Valor absoluto");
            Console.WriteLine("6. Cuadrado");
            Console.WriteLine("7. Raíz cuadrada");
            Console.WriteLine("8. Seno (en radianes)");
            Console.WriteLine("9. Coseno (en radianes)");
            Console.WriteLine("10. Parte entera");
            Console.Write("Opción: ");
            string opcionTexto = Console.ReadLine();
            int opcion;
            
            if (!int.TryParse(opcionTexto, out opcion) || opcion < 1 || opcion > 10)
            {
                Console.WriteLine("Opción inválida. Presione cualquier tecla para reiniciar.");
                Console.ReadKey();
                continue;
            }
            
            double resultado = 0; 
            
            // operaciones de dos números 
            if (opcion >= 1 && opcion <= 4)
            {
                Console.Write("Ingrese el primer numero: ");
                string num1Texto = Console.ReadLine();
                double num1;
                if (!double.TryParse(num1Texto, out num1))
                {
                    Console.WriteLine("El primer numero ingresado no es valido.");
                    Console.ReadKey();
                    continue;
                }
                
                Console.Write("Ingrese el segundo numero: ");
                string num2Texto = Console.ReadLine();
                double num2;
                if (!double.TryParse(num2Texto, out num2))
                {
                    Console.WriteLine("El segundo numero ingresado no es valido.");
                    Console.ReadKey();
                    continue;
                }
                
                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        Console.WriteLine("La suma es: " + resultado);
                        break;
                    case 2:
                        resultado = num1 - num2;
                        Console.WriteLine("La resta es: " + resultado);
                        break;
                    case 3:
                        resultado = num1 * num2;
                        Console.WriteLine("La multiplicacion es: " + resultado);
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: No se puede dividir por cero.");
                        }
                        else
                        {
                            resultado = num1 / num2;
                            Console.WriteLine("La division es: " + resultado);
                        }
                        break;
                }
            }
            else // operaciones con un solo operando 
            {
                Console.Write("Ingrese un numero: ");
                string input = Console.ReadLine();
                double num;
                if (!double.TryParse(input, out num))
                {
                    Console.WriteLine("El numero ingresado no es valido.");
                    Console.ReadKey();
                    continue;
                }
                
                switch (opcion)
                {
                    case 5:
                        resultado = Math.Abs(num);
                        Console.WriteLine("El valor absoluto es: " + resultado);
                        break;
                    case 6:
                        resultado = num * num;
                        Console.WriteLine("El cuadrado es: " + resultado);
                        break;
                    case 7:
                        if (num < 0)
                        {
                            Console.WriteLine("Error: No se puede calcular la raz cuadrada de un numero negativo.");
                        }
                        else
                        {
                            resultado = Math.Sqrt(num);
                            Console.WriteLine("La raiz cuadrada es: " + resultado);
                        }
                        break;
                    case 8:
                        resultado = Math.Sin(num);
                        Console.WriteLine("El seno es: " + resultado);
                        break;
                    case 9:
                        resultado = Math.Cos(num);
                        Console.WriteLine("El coseno es: " + resultado);
                        break;
                    case 10:
                        int parteEntera = (int)num;
                        Console.WriteLine("La parte entera es: " + parteEntera);
                        break;
                }
            }
            
            
            Console.Write("\n¿Desea realizar otro cálculo? (S/N): ");
            string resp = Console.ReadLine();
            if (!string.IsNullOrEmpty(resp))
            {
                continuar = resp[0];
            }
            else
            {
                continuar = 'N';
            }
            
        } while (continuar == 'S' || continuar == 's');


    Console.WriteLine("Max y min:");
        Console.Write("Ingrese el primer numero: ");
        string input1 = Console.ReadLine();
        double NUM1;
        if (!double.TryParse(input1, out NUM1))
        {
            Console.WriteLine("El primer número no es valido.");
            Console.ReadKey();
            return;
        }
        
        
        Console.Write("Ingrese el segundo numero: ");
        string input2 = Console.ReadLine();
        double NUM2;
        if (!double.TryParse(input2, out NUM2))
        {
            Console.WriteLine("El segundo numero no es valido.");
            Console.ReadKey();
            return;
        }
        
        double maximo = Math.Max(NUM1, NUM2);
        double minimo = Math.Min(NUM1, NUM2);

        
        Console.WriteLine("El maximo entre {0} y {1} es: {2}", NUM1, NUM2, maximo);
        Console.WriteLine("El minimo entre {0} y {1} es: {2}", NUM1, NUM2, minimo);
        
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadKey();
 



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