Console.WriteLine("введите первое число");
double userNumber1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите второе число");
double userNumber2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите третье число");
double userNumber3 = Convert.ToDouble(Console.ReadLine());
if (userNumber1>userNumber2 & userNumber1>userNumber3)
{
 Console.WriteLine("Максимальное число "+userNumber1);
}
 if (userNumber2>userNumber1 & userNumber2>userNumber3){
 Console.WriteLine("Максимальное число "+userNumber2);   
 }
 else
{
 Console.WriteLine("Максимальное число "+userNumber3);
}
