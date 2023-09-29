// Задача №11 
// Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого 
// числа.

//создаем рандомайзер
int num = new Random().Next(100, 1000);
//выводим рандомное число
Console.WriteLine(num);
//получаем первую цифру
int firstDigit = num / 100;
//получаем вторую цифру
int lastDigit = num % 10;
//получаем результат
num = firstDigit * 10 + lastDigit;
//выводим результат
Console.WriteLine(num);



// int ran = new System.Random().Next(100, 1000);
// System.Console.WriteLine(ran);
// char[] digitChar = ran.ToString().ToCharArray();
// System.Console.Write(digitChar[0]);
// System.Console.Write(digitChar[2]);


// Console.Write("Введите число: ");
// string stringNum = Console.ReadLine()??"0";
// int num = Convert.ToInt32(stringNum);
// if (stringNum.Length != 3)
//     Console.WriteLine("Число не трёхзначное");
// else
// {
//     Console.WriteLine((num / 100) * 10 + (num % 10));
// }
// // Console.WriteLine(stringNum.Length != 3 ? "Число не трёхзначное" : (num / 100) * 10 + (num % 10));
// Console.WriteLine();

