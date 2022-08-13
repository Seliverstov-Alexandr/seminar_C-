Console.WriteLine("введите первое число");
double userNumber1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите второе число");
double userNumber2 = Convert.ToDouble(Console.ReadLine());
if (userNumber1>userNumber2)
{
 Console.WriteLine("Большее число "+userNumber1+" меньшее число "+userNumber2);
}
 else
{
Console.WriteLine("Большее число "+userNumber2+" меньшее число "+userNumber1);

}
