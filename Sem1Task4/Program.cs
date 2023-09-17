// №4 
// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите Третье число: ");
int num3 = int.Parse(Console.ReadLine() ?? "0");

int maxNum = num1;

if (num2>maxNum)
{
    maxNum = num2;
}
else if (num3>maxNum)
{
    maxNum = num3;
}

Console.WriteLine("Максимальное число это: " + maxNum);