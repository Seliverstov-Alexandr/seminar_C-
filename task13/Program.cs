// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет./
int GetHundredsType (int number)
{
    int result = number %1000/100;
    return result;
}

    Console.WriteLine("Введите целое число");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number<100)
    {
       Console.WriteLine("Третьей цифры нет");
    }
       else 
    {  int HundredsType = GetHundredsType (number);
    Console.WriteLine("Третья цифра числа " + HundredsType);
    }
    
