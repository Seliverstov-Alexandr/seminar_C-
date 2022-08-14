// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа./
int GetTenType (int number)
{
    int result = number %100/10;
    return result;
}

    Console.WriteLine("Введите целое трехзначное число");
    int number = Convert.ToInt32(Console.ReadLine());
    int TenType = GetTenType (number);
    Console.WriteLine("Вторая цифра числа " + TenType);


