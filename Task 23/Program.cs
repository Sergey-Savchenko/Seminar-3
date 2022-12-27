// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void excel(int N)
{
    for (int cif = 1; cif <= N; cif++)
    {
        int Kub = cif*cif*cif;
        Console.WriteLine(Kub);
    }
}

System.Console.Write("Введите число: ");
int user = Convert.ToInt32(Console.ReadLine());
excel(user);