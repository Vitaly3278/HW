// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B. 
// Решить задачу с использованием методов.

int Degree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    return result;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int b = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = Degree(a, b);
Console.WriteLine($"Число {a} в степени {b} равно {result}: ");
