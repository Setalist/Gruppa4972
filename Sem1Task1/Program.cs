// Задача №1 
// Напишите программу, которая на вход принимает 
// два числа и проверяет, является ли первое число 
// квадратом второго.


Console.WriteLine("Введите число 1: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число 2: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");

if(num1 == Math.Pow(num2, 2))
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}