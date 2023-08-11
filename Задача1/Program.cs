/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

Console.Clear();
Console.WriteLine("Введите трехзначное число");
int.TryParse(Console.ReadLine(), out int num);

if (num > 999 || num < 100)
{
    Console.WriteLine("Это не трехзначное число!");
    return;
}
int GetSecond(int num)
{
    while (num >= 100) num /= 10;
    int num1 = num % 10;
    return num1;
}
Console.WriteLine(GetSecond(num));
