// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
Console.WriteLine("Введите координату X точки А ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки А ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки А ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X точки Б ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y точки Б ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z точки Б ");
double z2 = Convert.ToDouble(Console.ReadLine());
double distance = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));
Console.WriteLine("Расстояние между точками А и Б "+ distance);