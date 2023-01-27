// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int count = 0;

// while (num > 0)
// {
//     count += num % 10;
//     num /= 10;
// }

// Console.WriteLine(count);


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (num > 0)
{
    int last_num = num % 10;
    count += last_num;
    num /= 10;
}

Console.WriteLine(count);