// №2 
// Напишите программу, которая на вход принимает два числа 
// и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
if (num1 > num2)
{
    Console.WriteLine("Число большее:"+num1);
    Console.WriteLine("Число меньшее:"+num2);
}
else if (num2 > num1)
{
    Console.WriteLine("Число большее:"+num2);
    Console.WriteLine("Число меньшее:"+num1);
}
else 
{
    Console.WriteLine("Числа равны");
}