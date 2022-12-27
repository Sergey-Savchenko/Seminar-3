// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

void Pali(int numb)
{
    if (numb >9999 && numb <100000)
    {
        int a = numb % 10;
        int b = numb / 10 % 10;
        int c = numb / 1000 % 10;
        int d = numb / 10000 % 10;
        if (a==d && b==c)
        {
            System.Console.WriteLine("Это число - Палиндром");
        }
        else System.Console.WriteLine("Это число - НЕ Палиндром");
    }
    else System.Console.WriteLine("Error");
}

System.Console.Write("Введите пятизначное число: ");
int user = Convert.ToInt32(Console.ReadLine());
Pali(user);