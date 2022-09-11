// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int SumDigits(int num)
{
    int sum = 0;
    while (num > 0)
    {
        sum = sum + (num % 10);
        num = num / 10;
    }
    return sum;
}


try
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int sum = SumDigits(num);
    Console.WriteLine($"Сумма цифр в числе {num} равна {sum} ");
}
catch
{
    Console.WriteLine("Введено не число!!! "); 
}

