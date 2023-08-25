// Напишите цикл, который принимает на вход два 
// числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Parse(string text)
{
    Console.WriteLine(text);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

string again = "y";
while (again == "y"){
    int number = Parse("Введите первое число");
    int number2 = Parse("Введите второе число");
    double result = Math.Pow(number,number2);
    Console.WriteLine(result);
    
    Console.WriteLine("Попробовать еще? (y = Да, n = Нет)");
    again = Console.ReadLine();
}
