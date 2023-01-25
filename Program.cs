// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] Array()
{
    Console.Write("Введите количество элементов в массиве: ");
    int len = Convert.ToInt32(Console.ReadLine());

    int[] list = new int[len];

    for (int i = 0; i < len; i++)
    {
        Console.Write($"Введите значение элемента {i}: ");
        int num = Convert.ToInt32(Console.ReadLine());
        list[i] = num;
    }
    return list;
}

void PrintArray(int[] data)
{
    for (int i = 0; i < data.Length; i++)
    {
        Console.WriteLine($"arr[{i}] = {data[i]}");
    }
}

int[] array = Array();
PrintArray(array);