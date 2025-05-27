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


        Console.Write("Ingrese una cadena de texto: ");
        string texto1 = Console.ReadLine();
        Console.WriteLine("La longitud de la cadena es: " + texto1.Length);

        Console.Write("Ingrese una segunda cadena de texto: ");
        string texto2 = Console.ReadLine();
        string concatenacion = texto1 + texto2;
        Console.WriteLine("La concatenacion de ambas cadenas es: " + concatenacion);

        Console.Write("Ingrese el indice de inicio para extraer la subcadena: ");
        string inicioStr = Console.ReadLine();
        int inicio;
        if (!int.TryParse(inicioStr, out inicio))
        {
            Console.WriteLine("Indice invalido.");
        }
        else
        {
            Console.Write("Ingrese la cantidad de caracteres a extraer: ");
            string cantidadStr = Console.ReadLine();
            int cantidad;
            if (!int.TryParse(cantidadStr, out cantidad))
            {
                Console.WriteLine("Cantidad invalida.");
            }
            else
            {
                if (inicio < 0 || inicio >= texto1.Length || inicio + cantidad > texto1.Length)
                {
                    Console.WriteLine("El rango indicado esta fuera de limites.");
                }
                else
                {
                    string subcadena = texto1.Substring(inicio, cantidad);
                    Console.WriteLine("La subcadena extraida es: " + subcadena);
                }
            }
        }

        Console.Write("Ingrese el primer numero para la operacion: ");
        string num1Str = Console.ReadLine();
        double Num1;
        if (!double.TryParse(num1Str, out Num1))
        {
            Console.WriteLine("El primer numero ingresado no es valido.");
        }
        else
        {
            Console.Write("Ingrese el segundo numero: ");
            string num2Str = Console.ReadLine();
            double num2;
            if (!double.TryParse(num2Str, out num2))
            {
                Console.WriteLine("El segundo numero ingresado no es valido.");
            }
            else
            {
                double suma = Num1 + num2;
                Console.WriteLine("La suma de " + Num1.ToString() + " y de " +
                                  num2.ToString() + " es igual a: " + suma.ToString());
            }
        }

        Console.WriteLine("Mostrando la primera cadena caracter por caracter:");
        foreach (char caracter in texto1)
        {
            Console.WriteLine(caracter);
        }

        Console.Write("Ingrese la palabra que desea buscar en la primera cadena: ");
        string palabra = Console.ReadLine();
        int posicion = texto1.IndexOf(palabra);
        if (posicion >= 0)
        {
            Console.WriteLine("La palabra \"" + palabra + "\" se encontro en la posicion: " + posicion);
        }
        else
        {
            Console.WriteLine("La palabra \"" + palabra + "\" no se encontro en la cadena.");
        }

        string mayusculas = texto1.ToUpper();
        string minusculas = texto1.ToLower();
        Console.WriteLine("Cadena en mayusculas: " + mayusculas);
        Console.WriteLine("Cadena en minusculas: " + minusculas);

        Console.Write("Ingrese una cadena a separar: ");
        string cadenaSeparada = Console.ReadLine();
        Console.Write("Ingrese el delimitador utilizado: ");
        string delimitador = Console.ReadLine();
        string[] elementos = cadenaSeparada.Split(delimitador);
        Console.WriteLine("La cadena se ha dividido en " + elementos.Length + " partes:");
        foreach (string elemento in elementos)
        {
            Console.WriteLine(elemento.Trim());
        }

        Console.Write("Ingrese una ecuacion simple: ");
        string ecuacion = Console.ReadLine();
        if (ecuacion.Contains("+"))//analiza si contiene +
        {
            string[] ops = ecuacion.Split('+');
            if (ops.Length == 2 &&
                double.TryParse(ops[0].Trim(), out double opA) &&
                double.TryParse(ops[1].Trim(), out double opB))
            {
                Console.WriteLine("El resultado de la ecuacion " + ecuacion + " es: " + (opA + opB));
            }
            else
            {
                Console.WriteLine("Formato de ecuacion incorrecto.");
            }
        }
        else if (ecuacion.Contains("-"))
        {
            string[] ops = ecuacion.Split('-');
            if (ops.Length == 2 &&
                double.TryParse(ops[0].Trim(), out double opA) &&
                double.TryParse(ops[1].Trim(), out double opB))
            {
                Console.WriteLine("El resultado de la ecuacion " + ecuacion + " es: " + (opA - opB));
            }
            else
            {
                Console.WriteLine("Formato de ecuacion incorrecto.");
            }
        }
        else if (ecuacion.Contains("*"))
        {
            string[] ops = ecuacion.Split('*');
            if (ops.Length == 2 &&
                double.TryParse(ops[0].Trim(), out double opA) &&
                double.TryParse(ops[1].Trim(), out double opB))
            {
                Console.WriteLine("El resultado de la ecuacion " + ecuacion + " es: " + (opA * opB));
            }
            else
            {
                Console.WriteLine("Formato de ecuacion incorrecto.");
            }
        }
        else if (ecuacion.Contains("/"))
        {
            string[] ops = ecuacion.Split('/');
            if (ops.Length == 2 &&
                double.TryParse(ops[0].Trim(), out double opA) &&
                double.TryParse(ops[1].Trim(), out double opB))
            {
                if (opB == 0)
                {
                    Console.WriteLine("Error: Division por cero.");
                }
                else
                {
                    Console.WriteLine("El resultado de la ecuacion " + ecuacion + " es: " + (opA / opB));
                }
            }
            else
            {
                Console.WriteLine("Formato de ecuacion incorrecto.");
            }
        }
        else
        {
            Console.WriteLine("La ecuacion ingresada no contiene ningun operador reconocido (+, -, *, /).");
        }

        Console.WriteLine("Presione cualquier tecla para salir...");
        Console.ReadKey();
