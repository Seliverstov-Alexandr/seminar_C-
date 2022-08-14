// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.//
void DayOff(int number)
{
if (number == 6 || number == 7)
{
    Console.WriteLine("Этот день выходной!");
}
else 
{
    Console.WriteLine("Это рабочий день.");
}
}
Console.WriteLine("Введите день недели соответствующей цифрой от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number<1 || number>7)
{
    Console.WriteLine("Вы ввели несоответствующую цифру");
}
else
{
DayOff(number);
}