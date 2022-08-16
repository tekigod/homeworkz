//  Напишите программу, которая 
// 1. принимает на вход цифру, обозначающую день недели, и 
// 2. проверяет, является ли этот день выходным.
// Например:
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите число: ");
int num = Convert.ToInt16(Console.ReadLine());
switch (num)
{
    case 1: Console.WriteLine("Понедельник(Нет)"); break;
    case 2: Console.WriteLine("Вторник(Нет)"); break;
    case 3: Console.WriteLine("Среда(Нет)"); break;
    case 4: Console.WriteLine("Четверг(Нет)"); break;
    case 5: Console.WriteLine("Пятница(Нет)"); break;
    case 6: Console.WriteLine("Суббота(Да)"); break;
    case 7: Console.WriteLine("Воскресенье(Да)"); break;
    default: Console.WriteLine("ERROR"); break;
}
Console.ReadKey();