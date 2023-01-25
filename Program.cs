// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999 & number <= 9999)
{
    int n4 = number % 10; // последняя цифра
    int n3 = (number % 100) / 10; // предпоследняя цифра
    int n2 = number / 10000; // вторая цифра
    int n1 = number / 1000 % 10; // первая цифра
    Console.WriteLine($"Сумма цифр в числе {number} равняется {n1+n2+n3+n4}");
}

else
{
    if (number > 99 & number < 1000)
    {
        int n3 = number % 10;
        int n2 = (number / 10) % 10;
        int n1 = (number / 100) % 10;
        Console.WriteLine($"Сумма цифр в числе {number} равняется {n1+n2+n3}");
    }

    else
    {
        int n1 = (number / 10) % 10;
        int n2 = number % 10;
        Console.WriteLine($"Сумма цифр в числе {number} равняется {n1+n2}");
    }
}