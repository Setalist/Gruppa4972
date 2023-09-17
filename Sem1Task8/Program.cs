// №8 
// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число: ");
int numN = int.Parse(Console.ReadLine()??"0");
if (numN<2)
{
    Console.WriteLine("Число меньше 2");
}
else
{
    Console.WriteLine("Четные числа от 1 до "+numN+":");
    for(int i = 2; i <= numN; i= i+2)
    {
        Console.Write(i+" ");
    }
}
