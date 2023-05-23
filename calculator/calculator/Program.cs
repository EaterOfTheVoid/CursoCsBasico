// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int num1;
int num2;
int num3;

Console.WriteLine("Ingrese el primer valor: ");
num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el segundo valor: ");
num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese el tercero valor: ");
num3 = Convert.ToInt32(Console.ReadLine());

int result = num1 + num2;
int result2 = num3 + num1;

Console.WriteLine("La suma de " + num1 + "+" + num2 + " es igual a " + result);
Console.WriteLine("La suma de " + num3 + "+" + num1 + " es igual a " + result2);