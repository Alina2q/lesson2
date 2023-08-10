/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.Clear();
int dayNum = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(day(dayNum));
int ReadInt(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}
string day(int num)
{
    if (num > 0 & num < 8)
    {
        if (num == 7 | num == 6)
        {
            Console.Write($" {num}  - Выходной день");
        }
        else
        {
            Console.Write($"{num} - Рабочий день");
        }
    }
    else
    {
        Console.Write("Введите с 1 по 7 день");
    }
    return "";
}


