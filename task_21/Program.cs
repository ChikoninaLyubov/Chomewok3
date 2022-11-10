// Задача 21 Напишите программу, которая принимает на вход координаты
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

double distance(int ax, int ay, int ac, int bx, int by, int bc)
{
    double result = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bc - ac), 2));
    result = Math.Round(result, 2);
    return result;
}
Console.Write("Введите координату Ax: ");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ay: ");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Ac: ");
int ac = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bx: ");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату By: ");
int by = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Bc: ");
int bc = Convert.ToInt32(Console.ReadLine());

double dist = distance(ax, ay, ac, bx, by, bc);

Console.WriteLine($"Расстояние между точками A и B  = {dist}");

