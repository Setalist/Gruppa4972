// Задача №3 
// Напишите программу, которая будет выдавать 
// название дня недели по заданному номеру.


Console.WriteLine("Введите день недели");
int day = int.Parse(Console.ReadLine()??"0");
string[] dayOfWeek = new string[7];
dayOfWeek[0] = "Понедельник";
dayOfWeek[1] = "Вторник";
dayOfWeek[2] = "Среда";
dayOfWeek[3] = "Четверг";
dayOfWeek[4] = "Пятница";
dayOfWeek[5] = "Субота";
dayOfWeek[6] = "Воскресенье";
if(day > 7)
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    Console.WriteLine(dayOfWeek[day - 1]);
}


// string day = Console.ReadLine()??"0";

// switch (day)
// {
//     case "1": Console.WriteLine("Понедельник"); break;
//     case "2": Console.WriteLine("Вторник"); break;
//     case "3": Console.WriteLine("Среда"); break;
//     case "4": Console.WriteLine("Четверг"); break;
//     case "5": Console.WriteLine("Пятница"); break;
//     case "6": Console.WriteLine("Суббота"); break;
//     case "7": Console.WriteLine("Воскресенье"); break;
//     default: Console.WriteLine("Неверные данные"); break;
// }


// Console.WriteLine("Enter day number");
// int dayNum = int.Parse(Console.ReadLine());

// string outDayOfWeek = System.Globalization.CultureInfo.GetCultureInfo("ru-Ru").DateTimeFormat.GetDayName((DayOfWeek)Enum.GetValues(typeof(DayOfWeek)).GetValue(dayNum));

// Console.WriteLine(outDayOfWeek);