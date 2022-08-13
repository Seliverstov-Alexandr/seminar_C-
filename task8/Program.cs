Console.WriteLine("введите натуральное число");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.WriteLine("Четные числа от 1 до "+userNumber1);
while (count <= userNumber1)
{
Console.Write(count+" ");
count +=2;
}

