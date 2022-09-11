// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Элементы массива вводятся пользователем.

// Сделал для любого размера массива)))

int[] GetArray(int x)
{
    int[] array = new int[x];
    for (int i = 0; i < x; i++)
    {
        Console.Write($"Введите {i + 1} число массива: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}

Console.Write("Введите размер массива: ");
try
{
    int x = int.Parse(Console.ReadLine());
    int[] result = GetArray(x);
    Console.WriteLine($"Ваш массив: [{string.Join(",", result)}]");
}
catch
{
    Console.WriteLine("ОШИБКА! Вы ввели не число!");
}