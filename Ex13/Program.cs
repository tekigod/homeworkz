// Напишите программу, которая 
// 1. выводит третью цифру заданного числа или 
// 2. сообщает, что третьей цифры нет.
// Например:
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (!input.Equals("exit"))
                Console.WriteLine($"{(object)input} -> {(object)input[2]}");
            else
                break;
        }
    }
}