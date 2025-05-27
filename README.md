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
