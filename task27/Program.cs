// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

int SummaCifr(int x)
{
    x = Math.Abs(x);
    int xsum = 0;
    while (x > 0)
    {
        int xchiclo = x % 10;
        xsum = xsum + xchiclo;
        x = x / 10;
    }
    return xsum;
}

int summaCifr = SummaCifr(chislo);
Console.WriteLine($"Сумма цифр числа {chislo} равна {summaCifr}");