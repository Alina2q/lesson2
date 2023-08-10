/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 
*/


Console.Clear();
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(Array(number, count));
int ReadInt(string mes)
{
    Console.Write(mes);
    return Convert.ToInt32(Console.ReadLine());
}

int Array(int num1, int num2)
{
    int result = 0;
    if (num2 < 3)
    {
        Console.Write("Третьей цифры нет");
    }
    else
    {
        int num3 = 1;
        for (int i = num2; i > 3; i--)
        {
            num3 = num3 * 10;
        }

        result = (num1 / num3) % 10;
    }
    return result;
}

