// Задание 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите Xa: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Ya: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Za: ");
double za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Xb: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Yb: ");
double yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Zb: ");
double zb = Convert.ToInt32(Console.ReadLine());

double ab = Math.Sqrt(Math.Pow(xb-xa,2) + Math.Pow(yb - ya,2) + Math.Pow(zb-za,2));

Console.WriteLine("Расстояние между точками в пространстве составляет: ");
Console.WriteLine(ab);