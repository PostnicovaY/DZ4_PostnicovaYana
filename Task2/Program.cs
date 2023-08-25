// Задача 27: Напишите программу, которая принимает 
// на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = Parse("Введите число");

int Sumx(int number)
{
    int count = 0;
    while (number != 0)
    {
        count += number % 10;
        number = number / 10;
    }
    return count;
}

Console.WriteLine(Sumx(number));