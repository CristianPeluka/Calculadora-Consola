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
```c#
Console.Write("Ingrese el primer numero: ");
n1 = int.Parse(Console.ReadLine());

Console.Write("Ingrese el segundo numero: ");
n2 = int.Parse(Console.ReadLine());

Console.WriteLine("1. + \n2. - \n3. * \n4. /");
Console.Write("Seleccione la operacion a realizar: ");
operacion = Console.ReadLine();
```
