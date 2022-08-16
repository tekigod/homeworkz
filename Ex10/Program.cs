// Напишите программу, которая 
// 1. принимает на вход трёхзначное число и 
// 2. на выходе показывает вторую цифру этого числа.
// Например: 
// 456 -> 5
// 782 -> 8
// 918 -> 1

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите трехзначное число: ");
        while (true)
        {
            string input = Console.ReadLine();
            if (!input.Equals("exit"))
                Console.WriteLine($"{(object)input} -> {(object)input[1]}");
            else
                break;
        }
    }
}