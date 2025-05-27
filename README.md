[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/24pP-Pw_)

### ¿String es un tipo por valor o un tipo por referencia?
En C#, string es un tipo por referencia. Aunque se comporta como inmutable, se almacena en el heap y se pasa por referencia.

### ¿Qué secuencias de escape tiene el tipo string?
Los strings admiten secuencias de escape como:

\n (nueva línea)

\r (retorno de carro)

\t (tabulador)

\\ (barra invertida)

\" (comillas dobles)

\0 (carácter nulo)

### ¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto?
@: Crea una cadena literal (verbatim), en la cual no se interpretan las secuencias de escape.

$: Permite la interpolación de variables dentro de la cadena.

Combinados @$ or $@: Se obtiene un string interpolado y verbatim, que permite incluir saltos de línea y variables sin necesidad de escapes.


### Qué significa que no se interpretan las secuencias de escape?
En una cadena normal (sin @), las secuencias de escape como \n o \t se convierten en caracteres especiales (por ejemplo, \n genera un salto de línea). En cambio, si declaras la cadena con @ (cadena verbatim), las secuencias de escape se toman literalmente; es decir, los caracteres \ y n se muestran tal cual, sin generar un salto de línea.

### ¿Qué es un string verbatim?
Un string verbatim se declara anteponiendo el carácter @ a las comillas. Esto le indica al compilador que lea la cadena tal como está escrita, sin interpretar ninguna secuencia de escape y permitiendo que se conserven los saltos de línea, espacios y caracteres especiales exactamente como aparecen en el código.

### ¿A qué se refiere la interpolación de variables dentro de la cadena?

La interpolación permite incrustar variables o expresiones directamente en una cadena de texto. Declarando la cadena con el símbolo `$`, se pueden incluir variables entre llaves `{}`; en tiempo de ejecución, se reemplazan por sus valores. Por ejemplo:

```csharp
string nombre = "Carlos";
int edad = 25;
string mensaje = $"Mi nombre es {nombre} y tengo {edad} años.";


## Expresiones Regulares: Qué son y cómo funcionan

Las expresiones regulares son secuencias de caracteres que definen un patrón de búsqueda. Con ellas se pueden buscar, extraer, validar o reemplazar partes de un texto de forma muy flexible y potente. Funcionan analizando el contenido de un string y comparándolo con el patrón definido, permitiendo realizar operaciones complejas con pocos comandos. En .NET, el motor de expresiones regulares se implementa en la clase `Regex` del espacio de nombres `System.Text.RegularExpressions`.

---

## ¿Funcionan únicamente en C#?

No, las expresiones regulares no son exclusivas de C#. Son un estándar ampliamente adoptado y se utilizan en muchos lenguajes de programación (por ejemplo, Java, Python, JavaScript, Perl, PHP y Ruby). Aunque cada lenguaje puede tener su propia implementación o ligeras variaciones en la sintaxis, los conceptos básicos y la mayoría de los patrones son muy similares en todas estas plataformas.

---

## Casos de uso: ¿En qué casos resultan útiles?

1. **Validación de entradas:**  
   Se usan para comprobar que los datos ingresados por el usuario (como direcciones de correo electrónico, números de teléfono o códigos postales) tengan el formato correcto.

2. **Búsqueda y extracción de información:**  
   Permiten encontrar y extraer información específica de textos largos, por ejemplo, capturar fechas, URLs o patrones especiales en logs o documentos.

3. **Reemplazo y limpieza de datos:**  
   Son muy útiles para limpiar cadenas de texto, eliminar caracteres no deseados, o reemplazar ciertas partes de un texto, como quitar etiquetas HTML o corregir formatos.

---

## Uso de expresiones regulares en C#

En C# se utilizan a través de la clase `Regex` (del espacio de nombres `System.Text.RegularExpressions`). Algunos métodos comunes son:

- **`Regex.IsMatch(string input, string pattern)`:**  
  Determina si la cadena `input` cumple con el patrón especificado.

- **`Regex.Match(string input, string pattern)`:**  
  Devuelve la primera ocurrencia que coincide con el patrón.

- **`Regex.Matches(string input, string pattern)`:**  
  Permite obtener todas las coincidencias del patrón en la cadena.

- **`Regex.Replace(string input, string pattern, string replacement)`:**  
  Sustituye partes de la cadena que coincidan con el patrón por otro texto.

Un ejemplo sencillo en C# sería:

```csharp
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string email = "usuario@example.com";
        bool esValido = Regex.IsMatch(email, patronCorreo);
        Console.WriteLine("El correo es válido: " + esValido);
    }
}
