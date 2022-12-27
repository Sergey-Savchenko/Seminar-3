// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

void coords(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double sqr = (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) + (z2 - z1)*(z2-z1);
    double sqrt = Math.Sqrt(sqr);
    System.Console.Write($"Расстояние между двумя точками {sqrt}");
}

System.Console.Write("Введите координату x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

coords(x1,y1,z1,x2,y2,z2);