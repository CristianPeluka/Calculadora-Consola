# Calculadora en consola
El siguiente proyecto pequeño es una calculadora que tiene las 4 operaciones básicas:
 - Suma
 - Resta
 - Multiplicación
 - División

Esta desarrollado con el lenguaje **C#** y con el IDE **Visual Studio 2022**, a continuación dejare los pasos que hice para desarrollar este proyecto básico.
## Declaración de variables:
Para empezar a desarrollar este proyecto pequeño declare 3 variables, dos del tipo entero (int) y uno del tipo cadena (string)  
```c#
int n1, n2;
string operacion;
```
Luego use las variables del tipo entero (int) para que el usuario pueda ingresar dos números y además use la otra variable del tipo cadena de texto (string) y me seleccione la operación matemática que quería resolver. 
```c#
Console.Write("Ingrese el primer numero: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("1. + \n2. - \n3. * \n4. /");
Console.Write("Seleccione la operacion a realizar: ");
operacion = Console.ReadLine();
```
Utilice un Switch para poder desarrollar la operación que el usuario eligió, como ven en la imagen si el usuario elige el numero 1 pues significa que los dos números ingresados por el mismo usuario se van a suma y así con las demás operaciones.  
```c#
switch (operacion)
{
    case "1": Suma(n1, n2); break; // metodo para la suma
    case "2": Resta(n1, n2); break; // metodo para la resta
    case "3": Multiplicacion(n1, n2); break; // metodo para la multiplicacion
    case "4": Dividir(n1, n2); break; // metodo para la division
}
```
Ahora como ven en el **Switch**, al momento de elegir la operación **suma** , la suma de los dos números como tal no esta, lo que esta realmente es un método para cada operación matemática dentro del **Switch**, estos métodos están enviando dos parámetros los cuales son los dos números que el usuario ingresa por consola, el método recibe estos dos parámetros y dentro de cada método se imprime un mensaje con el desarrollo de la operación, en otras palabras cuando mandas a llamar al método desde el **main**, en consola se imprime directamente el resultado de la operación de los dos números ingresados por el usuario.
```c#
 public static void Suma(int n1, int n2)
 {
     Console.WriteLine($"La suma de los dos numeros es {n1 + n2}");
 }

 public static void Resta(int n1, int n2)
 {
     Console.WriteLine($"La resta de los dos numero es {n1 - n2}");
 }

 public static void Multiplicacion(int n1, int n2)
 {
     Console.WriteLine($"El producto de ambos numeros es {n1 * n2}");
 }

 public static void Dividir(int n1, int n2)
 {
     if (n2 == 0)
     {
         Console.WriteLine("No se puede dividir entre cero");
     }
     else
     {
         Console.WriteLine($"La division entre los dos numeros es {n1 / n2}");
     }
 }
 ```
